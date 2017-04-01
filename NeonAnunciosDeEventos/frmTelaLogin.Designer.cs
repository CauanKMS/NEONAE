namespace NeonAnunciosDeEventos
{
    partial class frmTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblerroemail = new System.Windows.Forms.Label();
            this.lblerrosenha = new System.Windows.Forms.Label();
            this.btnlogar = new System.Windows.Forms.Button();
            this.txtrespsec = new System.Windows.Forms.TextBox();
            this.lblrespostasec = new System.Windows.Forms.Label();
            this.cmbPerguntaSecreta = new System.Windows.Forms.ComboBox();
            this.lblpergsec = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pctLogoNeon = new System.Windows.Forms.PictureBox();
            this.lnkSenha = new System.Windows.Forms.LinkLabel();
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoNeon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            resources.ApplyResources(this.txtemail, "txtemail");
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Name = "txtemail";
            this.toolTipHint.SetToolTip(this.txtemail, resources.GetString("txtemail.ToolTip"));
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            // 
            // txtsenha
            // 
            resources.ApplyResources(this.txtsenha, "txtsenha");
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.Name = "txtsenha";
            this.toolTipHint.SetToolTip(this.txtsenha, resources.GetString("txtsenha.ToolTip"));
            this.txtsenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsenha_KeyDown);
            // 
            // lblEmailLogin
            // 
            resources.ApplyResources(this.lblEmailLogin, "lblEmailLogin");
            this.lblEmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailLogin.ForeColor = System.Drawing.Color.Black;
            this.lblEmailLogin.Name = "lblEmailLogin";
            // 
            // lblSenhaLogin
            // 
            resources.ApplyResources(this.lblSenhaLogin, "lblSenhaLogin");
            this.lblSenhaLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaLogin.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            // 
            // lblerroemail
            // 
            resources.ApplyResources(this.lblerroemail, "lblerroemail");
            this.lblerroemail.BackColor = System.Drawing.Color.Transparent;
            this.lblerroemail.ForeColor = System.Drawing.Color.Red;
            this.lblerroemail.Name = "lblerroemail";
            // 
            // lblerrosenha
            // 
            resources.ApplyResources(this.lblerrosenha, "lblerrosenha");
            this.lblerrosenha.BackColor = System.Drawing.Color.Transparent;
            this.lblerrosenha.ForeColor = System.Drawing.Color.Red;
            this.lblerrosenha.Name = "lblerrosenha";
            // 
            // btnlogar
            // 
            this.btnlogar.BackColor = System.Drawing.Color.Cyan;
            resources.ApplyResources(this.btnlogar, "btnlogar");
            this.btnlogar.ForeColor = System.Drawing.Color.White;
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.UseVisualStyleBackColor = false;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // txtrespsec
            // 
            resources.ApplyResources(this.txtrespsec, "txtrespsec");
            this.txtrespsec.Name = "txtrespsec";
            this.toolTipHint.SetToolTip(this.txtrespsec, resources.GetString("txtrespsec.ToolTip"));
            this.txtrespsec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrespsec_KeyDown);
            // 
            // lblrespostasec
            // 
            resources.ApplyResources(this.lblrespostasec, "lblrespostasec");
            this.lblrespostasec.Name = "lblrespostasec";
            // 
            // cmbPerguntaSecreta
            // 
            resources.ApplyResources(this.cmbPerguntaSecreta, "cmbPerguntaSecreta");
            this.cmbPerguntaSecreta.ForeColor = System.Drawing.Color.Black;
            this.cmbPerguntaSecreta.FormattingEnabled = true;
            this.cmbPerguntaSecreta.Items.AddRange(new object[] {
            resources.GetString("cmbPerguntaSecreta.Items"),
            resources.GetString("cmbPerguntaSecreta.Items1"),
            resources.GetString("cmbPerguntaSecreta.Items2"),
            resources.GetString("cmbPerguntaSecreta.Items3"),
            resources.GetString("cmbPerguntaSecreta.Items4"),
            resources.GetString("cmbPerguntaSecreta.Items5")});
            this.cmbPerguntaSecreta.Name = "cmbPerguntaSecreta";
            this.toolTipHint.SetToolTip(this.cmbPerguntaSecreta, resources.GetString("cmbPerguntaSecreta.ToolTip"));
            this.cmbPerguntaSecreta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerguntaSecreta_KeyDown);
            // 
            // lblpergsec
            // 
            resources.ApplyResources(this.lblpergsec, "lblpergsec");
            this.lblpergsec.Name = "lblpergsec";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.Cyan;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            resources.ApplyResources(this.btnMin, "btnMin");
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Name = "btnMin";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctLogoNeon
            // 
            resources.ApplyResources(this.pctLogoNeon, "pctLogoNeon");
            this.pctLogoNeon.ErrorImage = global::NeonAnunciosDeEventos.Properties.Resources.semimagem;
            this.pctLogoNeon.Name = "pctLogoNeon";
            this.pctLogoNeon.TabStop = false;
            // 
            // lnkSenha
            // 
            resources.ApplyResources(this.lnkSenha, "lnkSenha");
            this.lnkSenha.LinkColor = System.Drawing.Color.Red;
            this.lnkSenha.Name = "lnkSenha";
            this.lnkSenha.TabStop = true;
            this.lnkSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSenha_LinkClicked);
            // 
            // frmTelaLogin
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lnkSenha);
            this.Controls.Add(this.pctLogoNeon);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblpergsec);
            this.Controls.Add(this.cmbPerguntaSecreta);
            this.Controls.Add(this.lblrespostasec);
            this.Controls.Add(this.txtrespsec);
            this.Controls.Add(this.btnlogar);
            this.Controls.Add(this.lblerrosenha);
            this.Controls.Add(this.lblerroemail);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblEmailLogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaLogin";
            this.Load += new System.EventHandler(this.frmTelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoNeon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblEmailLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Label lblerroemail;
        private System.Windows.Forms.Label lblerrosenha;
        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.TextBox txtrespsec;
        private System.Windows.Forms.Label lblrespostasec;
        private System.Windows.Forms.ComboBox cmbPerguntaSecreta;
        private System.Windows.Forms.Label lblpergsec;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.PictureBox pctLogoNeon;
        private System.Windows.Forms.LinkLabel lnkSenha;
        private System.Windows.Forms.ToolTip toolTipHint;
    }
}