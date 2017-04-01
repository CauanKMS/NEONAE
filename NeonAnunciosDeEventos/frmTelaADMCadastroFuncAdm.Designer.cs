namespace NeonAnunciosDeEventos
{
    partial class frmTelaADMCadastroFuncAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaADMCadastroFuncAdm));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblimgperfil = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblsx = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbldtnasc = new System.Windows.Forms.Label();
            this.mskdtnasc = new System.Windows.Forms.MaskedTextBox();
            this.cmbsx = new System.Windows.Forms.ComboBox();
            this.pctbperfil = new System.Windows.Forms.PictureBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.grptipo = new System.Windows.Forms.GroupBox();
            this.rdbadm = new System.Windows.Forms.RadioButton();
            this.rdbfunc = new System.Windows.Forms.RadioButton();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnbuscaimg = new System.Windows.Forms.Button();
            this.mskrg = new System.Windows.Forms.MaskedTextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.ofdimg = new System.Windows.Forms.OpenFileDialog();
            this.lblerro9 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoLogradouro = new System.Windows.Forms.ComboBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblerro5 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lnkCep = new System.Windows.Forms.LinkLabel();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblerro2 = new System.Windows.Forms.Label();
            this.lblerro4 = new System.Windows.Forms.Label();
            this.lblerro3 = new System.Windows.Forms.Label();
            this.lblerro1 = new System.Windows.Forms.Label();
            this.lblerro10 = new System.Windows.Forms.Label();
            this.lblerro6 = new System.Windows.Forms.Label();
            this.lblerro7 = new System.Windows.Forms.Label();
            this.lblerro8 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblForca = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tooTipHint = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctbperfil)).BeginInit();
            this.grptipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(74, 163);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(285, 22);
            this.txtemail.TabIndex = 5;
            this.tooTipHint.SetToolTip(this.txtemail, "Digite o Email Da pessoa a ser cadastrada");
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.Location = new System.Drawing.Point(28, 167);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(39, 15);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "Email";
            // 
            // lblimgperfil
            // 
            this.lblimgperfil.AutoSize = true;
            this.lblimgperfil.BackColor = System.Drawing.Color.Transparent;
            this.lblimgperfil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimgperfil.ForeColor = System.Drawing.Color.Black;
            this.lblimgperfil.Location = new System.Drawing.Point(564, 14);
            this.lblimgperfil.Name = "lblimgperfil";
            this.lblimgperfil.Size = new System.Drawing.Size(101, 15);
            this.lblimgperfil.TabIndex = 5;
            this.lblimgperfil.Text = "Imagem de Perfil";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.BackColor = System.Drawing.Color.Transparent;
            this.lbltel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.ForeColor = System.Drawing.Color.Black;
            this.lbltel.Location = new System.Drawing.Point(30, 216);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(54, 15);
            this.lbltel.TabIndex = 13;
            this.lbltel.Text = "Telefone";
            // 
            // lblsx
            // 
            this.lblsx.AutoSize = true;
            this.lblsx.BackColor = System.Drawing.Color.Transparent;
            this.lblsx.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsx.ForeColor = System.Drawing.Color.Black;
            this.lblsx.Location = new System.Drawing.Point(30, 267);
            this.lblsx.Name = "lblsx";
            this.lblsx.Size = new System.Drawing.Size(34, 15);
            this.lblsx.TabIndex = 3;
            this.lblsx.Text = "Sexo";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.Black;
            this.lblnome.Location = new System.Drawing.Point(30, 79);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(41, 15);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.Black;
            this.txtnome.Location = new System.Drawing.Point(71, 76);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(285, 22);
            this.txtnome.TabIndex = 3;
            this.tooTipHint.SetToolTip(this.txtnome, "Digite o nome completo");
            this.txtnome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnome_KeyDown);
            // 
            // lbldtnasc
            // 
            this.lbldtnasc.AutoSize = true;
            this.lbldtnasc.BackColor = System.Drawing.Color.Transparent;
            this.lbldtnasc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtnasc.ForeColor = System.Drawing.Color.Black;
            this.lbldtnasc.Location = new System.Drawing.Point(30, 124);
            this.lbldtnasc.Name = "lbldtnasc";
            this.lbldtnasc.Size = new System.Drawing.Size(120, 15);
            this.lbldtnasc.TabIndex = 21;
            this.lbldtnasc.Text = "Data de Nascimento";
            // 
            // mskdtnasc
            // 
            this.mskdtnasc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtnasc.ForeColor = System.Drawing.Color.Black;
            this.mskdtnasc.Location = new System.Drawing.Point(156, 122);
            this.mskdtnasc.Mask = "00/00/0000";
            this.mskdtnasc.Name = "mskdtnasc";
            this.mskdtnasc.Size = new System.Drawing.Size(78, 21);
            this.mskdtnasc.TabIndex = 4;
            this.tooTipHint.SetToolTip(this.mskdtnasc, "Digite a Data de nascimento");
            this.mskdtnasc.ValidatingType = typeof(System.DateTime);
            this.mskdtnasc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskdtnasc_KeyDown);
            this.mskdtnasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskdtnasc_KeyPress);
            this.mskdtnasc.Leave += new System.EventHandler(this.mskdtnasc_Leave);
            // 
            // cmbsx
            // 
            this.cmbsx.ForeColor = System.Drawing.Color.Black;
            this.cmbsx.FormattingEnabled = true;
            this.cmbsx.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cmbsx.Location = new System.Drawing.Point(74, 261);
            this.cmbsx.Name = "cmbsx";
            this.cmbsx.Size = new System.Drawing.Size(121, 21);
            this.cmbsx.TabIndex = 8;
            this.tooTipHint.SetToolTip(this.cmbsx, "Escolha o Sexo correspondente a pessoa");
            this.cmbsx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbsx_KeyDown);
            // 
            // pctbperfil
            // 
            this.pctbperfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctbperfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctbperfil.Location = new System.Drawing.Point(497, 39);
            this.pctbperfil.Name = "pctbperfil";
            this.pctbperfil.Size = new System.Drawing.Size(204, 185);
            this.pctbperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbperfil.TabIndex = 24;
            this.pctbperfil.TabStop = false;
            this.pctbperfil.SizeModeChanged += new System.EventHandler(this.btnbuscaimg_Click);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.BackColor = System.Drawing.Color.Transparent;
            this.lblcpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.Color.Black;
            this.lblcpf.Location = new System.Drawing.Point(239, 263);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(31, 15);
            this.lblcpf.TabIndex = 26;
            this.lblcpf.Text = "CPF";
            // 
            // mskcpf
            // 
            this.mskcpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskcpf.ForeColor = System.Drawing.Color.Black;
            this.mskcpf.Location = new System.Drawing.Point(280, 260);
            this.mskcpf.Mask = "000,000,000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(102, 21);
            this.mskcpf.TabIndex = 9;
            this.tooTipHint.SetToolTip(this.mskcpf, "Digite o CPF");
            this.mskcpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskcpf_KeyDown);
            this.mskcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskcpf_KeyPress);
            this.mskcpf.Leave += new System.EventHandler(this.mskcpf_Leave);
            // 
            // grptipo
            // 
            this.grptipo.BackColor = System.Drawing.Color.Transparent;
            this.grptipo.Controls.Add(this.rdbadm);
            this.grptipo.Controls.Add(this.rdbfunc);
            this.grptipo.Controls.Add(this.lblErro);
            this.grptipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptipo.ForeColor = System.Drawing.Color.Black;
            this.grptipo.Location = new System.Drawing.Point(12, 5);
            this.grptipo.Name = "grptipo";
            this.grptipo.Size = new System.Drawing.Size(387, 50);
            this.grptipo.TabIndex = 32;
            this.grptipo.TabStop = false;
            this.grptipo.Text = "Escolha o tipo de usuário";
            // 
            // rdbadm
            // 
            this.rdbadm.AutoSize = true;
            this.rdbadm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbadm.Location = new System.Drawing.Point(200, 19);
            this.rdbadm.Name = "rdbadm";
            this.rdbadm.Size = new System.Drawing.Size(102, 19);
            this.rdbadm.TabIndex = 1;
            this.rdbadm.Text = "Administrador";
            this.tooTipHint.SetToolTip(this.rdbadm, "Cadastrar Um ADM");
            this.rdbadm.UseVisualStyleBackColor = true;
            // 
            // rdbfunc
            // 
            this.rdbfunc.AutoSize = true;
            this.rdbfunc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfunc.Location = new System.Drawing.Point(49, 19);
            this.rdbfunc.Name = "rdbfunc";
            this.rdbfunc.Size = new System.Drawing.Size(108, 19);
            this.rdbfunc.TabIndex = 0;
            this.rdbfunc.Text = "Colaboradores";
            this.tooTipHint.SetToolTip(this.rdbfunc, "Cadastrar um Colaborador");
            this.rdbfunc.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(15, 19);
            this.lblErro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(16, 19);
            this.lblErro.TabIndex = 83;
            this.lblErro.Text = "*";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Cyan;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(202, 503);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 30);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnbuscaimg
            // 
            this.btnbuscaimg.BackColor = System.Drawing.Color.Cyan;
            this.btnbuscaimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscaimg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscaimg.ForeColor = System.Drawing.Color.White;
            this.btnbuscaimg.Location = new System.Drawing.Point(546, 230);
            this.btnbuscaimg.Name = "btnbuscaimg";
            this.btnbuscaimg.Size = new System.Drawing.Size(97, 29);
            this.btnbuscaimg.TabIndex = 13;
            this.btnbuscaimg.Text = "Buscar Imagem";
            this.btnbuscaimg.UseVisualStyleBackColor = false;
            this.btnbuscaimg.Click += new System.EventHandler(this.btnbuscaimg_Click);
            // 
            // mskrg
            // 
            this.mskrg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskrg.ForeColor = System.Drawing.Color.Black;
            this.mskrg.Location = new System.Drawing.Point(280, 210);
            this.mskrg.Mask = "00,000,000-0";
            this.mskrg.Name = "mskrg";
            this.mskrg.Size = new System.Drawing.Size(102, 21);
            this.mskrg.TabIndex = 7;
            this.tooTipHint.SetToolTip(this.mskrg, "Digite o RG");
            this.mskrg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskrg_KeyDown);
            this.mskrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskrg_KeyPress);
            this.mskrg.Leave += new System.EventHandler(this.mskrg_Leave);
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.BackColor = System.Drawing.Color.Transparent;
            this.lblrg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.ForeColor = System.Drawing.Color.Black;
            this.lblrg.Location = new System.Drawing.Point(239, 213);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(25, 15);
            this.lblrg.TabIndex = 37;
            this.lblrg.Text = "RG";
            // 
            // msktel
            // 
            this.msktel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktel.ForeColor = System.Drawing.Color.Black;
            this.msktel.Location = new System.Drawing.Point(92, 213);
            this.msktel.Mask = "(99) 00000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(106, 21);
            this.msktel.TabIndex = 6;
            this.tooTipHint.SetToolTip(this.msktel, "Digite o telefone");
            this.msktel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktel_KeyDown);
            this.msktel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msktel_KeyPress);
            // 
            // ofdimg
            // 
            this.ofdimg.FileName = "openFileDialog1";
            // 
            // lblerro9
            // 
            this.lblerro9.AutoSize = true;
            this.lblerro9.BackColor = System.Drawing.Color.Transparent;
            this.lblerro9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro9.ForeColor = System.Drawing.Color.Red;
            this.lblerro9.Location = new System.Drawing.Point(12, 348);
            this.lblerro9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro9.Name = "lblerro9";
            this.lblerro9.Size = new System.Drawing.Size(16, 19);
            this.lblerro9.TabIndex = 70;
            this.lblerro9.Text = "*";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(13, 406);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 16);
            this.lblTipo.TabIndex = 69;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipoLogradouro
            // 
            this.cmbTipoLogradouro.Enabled = false;
            this.cmbTipoLogradouro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoLogradouro.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoLogradouro.FormattingEnabled = true;
            this.cmbTipoLogradouro.Location = new System.Drawing.Point(68, 404);
            this.cmbTipoLogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoLogradouro.Name = "cmbTipoLogradouro";
            this.cmbTipoLogradouro.Size = new System.Drawing.Size(115, 23);
            this.cmbTipoLogradouro.TabIndex = 56;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.BackColor = System.Drawing.Color.Transparent;
            this.lblRua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.Black;
            this.lblRua.Location = new System.Drawing.Point(193, 407);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(35, 16);
            this.lblRua.TabIndex = 63;
            this.lblRua.Text = "Rua:";
            // 
            // lblerro5
            // 
            this.lblerro5.AutoSize = true;
            this.lblerro5.BackColor = System.Drawing.Color.Transparent;
            this.lblerro5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro5.ForeColor = System.Drawing.Color.Red;
            this.lblerro5.Location = new System.Drawing.Point(218, 210);
            this.lblerro5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro5.Name = "lblerro5";
            this.lblerro5.Size = new System.Drawing.Size(16, 19);
            this.lblerro5.TabIndex = 74;
            this.lblerro5.Text = "*";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Black;
            this.lblNum.Location = new System.Drawing.Point(28, 351);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 15);
            this.lblNum.TabIndex = 64;
            this.lblNum.Text = "Número:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblComplemento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.Black;
            this.lblComplemento.Location = new System.Drawing.Point(202, 352);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(89, 15);
            this.lblComplemento.TabIndex = 65;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lnkCep
            // 
            this.lnkCep.AutoSize = true;
            this.lnkCep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCep.ForeColor = System.Drawing.Color.Black;
            this.lnkCep.LinkColor = System.Drawing.Color.Red;
            this.lnkCep.Location = new System.Drawing.Point(206, 306);
            this.lnkCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkCep.Name = "lnkCep";
            this.lnkCep.Size = new System.Drawing.Size(176, 15);
            this.lnkCep.TabIndex = 73;
            this.lnkCep.TabStop = true;
            this.lnkCep.Text = "Não sei meu CEP / Zona Rural";
            this.lnkCep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCep_LinkClicked);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(13, 431);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 66;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.BackColor = System.Drawing.Color.Transparent;
            this.lblCid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.ForeColor = System.Drawing.Color.Black;
            this.lblCid.Location = new System.Drawing.Point(13, 453);
            this.lblCid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(52, 16);
            this.lblCid.TabIndex = 67;
            this.lblCid.Text = "Cidade:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.Transparent;
            this.lblUF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.ForeColor = System.Drawing.Color.Black;
            this.lblUF.Location = new System.Drawing.Point(482, 442);
            this.lblUF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(53, 16);
            this.lblUF.TabIndex = 68;
            this.lblUF.Text = "Estado:";
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.ForeColor = System.Drawing.Color.Black;
            this.mskCep.Location = new System.Drawing.Point(86, 303);
            this.mskCep.Margin = new System.Windows.Forms.Padding(2);
            this.mskCep.Mask = "00,000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(97, 21);
            this.mskCep.TabIndex = 10;
            this.tooTipHint.SetToolTip(this.mskCep, "Digite o CEP");
            this.mskCep.TextChanged += new System.EventHandler(this.mskCep_TextChanged);
            this.mskCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCep_KeyDown);
            this.mskCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCep_KeyPress);
            // 
            // txtRua
            // 
            this.txtRua.Enabled = false;
            this.txtRua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Black;
            this.txtRua.Location = new System.Drawing.Point(231, 404);
            this.txtRua.Margin = new System.Windows.Forms.Padding(2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(495, 21);
            this.txtRua.TabIndex = 57;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.Black;
            this.txtNum.Location = new System.Drawing.Point(86, 349);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(81, 21);
            this.txtNum.TabIndex = 11;
            this.tooTipHint.SetToolTip(this.txtNum, "Digite o número da casa dessa pessoa");
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.Black;
            this.lblCep.Location = new System.Drawing.Point(28, 309);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 15);
            this.lblCep.TabIndex = 71;
            this.lblCep.Text = "CEP:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(291, 349);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(293, 22);
            this.txtComplemento.TabIndex = 12;
            this.tooTipHint.SetToolTip(this.txtComplemento, "Caso seja necessário um complemento digite-o");
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComplemento_KeyDown);
            // 
            // cmbUF
            // 
            this.cmbUF.Enabled = false;
            this.cmbUF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUF.ForeColor = System.Drawing.Color.Black;
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUF.Location = new System.Drawing.Point(539, 439);
            this.cmbUF.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(90, 23);
            this.cmbUF.TabIndex = 62;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(68, 429);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(403, 21);
            this.txtBairro.TabIndex = 60;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(68, 453);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(403, 21);
            this.txtCidade.TabIndex = 61;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.White;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(27, 509);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(147, 16);
            this.lblMensagem.TabIndex = 75;
            this.lblMensagem.Text = "(*) Campos Obrigatórios";
            // 
            // lblerro2
            // 
            this.lblerro2.AutoSize = true;
            this.lblerro2.BackColor = System.Drawing.Color.Transparent;
            this.lblerro2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro2.ForeColor = System.Drawing.Color.Red;
            this.lblerro2.Location = new System.Drawing.Point(12, 121);
            this.lblerro2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro2.Name = "lblerro2";
            this.lblerro2.Size = new System.Drawing.Size(16, 19);
            this.lblerro2.TabIndex = 76;
            this.lblerro2.Text = "*";
            // 
            // lblerro4
            // 
            this.lblerro4.AutoSize = true;
            this.lblerro4.BackColor = System.Drawing.Color.Transparent;
            this.lblerro4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro4.ForeColor = System.Drawing.Color.Red;
            this.lblerro4.Location = new System.Drawing.Point(9, 213);
            this.lblerro4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro4.Name = "lblerro4";
            this.lblerro4.Size = new System.Drawing.Size(16, 19);
            this.lblerro4.TabIndex = 78;
            this.lblerro4.Text = "*";
            // 
            // lblerro3
            // 
            this.lblerro3.AutoSize = true;
            this.lblerro3.BackColor = System.Drawing.Color.Transparent;
            this.lblerro3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro3.ForeColor = System.Drawing.Color.Red;
            this.lblerro3.Location = new System.Drawing.Point(12, 165);
            this.lblerro3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro3.Name = "lblerro3";
            this.lblerro3.Size = new System.Drawing.Size(16, 19);
            this.lblerro3.TabIndex = 85;
            this.lblerro3.Text = "*";
            // 
            // lblerro1
            // 
            this.lblerro1.AutoSize = true;
            this.lblerro1.BackColor = System.Drawing.Color.Transparent;
            this.lblerro1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro1.ForeColor = System.Drawing.Color.Red;
            this.lblerro1.Location = new System.Drawing.Point(12, 78);
            this.lblerro1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro1.Name = "lblerro1";
            this.lblerro1.Size = new System.Drawing.Size(16, 19);
            this.lblerro1.TabIndex = 84;
            this.lblerro1.Text = "*";
            // 
            // lblerro10
            // 
            this.lblerro10.AutoSize = true;
            this.lblerro10.BackColor = System.Drawing.Color.Transparent;
            this.lblerro10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro10.ForeColor = System.Drawing.Color.Red;
            this.lblerro10.Location = new System.Drawing.Point(543, 11);
            this.lblerro10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro10.Name = "lblerro10";
            this.lblerro10.Size = new System.Drawing.Size(16, 19);
            this.lblerro10.TabIndex = 82;
            this.lblerro10.Text = "*";
            // 
            // lblerro6
            // 
            this.lblerro6.AutoSize = true;
            this.lblerro6.BackColor = System.Drawing.Color.Transparent;
            this.lblerro6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro6.ForeColor = System.Drawing.Color.Red;
            this.lblerro6.Location = new System.Drawing.Point(12, 264);
            this.lblerro6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro6.Name = "lblerro6";
            this.lblerro6.Size = new System.Drawing.Size(16, 19);
            this.lblerro6.TabIndex = 91;
            this.lblerro6.Text = "*";
            // 
            // lblerro7
            // 
            this.lblerro7.AutoSize = true;
            this.lblerro7.BackColor = System.Drawing.Color.Transparent;
            this.lblerro7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro7.ForeColor = System.Drawing.Color.Red;
            this.lblerro7.Location = new System.Drawing.Point(218, 260);
            this.lblerro7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro7.Name = "lblerro7";
            this.lblerro7.Size = new System.Drawing.Size(16, 19);
            this.lblerro7.TabIndex = 89;
            this.lblerro7.Text = "*";
            // 
            // lblerro8
            // 
            this.lblerro8.AutoSize = true;
            this.lblerro8.BackColor = System.Drawing.Color.Transparent;
            this.lblerro8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerro8.ForeColor = System.Drawing.Color.Red;
            this.lblerro8.Location = new System.Drawing.Point(12, 306);
            this.lblerro8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerro8.Name = "lblerro8";
            this.lblerro8.Size = new System.Drawing.Size(16, 19);
            this.lblerro8.TabIndex = 88;
            this.lblerro8.Text = "*";
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Cyan;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.Color.White;
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(681, 500);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(71, 32);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblForca
            // 
            this.lblForca.AutoSize = true;
            this.lblForca.Location = new System.Drawing.Point(367, 190);
            this.lblForca.Name = "lblForca";
            this.lblForca.Size = new System.Drawing.Size(0, 13);
            this.lblForca.TabIndex = 93;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(685, -2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(41, 30);
            this.btnMin.TabIndex = 16;
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
            this.btnClose.Location = new System.Drawing.Point(723, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 30);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTelaADMCadastroFuncAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 544);
            this.Controls.Add(this.pctbperfil);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblForca);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lblerro6);
            this.Controls.Add(this.lblerro7);
            this.Controls.Add(this.lblerro8);
            this.Controls.Add(this.lblerro3);
            this.Controls.Add(this.lblerro1);
            this.Controls.Add(this.lblerro10);
            this.Controls.Add(this.lblerro4);
            this.Controls.Add(this.lblerro2);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblerro9);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipoLogradouro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblerro5);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lnkCep);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.cmbUF);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.mskrg);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.btnbuscaimg);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.cmbsx);
            this.Controls.Add(this.mskdtnasc);
            this.Controls.Add(this.lbldtnasc);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsx);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblimgperfil);
            this.Controls.Add(this.grptipo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaADMCadastroFuncAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Cadastro de Funcionário e Adms";
            this.Load += new System.EventHandler(this.frmTelaADMCadastroFuncAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbperfil)).EndInit();
            this.grptipo.ResumeLayout(false);
            this.grptipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblimgperfil;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblsx;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbldtnasc;
        private System.Windows.Forms.MaskedTextBox mskdtnasc;
        private System.Windows.Forms.ComboBox cmbsx;
        private System.Windows.Forms.PictureBox pctbperfil;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.GroupBox grptipo;
        private System.Windows.Forms.RadioButton rdbadm;
        private System.Windows.Forms.RadioButton rdbfunc;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnbuscaimg;
        private System.Windows.Forms.MaskedTextBox mskrg;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.OpenFileDialog ofdimg;
        private System.Windows.Forms.Label lblerro9;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoLogradouro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblerro5;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.LinkLabel lnkCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.ComboBox cmbUF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblerro2;
        private System.Windows.Forms.Label lblerro4;
        private System.Windows.Forms.Label lblerro3;
        private System.Windows.Forms.Label lblerro1;
        private System.Windows.Forms.Label lblerro10;
        private System.Windows.Forms.Label lblerro6;
        private System.Windows.Forms.Label lblerro7;
        private System.Windows.Forms.Label lblerro8;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblForca;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip tooTipHint;
    }
}