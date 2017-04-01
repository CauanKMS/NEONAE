using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaADMCadastroFuncAdm : Form
    {
        #region Acessos
        acessoCEP cep = new acessoCEP();
        acessoADM adm = new acessoADM();
        acessoAuditoria aud = new acessoAuditoria();
        #endregion

        #region Variáveis Globais
        String cepLimpo;

        int tipouso;
        string sexo, senha;

        string enderecoFotoOrigem, enderecoFotoDestino,NomedaImagem;

        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;
  
        string anoTela, AnoFinal;
        int anoMin,anoMax,anoAtual;
        #endregion

        public frmTelaADMCadastroFuncAdm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //campos nulos
            if (txtnome.Text == string.Empty || mskdtnasc.MaskFull == false || txtemail.Text == string.Empty || cmbsx.Text == string.Empty || msktel.MaskFull == false || mskcpf.MaskFull == false || mskrg.MaskFull == false || mskCep.MaskFull == false || txtNum.Text == string.Empty)
            {
                MessageBox.Show("Por favor Preencha todos os campos obrigatórios");
            }
            //verifica se o email ou cpf já é cadastrado
            else if (adm.verificar(txtemail.Text, mskcpf.Text) == true)
            {
                MessageBox.Show("Email ou Cpf já cadastrados!");
            }
            else
            {
                //caso zona rural se sim lel limpa cep
                if (dadosCEP.ZonaRural == "S")
                    cepLimpo = limparCEP(mskCep.Text);
                else
                    cepLimpo = dadosCEP.Cep;

                //complemento recebe "Sem complemento"
                if (txtComplemento.Text == string.Empty)
                {
                    txtComplemento.Text = "Sem complemento";
                }

                //verificando se o rdbFunc ou rdbAdm foi selecionado
                if (rdbfunc.Checked == false && rdbadm.Checked == false)
                {
                    MessageBox.Show("Escolha um tipo de usuário que você quer cadastrar");
                }

                //caso não seja selecionado a imagem
                if (NomedaImagem == null)
                {
                    NomedaImagem = "PadraoPerfil.png";
                }

                //a varaivel recebe a letra que será cadastrada
                if (cmbsx.SelectedIndex == 0)
                    sexo = "M";
                if (cmbsx.SelectedIndex == 1)
                    sexo = "F";
                if (cmbsx.SelectedIndex == 2)
                    sexo = "O";

                //gerando a senha aleatória
                senha = adm.CreatePassword(7);

                //enviando a senha gerada para o email cadastrado
                Email.CadConfSenha(txtemail.Text, txtnome.Text, senha);

                string pergsec, respsec;

                pergsec = "";
                respsec = "";

                //caso seja selecionado rdbFunc
                if (rdbfunc.Checked == true)
                {
                    //evento que pega data e hora
                    AuditoriaDtHr();
                    tabelamod = "Usuario"; descricao = "Cadastrou um Funcionário";
                    //criando auditoria
                    aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    //o tipo recebe 2
                    tipouso = 2;
                    //evento cadastrar
                    adm.inserir(tipouso.ToString(), txtnome.Text, mskdtnasc.Text, txtemail.Text, senha, msktel.Text, sexo, NomedaImagem, mskrg.Text, mskcpf.Text, mskCep.Text, txtNum.Text, txtComplemento.Text, pergsec, respsec);
                    MessageBox.Show("Funcionário Cadastrado com sucesso");
                    //voltando a tela de gerenciamento de Funcs e Adms
                    Visible = false;
                    frmTelaADMGerenciamento telageren = new frmTelaADMGerenciamento();
                    telageren.ShowDialog();
                    Close();
                }
                //caso seja selecionado rdbAdm
                if (rdbadm.Checked == true)
                {
                    //evento que pega data e hora
                    AuditoriaDtHr();
                    tabelamod = "Usuario"; descricao = "Cadastrou um Administrador";
                    //criando auditoria
                    aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    //o tipo recebe 1
                    tipouso = 1;
                    //evento cadastrar
                    adm.inserir(tipouso.ToString(), txtnome.Text, mskdtnasc.Text, txtemail.Text, senha, msktel.Text, sexo, NomedaImagem, mskrg.Text, mskcpf.Text, mskCep.Text, txtNum.Text, txtComplemento.Text, pergsec, respsec);
                    MessageBox.Show("Administrador Cadastrado com sucesso");
                    //voltando a tela de gerenciamento de Funcs e Adms
                    Visible = false;
                    frmTelaADMGerenciamento telageren = new frmTelaADMGerenciamento();
                    telageren.ShowDialog();
                    Close();
                }
            }
        }

        private void mskcpf_Leave(object sender, EventArgs e)
        {
            //quando for desselecionado o mskcpf verifica se foi preenchido os 11 caracteres
            if (mskcpf.MaskFull == true)
            {
                //evento que verifica se o cpf é valido
                adm.Valida(mskcpf.Text);
                //verifica se a variavel abstrata volta true ou false
                if (Convert.ToBoolean(abstractClasse.Cpf_valido) == false)
                {
                    //caso seja falso
                    MessageBox.Show("CPF Inválido! Digite Corretamente");
                    mskcpf.Clear();
                }
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            //quando for desselecionado o txtemail, ele verifica se o campo está vazio
            if (txtemail.Text == string.Empty)
            { }
            else
            {
                //quando for preenchido, ele verificará se o email é válido
                EmailCoerente();
            }
        }

        private void mskdtnasc_Leave(object sender, EventArgs e)
        {
            //quando for desselecionado verificará se mskdtnasc está completo
            if (mskdtnasc.MaskFull == true)
            {
                //verificará se a data digitada é coerente
                DataCoerente();
                if (Convert.ToInt32(AnoFinal) >= anoMax && Convert.ToInt32(AnoFinal) <= anoMin)
                {
                }
                else
                {
                    MessageBox.Show("Data Inválida! Digite uma data coerente");
                    mskdtnasc.Clear();
                }
            }
        }

        private void mskrg_Leave(object sender, EventArgs e)
        {
            //quando for desselecionado verificará se mskrg está completo
            if (mskrg.MaskFull == true)
            {
                //verificará se o rg digitado é válido
                if (adm.Valida2(mskrg.Text) == false)
                {
                    MessageBox.Show("RG Inválido! Digite Corretamente");
                    mskrg.Clear();
                }
            }
        }

        public void AuditoriaDtHr()
        {
            data = DateTime.Now.ToString("yyyy/MM/dd");
            hora = DateTime.Now.ToString("HH:mm");
        }

        public void DataCoerente()
        {
            //criando variaveis do ano atual para calcular os anos de Max e Min
            anoAtual = DateTime.Now.Year;
            anoMin = anoAtual - 16;
            anoMax = anoAtual - 100;

            //criando um array para selecionar os números do mskdatanasc
            int[] x = new int[4] { 0, 1, 2, 3 };

            //passando para uma variavel
            anoTela = mskdtnasc.Text;

            //retirando (.),(,) e (/) da data
            //anoTela = anoTela.Trim();
            anoTela = anoTela.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/","");

            //selecionado os números da data pelo array
            x[0] = Convert.ToInt32(anoTela.Substring(4, 1));
            x[1] = Convert.ToInt32(anoTela.Substring(5, 1));
            x[2] = Convert.ToInt32(anoTela.Substring(6, 1));
            x[3] = Convert.ToInt32(anoTela.Substring(7, 1));

            //montando o ano digitado para comparação de viabilização para o cadastro
            AnoFinal = (x[0] + "" + x[1] + "" + x[2] + "" + x[3]).ToString();
         }

        public void EmailCoerente()
        {
            string email = txtemail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                //MessageBox.Show("Email Valido!");
            }
            else
            {
                MessageBox.Show("Email Inválido!");
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            //volta pra tela de gerenciamento de Funcs e Adms
            Visible = false;
            frmTelaADMGerenciamento telageren = new frmTelaADMGerenciamento();
            telageren.ShowDialog();
            Close();
        }

        //Button buscar imagem
        #region Buscar Imagem

        private void btnbuscaimg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();

                // filtro das imagens
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pctbperfil.ImageLocation = open.FileName;

                    NomedaImagem = open.SafeFileName;
                    // exibir a foto no pct
                    pctbperfil.Image = new Bitmap(open.FileName);

                    // armazenar o endereço da imagem
                    enderecoFotoOrigem = open.FileName;

                    // gerando o endereço aonde será copiada a imagem
                    enderecoFotoDestino = Path.Combine( abstractClasse.LocalIMG, Path.GetFileName(enderecoFotoOrigem));

                    // copiando a imagem
                    File.Copy(enderecoFotoOrigem, enderecoFotoDestino, true);

                    // cadastrado no BD
                    // o primeiro parametro deve ser uma descrição para a foto, por exemplo um TEXTBOX
                    // o segundo tem que ser o nome da FOTO
                }
            }
            catch
            {

            }
        }
        #endregion

        //Button de fechar a tela
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button de minimizar a tela
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmTelaADMCadastroFuncAdm_Load(object sender, EventArgs e)
        {
            //cria conexão com a base_correios
            Conexao.criar_Conexao();
            //cria conexão com o banco do projeto
            ConexaoPrincipal.criar_Conexao();

            cmbTipoLogradouro.DataSource = cep.tipoLogradouro();
            cmbTipoLogradouro.DisplayMember = "tipologradouro";
            cmbTipoLogradouro.Text = "";
        }

        public String limparCEP(String cep)
        {
            String tmp;

            tmp = cep.Remove(2, 1);

            tmp = tmp.Remove(5, 1);

            return tmp;
        }

        private void mskCep_TextChanged(object sender, EventArgs e)
        {
            mskCep.BackColor = Color.White;
            // para cep's existentes
            if (mskCep.MaskFull == true && mskCep.Text != "00.000-000")
            {
                if (cep.buscaEndereco(limparCEP(mskCep.Text)) == true)
                {
                    cmbTipoLogradouro.Text = cep.Tipo_logradouro;
                    txtRua.Text = cep.Logradouro;
                    txtCidade.Text = cep.Cidade;
                    txtBairro.Text = cep.Bairro;
                    cmbUF.Text = cep.Uf;
                    dadosCEP.ZonaRural = "S";
                }
                else
                {
                    limCep();
                }
            }
            else
            {
                // para cep's de zona rural
                if (mskCep.Text != "  .   -" && mskCep.Text != "00.000-000")
                {
                    if (cep.buscaEndereco(limparCEP(mskCep.Text)) == true)
                    {
                        cmbTipoLogradouro.Text = cep.Tipo_logradouro;
                        txtRua.Text = cep.Logradouro;
                        txtCidade.Text = cep.Cidade;
                        txtBairro.Text = cep.Bairro;
                        cmbUF.Text = cep.Uf;
                        mskCep.Text = "00.000-000";
                        dadosCEP.ZonaRural = "Z";
                    }
                    else
                    {
                        // limCep();
                    }
                }
            }
        }

        public void limCep()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtNum.Clear();
            txtRua.Clear();
            cmbTipoLogradouro.Text = "";
            cmbUF.Text = "";
            mskCep.Clear();
        }

        private void lnkCep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTelaBuscaCEP tela = new frmTelaBuscaCEP();
            tela.ShowDialog();
            if (dadosCEP.ZonaRural == "S")
                mskCep.Text = dadosCEP.Cep;
            else
            {
                mskCep.Text = "00.000-000";
            }

            txtNum.Text = dadosCEP.Num;
            txtComplemento.Text = dadosCEP.Comple;
            txtBairro.Text = dadosCEP.Bairro;
            txtCidade.Text = dadosCEP.Cidade;
            txtRua.Text = dadosCEP.Rua;
            cmbTipoLogradouro.Text = dadosCEP.Tipo;
            cmbUF.Text = dadosCEP.Uf;
        }

        private void mskdtnasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void msktel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mskrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mskcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mskCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o nome completo!" + "\r\n" +"Exemplo:Gustavo Moreira");
            }
        }

        private void mskdtnasc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite a data de nascimento da pessoa a ser cadastrada" + "\r\n" +"Exemplo:27/10/1985");
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o email da pessoa a ser cadastrada" + "\r\n" + "Exemplo:gustavo@gmail.com");
            }
        }

        private void msktel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o telefone/celular da pessoa ser cadastrada" + "\r\n" + "Exemplo:(12)98172-5290");
            }
        }

        private void mskrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o Rg da pessoa a ser cadastrada" + "\r\n" + "Exemplo:42.756.592-3");
            }
        }

        private void cmbsx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("qual o sexo da pessoa a ser cadastrada?" + "\r\n" + "Exemplo:Feminino");
            }
        }

        private void mskcpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o Cpf da pessoa a ser cadastrada" + "\r\n" + "Exemplo:757.889.274-63");
            }
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o Cep da pessoa a ser cadastrada" + "\r\n" + "Exemplo:12245-300");
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o número da casa, do prédio, condomínio da pessoa a ser cadastrada" + "\r\n" + "Exemplo:300");
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o Complemento,caso necessário, da pessoa a ser cadastrada" + "\r\n" + "Exemplo:31A");
            }
        }

    }
}