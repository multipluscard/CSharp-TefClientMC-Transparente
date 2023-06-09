namespace ExemploDLLTefClientMC_TransparenteCSharp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabTipo = new System.Windows.Forms.TabControl();
            this.tabPageCartao = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabCreditoDebito = new System.Windows.Forms.TabControl();
            this.tabCredito = new System.Windows.Forms.TabPage();
            this.btnCancPreAutorizacao = new System.Windows.Forms.Button();
            this.btnConfPreAutorizacao = new System.Windows.Forms.Button();
            this.btnPreAutorizacao = new System.Windows.Forms.Button();
            this.btnConsultaCredito = new System.Windows.Forms.Button();
            this.btnCreditoParceladoAdm = new System.Windows.Forms.Button();
            this.btnCreditoParceladoLoja = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnCreditoAVista = new System.Windows.Forms.Button();
            this.tabDebito = new System.Windows.Forms.TabPage();
            this.btnConsultaDebito = new System.Windows.Forms.Button();
            this.btnDebitoAVista = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.tabFrota = new System.Windows.Forms.TabPage();
            this.btnVendaFrota = new System.Windows.Forms.Button();
            this.tabVoucher = new System.Windows.Forms.TabPage();
            this.btnVendaVoucher = new System.Windows.Forms.Button();
            this.lbCorOrientacaoCartao = new System.Windows.Forms.Label();
            this.tabPageADM = new System.Windows.Forms.TabPage();
            this.btnColetaCpf = new System.Windows.Forms.Button();
            this.btnReimpressao = new System.Windows.Forms.Button();
            this.btnExcluirBins = new System.Windows.Forms.Button();
            this.lbCorOrientacaoClient = new System.Windows.Forms.Label();
            this.tabPageQrMultiplos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCorOrientacaoQrMultiplos = new System.Windows.Forms.Label();
            this.btnStatusTransacao = new System.Windows.Forms.Button();
            this.btnCancelarEstornoQR = new System.Windows.Forms.Button();
            this.btnMercadoPago = new System.Windows.Forms.Button();
            this.btnPicPay = new System.Windows.Forms.Button();
            this.btnPSPClient = new System.Windows.Forms.Button();
            this.btnMenuPSP = new System.Windows.Forms.Button();
            this.panelAtributos = new System.Windows.Forms.Panel();
            this.lbNsu = new System.Windows.Forms.Label();
            this.lbCupom = new System.Windows.Forms.Label();
            this.lbParcela = new System.Windows.Forms.Label();
            this.txbNsu = new System.Windows.Forms.TextBox();
            this.txbParcela = new System.Windows.Forms.TextBox();
            this.txbCupom = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtributosAParte = new System.Windows.Forms.Button();
            this.btnLimpaLog = new System.Windows.Forms.Button();
            this.checkBoxMultiplosCartoes = new System.Windows.Forms.CheckBox();
            this.tansacoespendentes = new System.Windows.Forms.ListBox();
            this.lbTransacoes = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnDesfaz = new System.Windows.Forms.Button();
            this.checkBoxTodas = new System.Windows.Forms.CheckBox();
            this.panelTransacoes = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabTipo.SuspendLayout();
            this.tabPageCartao.SuspendLayout();
            this.tabCreditoDebito.SuspendLayout();
            this.tabCredito.SuspendLayout();
            this.tabDebito.SuspendLayout();
            this.tabFrota.SuspendLayout();
            this.tabVoucher.SuspendLayout();
            this.tabPageADM.SuspendLayout();
            this.tabPageQrMultiplos.SuspendLayout();
            this.panelAtributos.SuspendLayout();
            this.panelTransacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(557, 35);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(314, 342);
            this.lbLog.TabIndex = 0;
            // 
            // tabTipo
            // 
            this.tabTipo.Controls.Add(this.tabPageCartao);
            this.tabTipo.Controls.Add(this.tabPageADM);
            this.tabTipo.Controls.Add(this.tabPageQrMultiplos);
            this.tabTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTipo.HotTrack = true;
            this.tabTipo.ItemSize = new System.Drawing.Size(90, 45);
            this.tabTipo.Location = new System.Drawing.Point(12, 166);
            this.tabTipo.Multiline = true;
            this.tabTipo.Name = "tabTipo";
            this.tabTipo.Padding = new System.Drawing.Point(6, 5);
            this.tabTipo.SelectedIndex = 0;
            this.tabTipo.Size = new System.Drawing.Size(539, 419);
            this.tabTipo.TabIndex = 1;
            // 
            // tabPageCartao
            // 
            this.tabPageCartao.Controls.Add(this.btnCancelar);
            this.tabPageCartao.Controls.Add(this.tabCreditoDebito);
            this.tabPageCartao.Controls.Add(this.lbCorOrientacaoCartao);
            this.tabPageCartao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCartao.Location = new System.Drawing.Point(4, 49);
            this.tabPageCartao.Name = "tabPageCartao";
            this.tabPageCartao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCartao.Size = new System.Drawing.Size(531, 366);
            this.tabPageCartao.TabIndex = 0;
            this.tabPageCartao.Text = "CARTÃO";
            this.tabPageCartao.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(6, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 29);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabCreditoDebito
            // 
            this.tabCreditoDebito.Controls.Add(this.tabCredito);
            this.tabCreditoDebito.Controls.Add(this.tabDebito);
            this.tabCreditoDebito.Controls.Add(this.tabFrota);
            this.tabCreditoDebito.Controls.Add(this.tabVoucher);
            this.tabCreditoDebito.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCreditoDebito.Location = new System.Drawing.Point(6, 6);
            this.tabCreditoDebito.Name = "tabCreditoDebito";
            this.tabCreditoDebito.SelectedIndex = 0;
            this.tabCreditoDebito.Size = new System.Drawing.Size(519, 322);
            this.tabCreditoDebito.TabIndex = 9;
            // 
            // tabCredito
            // 
            this.tabCredito.Controls.Add(this.btnCancPreAutorizacao);
            this.tabCredito.Controls.Add(this.btnConfPreAutorizacao);
            this.tabCredito.Controls.Add(this.btnPreAutorizacao);
            this.tabCredito.Controls.Add(this.btnConsultaCredito);
            this.tabCredito.Controls.Add(this.btnCreditoParceladoAdm);
            this.tabCredito.Controls.Add(this.btnCreditoParceladoLoja);
            this.tabCredito.Controls.Add(this.btnCredito);
            this.tabCredito.Controls.Add(this.btnCreditoAVista);
            this.tabCredito.Location = new System.Drawing.Point(4, 25);
            this.tabCredito.Name = "tabCredito";
            this.tabCredito.Padding = new System.Windows.Forms.Padding(3);
            this.tabCredito.Size = new System.Drawing.Size(511, 293);
            this.tabCredito.TabIndex = 1;
            this.tabCredito.Text = "CREDITO";
            this.tabCredito.UseVisualStyleBackColor = true;
            // 
            // btnCancPreAutorizacao
            // 
            this.btnCancPreAutorizacao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancPreAutorizacao.Location = new System.Drawing.Point(360, 252);
            this.btnCancPreAutorizacao.Name = "btnCancPreAutorizacao";
            this.btnCancPreAutorizacao.Size = new System.Drawing.Size(142, 32);
            this.btnCancPreAutorizacao.TabIndex = 41;
            this.btnCancPreAutorizacao.Text = "CANC. PRÉ-AUTORIZAÇÃO";
            this.btnCancPreAutorizacao.UseVisualStyleBackColor = true;
            this.btnCancPreAutorizacao.Click += new System.EventHandler(this.btnCancPreAutorizacao_Click);
            // 
            // btnConfPreAutorizacao
            // 
            this.btnConfPreAutorizacao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfPreAutorizacao.Location = new System.Drawing.Point(213, 252);
            this.btnConfPreAutorizacao.Name = "btnConfPreAutorizacao";
            this.btnConfPreAutorizacao.Size = new System.Drawing.Size(141, 32);
            this.btnConfPreAutorizacao.TabIndex = 40;
            this.btnConfPreAutorizacao.Text = "CONF. PRÉ-AUTORIZAÇÃO";
            this.btnConfPreAutorizacao.UseVisualStyleBackColor = true;
            this.btnConfPreAutorizacao.Click += new System.EventHandler(this.btnConfPreAutorizacao_Click);
            // 
            // btnPreAutorizacao
            // 
            this.btnPreAutorizacao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreAutorizacao.Location = new System.Drawing.Point(91, 252);
            this.btnPreAutorizacao.Name = "btnPreAutorizacao";
            this.btnPreAutorizacao.Size = new System.Drawing.Size(116, 32);
            this.btnPreAutorizacao.TabIndex = 39;
            this.btnPreAutorizacao.Text = "PRÉ-AUTORIZAÇÃO";
            this.btnPreAutorizacao.UseVisualStyleBackColor = true;
            this.btnPreAutorizacao.Click += new System.EventHandler(this.btnPreAutorizacao_Click);
            // 
            // btnConsultaCredito
            // 
            this.btnConsultaCredito.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCredito.Location = new System.Drawing.Point(10, 252);
            this.btnConsultaCredito.Name = "btnConsultaCredito";
            this.btnConsultaCredito.Size = new System.Drawing.Size(75, 32);
            this.btnConsultaCredito.TabIndex = 38;
            this.btnConsultaCredito.Text = "CONSULTA";
            this.btnConsultaCredito.UseVisualStyleBackColor = true;
            this.btnConsultaCredito.Click += new System.EventHandler(this.btnConsultaCredito_Click);
            // 
            // btnCreditoParceladoAdm
            // 
            this.btnCreditoParceladoAdm.Location = new System.Drawing.Point(22, 184);
            this.btnCreditoParceladoAdm.Name = "btnCreditoParceladoAdm";
            this.btnCreditoParceladoAdm.Size = new System.Drawing.Size(170, 46);
            this.btnCreditoParceladoAdm.TabIndex = 37;
            this.btnCreditoParceladoAdm.Text = "CRÉDITO PARCELADO ADM";
            this.btnCreditoParceladoAdm.UseVisualStyleBackColor = true;
            this.btnCreditoParceladoAdm.Click += new System.EventHandler(this.btnCreditoParceladoAdm_Click);
            // 
            // btnCreditoParceladoLoja
            // 
            this.btnCreditoParceladoLoja.Location = new System.Drawing.Point(22, 132);
            this.btnCreditoParceladoLoja.Name = "btnCreditoParceladoLoja";
            this.btnCreditoParceladoLoja.Size = new System.Drawing.Size(170, 46);
            this.btnCreditoParceladoLoja.TabIndex = 36;
            this.btnCreditoParceladoLoja.Text = "CRÉDITO PARCELADO LOJA";
            this.btnCreditoParceladoLoja.UseVisualStyleBackColor = true;
            this.btnCreditoParceladoLoja.Click += new System.EventHandler(this.btnCreditoParceladoLoja_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.Location = new System.Drawing.Point(22, 28);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(170, 46);
            this.btnCredito.TabIndex = 35;
            this.btnCredito.Text = "CRÉDITO ";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnCreditoAVista
            // 
            this.btnCreditoAVista.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditoAVista.Location = new System.Drawing.Point(22, 80);
            this.btnCreditoAVista.Name = "btnCreditoAVista";
            this.btnCreditoAVista.Size = new System.Drawing.Size(170, 46);
            this.btnCreditoAVista.TabIndex = 34;
            this.btnCreditoAVista.Text = "CRÉDITO A VISTA";
            this.btnCreditoAVista.UseVisualStyleBackColor = true;
            this.btnCreditoAVista.Click += new System.EventHandler(this.btnCreditoAVista_Click);
            // 
            // tabDebito
            // 
            this.tabDebito.Controls.Add(this.btnConsultaDebito);
            this.tabDebito.Controls.Add(this.btnDebitoAVista);
            this.tabDebito.Controls.Add(this.btnDebito);
            this.tabDebito.Location = new System.Drawing.Point(4, 25);
            this.tabDebito.Name = "tabDebito";
            this.tabDebito.Size = new System.Drawing.Size(511, 293);
            this.tabDebito.TabIndex = 2;
            this.tabDebito.Text = "DEBITO";
            this.tabDebito.UseVisualStyleBackColor = true;
            // 
            // btnConsultaDebito
            // 
            this.btnConsultaDebito.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConsultaDebito.Location = new System.Drawing.Point(10, 252);
            this.btnConsultaDebito.Name = "btnConsultaDebito";
            this.btnConsultaDebito.Size = new System.Drawing.Size(75, 32);
            this.btnConsultaDebito.TabIndex = 25;
            this.btnConsultaDebito.Text = "CONSULTA";
            this.btnConsultaDebito.UseVisualStyleBackColor = true;
            this.btnConsultaDebito.Click += new System.EventHandler(this.btnConsultaDebito_Click);
            // 
            // btnDebitoAVista
            // 
            this.btnDebitoAVista.Location = new System.Drawing.Point(22, 80);
            this.btnDebitoAVista.Name = "btnDebitoAVista";
            this.btnDebitoAVista.Size = new System.Drawing.Size(170, 46);
            this.btnDebitoAVista.TabIndex = 24;
            this.btnDebitoAVista.Text = "DÉBITO A VISTA";
            this.btnDebitoAVista.UseVisualStyleBackColor = true;
            this.btnDebitoAVista.Click += new System.EventHandler(this.btnDebitoAVista_Click);
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(22, 28);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(170, 46);
            this.btnDebito.TabIndex = 24;
            this.btnDebito.Text = "DÉBITO";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // tabFrota
            // 
            this.tabFrota.Controls.Add(this.btnVendaFrota);
            this.tabFrota.Location = new System.Drawing.Point(4, 25);
            this.tabFrota.Name = "tabFrota";
            this.tabFrota.Size = new System.Drawing.Size(511, 293);
            this.tabFrota.TabIndex = 3;
            this.tabFrota.Text = "FROTA";
            this.tabFrota.UseVisualStyleBackColor = true;
            // 
            // btnVendaFrota
            // 
            this.btnVendaFrota.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVendaFrota.Location = new System.Drawing.Point(22, 28);
            this.btnVendaFrota.Name = "btnVendaFrota";
            this.btnVendaFrota.Size = new System.Drawing.Size(170, 46);
            this.btnVendaFrota.TabIndex = 44;
            this.btnVendaFrota.Text = "VENDA FROTA";
            this.btnVendaFrota.UseVisualStyleBackColor = true;
            this.btnVendaFrota.Click += new System.EventHandler(this.btnVendaFrota_Click);
            // 
            // tabVoucher
            // 
            this.tabVoucher.Controls.Add(this.btnVendaVoucher);
            this.tabVoucher.Location = new System.Drawing.Point(4, 25);
            this.tabVoucher.Name = "tabVoucher";
            this.tabVoucher.Size = new System.Drawing.Size(511, 293);
            this.tabVoucher.TabIndex = 4;
            this.tabVoucher.Text = "VOUCHER";
            this.tabVoucher.UseVisualStyleBackColor = true;
            // 
            // btnVendaVoucher
            // 
            this.btnVendaVoucher.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVendaVoucher.Location = new System.Drawing.Point(22, 28);
            this.btnVendaVoucher.Name = "btnVendaVoucher";
            this.btnVendaVoucher.Size = new System.Drawing.Size(170, 46);
            this.btnVendaVoucher.TabIndex = 0;
            this.btnVendaVoucher.Text = "VENDA VOUCHER";
            this.btnVendaVoucher.UseVisualStyleBackColor = true;
            this.btnVendaVoucher.Click += new System.EventHandler(this.btnVendaVoucher_Click);
            // 
            // lbCorOrientacaoCartao
            // 
            this.lbCorOrientacaoCartao.AutoSize = true;
            this.lbCorOrientacaoCartao.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbCorOrientacaoCartao.Font = new System.Drawing.Font("Arial", 5F);
            this.lbCorOrientacaoCartao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbCorOrientacaoCartao.Location = new System.Drawing.Point(0, -4);
            this.lbCorOrientacaoCartao.Name = "lbCorOrientacaoCartao";
            this.lbCorOrientacaoCartao.Size = new System.Drawing.Size(589, 7);
            this.lbCorOrientacaoCartao.TabIndex = 39;
            this.lbCorOrientacaoCartao.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // tabPageADM
            // 
            this.tabPageADM.Controls.Add(this.btnColetaCpf);
            this.tabPageADM.Controls.Add(this.btnReimpressao);
            this.tabPageADM.Controls.Add(this.btnExcluirBins);
            this.tabPageADM.Controls.Add(this.lbCorOrientacaoClient);
            this.tabPageADM.Location = new System.Drawing.Point(4, 49);
            this.tabPageADM.Name = "tabPageADM";
            this.tabPageADM.Size = new System.Drawing.Size(531, 366);
            this.tabPageADM.TabIndex = 3;
            this.tabPageADM.Text = "ADMINISTRAÇÃO";
            this.tabPageADM.UseVisualStyleBackColor = true;
            // 
            // btnColetaCpf
            // 
            this.btnColetaCpf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnColetaCpf.Location = new System.Drawing.Point(22, 132);
            this.btnColetaCpf.Name = "btnColetaCpf";
            this.btnColetaCpf.Size = new System.Drawing.Size(170, 46);
            this.btnColetaCpf.TabIndex = 43;
            this.btnColetaCpf.Text = "COLETA DE CPF";
            this.btnColetaCpf.UseVisualStyleBackColor = true;
            this.btnColetaCpf.Click += new System.EventHandler(this.btnColetaCpf_Click);
            // 
            // btnReimpressao
            // 
            this.btnReimpressao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReimpressao.Location = new System.Drawing.Point(23, 80);
            this.btnReimpressao.Name = "btnReimpressao";
            this.btnReimpressao.Size = new System.Drawing.Size(170, 46);
            this.btnReimpressao.TabIndex = 42;
            this.btnReimpressao.Text = "REIMPRESSAO";
            this.btnReimpressao.UseVisualStyleBackColor = true;
            this.btnReimpressao.Click += new System.EventHandler(this.btnReimpressao_Click);
            // 
            // btnExcluirBins
            // 
            this.btnExcluirBins.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluirBins.Location = new System.Drawing.Point(22, 28);
            this.btnExcluirBins.Name = "btnExcluirBins";
            this.btnExcluirBins.Size = new System.Drawing.Size(170, 46);
            this.btnExcluirBins.TabIndex = 41;
            this.btnExcluirBins.Text = "EXCLUIR BINS";
            this.btnExcluirBins.UseVisualStyleBackColor = true;
            this.btnExcluirBins.Click += new System.EventHandler(this.btnExcluirBins_Click);
            // 
            // lbCorOrientacaoClient
            // 
            this.lbCorOrientacaoClient.AutoSize = true;
            this.lbCorOrientacaoClient.BackColor = System.Drawing.Color.Salmon;
            this.lbCorOrientacaoClient.Font = new System.Drawing.Font("Arial", 5F);
            this.lbCorOrientacaoClient.ForeColor = System.Drawing.Color.Salmon;
            this.lbCorOrientacaoClient.Location = new System.Drawing.Point(0, -4);
            this.lbCorOrientacaoClient.Name = "lbCorOrientacaoClient";
            this.lbCorOrientacaoClient.Size = new System.Drawing.Size(582, 7);
            this.lbCorOrientacaoClient.TabIndex = 40;
            this.lbCorOrientacaoClient.Text = "xxxXXXXXXXXXXXXXXXXXXXXXXXXXXXXxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxx";
            // 
            // tabPageQrMultiplos
            // 
            this.tabPageQrMultiplos.Controls.Add(this.label2);
            this.tabPageQrMultiplos.Controls.Add(this.lbCorOrientacaoQrMultiplos);
            this.tabPageQrMultiplos.Controls.Add(this.btnStatusTransacao);
            this.tabPageQrMultiplos.Controls.Add(this.btnCancelarEstornoQR);
            this.tabPageQrMultiplos.Controls.Add(this.btnMercadoPago);
            this.tabPageQrMultiplos.Controls.Add(this.btnPicPay);
            this.tabPageQrMultiplos.Controls.Add(this.btnPSPClient);
            this.tabPageQrMultiplos.Controls.Add(this.btnMenuPSP);
            this.tabPageQrMultiplos.Location = new System.Drawing.Point(4, 49);
            this.tabPageQrMultiplos.Name = "tabPageQrMultiplos";
            this.tabPageQrMultiplos.Size = new System.Drawing.Size(531, 366);
            this.tabPageQrMultiplos.TabIndex = 4;
            this.tabPageQrMultiplos.Text = "QRMULTIPLUS";
            this.tabPageQrMultiplos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 32);
            this.label2.TabIndex = 41;
            this.label2.Text = "Obs: Para visualizar o QR Code utilizar o parâmetro\r\nExibirQrCode=2  no CliMC.ini" +
    "";
            // 
            // lbCorOrientacaoQrMultiplos
            // 
            this.lbCorOrientacaoQrMultiplos.AutoSize = true;
            this.lbCorOrientacaoQrMultiplos.BackColor = System.Drawing.Color.Red;
            this.lbCorOrientacaoQrMultiplos.Font = new System.Drawing.Font("Arial", 5F);
            this.lbCorOrientacaoQrMultiplos.ForeColor = System.Drawing.Color.Blue;
            this.lbCorOrientacaoQrMultiplos.Location = new System.Drawing.Point(-2, -4);
            this.lbCorOrientacaoQrMultiplos.Name = "lbCorOrientacaoQrMultiplos";
            this.lbCorOrientacaoQrMultiplos.Size = new System.Drawing.Size(589, 7);
            this.lbCorOrientacaoQrMultiplos.TabIndex = 40;
            this.lbCorOrientacaoQrMultiplos.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // btnStatusTransacao
            // 
            this.btnStatusTransacao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnStatusTransacao.Location = new System.Drawing.Point(141, 252);
            this.btnStatusTransacao.Name = "btnStatusTransacao";
            this.btnStatusTransacao.Size = new System.Drawing.Size(116, 32);
            this.btnStatusTransacao.TabIndex = 5;
            this.btnStatusTransacao.Text = "STATUS TRANSAÇÃO";
            this.btnStatusTransacao.UseVisualStyleBackColor = true;
            this.btnStatusTransacao.Click += new System.EventHandler(this.btnStatusTransacao_Click);
            // 
            // btnCancelarEstornoQR
            // 
            this.btnCancelarEstornoQR.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarEstornoQR.Location = new System.Drawing.Point(10, 252);
            this.btnCancelarEstornoQR.Name = "btnCancelarEstornoQR";
            this.btnCancelarEstornoQR.Size = new System.Drawing.Size(125, 32);
            this.btnCancelarEstornoQR.TabIndex = 4;
            this.btnCancelarEstornoQR.Text = "CANCELAR/ESTORNO";
            this.btnCancelarEstornoQR.UseVisualStyleBackColor = true;
            this.btnCancelarEstornoQR.Click += new System.EventHandler(this.btnCancelarEstornoQR_Click);
            // 
            // btnMercadoPago
            // 
            this.btnMercadoPago.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMercadoPago.Location = new System.Drawing.Point(22, 132);
            this.btnMercadoPago.Name = "btnMercadoPago";
            this.btnMercadoPago.Size = new System.Drawing.Size(170, 46);
            this.btnMercadoPago.TabIndex = 3;
            this.btnMercadoPago.Text = "MERCADO PAGO";
            this.btnMercadoPago.UseVisualStyleBackColor = true;
            this.btnMercadoPago.Click += new System.EventHandler(this.btnMercadoPago_Click);
            // 
            // btnPicPay
            // 
            this.btnPicPay.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPicPay.Location = new System.Drawing.Point(22, 184);
            this.btnPicPay.Name = "btnPicPay";
            this.btnPicPay.Size = new System.Drawing.Size(170, 46);
            this.btnPicPay.TabIndex = 2;
            this.btnPicPay.Text = "PICPAY";
            this.btnPicPay.UseVisualStyleBackColor = true;
            this.btnPicPay.Click += new System.EventHandler(this.btnPicPay_Click);
            // 
            // btnPSPClient
            // 
            this.btnPSPClient.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPSPClient.Location = new System.Drawing.Point(22, 80);
            this.btnPSPClient.Name = "btnPSPClient";
            this.btnPSPClient.Size = new System.Drawing.Size(170, 46);
            this.btnPSPClient.TabIndex = 1;
            this.btnPSPClient.Text = "PSP CLIENTE";
            this.btnPSPClient.UseVisualStyleBackColor = true;
            this.btnPSPClient.Click += new System.EventHandler(this.btnPSPClient_Click);
            // 
            // btnMenuPSP
            // 
            this.btnMenuPSP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuPSP.Location = new System.Drawing.Point(22, 28);
            this.btnMenuPSP.Name = "btnMenuPSP";
            this.btnMenuPSP.Size = new System.Drawing.Size(170, 46);
            this.btnMenuPSP.TabIndex = 0;
            this.btnMenuPSP.Text = "MENU OPÇÕES PSP";
            this.btnMenuPSP.UseVisualStyleBackColor = true;
            this.btnMenuPSP.Click += new System.EventHandler(this.btnMenuPSP_Click);
            // 
            // panelAtributos
            // 
            this.panelAtributos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelAtributos.Controls.Add(this.lbNsu);
            this.panelAtributos.Controls.Add(this.lbCupom);
            this.panelAtributos.Controls.Add(this.lbParcela);
            this.panelAtributos.Controls.Add(this.txbNsu);
            this.panelAtributos.Controls.Add(this.txbParcela);
            this.panelAtributos.Controls.Add(this.txbCupom);
            this.panelAtributos.Controls.Add(this.txbValor);
            this.panelAtributos.Controls.Add(this.label1);
            this.panelAtributos.Location = new System.Drawing.Point(16, 35);
            this.panelAtributos.Name = "panelAtributos";
            this.panelAtributos.Size = new System.Drawing.Size(535, 97);
            this.panelAtributos.TabIndex = 42;
            // 
            // lbNsu
            // 
            this.lbNsu.AutoSize = true;
            this.lbNsu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNsu.Location = new System.Drawing.Point(408, 26);
            this.lbNsu.Name = "lbNsu";
            this.lbNsu.Size = new System.Drawing.Size(31, 16);
            this.lbNsu.TabIndex = 7;
            this.lbNsu.Text = "NSU";
            // 
            // lbCupom
            // 
            this.lbCupom.AutoSize = true;
            this.lbCupom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupom.Location = new System.Drawing.Point(272, 26);
            this.lbCupom.Name = "lbCupom";
            this.lbCupom.Size = new System.Drawing.Size(48, 16);
            this.lbCupom.TabIndex = 6;
            this.lbCupom.Text = "CUPOM";
            // 
            // lbParcela
            // 
            this.lbParcela.AutoSize = true;
            this.lbParcela.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParcela.Location = new System.Drawing.Point(136, 26);
            this.lbParcela.Name = "lbParcela";
            this.lbParcela.Size = new System.Drawing.Size(58, 16);
            this.lbParcela.TabIndex = 5;
            this.lbParcela.Text = "PARCELA";
            // 
            // txbNsu
            // 
            this.txbNsu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNsu.Location = new System.Drawing.Point(411, 45);
            this.txbNsu.Name = "txbNsu";
            this.txbNsu.Size = new System.Drawing.Size(117, 22);
            this.txbNsu.TabIndex = 4;
            // 
            // txbParcela
            // 
            this.txbParcela.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbParcela.Location = new System.Drawing.Point(139, 45);
            this.txbParcela.Name = "txbParcela";
            this.txbParcela.Size = new System.Drawing.Size(118, 22);
            this.txbParcela.TabIndex = 3;
            // 
            // txbCupom
            // 
            this.txbCupom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCupom.Location = new System.Drawing.Point(275, 45);
            this.txbCupom.Name = "txbCupom";
            this.txbCupom.Size = new System.Drawing.Size(117, 22);
            this.txbCupom.TabIndex = 2;
            // 
            // txbValor
            // 
            this.txbValor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.Location = new System.Drawing.Point(6, 45);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(117, 22);
            this.txbValor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "VALOR";
            // 
            // btnAtributosAParte
            // 
            this.btnAtributosAParte.Image = ((System.Drawing.Image)(resources.GetObject("btnAtributosAParte.Image")));
            this.btnAtributosAParte.Location = new System.Drawing.Point(843, 5);
            this.btnAtributosAParte.Name = "btnAtributosAParte";
            this.btnAtributosAParte.Size = new System.Drawing.Size(28, 28);
            this.btnAtributosAParte.TabIndex = 43;
            this.toolTip1.SetToolTip(this.btnAtributosAParte, "Configurações do PDV");
            this.btnAtributosAParte.UseVisualStyleBackColor = true;
            this.btnAtributosAParte.Click += new System.EventHandler(this.btnAtributosAParte_Click);
            // 
            // btnLimpaLog
            // 
            this.btnLimpaLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpaLog.Image")));
            this.btnLimpaLog.Location = new System.Drawing.Point(809, 5);
            this.btnLimpaLog.Name = "btnLimpaLog";
            this.btnLimpaLog.Size = new System.Drawing.Size(28, 28);
            this.btnLimpaLog.TabIndex = 44;
            this.toolTip1.SetToolTip(this.btnLimpaLog, "Limpar log de eventos na tela");
            this.btnLimpaLog.UseVisualStyleBackColor = true;
            this.btnLimpaLog.Click += new System.EventHandler(this.btnLimpaLog_Click);
            // 
            // checkBoxMultiplosCartoes
            // 
            this.checkBoxMultiplosCartoes.AutoSize = true;
            this.checkBoxMultiplosCartoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.checkBoxMultiplosCartoes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMultiplosCartoes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxMultiplosCartoes.Location = new System.Drawing.Point(399, 138);
            this.checkBoxMultiplosCartoes.Name = "checkBoxMultiplosCartoes";
            this.checkBoxMultiplosCartoes.Size = new System.Drawing.Size(152, 19);
            this.checkBoxMultiplosCartoes.TabIndex = 45;
            this.checkBoxMultiplosCartoes.Text = "MÚLTIPLOS CARTÕES";
            this.checkBoxMultiplosCartoes.UseVisualStyleBackColor = false;
            this.checkBoxMultiplosCartoes.CheckedChanged += new System.EventHandler(this.checkBoxMultiplosCartoes_CheckedChanged);
            // 
            // tansacoespendentes
            // 
            this.tansacoespendentes.Cursor = System.Windows.Forms.Cursors.Default;
            this.tansacoespendentes.FormattingEnabled = true;
            this.tansacoespendentes.Location = new System.Drawing.Point(6, 31);
            this.tansacoespendentes.Name = "tansacoespendentes";
            this.tansacoespendentes.Size = new System.Drawing.Size(302, 121);
            this.tansacoespendentes.TabIndex = 46;
            // 
            // lbTransacoes
            // 
            this.lbTransacoes.AutoSize = true;
            this.lbTransacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransacoes.Location = new System.Drawing.Point(3, 12);
            this.lbTransacoes.Name = "lbTransacoes";
            this.lbTransacoes.Size = new System.Drawing.Size(81, 16);
            this.lbTransacoes.TabIndex = 47;
            this.lbTransacoes.Text = "Transações";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(6, 153);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(119, 35);
            this.btnConfirma.TabIndex = 48;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnDesfaz
            // 
            this.btnDesfaz.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesfaz.Location = new System.Drawing.Point(129, 153);
            this.btnDesfaz.Name = "btnDesfaz";
            this.btnDesfaz.Size = new System.Drawing.Size(119, 35);
            this.btnDesfaz.TabIndex = 48;
            this.btnDesfaz.Text = "DESFAZ";
            this.btnDesfaz.UseVisualStyleBackColor = true;
            this.btnDesfaz.Click += new System.EventHandler(this.btnDesfaz_Click);
            // 
            // checkBoxTodas
            // 
            this.checkBoxTodas.AutoSize = true;
            this.checkBoxTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTodas.Location = new System.Drawing.Point(251, 161);
            this.checkBoxTodas.Name = "checkBoxTodas";
            this.checkBoxTodas.Size = new System.Drawing.Size(60, 19);
            this.checkBoxTodas.TabIndex = 49;
            this.checkBoxTodas.Text = "Todas";
            this.checkBoxTodas.UseVisualStyleBackColor = true;
            // 
            // panelTransacoes
            // 
            this.panelTransacoes.Controls.Add(this.checkBoxTodas);
            this.panelTransacoes.Controls.Add(this.lbTransacoes);
            this.panelTransacoes.Controls.Add(this.btnDesfaz);
            this.panelTransacoes.Controls.Add(this.tansacoespendentes);
            this.panelTransacoes.Controls.Add(this.btnConfirma);
            this.panelTransacoes.Location = new System.Drawing.Point(557, 382);
            this.panelTransacoes.Name = "panelTransacoes";
            this.panelTransacoes.Size = new System.Drawing.Size(314, 199);
            this.panelTransacoes.TabIndex = 50;
            this.panelTransacoes.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(877, 594);
            this.Controls.Add(this.checkBoxMultiplosCartoes);
            this.Controls.Add(this.btnLimpaLog);
            this.Controls.Add(this.btnAtributosAParte);
            this.Controls.Add(this.panelAtributos);
            this.Controls.Add(this.panelTransacoes);
            this.Controls.Add(this.tabTipo);
            this.Controls.Add(this.lbLog);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo TefClientMC - C#";
            this.tabTipo.ResumeLayout(false);
            this.tabPageCartao.ResumeLayout(false);
            this.tabPageCartao.PerformLayout();
            this.tabCreditoDebito.ResumeLayout(false);
            this.tabCredito.ResumeLayout(false);
            this.tabDebito.ResumeLayout(false);
            this.tabFrota.ResumeLayout(false);
            this.tabVoucher.ResumeLayout(false);
            this.tabPageADM.ResumeLayout(false);
            this.tabPageADM.PerformLayout();
            this.tabPageQrMultiplos.ResumeLayout(false);
            this.tabPageQrMultiplos.PerformLayout();
            this.panelAtributos.ResumeLayout(false);
            this.panelAtributos.PerformLayout();
            this.panelTransacoes.ResumeLayout(false);
            this.panelTransacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TabControl tabTipo;
        private System.Windows.Forms.TabPage tabPageCartao;
        private System.Windows.Forms.TabControl tabCreditoDebito;
        private System.Windows.Forms.TabPage tabCredito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnCreditoAVista;
        private System.Windows.Forms.TabPage tabDebito;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Label lbCorOrientacaoCartao;
        private System.Windows.Forms.TabPage tabPageADM;
        private System.Windows.Forms.Label lbCorOrientacaoClient;
        private System.Windows.Forms.Panel panelAtributos;
        private System.Windows.Forms.Button btnAtributosAParte;
        private System.Windows.Forms.Button btnLimpaLog;
        private System.Windows.Forms.Label lbNsu;
        private System.Windows.Forms.Label lbCupom;
        private System.Windows.Forms.Label lbParcela;
        private System.Windows.Forms.TextBox txbNsu;
        private System.Windows.Forms.TextBox txbParcela;
        private System.Windows.Forms.TextBox txbCupom;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDebitoAVista;
        private System.Windows.Forms.Button btnCreditoParceladoLoja;
        private System.Windows.Forms.Button btnCreditoParceladoAdm;
        private System.Windows.Forms.Button btnVendaFrota;
        private System.Windows.Forms.Button btnVendaVoucher;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCancPreAutorizacao;
        private System.Windows.Forms.Button btnConfPreAutorizacao;
        private System.Windows.Forms.Button btnPreAutorizacao;
        private System.Windows.Forms.Button btnConsultaCredito;
        private System.Windows.Forms.Button btnConsultaDebito;
        private System.Windows.Forms.TabPage tabFrota;
        private System.Windows.Forms.TabPage tabVoucher;
        private System.Windows.Forms.Button btnColetaCpf;
        private System.Windows.Forms.Button btnReimpressao;
        private System.Windows.Forms.Button btnExcluirBins;
        private System.Windows.Forms.CheckBox checkBoxMultiplosCartoes;
        private System.Windows.Forms.ListBox tansacoespendentes;
        private System.Windows.Forms.Label lbTransacoes;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnDesfaz;
        private System.Windows.Forms.CheckBox checkBoxTodas;
        private System.Windows.Forms.Panel panelTransacoes;
        private System.Windows.Forms.TabPage tabPageQrMultiplos;
        private System.Windows.Forms.Button btnMenuPSP;
        private System.Windows.Forms.Button btnMercadoPago;
        private System.Windows.Forms.Button btnPicPay;
        private System.Windows.Forms.Button btnPSPClient;
        private System.Windows.Forms.Button btnStatusTransacao;
        private System.Windows.Forms.Button btnCancelarEstornoQR;
        private System.Windows.Forms.Label lbCorOrientacaoQrMultiplos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}

