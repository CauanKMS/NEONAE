namespace NeonAnunciosDeEventos
{
    partial class frmTelaSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaSplash));
            this.pgbtime = new System.Windows.Forms.ProgressBar();
            this.tmrTelaSplash = new System.Windows.Forms.Timer(this.components);
            this.ptbTelaSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelaSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbtime
            // 
            this.pgbtime.BackColor = System.Drawing.Color.Black;
            this.pgbtime.ForeColor = System.Drawing.Color.White;
            this.pgbtime.Location = new System.Drawing.Point(0, 311);
            this.pgbtime.Name = "pgbtime";
            this.pgbtime.Size = new System.Drawing.Size(431, 10);
            this.pgbtime.TabIndex = 1;
            // 
            // tmrTelaSplash
            // 
            this.tmrTelaSplash.Enabled = true;
            this.tmrTelaSplash.Tick += new System.EventHandler(this.tmrTelaSplash_Tick);
            // 
            // ptbTelaSplash
            // 
            this.ptbTelaSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbTelaSplash.ErrorImage = null;
            this.ptbTelaSplash.Image = ((System.Drawing.Image)(resources.GetObject("ptbTelaSplash.Image")));
            this.ptbTelaSplash.InitialImage = null;
            this.ptbTelaSplash.Location = new System.Drawing.Point(0, 0);
            this.ptbTelaSplash.Name = "ptbTelaSplash";
            this.ptbTelaSplash.Size = new System.Drawing.Size(436, 336);
            this.ptbTelaSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTelaSplash.TabIndex = 0;
            this.ptbTelaSplash.TabStop = false;
            // 
            // frmTelaSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(430, 321);
            this.ControlBox = false;
            this.Controls.Add(this.pgbtime);
            this.Controls.Add(this.ptbTelaSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmTelaSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelaSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTelaSplash;
        private System.Windows.Forms.ProgressBar pgbtime;
        private System.Windows.Forms.Timer tmrTelaSplash;

    }
}

