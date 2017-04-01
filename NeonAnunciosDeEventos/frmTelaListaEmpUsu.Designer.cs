namespace NeonAnunciosDeEventos
{
    partial class frmTelaListaEmpUsu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaListaEmpUsu));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdbListaUsu = new System.Windows.Forms.RadioButton();
            this.rdbListaEmp = new System.Windows.Forms.RadioButton();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.gvExibirEmpUsu = new System.Windows.Forms.DataGridView();
            this.lblemailadm = new System.Windows.Forms.Label();
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirEmpUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(363, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(272, 15);
            this.lblMensagem.TabIndex = 285;
            this.lblMensagem.Text = "Click 2 vezes no email pra ir para a tela auditoria";
            this.lblMensagem.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(669, -1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(41, 30);
            this.btnMin.TabIndex = 281;
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
            this.btnClose.Location = new System.Drawing.Point(707, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 30);
            this.btnClose.TabIndex = 282;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdbListaUsu
            // 
            this.rdbListaUsu.AutoSize = true;
            this.rdbListaUsu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbListaUsu.Location = new System.Drawing.Point(258, 12);
            this.rdbListaUsu.Name = "rdbListaUsu";
            this.rdbListaUsu.Size = new System.Drawing.Size(76, 19);
            this.rdbListaUsu.TabIndex = 280;
            this.rdbListaUsu.TabStop = true;
            this.rdbListaUsu.Text = "Usuários";
            this.toolTipHint.SetToolTip(this.rdbListaUsu, "Abre a lista dos usuários");
            this.rdbListaUsu.UseVisualStyleBackColor = true;
            this.rdbListaUsu.CheckedChanged += new System.EventHandler(this.rdbListaUsu_CheckedChanged);
            // 
            // rdbListaEmp
            // 
            this.rdbListaEmp.AutoSize = true;
            this.rdbListaEmp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbListaEmp.Location = new System.Drawing.Point(169, 11);
            this.rdbListaEmp.Name = "rdbListaEmp";
            this.rdbListaEmp.Size = new System.Drawing.Size(83, 19);
            this.rdbListaEmp.TabIndex = 279;
            this.rdbListaEmp.TabStop = true;
            this.rdbListaEmp.Text = "Empresas";
            this.toolTipHint.SetToolTip(this.rdbListaEmp, "Abre a lista das empresas");
            this.rdbListaEmp.UseVisualStyleBackColor = true;
            this.rdbListaEmp.CheckedChanged += new System.EventHandler(this.rdbListaEmp_CheckedChanged);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackgroundImage = global::NeonAnunciosDeEventos.Properties.Resources.VoltarTela;
            this.btnvoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(12, 5);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(71, 32);
            this.btnvoltar.TabIndex = 278;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // gvExibirEmpUsu
            // 
            this.gvExibirEmpUsu.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvExibirEmpUsu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirEmpUsu.BackgroundColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirEmpUsu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvExibirEmpUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirEmpUsu.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirEmpUsu.GridColor = System.Drawing.Color.Black;
            this.gvExibirEmpUsu.Location = new System.Drawing.Point(12, 43);
            this.gvExibirEmpUsu.Name = "gvExibirEmpUsu";
            this.gvExibirEmpUsu.Size = new System.Drawing.Size(725, 464);
            this.gvExibirEmpUsu.TabIndex = 284;
            this.gvExibirEmpUsu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirFunc_CellContentClick);
            // 
            // lblemailadm
            // 
            this.lblemailadm.AutoSize = true;
            this.lblemailadm.BackColor = System.Drawing.Color.Transparent;
            this.lblemailadm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailadm.ForeColor = System.Drawing.Color.Black;
            this.lblemailadm.Location = new System.Drawing.Point(112, 13);
            this.lblemailadm.Name = "lblemailadm";
            this.lblemailadm.Size = new System.Drawing.Size(58, 15);
            this.lblemailadm.TabIndex = 283;
            this.lblemailadm.Text = "Escolha :";
            // 
            // frmTelaListaEmpUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 519);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rdbListaUsu);
            this.Controls.Add(this.rdbListaEmp);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.gvExibirEmpUsu);
            this.Controls.Add(this.lblemailadm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaListaEmpUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaListaEmpUsu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaListaEmpUsu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirEmpUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdbListaUsu;
        private System.Windows.Forms.RadioButton rdbListaEmp;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.DataGridView gvExibirEmpUsu;
        private System.Windows.Forms.Label lblemailadm;
        private System.Windows.Forms.ToolTip toolTipHint;
    }
}