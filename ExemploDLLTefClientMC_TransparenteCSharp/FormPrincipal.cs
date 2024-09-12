using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace ExemploDLLTefClientMC_TransparenteCSharp
{

    public partial class FormPrincipal : Form
    {
        #region Declaração das Funções da DLL

        [DllImport("TefClientmc.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int IniciaFuncaoMCInterativo(int iComando, string sCnpjCliente, int iParcela, string sCupom, string sValor,
            string sNsu, string sData, string sNumeroPDV, string sCodigoLoja, int sTipoComunicacao, string sParametro);

        [DllImport("TefClientmc.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        static extern string AguardaFuncaoMCInterativo();

        [DllImport("TefClientmc.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int ContinuaFuncaoMCInterativo(string sInformacao);

        [DllImport("TefClientmc.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int FinalizaFuncaoMCInterativo(int iComando, string sCnpjCliente, int iParcela, string sCupom, string sValor,
            string sNsu, string sData, string sNumeroPDV, string sCodigoLoja, int sTipoComunicacao, string sParametro);

        [DllImport("TefClientmc.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int CancelarFluxoMCInterativo();

        #endregion Declaração das Funções da DLL

        #region Variaveis Globais FormAtributos
        private static int comunicacao;
        public string cnpj;
        public string data;
        public string pdv;
        public string codloja;

        #endregion

        #region Variaveis formPrincipal
        int flagretorno;
        int flagoperacao;
        string valor;
        int parcelas;
        string cupom;
        string nsu;
        bool confirmar = true;

        bool InsereNovoCartao;
        bool NovaVenda = true;
        #endregion

        FormAtributosAParte form;

        List<RetCupom> lstCupons;
        List<object> lstExibicao = new List<object>();

        public FormPrincipal()
        {
            InitializeComponent();
            AtribuirosDados();
            form = new FormAtributosAParte(comunicacao, cnpj, codloja, data, pdv);

            lbLog.HorizontalScrollbar = true;
            tansacoespendentes.HorizontalScrollbar = true;

            if (checkBoxMultiplosCartoes.Checked == true)
            {
                panelTransacoes.Visible = true;
                lbLog.Size = new Size(314, 342);
            }
            else
            {
                panelTransacoes.Visible = false;
                lbLog.Size = new Size(314, 550);
            }
        }

        #region Metodos

        private void ExecutarFuncao(int operacao)
        {
            if (GetParametros())
            {
                if (checkBoxMultiplosCartoes.Checked == false)
                {
                    panelTransacoes.Visible = false;
                    lbLog.Size = new Size(314, 550);
                }


                flagoperacao = operacao;
                int retorno = IniciaFuncaoMCInterativo(operacao, cnpj, parcelas, cupom, valor, nsu, data, pdv, codloja, comunicacao, "");

                flagretorno = retorno;
                lbLog.Items.Insert(0, DateTime.Now + " - IniciaFuncaoMCInterativo()");
                lbLog.HorizontalScrollbar = true;

                Util.AdicionaLog("IniciaFuncaoMCInterativo()");
                lbLog.Refresh();


                if (retorno == 0)
                {
                    string retMsg = "";
                    int retFim;
                    string[] arrMsg = null;

                    while (retMsg != "[ERROABORTAR]" && retMsg != "[RETORNO]" && retMsg != "[ERRODISPLAY]")
                    {
                        string strRetAguardaFMCInt = AguardaFuncaoMCInterativo();
                        Util.AdicionaLog(strRetAguardaFMCInt);

                        if (strRetAguardaFMCInt != "")
                        {
                            lbLog.Items.Insert(0, DateTime.Now + " - " + strRetAguardaFMCInt);
                            lbLog.Refresh();
                        }

                        arrMsg = strRetAguardaFMCInt.Split('#');
                        retMsg = arrMsg[0];

                        if (retMsg == "[MENU]")
                        {
                            FormMensagem tela = arrMsg.Count() > 2 ?
                                new FormMensagem(arrMsg[1], arrMsg[2].Contains("|") ? arrMsg[2].Replace('|', '\n') : string.Join("\n", Util.WordWrap(arrMsg[2], 30))) :
                                new FormMensagem(arrMsg[0], arrMsg[1].Replace('|', '\n'));
                            tela.ShowDialog();

                            if (tela.cancelar)
                            {
                                CancelarFluxoMCInterativo();
                                Util.AdicionaLog("CancelarFluxoMCInterativo()");
                                MessageBox.Show("Fluxo Cancelado");
                                retMsg = "[ERROABORTAR]";
                                lbLog.Items.Insert(0, DateTime.Now + " - Fluxo Cancelado");
                                Util.AdicionaLog("Fluxo Cancelado");
                                lbLog.Refresh();
                            }
                            else
                            {
                                ContinuaFuncaoMCInterativo(tela.retornoMsg);
                                tela.Dispose();
                            }
                        }

                        if (retMsg == "[PERGUNTA]")
                        {
                            FormMensagem tela = new FormMensagem(arrMsg[1], arrMsg[2].Replace('|', '\n'));
                            tela.ShowDialog();

                            if (tela.cancelar)
                            {
                                CancelarFluxoMCInterativo();
                                Util.AdicionaLog("CancelarFluxoMCInterativo()");
                                MessageBox.Show("Fluxo Cancelado");
                                retMsg = "[ERROABORTAR]";
                                lbLog.Items.Insert(0, DateTime.Now + " - Fluxo Cancelado");
                                Util.AdicionaLog("Fluxo Cancelado");
                                lbLog.Refresh();
                            }
                            else
                            {
                                ContinuaFuncaoMCInterativo(tela.retornoMsg);
                                tela.Dispose();
                            }
                        }

                        if (retMsg == "[MSG]")
                        {
                            if (arrMsg.Count() >= 2)
                            {
                                if (arrMsg[1].Contains("SALDO") && !arrMsg[1].Contains("RETIRE"))
                                {
                                    FormMensagem tela = new FormMensagem(arrMsg[0], arrMsg[1].Replace('|', '\n'));
                                    tela.ShowDialog();
                                }
                            }


                            if (arrMsg[1].Contains("QRCODE"))
                            {
                                var arrAux = arrMsg[1].Split('|');

                                var nsu = arrAux[0].Split('=');
                                var origem = arrAux[1].Split('=');
                                var valor = arrAux[2].Split('=');
                                var qrcode = arrAux[3].Split('=');

                                var t = Task.Run(() => ExibirTelaQrCode(qrcode[1], origem[1], valor[1]));
                            }

                        }
                        if (retMsg == "[ERRODISPLAY]")
                        {
                            FormMensagem tela = new FormMensagem(arrMsg[0], arrMsg[1].Replace('|', '\n'));
                            tela.ShowDialog();

                            if (tela.cancelar)
                            {
                                CancelarFluxoMCInterativo();
                                Util.AdicionaLog("CancelarFluxoMCInterativo()");
                                MessageBox.Show("Fluxo Cancelado");
                                retMsg = "[ERROABORTAR]";
                                lbLog.Items.Insert(0, DateTime.Now + " - Fluxo Cancelado");
                                Util.AdicionaLog("Fluxo Cancelado");
                                lbLog.Refresh();
                            }
                            else
                            {
                                ContinuaFuncaoMCInterativo(tela.retornoMsg);
                                tela.Dispose();
                            }
                        }

                        Thread.Sleep(50);
                    }
                    if (retMsg == "[ERROABORTAR]")
                    {
                        MessageBox.Show(retMsg);
                    }
                    if (retMsg == "[RETORNO]")
                    {
                        Thread.Sleep(50);
                        string strCupom = "";
                        string nsuRet = "";

                        if (arrMsg.Length > 2)
                        {
                            if (operacao > 50 && operacao < 60)
                            {
                                try
                                {
                                    File.Create($"{AppDomain.CurrentDomain.BaseDirectory}concluiupix.txt");

                                }
                                catch (Exception ex)
                                {
                                    Util.AdicionaLog($"Erro - {ex.Message}");
                                }
                            }

                            strCupom = arrMsg[15].Replace("CAMPO122=", "").Replace("|", "\n").Replace("CORTAR", "\n-------------------------------\n");

                            var auxCupom = strCupom + "-------------------------------\n\n";

                            nsuRet = arrMsg[5].Replace("CAMPO0133=", "");
                        }

                        if (arrMsg.Length == 2 && operacao == 200)
                        {
                            var aux = arrMsg[1].Split('=');
                            strCupom = $"CPF Coletado: {aux[1]}";
                        }

                        MessageBox.Show(strCupom);
                        MessageBox.Show(string.Join("\n", arrMsg));

                        retFim = 0;

                        if (operacao != 98 && operacao != 99)
                        {
                            if (confirmar)
                            {
                                retFim = FinalizaFuncaoMCInterativo(98, cnpj, parcelas, cupom, valor, nsuRet, data, pdv, codloja, comunicacao, "");
                            }
                            else
                            {
                                retFim = FinalizaFuncaoMCInterativo(99, cnpj, parcelas, cupom, valor, nsuRet, data, pdv, codloja, comunicacao, "");
                            }
                            Util.AdicionaLog("FinalizaFuncaoMCInterativo()");

                            string strRetAguardaFMCInt = AguardaFuncaoMCInterativo();

                            int count = 0;

                            while (!strRetAguardaFMCInt.Contains("RETORNO") && count < 15)
                            {
                                lbLog.Items.Insert(0, DateTime.Now + " - " + strRetAguardaFMCInt);
                                strRetAguardaFMCInt = AguardaFuncaoMCInterativo();
                                count++;
                            }

                            Util.AdicionaLog(strRetAguardaFMCInt);

                            lbLog.Items.Insert(0, DateTime.Now + " - " + strRetAguardaFMCInt);

                        }
                        else
                        {
                            retFim = 0;
                        }

                        if (retFim == 0)
                        {
                            lbLog.Items.Insert(0, DateTime.Now + " - FIM DA TRANSAÇÃO");
                            lbLog.Refresh();
                        }
                        else
                        {
                            lbLog.Items.Insert(0, DateTime.Now + " - ERRO: " + retFim);
                            lbLog.Refresh();
                        }
                    }
                }
                else
                {
                    retornaErro();
                    Util.AdicionaLog("Erro - IniciaFuncaoMCInterativo");
                }
            }

        }

        private bool GetParametros(bool ExcluirBins = false)
        {
            if (ExcluirBins)
                flagoperacao = 110;

            if (cnpj == null || comunicacao.ToString() == "" || txbCupom.Text == "" || data.ToString() == "" || txbNsu.Text == ""
               || txbParcela.Text == "" || pdv == null || txbValor.Text == "" || codloja == null)
            {
                MessageBox.Show("Informe todos os parâmetros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {

                flagoperacao = 0;
                parcelas = 1;

                comunicacao = 0;

                int.TryParse(txbParcela.Text, out parcelas);
                cupom = txbCupom.Text;
                nsu = txbNsu.Text;
                valor = txbValor.Text;
                return true;
            }
        }

        private void retornaErro()
        {
            if (flagretorno == 1)
                MessageBox.Show("Erro genérico na execução", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 30)
                MessageBox.Show("Não foi encontrado o caminho do ClientD.exe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 31)
                MessageBox.Show("ConfigMC.ini está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 32)
                MessageBox.Show("ClientD.exe não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 33)
                MessageBox.Show("ClientD.exe não está em execução", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 34)
                MessageBox.Show("Erro ao iniciar ClientD.exe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 35)
                MessageBox.Show("Não foi possível criar o arquivo de resposta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 36)
                MessageBox.Show("Erro na manipulação do arquivo de resposta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 37)
                MessageBox.Show("Erro na leitura do arquivo ConfigMC.ini", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 38)
                MessageBox.Show("Valor da transação com formato incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 39)
                MessageBox.Show("Executável de envio de transações não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 40)
                MessageBox.Show("CNPJ Inválido ou no formato incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 41)
                MessageBox.Show("ClientD.exe está em processo de atualização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (flagretorno == 42)
                MessageBox.Show("A automação não está sendo executada no modo administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void AtribuirosDados()
        {
            string aplicacao = Application.StartupPath;
            string path = $@"{aplicacao}\ArqCarregaDados.txt";
            var file = File.ReadAllLines(path);
            foreach (var line in file)
            {
                var arr = line.ToUpper().Split('=');
                if (arr.Length < 2)
                    continue;
                switch (arr[0])
                {
                    case "CNPJ":
                        cnpj = arr[1];
                        break;
                    case "PDV":
                        pdv = arr[1];
                        break;
                    case "CODIGO_LOJA":
                        codloja = arr[1];
                        break;
                }
            }

            data = DateTime.Now.ToString("yyyyMMdd");
            comunicacao = 0;
        }
        private void ExibirTelaQrCode(string QrCode, string Origem, string Valor)
        {
            ContinuaFuncaoMCInterativo("2");
        }
        #endregion

        #region Eventos
        private void btnAtributosAParte_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.ShowDialog();
                if (!form.IsDisposed)
                {
                    comunicacao = form.AtrComunicacao;
                    cnpj = form.AtrCnpj;
                    pdv = form.AtrPdv;
                    data = form.AtrData;
                    codloja = form.AtrCodLoja;
                }

            }
            else
            {
                form = new FormAtributosAParte();
                form.ShowDialog();
            }
        }


        private void btnCredito_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(1);
        }
        private void btnLimpaLog_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
        }
        private void btnCreditoAVista_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(0);
        }
        private void btnDebito_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(4);
        }
        private void btnDebitoAVista_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(20);
        }
        private void btnCreditoParceladoLoja_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(2);
        }
        private void btnCreditoParceladoAdm_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(3);
        }
        private void btnVendaFrota_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(11);
        }
        private void btnVendaVoucher_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(18);
        }
        private void checkBoxMultiplosCartoes_CheckedChanged(object sender, EventArgs e)
        {
            if (GetParametros() && checkBoxMultiplosCartoes.Checked)
            {
                NovaVenda = true;
                while (NovaVenda)
                {
                    panelTransacoes.Visible = true;
                    lbLog.Size = new Size(314, 342);


                    if (!InsereNovoCartao)
                    {

                        lstCupons = new List<RetCupom>();
                        lstExibicao = new List<object>();
                    }

                    string flagnsu = $"{nsu}*";
                    int retorno = IniciaFuncaoMCInterativo(flagoperacao, cnpj, parcelas, cupom, valor, flagnsu, data, pdv, codloja, comunicacao, "");
                    lbLog.Items.Insert(0, DateTime.Now + " - IniciaFuncaoMCInterativo()");
                    Util.AdicionaLog("IniciaFuncaoMCInterativo()");
                    lbLog.Refresh();

                    FormMensagem tela;

                    if (retorno == 0)
                    {
                        string retMsg = "";
                        string[] arrMsg = null;

                        while (retMsg != "[ERROABORTAR]" && retMsg != "[RETORNO]" && retMsg != "[ERRODISPLAY]")
                        {
                            string strRetAguardaFMCInt = AguardaFuncaoMCInterativo();
                            Util.AdicionaLog(strRetAguardaFMCInt);

                            if (strRetAguardaFMCInt != "")
                            {
                                lbLog.Items.Insert(0, DateTime.Now + " - " + strRetAguardaFMCInt);
                                lbLog.Refresh();
                            }

                            arrMsg = strRetAguardaFMCInt.Split('#');
                            retMsg = arrMsg[0];

                            if (retMsg == "[MENU]")
                            {
                                tela = arrMsg.Count() > 2 ? new FormMensagem(arrMsg[1], arrMsg[2].Replace('|', '\n')) :
                                    new FormMensagem(arrMsg[0], arrMsg[1].Replace('|', '\n'));
                                tela.ShowDialog();

                                if (tela.cancelar)
                                {
                                    CancelarFluxoMCInterativo();
                                    Util.AdicionaLog("CancelarFluxoMCInterativo()");
                                    MessageBox.Show("Fluxo Cancelado");
                                    retMsg = "[ERROABORTAR]";
                                    lbLog.Items.Insert(0, DateTime.Now + " - Fluxo Cancelado");
                                    Util.AdicionaLog("Fluxo Cancelado");
                                    lbLog.Refresh();
                                    NovaVenda = false;
                                }
                                else
                                {
                                    ContinuaFuncaoMCInterativo(tela.retornoMsg);
                                    tela.Dispose();
                                }
                            }

                            if (retMsg == "[PERGUNTA]")
                            {
                                tela = new FormMensagem(arrMsg[1], arrMsg[2].Replace('|', '\n'));
                                tela.ShowDialog();

                                if (tela.cancelar)
                                {
                                    CancelarFluxoMCInterativo();
                                    Util.AdicionaLog("CancelarFluxoMCInterativo()");
                                    MessageBox.Show("Fluxo Cancelado");
                                    retMsg = "[ERROABORTAR]";
                                    lbLog.Items.Insert(0, DateTime.Now + " - Fluxo Cancelado");
                                    Util.AdicionaLog("Fluxo Cancelado");
                                    lbLog.Refresh();
                                    NovaVenda = false;
                                }
                                else
                                {
                                    ContinuaFuncaoMCInterativo(tela.retornoMsg);
                                    tela.Dispose();
                                }
                            }

                            if (retMsg == "[MSG]")
                            {
                                if (arrMsg.Count() >= 2)
                                {
                                    if (arrMsg[1].Contains("SALDO") && !arrMsg[1].Contains("RETIRE"))
                                    {
                                        tela = new FormMensagem(arrMsg[0], arrMsg[1].Replace('|', '\n'));
                                        tela.ShowDialog();
                                    }

                                    if (arrMsg[1].Contains("QRCODE"))
                                    {
                                        var arrAux = arrMsg[1].Split('|');

                                        var nsu = arrAux[0].Split('=');
                                        var origem = arrAux[1].Split('=');
                                        var valor = arrAux[2].Split('=');
                                        var qrcode = arrAux[3].Split('=');

                                        ContinuaFuncaoMCInterativo("1");
                                    }
                                }
                            }
                            if (retMsg == "[ERRODISPLAY]")
                            {
                                tela = new FormMensagem(arrMsg[0], arrMsg[1].Replace('|', '\n'));
                                tela.ShowDialog();

                                InsereNovoCartao = false;
                                NovaVenda = false;

                                if (tela.cancelar)
                                {
                                    CancelarFluxoMCInterativo();
                                    Util.AdicionaLog("CancelarFluxoMCInterativo()");
                                    MessageBox.Show("Fluxo Cancelado");
                                    retMsg = "[ERROABORTAR]";
                                    lbLog.Items.Insert(0, DateTime.Now + " - Fluxo Cancelado");
                                    Util.AdicionaLog("Fluxo Cancelado");
                                    lbLog.Refresh();
                                    NovaVenda = false;
                                }
                                else
                                {
                                    ContinuaFuncaoMCInterativo(tela.retornoMsg);
                                    tela.Dispose();
                                }
                            }
                            Thread.Sleep(50);
                        }
                        if (retMsg == "[ERROABORTAR]")
                        {
                            MessageBox.Show(retMsg);
                        }

                        if (retMsg == "[RETORNO]")
                        {
                            Thread.Sleep(50);
                            var strCupom = arrMsg[15].Replace("CAMPO122=", "").Replace("|", "\n").Replace("CORTAR", "\n\n");

                            var auxCupom = strCupom + "-------------------------------\n\n" + strCupom;

                            var dadosCupom = new RetCupom();

                            dadosCupom.Comprovante = arrMsg[15].Replace("CAMPO122=", "").Replace("|", "\n").Replace("CORTAR", "\n-------------------------------\n");
                            dadosCupom.VenctoCartao = arrMsg[14].Replace("CAMPO0513=", "");
                            dadosCupom.NsuRede = arrMsg[13].Replace("CAMPO0134=", "");
                            dadosCupom.Cliente = arrMsg[12].Replace("CAMPO1003=", "");
                            dadosCupom.Cnpj = arrMsg[11].Replace("CAMPO0950=", "");
                            dadosCupom.UltimosDigitos = arrMsg[10].Replace("CAMPO1190=", "");
                            dadosCupom.BinCartao = arrMsg[9].Replace("CAMPO0136=", "");
                            dadosCupom.TxServico = arrMsg[8].Replace("CAMPO0504=", "");
                            dadosCupom.Parcelas = arrMsg[7].Replace("CAMPO0505=", "");
                            dadosCupom.Nsu = arrMsg[6].Replace("CAMPO0133=", "");
                            dadosCupom.CodAutorizacao = arrMsg[5].Replace("CAMPO0135=", "");
                            dadosCupom.CodRede = arrMsg[4].Replace("CAMPO0131=", "");
                            dadosCupom.CodBandeira = arrMsg[3].Replace("CAMPO0132=", "");
                            dadosCupom.Valor = arrMsg[2].Replace("CAMPO0002=", "");
                            dadosCupom.Cupom = arrMsg[1].Replace("CAMPO0160=", "");

                            lstCupons.Add(dadosCupom);

                            var obj1 = new
                            {
                                valor = dadosCupom.Valor,
                                exibir = dadosCupom.Comprovante.Replace("\n", "|")
                            };

                            tansacoespendentes.Items.Add(dadosCupom.Comprovante.Replace("\n", "|"));
                            tansacoespendentes.Refresh();

                            lstExibicao.Add(obj1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro - IniciaFuncaoMCInterativo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Util.AdicionaLog("Erro - IniciaFuncaoMCInterativo");
                    }

                    if (NovaVenda)
                    {
                        if (MessageBox.Show("Deseja Pagar com mais um cartão?", "Pagar com Múltiplos Cartões", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                        {
                            InsereNovoCartao = true;

                            var NovoValor = Interaction.InputBox("Digite o valor da Transação:", "Múltiplos Cartões", "");
                            valor = NovoValor;
                        }
                        else
                        {
                            InsereNovoCartao = false;
                            NovaVenda = false;
                        }
                    }
                    else
                    {
                        checkBoxMultiplosCartoes.Checked = false;
                        panelTransacoes.Visible = false;
                        lbLog.Size = new Size(314, 550);
                    }

                }
            }
            else
            {
                NovaVenda = false;
                checkBoxMultiplosCartoes.Checked = false;
            }
        }

        private void btnStatusTransacao_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(56);
        }
        private void btnCancelarEstornoQR_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(54);
        }
        private void btnExcluirBins_Click(object sender, EventArgs e)
        {
            try
            {
                GetParametros(true);
                var ret = IniciaFuncaoMCInterativo(110, cnpj, parcelas, cupom, valor, nsu, data, pdv, codloja, comunicacao, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConsultaCredito_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(9);
        }
        private void btnPreAutorizacao_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(15);
        }
        private void btnConfPreAutorizacao_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(16);
        }
        private void btnCancPreAutorizacao_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(17);
        }
        private void btnConsultaDebito_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(10);
        }
        private void btnReimpressao_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(6);
        }
        private void btnColetaCpf_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(200);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(5);
        }
        private void btnPSPClient_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(51);
        }
        private void btnMenuPSP_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(50);
        }
        private void btnMercadoPago_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(52);
        }
        private void btnPicPay_Click(object sender, EventArgs e)
        {
            ExecutarFuncao(53);
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            int paramConfConfi = 98;
            string nsuConf = "";
            this.Cursor = Cursors.WaitCursor;

            if (checkBoxTodas.Checked)
            {

                this.Cursor = Cursors.WaitCursor;
                foreach (var item in lstCupons)
                {

                    var auxParc = Convert.ToInt32(item.Parcelas);

                    var parc = auxParc == 0 ? 1 : auxParc;

                    var sNsu = item.Nsu;

                    if (item != lstCupons.Last())
                        sNsu += "*";

                    var retFim = FinalizaFuncaoMCInterativo(paramConfConfi, cnpj, parc, item.Cupom, item.Valor, sNsu, data, pdv, codloja, comunicacao, "");
                    Util.AdicionaLog($"{paramConfConfi}, {cnpj}, {Convert.ToInt32(item.Parcelas)}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}");
                    Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}");

                    lbLog.Items.Insert(0, DateTime.Now + $" - Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}");
                    lbLog.Items.Insert(0, DateTime.Now + $" - {paramConfConfi}, {cnpj}, {parc}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}");

                    nsuConf = item.Nsu;
                }

                foreach (var item in lstCupons)
                {
                    var auxCupom = item.Comprovante + "-------------------------------\n\n" + item.Comprovante;

                    MessageBox.Show(item.Comprovante);
                }

                tansacoespendentes.Items.Clear();
                lbLog.Items.Insert(0, DateTime.Now + " - FIM DA TRANSAÇÃO");
                this.Cursor = Cursors.Default;
                checkBoxMultiplosCartoes.Checked = false;
                lbLog.Refresh();
            }
            else
            {


                int iTrans = tansacoespendentes.SelectedIndex == -1 ? 0 : tansacoespendentes.SelectedIndex;

                var transacao = lstCupons.ElementAt(iTrans);

                MessageBox.Show(transacao.Comprovante);

                var auxParc = Convert.ToInt32(transacao.Parcelas);

                var parc = auxParc == 0 ? 1 : auxParc;

                var sNsu = transacao.Nsu;

                if (lstCupons.Count() > 1)
                    sNsu += "*";

                var retFim = FinalizaFuncaoMCInterativo(paramConfConfi, cnpj, parc, transacao.Cupom, transacao.Valor, sNsu, data, pdv, codloja, comunicacao, "");

                Util.AdicionaLog($"{paramConfConfi}, {cnpj}, {Convert.ToInt32(transacao.Parcelas)}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}");
                Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}");

                lbLog.Items.Insert(0, DateTime.Now + $" - Retorno Confirmação/Desfazimento - {paramConfConfi}: {retFim}");
                lbLog.Items.Insert(0, DateTime.Now + $" - {paramConfConfi}, {cnpj}, {parc}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}");


                lstCupons.RemoveAt(iTrans);

                lstExibicao.RemoveAt(iTrans);

                tansacoespendentes.Items.RemoveAt(iTrans);

                tansacoespendentes.Refresh();


                if (lstCupons.Count == 0)
                {

                    lbLog.Items.Insert(0, DateTime.Now + " - FIM DA TRANSAÇÃO");
                    lbLog.Refresh();
                    this.Cursor = Cursors.Default;
                    checkBoxMultiplosCartoes.Checked = false;
                }

            }


        }
        private void btnDesfaz_Click(object sender, EventArgs e)
        {

            int paramConfDesf = 99;
            string nsuConf = "";
            this.Cursor = Cursors.WaitCursor;

            if (checkBoxTodas.Checked)
            {
                this.Cursor = Cursors.WaitCursor;
                foreach (var item in lstCupons)
                {

                    var auxParc = Convert.ToInt32(item.Parcelas);

                    var parc = auxParc == 0 ? 1 : auxParc;

                    var sNsu = item.Nsu;

                    if (item != lstCupons.Last())
                        sNsu += "*";

                    var retFim = FinalizaFuncaoMCInterativo(paramConfDesf, cnpj, parc, item.Cupom, item.Valor, sNsu, data, pdv, codloja, comunicacao, "");
                    Util.AdicionaLog($"{paramConfDesf}, {cnpj}, {Convert.ToInt32(item.Parcelas)}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}");
                    Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}");

                    lbLog.Items.Insert(0, DateTime.Now + $" - Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}");
                    lbLog.Items.Insert(0, DateTime.Now + $" - {paramConfDesf}, {cnpj}, {parc}, {item.Cupom}, {item.Valor}, {sNsu}, {data}, {pdv}, {codloja}, {comunicacao}");

                    nsuConf = item.Nsu;

                }

                foreach (var item in lstCupons)
                {

                    var auxCupom = item.Comprovante + "-------------------------------\n\n" + item.Comprovante;

                    MessageBox.Show(item.Comprovante);
                }

                tansacoespendentes.Items.Clear();
                lbLog.Items.Insert(0, DateTime.Now + " - FIM DA TRANSAÇÃO");
                this.Cursor = Cursors.Default;
                checkBoxMultiplosCartoes.Checked = false;
                lbLog.Refresh();
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                int iTrans = tansacoespendentes.SelectedIndex == -1 ? 0 : tansacoespendentes.SelectedIndex;

                var transacao = lstCupons.ElementAt(iTrans);

                MessageBox.Show(transacao.Comprovante);

                var auxParc = Convert.ToInt32(transacao.Parcelas);

                var parc = auxParc == 0 ? 1 : auxParc;

                var sNsu = transacao.Nsu;

                if (lstCupons.Count() > 1)
                    sNsu += "*";

                var retFim = FinalizaFuncaoMCInterativo(paramConfDesf, cnpj, parc, transacao.Cupom, transacao.Valor, sNsu, data, pdv, codloja, comunicacao, "");
                Util.AdicionaLog($"{paramConfDesf}, {cnpj}, {Convert.ToInt32(transacao.Parcelas)}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}");
                Util.AdicionaLog($"Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}");

                lbLog.Items.Insert(0, DateTime.Now + $" - Retorno Confirmação/Desfazimento - {paramConfDesf}: {retFim}");
                lbLog.Items.Insert(0, DateTime.Now + $" - {paramConfDesf}, {cnpj}, {parc}, {transacao.Cupom}, {transacao.Valor}, {transacao.Nsu}, {data}, {pdv}, {codloja}, {comunicacao}");


                lstCupons.RemoveAt(iTrans);

                lstExibicao.RemoveAt(iTrans);

                tansacoespendentes.Items.RemoveAt(iTrans);

                tansacoespendentes.Refresh();


                if (lstCupons.Count == 0)
                {

                    lbLog.Items.Insert(0, DateTime.Now + " - FIM DA TRANSAÇÃO");
                    lbLog.Refresh();
                    this.Cursor = Cursors.Default;
                    checkBoxMultiplosCartoes.Checked = false;
                }

            }

        }


        #endregion
    }
}
