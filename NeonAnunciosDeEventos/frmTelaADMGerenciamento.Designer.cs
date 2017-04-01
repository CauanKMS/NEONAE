namespace NeonAnunciosDeEventos
{
    partial class frmTelaADMGerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaADMGerenciamento));
            this.btnCadsFuncAdm = new System.Windows.Forms.Button();
            this.btnListaAdmFunc = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.pctLogoNeon = new System.Windows.Forms.PictureBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlistaEmpUsu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoNeon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadsFuncAdm
            // 
            this.btnCadsFuncAdm.BackColor = System.Drawing.Color.Cyan;
            this.btnCadsFuncAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadsFuncAdm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadsFuncAdm.ForeColor = System.Drawing.Color.White;
            this.btnCadsFuncAdm.Location = new System.Drawing.Point(150, 183);
            this.btnCadsFuncAdm.Name = "btnCadsFuncAdm";
            this.btnCadsFuncAdm.Size = new System.Drawing.Size(219, 48);
            this.btnCadsFuncAdm.TabIndex = 0;
            this.btnCadsFuncAdm.Text = "Cadastrar Colaboradores e Administradores";
            this.btnCadsFuncAdm.UseVisualStyleBackColor = false;
            this.btnCadsFuncAdm.Click += new System.EventHandler(this.btnCadsFuncAdm_Click);
            // 
            // btnListaAdmFunc
            // 
            this.btnListaAdmFunc.BackColor = System.Drawing.Color.Cyan;
            this.btnListaAdmFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAdmFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaAdmFunc.ForeColor = System.Drawing.Color.White;
            this.btnListaAdmFunc.Location = new System.Drawing.Point(150, 242);
            this.btnListaAdmFunc.Name = "btnListaAdmFunc";
            this.btnListaAdmFunc.Size = new System.Drawing.Size(219, 48);
            this.btnListaAdmFunc.TabIndex = 1;
            this.btnListaAdmFunc.Text = "Lista de Administradores\r\n e Colaboradores";
            this.btnListaAdmFunc.UseVisualStyleBackColor = false;
            this.btnListaAdmFunc.Click += new System.EventHandler(this.btnListaAdm_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(432, -1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(41, 30);
            this.btnMin.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(470, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.Color.White;
            this.btnLogoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoff.BackgroundImage")));
            this.btnLogoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.ForeColor = System.Drawing.Color.Cyan;
            this.btnLogoff.Location = new System.Drawing.Point(12, 451);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(54, 56);
            this.btnLogoff.TabIndex = 3;
            this.btnLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // pctLogoNeon
            // 
            this.pctLogoNeon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogoNeon.BackgroundImage")));
            this.pctLogoNeon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogoNeon.ErrorImage = global::NeonAnunciosDeEventos.Properties.Resources.semimagem;
            this.pctLogoNeon.Location = new System.Drawing.Point(-1, -1);
            this.pctLogoNeon.Name = "pctLogoNeon";
            this.pctLogoNeon.Size = new System.Drawing.Size(145, 143);
            this.pctLogoNeon.TabIndex = 105;
            this.pctLogoNeon.TabStop = false;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackgroundImage = global::NeonAnunciosDeEventos.Properties.Resources.VoltarTela;
            this.btnvoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(432, 475);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(71, 32);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlistaEmpUsu
            // 
            this.btnlistaEmpUsu.BackColor = System.Drawing.Color.Cyan;
            this.btnlistaEmpUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistaEmpUsu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistaEmpUsu.ForeColor = System.Drawing.Color.White;
            this.btnlistaEmpUsu.Location = new System.Drawing.Point(150, 306);
            this.btnlistaEmpUsu.Name = "btnlistaEmpUsu";
            this.btnlistaEmpUsu.Size = new System.Drawing.Size(219, 48);
            this.btnlistaEmpUsu.TabIndex = 106;
            this.btnlistaEmpUsu.Text = "Lista de Empresas\r\n e Usuários";
            this.btnlistaEmpUsu.UseVisualStyleBackColor = false;
            this.btnlistaEmpUsu.Click += new System.EventHandler(this.btnlistaEmpUsu_Click);
            // 
            // frmTelaADMGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 519);
            this.Controls.Add(this.btnlistaEmpUsu);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.pctLogoNeon);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnListaAdmFunc);
            this.Controls.Add(this.btnCadsFuncAdm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaADMGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Gerenciamento de Funcionários e Adms";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoNeon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadsFuncAdm;
        private System.Windows.Forms.Button btnListaAdmFunc;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctLogoNeon;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnlistaEmpUsu;
    }
}