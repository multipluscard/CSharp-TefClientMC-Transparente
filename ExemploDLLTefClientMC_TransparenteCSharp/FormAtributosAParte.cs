using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDLLTefClientMC_TransparenteCSharp
{
   
    public partial class FormAtributosAParte : Form
    {

        public int AtrComunicacao;
        public string AtrCnpj { get; set; }
        public string AtrData { get; set; }
        public string AtrPdv { get; set; }
        public string AtrCodLoja { get; set; }

        public FormAtributosAParte()
        {
            InitializeComponent();         
        }

        public FormAtributosAParte(int comunicacao, string cnpj, string codloja, string data, string pdv)
        {
            
            InitializeComponent();
            txbComunicacao.Text = comunicacao.ToString();
            txbCnpj.Text = cnpj;
            txbCodLoja.Text = codloja;
            txbData.Text = data;
            txbPDV.Text = pdv;           
        }

        private void txbComunicacao_TextChanged(object sender, EventArgs e)
        {
           int.TryParse(txbComunicacao.Text, out AtrComunicacao);
        }

        private void txbPDV_TextChanged(object sender, EventArgs e)
        {
            AtrPdv = txbPDV.Text;
        }

        private void txbCodLoja_TextChanged(object sender, EventArgs e)
        {
            AtrCodLoja = txbCodLoja.Text;
        }

        private void txbCnpj_TextChanged_1(object sender, EventArgs e)
        {
            AtrCnpj = txbCnpj.Text;
        }

        private void txbData_TextChanged_1(object sender, EventArgs e)
        {
            AtrData = txbData.Text;
        }

    }
}
