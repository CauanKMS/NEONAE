namespace NeonAnunciosDeEventos
{
    partial class frmTelaFuncMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaFuncMenu));
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnTelaSobre = new System.Windows.Forms.Button();
            this.btnTelaEventos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTelaPerfil = new System.Windows.Forms.Button();
            this.pctLogoNeon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoNeon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(459, -1);
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
            this.btnClose.Location = new System.Drawing.Point(497, -2);
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
            this.btnLogoff.BackgroundImage = global::NeonAnunciosDeEventos.Properties.Resources.Logout;
            this.btnLogoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.ForeColor = System.Drawing.Color.Cyan;
            this.btnLogoff.Location = new System.Drawing.Point(12, 410);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(54, 56);
            this.btnLogoff.TabIndex = 3;
            this.btnLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnTelaSobre
            // 
            this.btnTelaSobre.BackgroundImage = global::NeonAnunciosDeEventos.Properties.Resources.Desenvolvedores;
            this.btnTelaSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTelaSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaSobre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaSobre.Location = new System.Drawing.Point(223, 307);
            this.btnTelaSobre.Name = "btnTelaSobre";
            this.btnTelaSobre.Size = new System.Drawing.Size(141, 63);
            this.btnTelaSobre.TabIndex = 2;
            this.btnTelaSobre.UseVisualStyleBackColor = true;
            this.btnTelaSobre.Click += new System.EventHandler(this.btnTelaSobre_Click);
            // 
            // btnTelaEventos
            // 
            this.btnTelaEventos.BackColor = System.Drawing.Color.White;
            this.btnTelaEventos.BackgroundImage = global::NeonAnunciosDeEventos.Properties.Resources.Eventos;
            this.btnTelaEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTelaEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaEventos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaEventos.Location = new System.Drawing.Point(223, 231);
            this.btnTelaEventos.Name = "btnTelaEventos";
            this.btnTelaEventos.Size = new System.Drawing.Size(141, 58);
            this.btnTelaEventos.TabIndex = 1;
            this.btnTelaEventos.UseVisualStyleBackColor = false;
            this.btnTelaEventos.Click += new System.EventHandler(this.btnTelaEventos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 106;
            this.label2.Text = "Perfil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "Desenvolvedores";
            // 
            // btnTelaPerfil
            // 
            this.btnTelaPerfil.BackgroundImage = global::NeonAnunciosDeEventos.Properties.Resources.IMG_PERFIL_FUNC;
            this.btnTelaPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTelaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaPerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaPerfil.Location = new System.Drawing.Point(223, 155);
            this.btnTelaPerfil.Name = "btnTelaPerfil";
            this.btnTelaPerfil.Size = new System.Drawing.Size(141, 59);
            this.btnTelaPerfil.TabIndex = 0;
            this.btnTelaPerfil.UseVisualStyleBackColor = true;
            this.btnTelaPerfil.Click += new System.EventHandler(this.btnTelaPerfil_Click);
            // 
            // pctLogoNeon
            // 
            this.pctLogoNeon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogoNeon.BackgroundImage")));
            this.pctLogoNeon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogoNeon.ErrorImage = global::NeonAnunciosDeEventos.Properties.Resources.semimagem;
            this.pctLogoNeon.Location = new System.Drawing.Point(-1, -1);
            this.pctLogoNeon.Name = "pctLogoNeon";
            this.pctLogoNeon.Size = new System.Drawing.Size(172, 169);
            this.pctLogoNeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoNeon.TabIndex = 104;
            this.pctLogoNeon.TabStop = false;
            // 
            // frmTelaFuncMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnTelaSobre);
            this.Controls.Add(this.btnTelaPerfil);
            this.Controls.Add(this.btnTelaEventos);
            this.Controls.Add(this.pctLogoNeon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaFuncMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoNeon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnTelaSobre;
        private System.Windows.Forms.Button btnTelaPerfil;
        private System.Windows.Forms.Button btnTelaEventos;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctLogoNeon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

