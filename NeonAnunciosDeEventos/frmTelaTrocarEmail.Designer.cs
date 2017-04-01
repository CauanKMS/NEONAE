namespace NeonAnunciosDeEventos
{
    partial class frmTelaTrocarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaTrocarEmail));
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTrocarEmail = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtNovoEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfNovoEmail = new System.Windows.Forms.TextBox();
            this.lblConfNovoEmail = new System.Windows.Forms.Label();
            this.toolTipHint = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(513, -1);
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
            this.btnClose.Location = new System.Drawing.Point(557, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTrocarEmail
            // 
            this.btnTrocarEmail.BackColor = System.Drawing.Color.Cyan;
            this.btnTrocarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarEmail.ForeColor = System.Drawing.Color.White;
            this.btnTrocarEmail.Location = new System.Drawing.Point(480, 65);
            this.btnTrocarEmail.Name = "btnTrocarEmail";
            this.btnTrocarEmail.Size = new System.Drawing.Size(113, 25);
            this.btnTrocarEmail.TabIndex = 3;
            this.btnTrocarEmail.Text = "Trocar Email";
            this.btnTrocarEmail.UseVisualStyleBackColor = false;
            this.btnTrocarEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(171, 24);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(307, 21);
            this.txtemail.TabIndex = 0;
            this.toolTipHint.SetToolTip(this.txtemail, "Digite seu Email Atual");
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.Location = new System.Drawing.Point(19, 27);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(149, 15);
            this.lblemail.TabIndex = 227;
            this.lblemail.Text = "Confirme seu Email Atual:";
            // 
            // txtNovoEmail
            // 
            this.txtNovoEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoEmail.Location = new System.Drawing.Point(98, 67);
            this.txtNovoEmail.Name = "txtNovoEmail";
            this.txtNovoEmail.Size = new System.Drawing.Size(307, 21);
            this.txtNovoEmail.TabIndex = 1;
            this.toolTipHint.SetToolTip(this.txtNovoEmail, "Digite um email válido para que seja enviado uma nova senha");
            this.txtNovoEmail.Leave += new System.EventHandler(this.txtNovoEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 229;
            this.label1.Text = "Novo Email:";
            // 
            // txtConfNovoEmail
            // 
            this.txtConfNovoEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfNovoEmail.Location = new System.Drawing.Point(171, 109);
            this.txtConfNovoEmail.Name = "txtConfNovoEmail";
            this.txtConfNovoEmail.Size = new System.Drawing.Size(307, 21);
            this.txtConfNovoEmail.TabIndex = 2;
            this.toolTipHint.SetToolTip(this.txtConfNovoEmail, "Confirme seu novo Email");
            // 
            // lblConfNovoEmail
            // 
            this.lblConfNovoEmail.AutoSize = true;
            this.lblConfNovoEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblConfNovoEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfNovoEmail.ForeColor = System.Drawing.Color.Black;
            this.lblConfNovoEmail.Location = new System.Drawing.Point(19, 112);
            this.lblConfNovoEmail.Name = "lblConfNovoEmail";
            this.lblConfNovoEmail.Size = new System.Drawing.Size(149, 15);
            this.lblConfNovoEmail.TabIndex = 231;
            this.lblConfNovoEmail.Text = "Confirme seu novo Email:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 143);
            this.panel1.TabIndex = 232;
            // 
            // frmTelaTrocarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 147);
            this.Controls.Add(this.txtConfNovoEmail);
            this.Controls.Add(this.lblConfNovoEmail);
            this.Controls.Add(this.txtNovoEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnTrocarEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaTrocarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaTrocarEmail";
            this.Load += new System.EventHandler(this.frmTelaTrocarEmail_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTrocarEmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtNovoEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfNovoEmail;
        private System.Windows.Forms.Label lblConfNovoEmail;
        private System.Windows.Forms.ToolTip toolTipHint;
        private System.Windows.Forms.Panel panel1;
    }
}