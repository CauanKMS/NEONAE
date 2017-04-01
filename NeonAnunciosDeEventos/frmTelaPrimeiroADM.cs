using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaPrimeiroADM : Form
    {
        #region Variáveis Globais
        String cepLimpo;
        int tipouso;
        string sexo, email, cpf, senha, NomedaImagem;
        string enderecoFotoOrigem, enderecoFotoDestino, anoTela, AnoFinal;

        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;

        int anoMin, anoMax, anoAtual;
        #endregion

        #region Acessos
        acessoCEP cep = new acessoCEP();
        acessoADM adm = new acessoADM();
        acessoAuditoria auditoria = new acessoAuditoria();
        acessoSenhasAntigas senhasAntigas = new acessoSenhasAntigas();
        #endregion

        public frmTelaPrimeiroADM()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //campos nulos
                if (txtnome.Text == string.Empty || mskdtnasc.MaskFull == false || txtemail.Text == string.Empty || txtSenha.Text == string.Empty || txtConfSenha.Text == string.Empty || NomedaImagem == string.Empty || cmbsx.Text == string.Empty || msktel.MaskFull == false || mskcpf.MaskFull == false || mskrg.MaskFull == false || mskCep.MaskFull == false || txtNum.Text == string.Empty || cmbPerguntaSecreta.Text == string.Empty || txtrespsec.Text == string.Empty)
                {
                    MessageBox.Show("Por favor Preencha todos os campos obrigatórios");
                }
                else if (txtSenha.Text != txtConfSenha.Text)
                {
                    MessageBox.Show("Senhas não correspondem");
                }
                //se o label que verifica se a senha é forte ou não, ou se foi digitado há quantidade mínima de caracteres
                else if (lblSenhaForte.Text == "Senha Fraca" && lblSenhaForte.Text == "Favor digitar outra senha com 6 caracteres no mínimo")
                {
                    MessageBox.Show("Senha é fraca ou curta demais! Por Favor Digite uma senha Forte ou Média");
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

                    //a varaivel recebe a letra que será cadastrada
                    if (cmbsx.SelectedIndex == 0)
                        sexo = "M";
                    if (cmbsx.SelectedIndex == 1)
                        sexo = "F";
                    if (cmbsx.SelectedIndex == 2)
                        sexo = "O";

                    if (NomedaImagem == null)
                    {
                        NomedaImagem = "PerfilPadrao.png";
                    }

                    //o tipo recebe 2
                    tipouso = 1;
                    //evento cadastrar
                    adm.inserir(tipouso.ToString(), txtnome.Text, mskdtnasc.Text, txtemail.Text, txtSenha.Text, msktel.Text, sexo, NomedaImagem, mskrg.Text, mskcpf.Text, mskCep.Text, txtNum.Text, txtComplemento.Text, cmbPerguntaSecreta.Text, txtrespsec.Text);
                    MessageBox.Show("Primeiro Administrador Cadastrado com sucesso");
                    
                    adm.IDPrimeiroADM();
                    abstractClasse.Id_logon = adm.Id_usu;

                    senhasAntigas.senhas_antigas(txtSenha.Text);

                    //evento que pega data e hora
                    AuditoriaDtHr();
                    tabelamod = "Usuario"; descricao = "O Primeiro Administrador foi cadastrado";
                    //criando auditoria
                    auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);
                    //voltando a tela de login
                    Visible = false;
                    frmTelaLogin Telalogin = new frmTelaLogin();
                    Telalogin.ShowDialog();
                    Close();
                }
            }
            catch { }
        }

        private void btnbuscaimg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();

                // filtro das imagens
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //txtbuscanomeimg.Text = open.SafeFileName;
                    pctbperfil.ImageLocation = open.FileName;
                    NomedaImagem = open.SafeFileName;
                    // exibir a foto no pct
                    pctbperfil.Image = new Bitmap(open.FileName);

                    // armazenar o endereço da imagem
                    enderecoFotoOrigem = open.FileName;

                    // gerando o endereço aonde será copiada a imagem
                    enderecoFotoDestino = Path.Combine(abstractClasse.LocalIMG, Path.GetFileName(enderecoFotoOrigem));

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

        private void frmTelaPrimeiroADM_Load(object sender, EventArgs e)
        {
            //cria conexão com a base_correios
            Conexao.criar_Conexao();
            //cria conexão com o banco do projeto
            ConexaoPrincipal.criar_Conexao();
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
            anoTela = anoTela.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "");

            //selecionado os números da data pelo array
            x[0] = Convert.ToInt32(anoTela.Substring(4, 1));
            x[1] = Convert.ToInt32(anoTela.Substring(5, 1));
            x[2] = Convert.ToInt32(anoTela.Substring(6, 1));
            x[3] = Convert.ToInt32(anoTela.Substring(7, 1));

            //montando o ano digitado para comparação de viabilização para o cadastro
            AnoFinal = (x[0] + "" + x[1] + "" + x[2] + "" + x[3]).ToString();
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

        private void txtnome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite seu nome completo!" + "\r\n" + "Exemplo:Gustavo Moreira");
            }
        }

        private void mskdtnasc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite sua data de nascimento" + "\r\n" + "Exemplo:27/10/1985");
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite seu email" + "\r\n" + "Exemplo:gustavo@gmail.com");
            }
        }

        private void msktel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite seu telefone/celular" + "\r\n" + "Exemplo:(12)98172-5290");
            }
        }

        private void mskrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite seu Rg" + "\r\n" + "Exemplo:42.756.592-3");
            }
        }

        private void cmbsx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Qual é seu sexo?" + "\r\n" + "Exemplo:Feminino");
            }
        }

        private void mskcpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite seu Cpf" + "\r\n" + "Exemplo:757.889.274-63");
            }
        }

        private void cmbPerguntaSecreta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Escolha uma das opções para ser sua pergunta secreta" + "\r\n" + "Exemplo:Qual o nome da sua cidade natal");
            }
        }

        private void txtrespsec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite sua resposta secreta" + "\r\n" + "Exemplo:alexandria");
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite uma senha Forte ou Média" + "\r\n" + "Exemplo de Senha Forte:A123b@");
            }
        }

        private void txtConfSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Confirme sua Senha");
            }
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite seu Cep" + "\r\n" + "Exemplo:12245-300");
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o número da sua casa, do seu prédio, do seu condomínio" + "\r\n" + "Exemplo:300");
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o Complemento,caso necessário, da sua residencia" + "\r\n" + "Exemplo:31A");
            }
        }

        public void AuditoriaDtHr()
        {
            data = DateTime.Now.ToString("yyyy/MM/dd");
            hora = DateTime.Now.ToString("HH:mm");
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button de minimizar a tela
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public String limparCEP(String cep)
        {
            String tmp;

            tmp = cep.Remove(2, 1);

            tmp = tmp.Remove(5, 1);

            return tmp;
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

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            int qtdLetras;
            int qtdLetMai = 0, qtdLetMin = 0, qtdNum = 0, qtdCar = 0;

            qtdLetras = txtSenha.Text.Length;

            //verifica se foi digitado menos de 6 caracteres
            if (qtdLetras < 6)
            {
                lblSenhaForte.Text = "Favor digitar outra senha com 6 caracteres no mínimo";
            }
            else
            {
                //caso seja 6 ou mais
                lblSenhaForte.Text = "Senha Fraca";

                //contagem de quantos numeros, letras maisuculas, minusculas e caracters especiais
                for (int i = 0; i < qtdLetras; i++)
                {
                    if (char.IsLower(txtSenha.Text[i]))
                    {
                        qtdLetMin++;
                    }
                    else
                    {
                        if (char.IsUpper(txtSenha.Text[i]))
                        {
                            qtdLetMai = qtdLetMai + 1;
                        }
                        else
                        {
                            if (char.IsNumber(txtSenha.Text[i]))
                            {
                                qtdNum++;
                            }
                            else
                            {
                                if (!char.IsWhiteSpace(txtSenha.Text[i]))
                                {
                                    qtdCar++;
                                }
                            }
                        }
                    }
                }
                //pelo menos 1 de cada faz a senha ser forte
                if (qtdCar != 0 &&
                    qtdLetMai != 0 &&
                    qtdLetMin != 0 &&
                    qtdNum != 0)
                {
                    lblSenhaForte.Text = "Senha Forte";
                }
                else
                {
                    if (qtdCar != 0)
                    {
                        //3 das 4 faz a senha se média
                        if (qtdLetMai != 0 && qtdLetMin != 0)
                        {
                            lblSenhaForte.Text = "Senha Média";
                        }
                        if (qtdLetMai != 0 && qtdNum != 0)
                        {
                            lblSenhaForte.Text = "Senha Média";
                        }
                        if (qtdLetMin != 0 && qtdNum != 0)
                        {
                            lblSenhaForte.Text = "Senha Média";
                        }
                    }
                    else
                    {
                        if (qtdLetMai != 0)
                        {
                            if (qtdLetMin != 0 && qtdNum != 0)
                            {
                                lblSenhaForte.Text = "Senha Média";
                            }
                        }
                        else
                        {
                            lblSenhaForte.Text = "Senha Fraca";
                        }

                    }
                }
            }
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
    }
}
