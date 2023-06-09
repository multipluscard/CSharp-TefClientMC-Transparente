namespace ExemploDLLTefClientMC_TransparenteCSharp
{
    partial class FormMensagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensagem));
            this.iconImag = new System.Windows.Forms.PictureBox();
            this.panelMensagem = new System.Windows.Forms.Panel();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.txbRecebe = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconImag)).BeginInit();
            this.panelMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconImag
            // 
            this.iconImag.Image = ((System.Drawing.Image)(resources.GetObject("iconImag.Image")));
            this.iconImag.Location = new System.Drawing.Point(15, 14);
            this.iconImag.Name = "iconImag";
            this.iconImag.Size = new System.Drawing.Size(37, 32);
            this.iconImag.TabIndex = 0;
            this.iconImag.TabStop = false;
            // 
            // panelMensagem
            // 
            this.panelMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMensagem.Controls.Add(this.lbMensagem);
            this.panelMensagem.Controls.Add(this.txbRecebe);
            this.panelMensagem.Controls.Add(this.btnCancelar);
            this.panelMensagem.Controls.Add(this.btnOk);
            this.panelMensagem.Controls.Add(this.iconImag);
            this.panelMensagem.Location = new System.Drawing.Point(12, 12);
            this.panelMensagem.Name = "panelMensagem";
            this.panelMensagem.Size = new System.Drawing.Size(479, 251);
            this.panelMensagem.TabIndex = 1;
            // 
            // lbMensagem
            // 
            this.lbMensagem.AllowDrop = true;
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.BackColor = System.Drawing.SystemColors.Control;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbMensagem.Location = new System.Drawing.Point(11, 60);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(82, 18);
            this.lbMensagem.TabIndex = 5;
            this.lbMensagem.Text = "Mensagem";
            // 
            // txbRecebe
            // 
            this.txbRecebe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRecebe.Location = new System.Drawing.Point(15, 208);
            this.txbRecebe.Name = "txbRecebe";
            this.txbRecebe.Size = new System.Drawing.Size(444, 26);
            this.txbRecebe.TabIndex = 3;
            this.txbRecebe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRecebe_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(385, 84);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(385, 41);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(503, 274);
            this.Controls.Add(this.panelMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMensagem";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulário Mensagem";
            ((System.ComponentModel.ISupportInitialize)(this.iconImag)).EndInit();
            this.panelMensagem.ResumeLayout(false);
            this.panelMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconImag;
        private System.Windows.Forms.Panel panelMensagem;
        private System.Windows.Forms.TextBox txbRecebe;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbMensagem;
    }
}