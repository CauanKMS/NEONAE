using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaTrocarEmail : Form
    {
        acessoADM troca = new acessoADM();
        acessoAuditoria aud = new acessoAuditoria();

        #region Variáveis Globais
        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;
        #endregion

        public frmTelaTrocarEmail()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //minimiza o projeto
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //fecha a tela de esqueceu sua senha
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verifica campos nulos
            if(txtemail.Text == string.Empty || txtNovoEmail.Text == string.Empty || txtConfNovoEmail.Text == string.Empty)
            {
                MessageBox.Show("Preencha os Campos corretamente");
            }
            //verifica se esse email é cadstrado
            else if(troca.VerificarEmailPraTroca(txtemail.Text) == false)
            {
                MessageBox.Show("Esse Email não é o Email Cadastrado");
            }
            //verifica se o novo email condiz com sua confirmação
            else if (txtNovoEmail.Text != txtConfNovoEmail.Text)
            {
                MessageBox.Show("Novo Email não correspondente a sua confirmação");
            }
            else
            {
                //pergunta se ele realmente quer trocar de email
                DialogResult result;
                string senha;
                result = MessageBox.Show("Realmente deseja Trocar seu Email?", "Trocar Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //auditoria
                    AuditoriaDtHr();
                    tabelamod = "Usuário"; descricao = "Usuário desejou alterar seu Email";
                    aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    //auditoria
                    tabelamod = "Usuário"; descricao = "Foi cadastrado uma nova senha criado pelo software e enviado para o novo Email do Usuário";
                    aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    //atualiza o email do usuário
                    troca.TrocarEmail(txtNovoEmail.Text);

                    //cria uma senha aleatória pra enviar para o email
                    senha = troca.CreatePassword(7);

                    //atualiza a senha e coloca a primeiraentrada_usu=0
                    troca.SenhaEmail(senha);

                    //envia para o mais novo email
                    Email.CadConfSenha(txtNovoEmail.Text, abstractClasse.Nome_logon, senha);

                    MessageBox.Show("Seu Email foi trocado com Sucesso!" + "\r\n" + "Você será Deslogado e uma senha será Enviada para seu Email");

                    //vai pra tela de login
                    Visible = false;
                    frmTelaLogin login = new frmTelaLogin();
                    login.ShowDialog();
                    Close();
                }
            }
        }

        public void AuditoriaDtHr()
        {
            //evento que define a data e hora atual
            data = DateTime.Now.ToString("yyyy/MM/dd");
            hora = DateTime.Now.ToString("HH:mm");
        }
        private void frmTelaTrocarEmail_Load(object sender, EventArgs e)
        {

        }

        private void txtNovoEmail_Leave(object sender, EventArgs e)
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
    }
    
}
