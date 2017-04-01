namespace NeonAnunciosDeEventos
{
    partial class frmTelaTrocarSenhaPrimeiraEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaTrocarSenhaPrimeiraEntrada));
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblSenhaForte = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfNovaSenha = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblpergsec = new System.Windows.Forms.Label();
            this.cmbPerguntaSecreta = new System.Windows.Forms.ComboBox();
            this.lblrespostasec = new System.Windows.Forms.Label();
            this.txtrespsec = new System.Windows.Forms.TextBox();
            this.txtConfSenhaOld = new System.Windows.Forms.TextBox();
            this.lblConfSenhaOld = new System.Windows.Forms.Label();
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSenha.Location = new System.Drawing.Point(13, 103);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(156, 17);
            this.lblConfSenha.TabIndex = 0;
            this.lblConfSenha.Text = "Confirmar nova senha:";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.Location = new System.Drawing.Point(13, 62);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(89, 17);
            this.lblNovaSenha.TabIndex = 1;
            this.lblNovaSenha.Text = "Nova senha:";
            // 
            // lblSenhaForte
            // 
            this.lblSenhaForte.AutoSize = true;
            this.lblSenhaForte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaForte.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaForte.Location = new System.Drawing.Point(285, 64);
            this.lblSenhaForte.Name = "lblSenhaForte";
            this.lblSenhaForte.Size = new System.Drawing.Size(0, 16);
            this.lblSenhaForte.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(113, 59);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(166, 25);
            this.txtNovaSenha.TabIndex = 2;
            this.toolTipHint.SetToolTip(this.txtNovaSenha, "Exemplo de Senha Forte: A123b@");
            this.txtNovaSenha.TextChanged += new System.EventHandler(this.txtSenhaAtual_TextChanged);
            this.txtNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaSenha_KeyDown);
            // 
            // txtConfNovaSenha
            // 
            this.txtConfNovaSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfNovaSenha.Location = new System.Drawing.Point(183, 100);
            this.txtConfNovaSenha.Name = "txtConfNovaSenha";
            this.txtConfNovaSenha.PasswordChar = '*';
            this.txtConfNovaSenha.Size = new System.Drawing.Size(166, 25);
            this.txtConfNovaSenha.TabIndex = 3;
            this.toolTipHint.SetToolTip(this.txtConfNovaSenha, "Confirme Sua senha");
            this.txtConfNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfNovaSenha_KeyDown);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Cyan;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(488, 96);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(92, 32);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar Senha";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(524, -1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(41, 30);
            this.btnMin.TabIndex = 7;
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
            this.btnClose.Location = new System.Drawing.Point(560, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblpergsec
            // 
            this.lblpergsec.AutoSize = true;
            this.lblpergsec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpergsec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblpergsec.Location = new System.Drawing.Point(13, 139);
            this.lblpergsec.Name = "lblpergsec";
            this.lblpergsec.Size = new System.Drawing.Size(230, 17);
            this.lblpergsec.TabIndex = 107;
            this.lblpergsec.Text = "Selecione a sua pergunta secreta:";
            // 
            // cmbPerguntaSecreta
            // 
            this.cmbPerguntaSecreta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerguntaSecreta.ForeColor = System.Drawing.Color.Black;
            this.cmbPerguntaSecreta.FormattingEnabled = true;
            this.cmbPerguntaSecreta.Items.AddRange(new object[] {
            "",
            "Qual o nome do seu animal de estimação",
            "Qual o nome da sua cidade natal",
            "Qual o nome do(a) seu(sua) professor(a) do primário",
            "Qual o nome da sua primeira escola",
            "Qual o nome do(a) seu(sua) melhor amigo(a)"});
            this.cmbPerguntaSecreta.Location = new System.Drawing.Point(16, 168);
            this.cmbPerguntaSecreta.Name = "cmbPerguntaSecreta";
            this.cmbPerguntaSecreta.Size = new System.Drawing.Size(375, 25);
            this.cmbPerguntaSecreta.TabIndex = 4;
            this.toolTipHint.SetToolTip(this.cmbPerguntaSecreta, "Escolha uma pergunta secreta");
            this.cmbPerguntaSecreta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerguntaSecreta_KeyDown);
            // 
            // lblrespostasec
            // 
            this.lblrespostasec.AutoSize = true;
            this.lblrespostasec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespostasec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblrespostasec.Location = new System.Drawing.Point(13, 205);
            this.lblrespostasec.Name = "lblrespostasec";
            this.lblrespostasec.Size = new System.Drawing.Size(292, 17);
            this.lblrespostasec.TabIndex = 106;
            this.lblrespostasec.Text = "Responda a pergunta secreta por gentileza:";
            // 
            // txtrespsec
            // 
            this.txtrespsec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrespsec.Location = new System.Drawing.Point(311, 202);
            this.txtrespsec.Name = "txtrespsec";
            this.txtrespsec.PasswordChar = '*';
            this.txtrespsec.Size = new System.Drawing.Size(181, 25);
            this.txtrespsec.TabIndex = 5;
            this.toolTipHint.SetToolTip(this.txtrespsec, "Digite Sua Resposta Secreta");
            this.txtrespsec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrespsec_KeyDown);
            // 
            // txtConfSenhaOld
            // 
            this.txtConfSenhaOld.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenhaOld.Location = new System.Drawing.Point(193, 18);
            this.txtConfSenhaOld.Name = "txtConfSenhaOld";
            this.txtConfSenhaOld.PasswordChar = '*';
            this.txtConfSenhaOld.Size = new System.Drawing.Size(156, 25);
            this.txtConfSenhaOld.TabIndex = 1;
            this.toolTipHint.SetToolTip(this.txtConfSenhaOld, "Digite sua senha novamente");
            this.txtConfSenhaOld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfSenhaOld_KeyDown);
            // 
            // lblConfSenhaOld
            // 
            this.lblConfSenhaOld.AutoSize = true;
            this.lblConfSenhaOld.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSenhaOld.Location = new System.Drawing.Point(12, 22);
            this.lblConfSenhaOld.Name = "lblConfSenhaOld";
            this.lblConfSenhaOld.Size = new System.Drawing.Size(184, 17);
            this.lblConfSenhaOld.TabIndex = 108;
            this.lblConfSenhaOld.Text = "Confirmar sua senha atual:";
            // 
            // frmTelaTrocarSenhaPrimeiraEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 241);
            this.Controls.Add(this.txtConfSenhaOld);
            this.Controls.Add(this.lblConfSenhaOld);
            this.Controls.Add(this.lblpergsec);
            this.Controls.Add(this.cmbPerguntaSecreta);
            this.Controls.Add(this.lblrespostasec);
            this.Controls.Add(this.txtrespsec);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtConfNovaSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.lblSenhaForte);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.lblConfSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaTrocarSenhaPrimeiraEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Senha";
            this.Load += new System.EventHandler(this.frmTelaTrocarSenhaPrimeiraEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblSenhaForte;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtConfNovaSenha;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblpergsec;
        private System.Windows.Forms.ComboBox cmbPerguntaSecreta;
        private System.Windows.Forms.Label lblrespostasec;
        private System.Windows.Forms.TextBox txtrespsec;
        private System.Windows.Forms.TextBox txtConfSenhaOld;
        private System.Windows.Forms.Label lblConfSenhaOld;
        private System.Windows.Forms.ToolTip toolTipHint;
    }
}