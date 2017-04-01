namespace NeonAnunciosDeEventos
{
    partial class frmTelaEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaEvento));
            this.btnEventonaoproprio = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.txtnomeEven = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.gveventos = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gveventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventonaoproprio
            // 
            this.btnEventonaoproprio.BackColor = System.Drawing.Color.Cyan;
            this.btnEventonaoproprio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventonaoproprio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventonaoproprio.ForeColor = System.Drawing.Color.White;
            this.btnEventonaoproprio.Location = new System.Drawing.Point(163, 50);
            this.btnEventonaoproprio.Name = "btnEventonaoproprio";
            this.btnEventonaoproprio.Size = new System.Drawing.Size(130, 31);
            this.btnEventonaoproprio.TabIndex = 2;
            this.btnEventonaoproprio.Text = "Excluir";
            this.btnEventonaoproprio.UseVisualStyleBackColor = false;
            this.btnEventonaoproprio.Click += new System.EventHandler(this.btnEventonaoproprio_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.BackColor = System.Drawing.Color.Cyan;
            this.btnLiberar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberar.ForeColor = System.Drawing.Color.White;
            this.btnLiberar.Location = new System.Drawing.Point(12, 50);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(130, 31);
            this.btnLiberar.TabIndex = 1;
            this.btnLiberar.Text = "Autorizar";
            this.btnLiberar.UseVisualStyleBackColor = false;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // txtnomeEven
            // 
            this.txtnomeEven.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeEven.Location = new System.Drawing.Point(323, 9);
            this.txtnomeEven.Name = "txtnomeEven";
            this.txtnomeEven.Size = new System.Drawing.Size(315, 25);
            this.txtnomeEven.TabIndex = 0;
            this.toolTipHint.SetToolTip(this.txtnomeEven, "Clicar Vezes no txt apaga o nome");
            this.txtnomeEven.TextChanged += new System.EventHandler(this.txtnomeEven_TextChanged);
            this.txtnomeEven.DoubleClick += new System.EventHandler(this.txtnomeEven_DoubleClick);
            this.txtnomeEven.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomeEven_KeyDown);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.ForeColor = System.Drawing.Color.Black;
            this.lblBusca.Location = new System.Drawing.Point(8, 12);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(309, 17);
            this.lblBusca.TabIndex = 13;
            this.lblBusca.Text = "Digite o nome do evento que deseja autorizar :";
            // 
            // gveventos
            // 
            this.gveventos.BackgroundColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gveventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gveventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gveventos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gveventos.Location = new System.Drawing.Point(6, 87);
            this.gveventos.Name = "gveventos";
            this.gveventos.Size = new System.Drawing.Size(756, 412);
            this.gveventos.TabIndex = 12;
            this.gveventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gveventos_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(683, 505);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(69, 35);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(686, -1);
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
            this.btnClose.Location = new System.Drawing.Point(724, -2);
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
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(302, 58);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(425, 16);
            this.lblMensagem.TabIndex = 158;
            this.lblMensagem.Text = "Clique 2 vezes no nome do evento para ver mais informaçoes do mesmo";
            // 
            // frmTelaADMEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 544);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEventonaoproprio);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.txtnomeEven);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.gveventos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaADMEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaADMEvento";
            this.Load += new System.EventHandler(this.frmTelaADMEvento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaADMEvento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gveventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventonaoproprio;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.TextBox txtnomeEven;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.DataGridView gveventos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTipHint;
        private System.Windows.Forms.Label lblMensagem;
    }
}