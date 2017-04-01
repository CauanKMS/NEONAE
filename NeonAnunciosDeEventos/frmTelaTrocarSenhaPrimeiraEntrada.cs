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
    public partial class frmTelaTrocarSenhaPrimeiraEntrada : Form
    {
        #region acessos
        acessoSenhasAntigas senhasAntigas = new acessoSenhasAntigas();
        acessoFunc func = new acessoFunc();
        acessoADM adm = new acessoADM();
        acessoLogin login = new acessoLogin();
        acessoAuditoria aud = new acessoAuditoria();
        #endregion

        #region Variáveis Globais
        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;
        #endregion

        public frmTelaTrocarSenhaPrimeiraEntrada()
        {
            InitializeComponent();
        }

        private void frmTelaTrocarSenhaPrimeiraEntrada_Load(object sender, EventArgs e)
        {
            if (adm.CarregarPergRespSecPrimeiraEntrada(abstractClasse.Id_logon) == true)
            {
                txtrespsec.Text = adm.Respsec;
                cmbPerguntaSecreta.Text = adm.Pergsec;
            }
        }

        private void txtConfSenhaOld_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite a senha enviada para seu email");
        }

        private void txtNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("Digite uma nova senha media ou forte");
        }

        private void txtConfNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("confirme sua nova senha");
        }

        private void cmbPerguntaSecreta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("caso não tenha uma pergunta secreta, escolha uma");
        }

        private void txtrespsec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
                MessageBox.Show("caso não tenha uma senha secreta secreta, digite uma");
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            //campos das senhas vazias
            if (txtConfSenhaOld.Text == string.Empty || txtNovaSenha.Text == string.Empty || txtConfNovaSenha.Text == string.Empty)
            {
                MessageBox.Show("Por favor cadastre a sua nova senha antes de prosseguir");
            }
            //se os campos da pergunta e a resposta secreta foram preenchidos
            else if (cmbPerguntaSecreta.Text == string.Empty || txtrespsec.Text == string.Empty)
            {
                MessageBox.Show("Por Favor Preencha os campos da pegunta secreta e resposta secreta");
            }
            //verificando se a senha no campo de senha atual é a pertecente no bancco
            else if (senhasAntigas.SenhaCadastrada(txtConfSenhaOld.Text) == false)
            {
                MessageBox.Show("Senha não reconhecida como atual!"+"\r\n"+"Digite novamente");
            }
            //se as senhas são correspondentes
            else if(txtNovaSenha.Text != txtConfNovaSenha.Text)
            {
                MessageBox.Show("Senhas não correspondem");
            }
            //se o label que verifica se a senha é forte ou não, ou se foi digitado há quantidade mínima de caracteres
            else if (lblSenhaForte.Text != "Senha Fraca" && lblSenhaForte.Text != "Favor digitar outra senha com 6 caracteres no mínimo")
            {
                //ele verifica o tipo de usuário que fez o login
                //caso seja Func
                if (abstractClasse.Id_tipologon == 2)
                {
                  //verifica se há na tabela de senhas_old a senha digitada 
                  if (senhasAntigas.pesqSenhasOldPemicion(txtNovaSenha.Text) == true)
                  {
                     //pega hora e data que foi realizada essas ações
                     //registra na auditoria do usuário
                     AuditoriaDtHr();
                     tabelamod = "Usuário"; descricao = "Alterou a senha que foi enviada por email";
                     aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                     tabelamod = "Senhas_old"; descricao = "Inceriu uma senha desigual das demais";
                     aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                     tabelamod = "Usuário"; descricao = "Atualizou a pergunta e resposta secreta de seu perfil";
                     aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                     //adiciona ou atualiza os dados do Funcionário
                     adm.UpdatePergSec(cmbPerguntaSecreta.Text , txtrespsec.Text);
                     //adiciona ou atuliza á tabela de senhas_old
                     senhasAntigas.senhas_antigas(txtNovaSenha.Text);

                     //vai para o menu do Funcionário
                     Visible = false;
                     frmTelaFuncMenu menufunc = new frmTelaFuncMenu();
                     menufunc.ShowDialog();
                     Close();
                  }
                  else
                  {
                      //caso essa senha já pertença a tabela de senhas_old
                      MessageBox.Show("Senha Já Cadastrada Recentemente!");
                  }
                }
                if (abstractClasse.Id_tipologon == 1)
                {
                   //verifica se há na tabela de senhas_old a senha digitada
                   if (senhasAntigas.pesqSenhasOldPemicion(txtNovaSenha.Text) == true)
                   {
                       //pega hora e data que foi realizada essas ações
                       //registra na auditoria do usuário
                       AuditoriaDtHr();
                       tabelamod = "Usuário"; descricao = "Alterou a senha que foi enviada por email";
                       aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                       tabelamod = "Senhas_old"; descricao = "Inceriu uma senha desigual das demais";
                       aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                       tabelamod = "Usuário"; descricao = "Atualizou a pergunta e resposta secreta de seu perfil";
                       aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                       //adiciona ou atualiza os dados do Administrador
                       adm.UpdatePergSec(cmbPerguntaSecreta.Text, txtrespsec.Text);
                       //adiciona ou atuliza á tabela de senhas_old
                       senhasAntigas.senhas_antigas(txtNovaSenha.Text);
                       //vai para o menu do Administrador
                       Visible = false;
                       frmTelaADMMenu menuadm = new frmTelaADMMenu();
                       menuadm.ShowDialog();
                       Close();
                    }
                    else
                    {
                       //caso essa senha já pertença a tabela de senhas_old
                       MessageBox.Show("Senha Já Cadastrada Recentemente!");
                    }
                }
            }
        }

        public void AuditoriaDtHr()
        {
            //evento que define a data e hora atual
            data = DateTime.Now.ToString("yyyy/MM/dd");
            hora = DateTime.Now.ToString("HH:mm");
        }

        private void txtSenhaAtual_TextChanged(object sender, EventArgs e)
        {
            int qtdLetras;
            int qtdLetMai = 0, qtdLetMin = 0, qtdNum = 0, qtdCar = 0;

            qtdLetras = txtNovaSenha.Text.Length;

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
                    if (char.IsLower(txtNovaSenha.Text[i]))
                    {
                        qtdLetMin++;
                    }
                    else
                    {
                        if (char.IsUpper(txtNovaSenha.Text[i]))
                        {
                            qtdLetMai = qtdLetMai + 1;
                        }
                        else
                        {
                            if (char.IsNumber(txtNovaSenha.Text[i]))
                            {
                                qtdNum++;
                            }
                            else
                            {
                                if (!char.IsWhiteSpace(txtNovaSenha.Text[i]))
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
        }//Força Da Senha

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
