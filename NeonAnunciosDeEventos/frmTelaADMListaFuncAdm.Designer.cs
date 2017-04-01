namespace NeonAnunciosDeEventos
{
    partial class frmTelaADMListaFuncAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaADMListaFuncAdm));
            this.gvExibirFuncAdm = new System.Windows.Forms.DataGridView();
            this.lblemailadm = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.rdbListaAdm = new System.Windows.Forms.RadioButton();
            this.rdbListaFunc = new System.Windows.Forms.RadioButton();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirFuncAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // gvExibirFuncAdm
            // 
            this.gvExibirFuncAdm.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvExibirFuncAdm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirFuncAdm.BackgroundColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirFuncAdm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvExibirFuncAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirFuncAdm.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirFuncAdm.GridColor = System.Drawing.Color.Black;
            this.gvExibirFuncAdm.Location = new System.Drawing.Point(12, 39);
            this.gvExibirFuncAdm.Name = "gvExibirFuncAdm";
            this.gvExibirFuncAdm.Size = new System.Drawing.Size(725, 469);
            this.gvExibirFuncAdm.TabIndex = 8;
            this.gvExibirFuncAdm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirFunc_CellContentClick);
            // 
            // lblemailadm
            // 
            this.lblemailadm.AutoSize = true;
            this.lblemailadm.BackColor = System.Drawing.Color.Transparent;
            this.lblemailadm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailadm.ForeColor = System.Drawing.Color.Black;
            this.lblemailadm.Location = new System.Drawing.Point(89, 13);
            this.lblemailadm.Name = "lblemailadm";
            this.lblemailadm.Size = new System.Drawing.Size(58, 15);
            this.lblemailadm.TabIndex = 6;
            this.lblemailadm.Text = "Escolha :";
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
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // rdbListaAdm
            // 
            this.rdbListaAdm.AutoSize = true;
            this.rdbListaAdm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbListaAdm.Location = new System.Drawing.Point(146, 11);
            this.rdbListaAdm.Name = "rdbListaAdm";
            this.rdbListaAdm.Size = new System.Drawing.Size(116, 19);
            this.rdbListaAdm.TabIndex = 1;
            this.rdbListaAdm.TabStop = true;
            this.rdbListaAdm.Text = "Administradores";
            this.toolTipHint.SetToolTip(this.rdbListaAdm, "Abre a lista de Administradores");
            this.rdbListaAdm.UseVisualStyleBackColor = true;
            this.rdbListaAdm.CheckedChanged += new System.EventHandler(this.rdbListaAdm_CheckedChanged);
            // 
            // rdbListaFunc
            // 
            this.rdbListaFunc.AutoSize = true;
            this.rdbListaFunc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbListaFunc.Location = new System.Drawing.Point(272, 11);
            this.rdbListaFunc.Name = "rdbListaFunc";
            this.rdbListaFunc.Size = new System.Drawing.Size(108, 19);
            this.rdbListaFunc.TabIndex = 2;
            this.rdbListaFunc.TabStop = true;
            this.rdbListaFunc.Text = "Colaboradores";
            this.toolTipHint.SetToolTip(this.rdbListaFunc, "Abre a lista de Colaboradores");
            this.rdbListaFunc.UseVisualStyleBackColor = true;
            this.rdbListaFunc.CheckedChanged += new System.EventHandler(this.rdbListaFunc_CheckedChanged);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(671, -1);
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
            this.btnClose.Location = new System.Drawing.Point(709, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(386, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(272, 15);
            this.lblMensagem.TabIndex = 277;
            this.lblMensagem.Text = "Click 2 vezes no email pra ir para a tela auditoria";
            this.lblMensagem.Visible = false;
            // 
            // frmTelaADMListaFuncAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 519);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rdbListaFunc);
            this.Controls.Add(this.rdbListaAdm);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.gvExibirFuncAdm);
            this.Controls.Add(this.lblemailadm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaADMListaFuncAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tela de Exibição de Administradores";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaADMListaADM_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirFuncAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvExibirFuncAdm;
        private System.Windows.Forms.Label lblemailadm;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.RadioButton rdbListaAdm;
        private System.Windows.Forms.RadioButton rdbListaFunc;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ToolTip toolTipHint;
    }
}