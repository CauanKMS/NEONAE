namespace NeonAnunciosDeEventos
{
    partial class frmTelaLoginEsqueceuSenha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLoginEsqueceuSenha));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblConfCpf = new System.Windows.Forms.Label();
            this.mskConfCpf = new System.Windows.Forms.MaskedTextBox();
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(190, 35);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(307, 25);
            this.txtemail.TabIndex = 0;
            this.toolTipHint.SetToolTip(this.txtemail, "Digite seu email para confirmação");
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.Location = new System.Drawing.Point(8, 38);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(176, 17);
            this.lblemail.TabIndex = 234;
            this.lblemail.Text = "Confirme seu Email Atual:";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.Cyan;
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.ForeColor = System.Drawing.Color.White;
            this.btnEnviarEmail.Location = new System.Drawing.Point(160, 111);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(154, 39);
            this.btnEnviarEmail.TabIndex = 2;
            this.btnEnviarEmail.Text = "Enviar para o Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(500, -1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(41, 30);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Cyan;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(538, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblConfCpf
            // 
            this.lblConfCpf.AutoSize = true;
            this.lblConfCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblConfCpf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfCpf.ForeColor = System.Drawing.Color.Black;
            this.lblConfCpf.Location = new System.Drawing.Point(8, 74);
            this.lblConfCpf.Name = "lblConfCpf";
            this.lblConfCpf.Size = new System.Drawing.Size(134, 17);
            this.lblConfCpf.TabIndex = 236;
            this.lblConfCpf.Text = "Confirme seu CPF:";
            // 
            // mskConfCpf
            // 
            this.mskConfCpf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskConfCpf.Location = new System.Drawing.Point(148, 71);
            this.mskConfCpf.Mask = "000,000,000-00";
            this.mskConfCpf.Name = "mskConfCpf";
            this.mskConfCpf.Size = new System.Drawing.Size(119, 25);
            this.mskConfCpf.TabIndex = 1;
            this.toolTipHint.SetToolTip(this.mskConfCpf, "Digite Seu Cpf");
            this.mskConfCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskConfCpf_KeyPress);
            // 
            // frmTelaLoginEsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 162);
            this.Controls.Add(this.mskConfCpf);
            this.Controls.Add(this.lblConfCpf);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaLoginEsqueceuSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaLoginEsqueceuSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblConfCpf;
        private System.Windows.Forms.MaskedTextBox mskConfCpf;
        private System.Windows.Forms.ToolTip toolTipHint;
    }
}