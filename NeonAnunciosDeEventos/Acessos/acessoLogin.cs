using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeonAnunciosDeEventos
{
    class acessoLogin
    {
        Criptografia cripto = new Criptografia("NEON");

        #region login

        int id_usu, id_tusu;
        string email_usu, senha_usu, pergsec_usu,respsec_usu, primeiraentrada_usu, nome_usu;

        public string Primeiraentrada_usu
        { 
            get { return Primeiraentrada_usu; }
            set { Primeiraentrada_usu = value; }
        }

        public string Pergsec_usu
        {
            get { return pergsec_usu; }
            set { pergsec_usu = value; }
        }

        public string Respsec_usu
        {
            get { return respsec_usu; }
            set { respsec_usu = value; }
        }

        public int Id_tusu
        {
            get { return id_tusu; }
            set { id_tusu = value; }
        }

        public int Id_usu
        {
            get { return id_usu; }
            set { id_usu = value; }
        }

        public string Senha_usu
        {
            get { return Senha_usu; }
            set { Senha_usu = value; }
        }

        public string Email_usu
        {
            get { return Email_usu; }
            set { Email_usu = value; }
        }

        public string Nome_usu
        {
            get
            {
                return nome_usu;
            }

            set
            {
                nome_usu = value;
            }
        }
        #endregion

        // variaveis para acessar o MySql
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        // método private de acesso ao BD
        private void carregar_tabela(string comando)
        {
            // criar uma sacolinha vazia
            tabela_memoria = new DataTable();

            // converter um texto (string) para um comando SQL
            comando_sql = new MySqlDataAdapter(comando, ConexaoPrincipal.Conectar);

            // executar o comando SQL 
            executar_comando = new MySqlCommandBuilder(comando_sql);

            // resposta que será armazenada na sacolinha
            comando_sql.Fill(tabela_memoria);

        }


        //metodo pesquisa
        public Boolean pesquisalogin(string email_usu, string senha_usu)
        {
            //login sem pergunta secreta
            email_usu = cripto.Encrypt(email_usu);
            senha_usu = cripto.Encrypt(senha_usu);
            carregar_tabela("select * from usuario where email_usu='" + email_usu + "' and senha_usu='" + senha_usu +"' and ativo_usu='1'");

            try
            {
                id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_usu"].ToString());
                id_tusu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tusu"].ToString());
                email_usu = cripto.Decrypt(tabela_memoria.Rows[0]["email_usu"].ToString());
                senha_usu = cripto.Decrypt(tabela_memoria.Rows[0]["senha_usu"].ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean pesqrespsec(string email_usu, string senha_usu,string pergsec_usu,string respsec_usu)
        {
            //login com pergunta secreta
            email_usu = cripto.Encrypt(email_usu);
            senha_usu = cripto.Encrypt(senha_usu);
            pergsec_usu = cripto.Encrypt(pergsec_usu);
            respsec_usu = cripto.Encrypt(respsec_usu);
            carregar_tabela("select * from usuario where email_usu='" + email_usu + "' and senha_usu='" + senha_usu + "' and pergsec_usu='" + pergsec_usu + "' and respsec_usu='" + respsec_usu + "' and ativo_usu='1'");

            try
            {
                id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_usu"].ToString());
                id_tusu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tusu"].ToString());
                email_usu = cripto.Decrypt(tabela_memoria.Rows[0]["email_usu"].ToString());
                senha_usu = cripto.Decrypt(tabela_memoria.Rows[0]["senha_usu"].ToString());
                pergsec_usu = cripto.Decrypt(tabela_memoria.Rows[0]["pergsec_usu"].ToString());
                respsec_usu = cripto.Decrypt(tabela_memoria.Rows[0]["respsec_usu"].ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean pesquisaPrimeiraEntrada(string pesq)
        {
            //pesquisa pra verificar se é a primeira entrada do usuário
            pesq = cripto.Encrypt(pesq);
            carregar_tabela("select * from usuario where email_usu='" + pesq + "' and primeiraentrada_usu='0' and ativo_usu='1'");

            if (tabela_memoria.Rows.Count != 0)
            {
                try
                {
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Boolean VerificarEmailExistente(string VerificacaoEmail, string VerificacaoCpf)
        {
            //verificando se o email digitado é cadastrado
            VerificacaoEmail = cripto.Encrypt(VerificacaoEmail);
            VerificacaoCpf = cripto.Encrypt(VerificacaoCpf);
            try
            {
                carregar_tabela("select id_usu,email_usu,cpf_usu,nome_usu from usuario where email_usu='"+ VerificacaoEmail +"' and cpf_usu='"+VerificacaoCpf+"' and ativo_usu='1'");
                id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_usu"].ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void VoltarPrimeiraEntrada(int idPessoa,string senha)
        {
            senha = cripto.Encrypt(senha);
            //voltando pra primeira entrada
            carregar_tabela("update usuario set primeiraentrada_usu='0', senha_usu='"+senha+"' where id_usu='"+ idPessoa +"'");
        }
    }
}
