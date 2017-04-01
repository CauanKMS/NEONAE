using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace NeonAnunciosDeEventos
{
    class acessoFunc
    {
        #region CarregarFunc
        string nome, dataTela, email, senha, numcasa, cel, sx, img, rg, cpf, cep, comp, pergsec, respsec;
        int id_usu;

        public int Id_usu
        {
            get { return id_usu; }
            set { id_usu = value; }
        }

        public string Numcasa
        {
            get { return numcasa; }
            set { numcasa = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string DataTela
        {
            get { return dataTela; }
            set { dataTela = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Cel
        {
            get { return cel; }
            set { cel = value; }
        }

        public string Sx
        {
            get { return sx; }
            set { sx = value; }
        }

        public string Img
        {
            get { return img; }
            set { img = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Comp
        {
            get { return comp; }
            set { comp = value; }
        }

        public string Pergsec
        {
            get { return pergsec; }
            set { pergsec = value; }
        }

        public string Respsec
        {
            get { return respsec; }
            set { respsec = value; }
        }
        #endregion

        #region EXevento
        int id_even;

        public int Id_even
        {
            get { return id_even; }
            set { id_even = value; }
        }

        #endregion

        #region Primeiraentrada_usu
        int primeiraentrada_usu;

        public int Primeiraentrada_usu
        {
            get { return primeiraentrada_usu; }
            set { primeiraentrada_usu = value; }
        }

        #endregion

        Criptografia cripto = new Criptografia("NEON");

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

        public void fechar()
        {
            ConexaoPrincipal.Conectar.Close();
        }

        public Boolean carregarPerfil(string EmailP, string tipousu)
        {
            EmailP = cripto.Encrypt(EmailP);
            carregar_tabela("select nome_usu,dtnasc_usu,email_usu,senha_usu,cel_usu,sx_usu,img_usu,rg_usu,cpf_usu,cep_usu,numcasa_usu,compl_usu,pergsec_usu,respsec_usu from usuario where id_tusu='" + tipousu + "' and email_usu='" + EmailP + "' and ativo_usu='1'");

            if (tabela_memoria.Rows.Count != 0)
            {
                Nome = cripto.Decrypt(tabela_memoria.Rows[0]["nome_usu"].ToString());
                dataTela = cripto.Decrypt(tabela_memoria.Rows[0]["dtnasc_usu"].ToString());
                Email = cripto.Decrypt(tabela_memoria.Rows[0]["email_usu"].ToString());
                Senha = cripto.Decrypt(tabela_memoria.Rows[0]["senha_usu"].ToString());
                Cel = cripto.Decrypt(tabela_memoria.Rows[0]["cel_usu"].ToString());
                Sx = cripto.Decrypt(tabela_memoria.Rows[0]["sx_usu"].ToString());
                Img = cripto.Decrypt(tabela_memoria.Rows[0]["img_usu"].ToString());
                Rg = cripto.Decrypt(tabela_memoria.Rows[0]["rg_usu"].ToString());
                Cpf = cripto.Decrypt(tabela_memoria.Rows[0]["cpf_usu"].ToString());
                Cep = cripto.Decrypt(tabela_memoria.Rows[0]["cep_usu"].ToString());
                Numcasa = cripto.Decrypt(tabela_memoria.Rows[0]["numcasa_usu"].ToString());
                Comp = cripto.Decrypt(tabela_memoria.Rows[0]["compl_usu"].ToString());
                Pergsec = cripto.Decrypt(tabela_memoria.Rows[0]["pergsec_usu"].ToString());
                Respsec = cripto.Decrypt(tabela_memoria.Rows[0]["respsec_usu"].ToString());

                return true;
            }
            else
            {
                return false;
            }
        }

        public void update(string nome, string dataTela, string email, string senha, string cel, string sx, string img, string rg, string cep, string numcasa, string comp, string pergsec, string respsec)
        {
            nome = cripto.Encrypt(nome);
            dataTela = cripto.Encrypt(dataTela);
            email = cripto.Encrypt(email);
            senha = cripto.Encrypt(senha);
            cel = cripto.Encrypt(cel);
            sx = cripto.Encrypt(sx);
            img = cripto.Encrypt(img);
            rg = cripto.Encrypt(rg);
            cep = cripto.Encrypt(cep);
            numcasa = cripto.Encrypt(numcasa);
            comp = cripto.Encrypt(comp);
            pergsec = cripto.Encrypt(pergsec);
            respsec = cripto.Encrypt(respsec);
            try
            {
                carregar_tabela("update usuario set nome_usu='" + nome + "',dtnasc_usu='" + dataTela + "',email_usu='"+email+"',senha_usu='" + senha + "',cel_usu='" + cel.Replace(",", ".") + "',sx_usu='" + sx + "',img_usu='" + img + "',rg_usu='" + rg.Replace(",", ".") + "',cep_usu='" + cep.Replace(",", ".") + "',numcasa_usu='" + numcasa + "',compl_usu='" + comp + "', pergsec_usu='" + pergsec + "', respsec_usu='" + respsec + "' where id_usu='" + abstractClasse.Id_logon + "'");
            }
            catch
            {
            }
        }
        public void DesativaConta()
        {
            carregar_tabela("update usuario set ativo_usu='0' where id_usu='"+abstractClasse.Id_logon+"'");
        }
    }
}
