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
    public partial class frmTelaPerfil : Form
    {
        #region Acessos
        acessoCEP cep = new acessoCEP();
        acessoADM adm = new acessoADM();
        acessoFunc Func = new acessoFunc();
        acessoAuditoria Aud = new acessoAuditoria();
        #endregion

        #region Variáveis Globais
        String cepLimpo;

        string enderecoFotoOrigem, enderecoFotoDestino;
        string sexo, NomeImagem;
        string tabelamod, descricao, hora, data;

        string anoTela, AnoFinal;
        int anoMin, anoMax, anoAtual;
        #endregion

        public frmTelaPerfil()
        {
            InitializeComponent();
        }

        private void btnbuscaimg_Click(object sender, EventArgs e)
        {
            try
            {
                //atribuindo a variavel open a abetura de uma janela de dialogo
                OpenFileDialog open = new OpenFileDialog();

                // filtro das imagens
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //a variavel pega o nome da imagem selecionada
                    NomeImagem = open.SafeFileName;

                    //exibe a imagem no pictureBox
                    pctbperfil.ImageLocation = open.FileName;

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
            {}
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (abstractClasse.Id_tipologon == 1)
            {
                //volta ao menu do adm
                Visible = false;
                frmTelaADMMenu menuAdm = new frmTelaADMMenu();
                menuAdm.ShowDialog();
                Close();
            }
            else
            {
                Visible = false;
                frmTelaFuncMenu menuFunc = new frmTelaFuncMenu();
                menuFunc.ShowDialog();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abre a tela da troca de email
            frmTelaTrocarEmail troca = new frmTelaTrocarEmail();
            troca.ShowDialog();
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


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (abstractClasse.Id_tipologon == 1)
            {
                //verificar se algum campo foi alterado
                if (txtnome.Text == adm.Nome && mskdtnasc.Text == adm.DataTela && txtemail.Text == adm.Email && txtsenha.Text == adm.Senha && txtConfSenha.Text == adm.Senha && msktel.Text == adm.Cel && mskrg.Text == adm.Rg && mskcpf.Text == adm.Cpf && mskCep.Text == adm.Cep && txtNum.Text == adm.Numcasa && txtComplemento.Text == adm.Comp && cmbPerguntaSecreta.Text == adm.Pergsec && txtrespsec.Text == adm.Respsec && adm.Sx == sexo && NomeImagem == adm.Img)
                {
                    MessageBox.Show("Informações Não Alteradas!");
                    Visible = false;
                    frmTelaADMMenu menu = new frmTelaADMMenu();
                    menu.ShowDialog();
                    Close();
                }
                //verifica se cpf já é cadastrado
                else if (mskcpf.Text != adm.Cpf)
                {
                    if (adm.verificarApenasCpf(mskcpf.Text) == true)
                        MessageBox.Show("Cpf já cadastrados!");
                }
            }
            if(abstractClasse.Id_tipologon == 2)
            {
                //verificar se algum campo foi alterado
                if (txtnome.Text == Func.Nome && mskdtnasc.Text == Func.DataTela && txtemail.Text == Func.Email && txtsenha.Text == Func.Senha && txtConfSenha.Text == Func.Senha && msktel.Text == Func.Cel && mskrg.Text == Func.Rg && mskcpf.Text == Func.Cpf && mskCep.Text == Func.Cep && txtNum.Text == Func.Numcasa && txtComplemento.Text == Func.Comp && cmbPerguntaSecreta.Text == Func.Pergsec && txtrespsec.Text == Func.Respsec && Func.Sx == sexo && NomeImagem == Func.Img)
                {
                    MessageBox.Show("Informações Não Alteradas!");
                    Visible = false;
                    frmTelaFuncMenu menu = new frmTelaFuncMenu();
                    menu.ShowDialog();
                    Close();
                }
                else if (mskcpf.Text != adm.Cpf)
                {
                    if (adm.verificarApenasCpf(mskcpf.Text) == true)
                        MessageBox.Show("Cpf já cadastrados!");
                }
            }
            //verificação de campos nulos
            if (txtnome.Text == string.Empty || mskdtnasc.MaskFull == false || txtemail.Text == string.Empty || txtsenha.Text == string.Empty || cmbsx.Text == string.Empty || msktel.MaskFull == false || mskcpf.MaskFull == false || mskrg.MaskFull == false || mskCep.MaskFull == false || txtNum.Text == string.Empty)
            {
                MessageBox.Show("Por favor Preencha todos os campos obrigatórios");
            }
            //verifica se há alguma imagem
            else if (NomeImagem == string.Empty)
            {
                MessageBox.Show("Escolha uma imagem de perfil antes de cadastrar");
            }
            //verificar se a senha forte ou media é a mesma no confirmar senha
            else if (txtsenha.Text != txtConfSenha.Text)
            {
                MessageBox.Show("Senha não coorespondente");
            }
            //verifica se as mensagens de senha fraca ou menos de 6 digitos está no lbl, para não deixar cadastrar senhas fracas ou com menos de 6 digitos
            else if (lblSenhaForte.Text == "Senha Fraca" || lblSenhaForte.Text == "Favor digitar outra senha com 6 caracteres no mínimo")
            {
                MessageBox.Show("Não é Possível alteração para uma senha Fraca!");
            }
            else
            {
                if (dadosCEP.ZonaRural == "S")
                    cepLimpo = limparCEP(mskCep.Text);
                else
                    cepLimpo = dadosCEP.Cep;

                //caso não seja digitado um complemento, a mensagem sem complemento é adicionado a textBox do complemento
                if (txtComplemento.Text == string.Empty)
                {
                    txtComplemento.Text = "Sem complemento";
                }

                //verifica o texto do comboBox para adicionar apenas uma letra para determinar o sexo
                if (cmbsx.Text == "Masculino")
                    sexo = "M";
                else if (cmbsx.Text == "Feminino")
                    sexo = "F";
                else if (cmbsx.Text == "Outros")
                    sexo = "O";

                if (abstractClasse.Id_tipologon == 1)
                {
                    //evento do update
                    adm.update(txtnome.Text, mskdtnasc.Text, txtemail.Text, txtsenha.Text, msktel.Text, sexo, NomeImagem, mskrg.Text, mskCep.Text, txtNum.Text, txtComplemento.Text, cmbPerguntaSecreta.Text, txtrespsec.Text);

                    //evento pra pegar hora e data pra auditoria
                    AuditoriaDtHr();
                    //coloca a descrição e a tabela de modificação da auditoria
                    tabelamod = "Usuário"; descricao = "Atualizou as informações do seu perfil";
                    //evento da auditoria
                    Aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    //mensagem de informações alteradas
                    MessageBox.Show("Informações do administrador alteradas com sucesso");
                    //evento que limpa os campos
                    Limpar();
                    //coloca a imagem do semimagem.jpg
                    pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, "semimagem.jpg");
                    //volta pra tela de menu do adm
                    Visible = false;
                    frmTelaADMMenu menu = new frmTelaADMMenu();
                    menu.ShowDialog();
                    Close();
                }
                else
                {
                    //evento do update
                    Func.update(txtnome.Text, mskdtnasc.Text, txtemail.Text, txtsenha.Text, msktel.Text, sexo, NomeImagem, mskrg.Text, mskCep.Text, txtNum.Text, txtComplemento.Text, cmbPerguntaSecreta.Text, txtrespsec.Text);

                    //evento pra pegar hora e data pra auditoria
                    AuditoriaDtHr();
                    //coloca a descrição e a tabela de modificação da auditoria
                    tabelamod = "Usuário"; descricao = "O colaborador alterou suas informações";
                    //evento da auditoria
                    Aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    //mensagem de informações alteradas
                    MessageBox.Show("Suas informações foram alteradas com sucesso");
                    //evento que limpa os campos
                    Limpar();
                    //coloca a imagem do semimagem.jpg
                    pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, "semimagem.jpg");

                    //volta pra tela de menu do func
                    Visible = false;
                    frmTelaFuncMenu menu = new frmTelaFuncMenu();
                    menu.ShowDialog();
                    Close();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Realmente deseja desativar seu perfil?", "Desativar Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //evento pra determinar se é o ultimo adm
                if(adm.UltimoADM(abstractClasse.Id_logon) == true)
                {
                    //evento pra pegar hora e data pra auditoria
                    AuditoriaDtHr();
                    //coloca a descrição e a tabela de modificação da auditoria
                    tabelamod = "Usuário"; descricao = "Desativou sua Conta";
                    //evento da auditoria
                    Aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    //evento que desativa a conta
                    adm.DesativaConta();
                    //mensagem de desativação da conta
                    MessageBox.Show("Sua conta foi desativada com sucesso");
                    //evento que limpa os campos
                    Limpar();
                    pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, "semimagem.jpg");
                    //volta a tela de login
                    Visible = false;
                    frmTelaLogin login = new frmTelaLogin();
                    login.ShowDialog();
                    Close();
                }
                else
                {
                    //evento pra pegar hora e data pra auditoria
                    AuditoriaDtHr();
                    //coloca a descrição e a tabela de modificação da auditoria
                    tabelamod = "Usuário"; descricao = "Tentou Desativar Sua Conta Porém é o ultimo ADM";
                    //evento da auditoria
                    Aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);
                    //mensagem que demonstra que não foi possivel desativar conta
                    MessageBox.Show("Você é o Ultimo Administrador! Desativação de conta não Autorizada");
                }
                
            }
        }

        private void frmTelaADMupdaDeleAdm_Load(object sender, EventArgs e)
        {
            //cria conexão com a base_correios
            Conexao.criar_Conexao();
            //cria conexão com o banco de dados do projeto
            ConexaoPrincipal.criar_Conexao();

            cmbTipoLogradouro.DataSource = cep.tipoLogradouro();
            cmbTipoLogradouro.DisplayMember = "tipologradouro";
            cmbTipoLogradouro.Text = "";

            if (abstractClasse.Id_tipologon == 1)
            {
                //evento pra carregar o perfil do adm
                if (adm.Pesq(abstractClasse.Email_logon, abstractClasse.Id_tipologon.ToString()) == true)
                {
                    //carregando as informações do perfil
                    txtnome.Text = adm.Nome; abstractClasse.Nome_logon = txtnome.Text;
                    mskdtnasc.Text = adm.DataTela;
                    txtemail.Text = adm.Email; txtemail.Enabled = false;
                    txtsenha.Text = adm.Senha;
                    txtConfSenha.Text = adm.Senha;
                    msktel.Text = adm.Cel;
                    mskrg.Text = adm.Rg;
                    mskcpf.Text = adm.Cpf;
                    mskCep.Text = adm.Cep;
                    txtNum.Text = adm.Numcasa;
                    txtComplemento.Text = adm.Comp;
                    cmbPerguntaSecreta.Text = adm.Pergsec;
                    txtrespsec.Text = adm.Respsec;


                    if ((adm.Sx == "M") || (adm.Sx == "m"))
                        cmbsx.SelectedText = "Masculino";
                    else if ((adm.Sx == "F") || (adm.Sx == "f"))
                        cmbsx.SelectedText = "Feminino";
                    else if ((adm.Sx == "O") || (adm.Sx == "o"))
                        cmbsx.SelectedText = "Outros";

                    sexo = adm.Sx;

                    NomeImagem = adm.Img;

                    //verifica se pegou alguma o nome de alguma imagem
                    if (NomeImagem == null)
                        pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, "semimagem.jpg");
                    else if (NomeImagem == "PadraoPerfil.png")
                        pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, "PerfilPadrao.png");
                    else
                        pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, NomeImagem);

                    //verifica se o cep carregado é zona rural
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
                    }
                }
            }
            else
            {
                Func.carregarPerfil(abstractClasse.Email_logon, abstractClasse.Id_tipologon.ToString());
                txtnome.Text = Func.Nome;
                mskdtnasc.Text = Func.DataTela;
                txtemail.Text = Func.Email;
                txtsenha.Text = Func.Senha;
                txtConfSenha.Text = Func.Senha;
                msktel.Text = Func.Cel;
                mskrg.Text = Func.Rg;
                mskcpf.Text = Func.Cpf;
                mskCep.Text = Func.Cep;
                txtNum.Text = Func.Numcasa;
                txtComplemento.Text = Func.Comp;
                cmbPerguntaSecreta.Text = Func.Pergsec;
                txtrespsec.Text = Func.Respsec;

                if ((Func.Sx == "M") || (Func.Sx == "m"))
                    cmbsx.SelectedText = "Masculino";
                else if ((Func.Sx == "F") || (Func.Sx == "f"))
                    cmbsx.SelectedText = "Feminino";
                else if ((Func.Sx == "O") || (Func.Sx == "o"))
                    cmbsx.SelectedText = "Outros";

                NomeImagem = Func.Img;

                sexo = Func.Sx;

                OpenFileDialog open = new OpenFileDialog();

                //verifica se pegou alguma o nome de alguma imagem
                if (NomeImagem == null)
                    pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, "semimagem.jpg");
                else
                    pctbperfil.ImageLocation = Path.Combine(abstractClasse.LocalIMG, NomeImagem);

                //verifica se o cep carregado é zona rural
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
                }
            }  
        }

        #region CEP
        public void Limpar()
        {
            txtnome.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtsenha.Text = string.Empty;
            mskdtnasc.Text = string.Empty;
            msktel.Text = string.Empty;
            mskrg.Text = string.Empty;
            mskcpf.Text = string.Empty;
            cmbsx.Text = string.Empty;
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtNum.Clear();
            txtRua.Clear();
            cmbTipoLogradouro.Text = "";
            cmbUF.Text = "";
            mskCep.Clear();
            mskCep.Enabled = true;
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
                        limCep();
                    }
                }
            }
        }

        public void limCep()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtRua.Clear();
            cmbTipoLogradouro.Text = "";
            cmbUF.Text = "";
        }

        private void mskdtnasc_Leave(object sender, EventArgs e)
        {
            if (mskdtnasc.MaskFull == true)
            {
                //quando for desselecionado verificará se mskdtnasc está completo
                //verificará se a data digitada é coerente
                DataCoerente();
                if (Convert.ToInt32(AnoFinal) >= anoMax && Convert.ToInt32(AnoFinal) <= anoMin)
                { }
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

        private void mskcpf_Leave(object sender, EventArgs e)
        {
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
        #endregion

        public void AuditoriaDtHr()
        {
            hora = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("yyyy/MM/dd");
        }

        #region Mini && Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            //encerra o projeto
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //minimiza o projeto
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //Força De Senha
        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            //variáveis contaveis
            int qtdLetras;
            int qtdLetMai = 0, qtdLetMin = 0, qtdNum = 0, qtdCar = 0;

            //número do conteudo que há no txt da senha
            qtdLetras = txtsenha.Text.Length;

            //se a quantidade de letras for menor que 6
            if (qtdLetras < 6)
            {
                //não permite o cadastro com a mensagem do lbl
                lblSenhaForte.Text = "Favor digitar outra senha com 6 caracteres no mínimo";
            }
            else
            {
                //caso seja maior que 6
                lblSenhaForte.Text = "Senha Fraca";

                //for pra determinar a quantidades de letras minisculas,maiuscula,numeros e caracteres especiais
                for (int i = 0; i < qtdLetras; i++)
                {
                    //minusculos
                    if (char.IsLower(txtsenha.Text[i]))
                        qtdLetMin++;
                    else
                    {
                        //maiusculos
                        if (char.IsUpper(txtsenha.Text[i]))
                            qtdLetMai = qtdLetMai + 1;
                        else
                        {
                            //numeros
                            if (char.IsNumber(txtsenha.Text[i]))
                                qtdNum++;
                            else
                            {
                                //caracteres especiais
                                if (!char.IsWhiteSpace(txtsenha.Text[i]))
                                    qtdCar++;
                            }
                        }
                    }
                }
                //caso tenha um de cada a senha é forte
                if (qtdCar != 0 &&
                    qtdLetMai != 0 &&
                    qtdLetMin != 0 &&
                    qtdNum != 0)
                {
                    lblSenhaForte.Text = "Senha Forte";
                }
                else
                {
                    //se tiver caracteres especiais
                    if (qtdCar != 0)
                    {
                        //verifica se tem letras maiusculas e minusculas tambem
                        if (qtdLetMai != 0 && qtdLetMin != 0)
                            lblSenhaForte.Text = "Senha Média";
                        //verifica se tem letras maiusculas e numeros
                        if (qtdLetMai != 0 && qtdNum != 0)
                            lblSenhaForte.Text = "Senha Média";
                        //verifica se tem letras minusculas e numeros
                        if (qtdLetMin != 0 && qtdNum != 0)
                            lblSenhaForte.Text = "Senha Média";
                    }
                    else
                    {
                        //verifica se tem letras maiusculas
                        if (qtdLetMai != 0)
                        {
                            //verifica se tem letras maisuculas e numeros tambem
                            if (qtdLetMin != 0 && qtdNum != 0)
                                lblSenhaForte.Text = "Senha Média";
                        }
                        else
                        {
                            //senão a senha fica fraca
                            lblSenhaForte.Text = "Senha Fraca";
                        }
                    }
                }
            }
        }

        #region Só Números
        private void mskdtnasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void msktel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void mskrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void mskcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void mskCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region Helps
        private void txtnome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite seu nome completo!" + "\r\n" +"Exemplo:Gustavo Moreira");
        }

        private void mskdtnasc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite sua data de nascimento" + "\r\n" + "Exemplo:27/10/1985");
        }

        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite uma senha Forte ou Média" + "\r\n" + "Exemplo de Senha Forte:A123b@");
        }

        private void txtConfSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Confirme sua Senha");
        }

        private void msktel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite seu telefone/celular" + "\r\n" + "Exemplo:(12)98172-5290");
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
                MessageBox.Show("Qual é seu sexo?" + "\r\n" + "Exemplo:Feminino");
        }

        private void mskcpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite seu Cpf" + "\r\n" + "Exemplo:757.889.274-63");
        }

        private void cmbPerguntaSecreta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Escolha uma das opções para ser sua pergunta secreta" + "\r\n" + "Exemplo:Qual o nome da sua cidade natal");
        }

        private void txtrespsec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite sua resposta secreta" + "\r\n" + "Exemplo:alexandria");
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite seu Cep" + "\r\n" + "Exemplo:12245-300");
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite o número da sua casa, do seu prédio, do seu condomínio" + "\r\n" + "Exemplo:300");
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite o Complemento,caso necessário, da sua residencia" + "\r\n" + "Exemplo:31A");
        }
        #endregion
    }
}
