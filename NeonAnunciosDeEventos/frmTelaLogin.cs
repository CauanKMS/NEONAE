using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaLogin : Form
    {
        #region Acessos
        acessoSenhasAntigas senhasAntigas = new acessoSenhasAntigas();
        acessoLogin login = new acessoLogin();
        acessoFunc func = new acessoFunc();
        acessoADM adm = new acessoADM();
        acessoAuditoria auditoria = new acessoAuditoria();
        #endregion

        #region Variáveis Globais
        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;
        int idtp,qtd_erro,id_usu;
        #endregion

        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
            try
            {
                DirtórioIMG();
                //ver se é o primeiro adm a ser cadastrado
                if (adm.PrimeiroAdm() == true)
                {
                    //ir a tela de cadstro do primeiro adm
                    Visible = false;
                    frmTelaPrimeiroADM PriAdm = new frmTelaPrimeiroADM();
                    PriAdm.ShowDialog();
                    Close();
                }
            }
            catch { }
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            adm.contaDesativada(txtemail.Text, txtsenha.Text);
            DiretórioBackup();
            SenhaExpirada();
            try
            { 
                if (txtemail.Text == string.Empty || txtsenha.Text == string.Empty)
                {
                    //campos em branco
                    lblerroemail.Visible = true;
                    lblerrosenha.Visible = true;
                    MessageBox.Show("Preencha os campos corretamente");
                }
                else if (login.pesquisalogin(txtemail.Text, txtsenha.Text) == false)
                {
                    //email e senha corretos
                    MessageBox.Show("O email ou a senha estão incorretos. " + "\r\n" + "Preencha-os corretamente");
                    qtd_erro++;
                    
                }
                if (qtd_erro >= 3)//errou sua senha ou email 3 vezes no mínimo
                {
                    visibleTrue();

                    if (login.pesqrespsec(txtemail.Text, txtsenha.Text, cmbPerguntaSecreta.Text, txtrespsec.Text) == true)
                    {
                        lblerroemail.Visible = false;
                        lblerrosenha.Visible = false;
                        VariaveisAbstracts();
                       
                        if (idtp == 1)
                        {
                            //primeira entrada com a pergunta secreta e senha secreta,ADM
                            if (login.pesquisaPrimeiraEntrada(txtemail.Text) == true && idtp == 1)
                            {
                                tabelamod = "Usuario"; descricao = "Logou na conta";
                                AuditoriaDtHr();
                                auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                                abstractClasse.Email_logon = txtemail.Text;
                                Visible = false;
                                frmTelaTrocarSenhaPrimeiraEntrada upFirstSenha = new frmTelaTrocarSenhaPrimeiraEntrada();
                                upFirstSenha.ShowDialog();
                                Close();
                            }
                            else
                            {
                                //logou com pergunta secreta e senha secreta,ADM
                                tabelamod = "Usuario"; descricao = "Logou na conta";
                                AuditoriaDtHr();
                                auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                                abstractClasse.Email_logon = txtemail.Text;
                                frmTelaADMMenu menuadm = new frmTelaADMMenu();
                                Visible = false;
                                menuadm.ShowDialog();
                                Close();
                            }
                        }
                        if (idtp == 2)
                        {
                            if (login.pesquisaPrimeiraEntrada(txtemail.Text) == true && idtp == 2)
                            {
                                //primeira entrada com a pergunta secreta e senha secreta,Func
                                tabelamod = "Usuario"; descricao = "Logou na conta";
                                AuditoriaDtHr();
                                auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                                abstractClasse.Email_logon = txtemail.Text;
                                Visible = false;
                                frmTelaTrocarSenhaPrimeiraEntrada upFirstSenha = new frmTelaTrocarSenhaPrimeiraEntrada();
                                upFirstSenha.ShowDialog();
                                Close();
                            }
                            else
                            {
                                //logou com pergunta secreta e senha secreta,Func
                                tabelamod = "Usuario"; descricao = "Logou na conta";
                                AuditoriaDtHr();
                                auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                                abstractClasse.Email_logon = txtemail.Text;
                                Visible = false;
                                frmTelaFuncMenu menuFunc = new frmTelaFuncMenu();
                                menuFunc.ShowDialog();
                                Close();
                            }
                        }
                    }
                    //se um dos 4 campos estiver errado, mensagem de erro
                    if (login.pesqrespsec(txtemail.Text, txtsenha.Text, cmbPerguntaSecreta.Text, txtrespsec.Text) == false)
                    {
                        if(qtd_erro > 3)
                        MessageBox.Show("O email, a senha ou a resposta secreta estão incorretos. " + "\r\n" + "Preencha-os corretamente");
                    }
                }
                else
                {
                    //não errou a senha e o email 3 vezes
                    lblerroemail.Visible = false;
                    lblerrosenha.Visible = false;
                    VariaveisAbstracts();

                    if (idtp == 1)
                    {
                        if (login.pesquisaPrimeiraEntrada(txtemail.Text) == true)
                        {
                            //primeira entrada, ADM
                            tabelamod = "Usuario"; descricao = "Logou na conta";
                            AuditoriaDtHr();
                            auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                            abstractClasse.Email_logon = txtemail.Text;
                            Visible = false;
                            frmTelaTrocarSenhaPrimeiraEntrada upFirstSenha = new frmTelaTrocarSenhaPrimeiraEntrada();
                            upFirstSenha.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            //ADM se logou 
                            tabelamod = "Usuario"; descricao = "Logou na conta";
                            AuditoriaDtHr();
                            auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                            abstractClasse.Email_logon = txtemail.Text;
                            frmTelaADMMenu menuadm = new frmTelaADMMenu();
                            Visible = false;
                            menuadm.ShowDialog();
                            this.Close();
                        }
                    }
                    if (idtp == 2)
                    {
                        if (login.pesquisaPrimeiraEntrada(txtemail.Text) == true && idtp == 2)
                        {
                            //primeira entrada, Func
                            tabelamod = "Usuario"; descricao = "Logou na conta";
                            AuditoriaDtHr();
                            auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                            abstractClasse.Email_logon = txtemail.Text;
                            Visible = false;
                            frmTelaTrocarSenhaPrimeiraEntrada upFirstSenha = new frmTelaTrocarSenhaPrimeiraEntrada();
                            upFirstSenha.ShowDialog();
                            Close();
                        }
                        else
                        {
                            //Func se logou
                            tabelamod = "Usuario"; descricao = "Logou na conta";
                            AuditoriaDtHr();
                            auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                            abstractClasse.Email_logon = txtemail.Text;
                            Visible = false;
                            frmTelaFuncMenu menuFunc = new frmTelaFuncMenu();
                            menuFunc.ShowDialog();
                            Close();
                        }
                    }
                }
            }
            catch { }
        }

        private void lnkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //label Link para a tela de esqueceu sua senha
            Visible = false;
            frmTelaLoginEsqueceuSenha trocarsenha = new frmTelaLoginEsqueceuSenha();
            trocarsenha.ShowDialog();
            Close();
        }

        public void visibleTrue()
        {
            //evento que apresenta os * de erro, a pergunta e resposta secreta
            lblrespostasec.Visible = true;
            lblpergsec.Visible = true;
            txtrespsec.Visible = true;
            cmbPerguntaSecreta.Visible = true;
        }

        public void VariaveisAbstracts()
        {
            //registrando o tipo e o id do usuario que logou
            idtp = login.Id_tusu;
            id_usu = login.Id_usu;
            abstractClasse.Id_tipologon = idtp;
            abstractClasse.Id_logon = id_usu;
        }

        public void AuditoriaDtHr()
        {
            //evento que define a data e hora atual
            data = DateTime.Now.ToString("yyyy/MM/dd");
            hora = DateTime.Now.ToString("HH:mm");
        }

        public void DirtórioIMG()
        {
            //evento que pega o diretória onde as img tem que ser salvas
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string path2 = path.Remove(path.LastIndexOf("\\"));
            path = path2.Remove(path2.LastIndexOf("\\"));
            path2 = path.Remove(path.LastIndexOf("\\"));
            path = path2 + "\\img\\uploaded\\";
             
            abstractClasse.LocalIMG = path;
        }

        public void DiretórioBackup()
        {
            //evento que pega o diretória onde os Backup tem que ser salvos
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string path2 = path.Remove(path.LastIndexOf("\\"));
            path = path2.Remove(path2.LastIndexOf("\\"));
            path2 = path.Remove(path.LastIndexOf("\\"));
            path = path2 + "\\Backup\\";

            abstractClasse.LocalBackup = path;
        }

        public void SenhaExpirada()
        {
            senhasAntigas.IDlogonParaVerSenhaExpiradaDoPrimeiroADM(txtemail.Text);
            abstractClasse.Id_logon = senhasAntigas.Id_usu;
            if(senhasAntigas.SenhaExpirada() == true)
            {
                senhasAntigas.VoltarPrimeiraEntrada(txtemail.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite seu Email para Logar");
            }
        }

        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite sua senha que foi enviada para seu email ou" + "\r\n" + "a senha que você criou");
            }
        }

        private void cmbPerguntaSecreta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Escolha a pergunta secreta que você escolheu" + "\r\n" + "caso não tenha escolhido ainda, não escolha nenhuma");
            }
        }

        private void txtrespsec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite sua resposta secreta" + "\r\n" + "caso não tenha uma ainda, não digite nada");
            }
        }
    }
}
