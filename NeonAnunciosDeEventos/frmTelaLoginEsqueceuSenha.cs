using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaLoginEsqueceuSenha : Form
    {
        #region acessos
        acessoLogin login = new acessoLogin();
        acessoADM adm = new acessoADM();
        acessoAuditoria aud = new acessoAuditoria();
        #endregion

        #region Variáveis Globais
        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;
        string senha;
        int id;
        #endregion

        public frmTelaLoginEsqueceuSenha()
        {
            InitializeComponent();
        }
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if(txtemail.Text == string.Empty || mskConfCpf.Text == string.Empty)
            {
                MessageBox.Show("Digite as respectivas informações nos Campos não Preenchidos");
            }
            else if (login.VerificarEmailExistente(txtemail.Text,mskConfCpf.Text) == true)//evento que verifica se o email e o cpf é cadastrado e se ele é ativo ativo
            {
                id = login.Id_usu;

                //criar uma senha aleatória pra enviar pro email
                senha = adm.CreatePassword(7);

                //enviando o email
                Email.EsqSenha(txtemail.Text,login.Nome_usu,senha);

                //atualizar as informações do usuario voltando a primeiraentrada pra 0 e
                // alterando a senha para a criada aleatóriamente, para que o seja possivel logar
                login.VoltarPrimeiraEntrada(id, senha);

                //evento que pega data e hora
                AuditoriaDtHr();
                tabelamod = "Usuario"; descricao = "enviou uma nova senha para o email pois esqueceu sua senha";
                //criando auditoria
                aud.cadAudAdm(id, tabelamod, descricao, hora, data);

                //voltando a TelaLogin
                Visible = false;
                frmTelaLogin Telalogin = new frmTelaLogin();
                Telalogin.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Email ou Cpf não cadastrados!" + "\r\n" + "Digite um email Válido para obter uma nova senha");
            }
        }

        public void AuditoriaDtHr()
        {
            data = DateTime.Now.ToShortDateString();
            hour = DateTime.Now.Hour.ToString();
            minute = DateTime.Now.Minute.ToString();
            minuto = Convert.ToInt32(minute);
            if (minuto >= 0 && minuto < 10)
                minute = "0" + minute;
            hora = hour + ":" + minute;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaLogin login = new frmTelaLogin();
            login.ShowDialog();
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mskConfCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //travando para que seja digitado apenas números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
