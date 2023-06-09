using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDLLTefClientMC_TransparenteCSharp
{
    public partial class FormMensagem : Form
    {
        public string retornoMsg;
        public bool cancelar = false;
        public FormMensagem()
        {
            InitializeComponent();
        }

        public FormMensagem(string titulo, string msg)
        {
            InitializeComponent();

            lbMensagem.Text = msg;
            this.Text = titulo;

            if (titulo == "[ERRODISPLAY]" || titulo == "[MSG]")
                txbRecebe.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            retornoMsg = txbRecebe.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
            this.Close();
        }

        private void txbRecebe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }


    }
}
