using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace NeonAnunciosDeEventos
{
    class acessoSenhasAntigas
    {
        Criptografia cripto = new Criptografia("NEON");

        #region Variáveis
        string data_old;
        int id_usu;

        public int Id_usu
        {
            get { return id_usu; }
            set { id_usu = value; }
        }
        public string Data_old
        {
            get
            {
                return data_old;
            }

            set
            {
                data_old = value;
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
            //fechar();
            ConexaoPrincipal.criar_Conexao();
            // criar uma sacolinha vazia
            tabela_memoria = new DataTable();
            // converter um texto (string) para um comando SQL
            comando_sql = new MySqlDataAdapter(comando, ConexaoPrincipal.Conectar);
            // executar o comando SQL 
            executar_comando = new MySqlCommandBuilder(comando_sql);
            // resposta que será armazenada na sacolinha
            comando_sql.Fill(tabela_memoria);
        }
        
        public Boolean senhas_antigas(string Senha)
        {
            //data em que a senha está sendo alterada
            string data_venc;

            data_venc = DateTime.Now.ToShortDateString();

            data_old = (Convert.ToDateTime(data_venc.ToString()).AddMonths(6)).ToString();

            data_old = Convert.ToDateTime(data_old).ToShortDateString();

            data_old = cripto.Encrypt(data_old);
            //a senha chega, é criptografada
            Senha = cripto.Encrypt(Senha);
            //as senhas do usuário que está se logando é pesquisada
            carregar_tabela("select senha1_old,senha2_old,senha3_old from senhas_old inner join usuario on usuario.id_usu=senhas_old.id_usu where senhas_old.id_usu='" + abstractClasse.Id_logon + "'");
            //caso não haja senhas cadastradas
            if (tabela_memoria.Rows.Count == 0)
            {
                try
                {
                    //ele inseri há nova senha na tabela senhasOld,troca a primeira entrada pra 1 e atualiza pra nova senha

                    carregar_tabela("insert into senhas_old values(0,'" + abstractClasse.Id_logon + "','" + Senha + "','','','"+ data_old + "')");
                    carregar_tabela("update usuario set primeiraentrada_usu='1', senha_usu='" + Senha + "' where id_usu='" + abstractClasse.Id_logon + "'");
                    return true;
                }
                catch
                {return false;}
            }
            //se houver senha1_old, e as outras duas nulas
            if (tabela_memoria.Rows[0]["senha1_old"].ToString() != null && tabela_memoria.Rows[0]["senha2_old"].ToString() == null && tabela_memoria.Rows[0]["senha3_old"].ToString() == null)
            {
                try
                {
                    //a primeira senha vai pra segunda, a noca vai pra primeira,,troca a primeira entrada pra 1 e atualiza para nova senha
                    carregar_tabela("update senhas_old set senha2_old = senha1_old, senha1_old='" + Senha + "', data_old='" + data_old + "' where id_usu='" + abstractClasse.Id_logon + "'");
                    carregar_tabela("update usuario set primeiraentrada_usu='1', senha_usu='" + Senha + "' where id_usu='" + abstractClasse.Id_logon + "'");
                    return true;
                }
                catch
                {return false;}
            }
            //se a primeira e a segunda senha forem diferentes de nulo 
            if (tabela_memoria.Rows[0]["senha1_old"].ToString() != null && tabela_memoria.Rows[0]["senha2_old"].ToString() != null)
            {
                try
                {
                    //a segunda vai pra terceira, a primeira senha vai pra segunda, a noca vai pra primeira, troca a primeira entrada pra 1 e atualiza para nova senha
                    carregar_tabela("update senhas_old set senha3_old= senha2_old, senha2_old= senha1_old, senha1_old='" + Senha + "', data_old='" + data_old + "' where id_usu='" + abstractClasse.Id_logon + "'");
                    carregar_tabela("update usuario set primeiraentrada_usu='1', senha_usu='" + Senha + "' where id_usu='" + abstractClasse.Id_logon + "'");
                    return true;
                }
                catch
                {return false;}
            }
            else { return false; }

        }

        public Boolean pesqSenhasOldPemicion(string senha)//Permição para cadastrar nova senha
        {
            //criptografa a senha e verifica se a senha que irá ser cadastrada está na tabela de senhas_old
            senha = cripto.Encrypt(senha);
            carregar_tabela("select senha1_old,senha2_old,senha3_old from senhas_old inner join usuario on usuario.id_usu=senhas_old.id_usu where senhas_old.id_usu='" + abstractClasse.Id_logon + "'");
            try
            {
                if(tabela_memoria.Rows.Count == 0)
                {return true;}
                else if (tabela_memoria.Rows[0]["senha1_old"].ToString() != senha && tabela_memoria.Rows[0]["senha2_old"].ToString() != senha && tabela_memoria.Rows[0]["senha3_old"].ToString() != senha)
                {return true;}
                else
                {return false;}
            }
            catch { return false; }
        }

        public Boolean SenhaCadastrada(string senha)
        {
            cripto.Encrypt(senha);
            carregar_tabela("select senha_usu from usuario where id_usu='" + abstractClasse.Id_logon + "' and senha_usu='" + senha + "'");
            try
            {return true;}
            catch
            {return false;}
        }

        public void IDlogonParaVerSenhaExpiradaDoPrimeiroADM(string email)
        {
            try
            {
                email = cripto.Encrypt(email);
                carregar_tabela("select id_usu from usuario where email_usu='"+email+"'");
                id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_usu"].ToString());
            }
            catch
            {}
        }

        public Boolean SenhaExpirada()
        {
            try
            {
                DateTime dtNow;
                dtNow = System.DateTime.Now;
                dtNow = Convert.ToDateTime(dtNow.ToShortDateString());

                carregar_tabela("select senhas_old.data_old from senhas_old inner join usuario on senhas_old.id_usu=usuario.id_usu where usuario.id_usu='" + abstractClasse.Id_logon + "'");
                data_old = cripto.Decrypt(tabela_memoria.Rows[0]["data_old"].ToString());

                //DateTime dt = Convert.ToDateTime(data_old.ToString());

                if (dtNow >= Convert.ToDateTime(data_old))
                {return true;}
                else
                {return false;}
            }
            catch { return false; }
        }

        public void VoltarPrimeiraEntrada(string email)
        {
            email = cripto.Encrypt(email);
            carregar_tabela("update usuario set primeiraentrada_usu='0' where email_usu='"+email+"'");
        }
    }
}
