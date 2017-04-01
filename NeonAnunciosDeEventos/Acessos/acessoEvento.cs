using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace NeonAnunciosDeEventos
{
    class acessoEvento
    {
        #region Variáveis Encapsuladas
        int id_even;
        string descr_teve, descr_subt, tipo_st, nome_emp, nome_even, uf_even, cid_even, rua_even, numlocal_even, nomelocal_even, img_even, detalhes_even, ativo_even, email_emp;
        DateTime startdt_even, starthr_even, fimdt_even, fimhr_even;

        public string Email_emp
        {
            get { return email_emp; }
            set { email_emp = value; }
        }
        
        public DateTime Fimhr_even
        {
            get { return fimhr_even; }
            set { fimhr_even = value; }
        }

        public DateTime Fimdt_even
        {
            get { return fimdt_even; }
            set { fimdt_even = value; }
        }

        public DateTime Starthr_even
        {
            get { return starthr_even; }
            set { starthr_even = value; }
        }

        public DateTime Startdt_even
        {
            get { return startdt_even; }
            set { startdt_even = value; }
        }

        public int Id_even
        {
            get
            {
                return Id_even;
            }

            set
            {
                Id_even = value;
            }
        }

        public string Descr_teve
        {
            get
            {
                return descr_teve;
            }

            set
            {
                descr_teve = value;
            }
        }

        public string Descr_subt
        {
            get
            {
                return descr_subt;
            }

            set
            {
                descr_subt = value;
            }
        }

        public string Tipo_st
        {
            get
            {
                return tipo_st;
            }

            set
            {
                tipo_st = value;
            }
        }

        public string Nome_emp
        {
            get
            {
                return nome_emp;
            }

            set
            {
                nome_emp = value;
            }
        }

        public string Nome_even
        {
            get
            {
                return nome_even;
            }

            set
            {
                nome_even = value;
            }
        }

        public string Uf_even
        {
            get
            {
                return uf_even;
            }

            set
            {
                uf_even = value;
            }
        }

        public string Cid_even
        {
            get
            {
                return cid_even;
            }

            set
            {
                cid_even = value;
            }
        }

        public string Rua_even
        {
            get
            {
                return rua_even;
            }

            set
            {
                rua_even = value;
            }
        }

        public string Numlocal_even
        {
            get
            {
                return numlocal_even;
            }

            set
            {
                numlocal_even = value;
            }
        }

        public string Nomelocal_even
        {
            get
            {
                return nomelocal_even;
            }

            set
            {
                nomelocal_even = value;
            }
        }

        public string Img_even
        {
            get
            {
                return img_even;
            }

            set
            {
                img_even = value;
            }
        }

        public string Detalhes_even
        {
            get
            {
                return detalhes_even;
            }

            set
            {
                detalhes_even = value;
            }
        }

        public string Ativo_even
        {
            get
            {
                return ativo_even;
            }

            set
            {
                ativo_even = value;
            }
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

        public DataTable eventosNaoAuto()
        {
            DataTable tabelaTemp = new DataTable();
            DateTime hora = new DateTime();

            tabelaTemp.Columns.Add("id_even", typeof(int));
            tabelaTemp.Columns.Add("nome_even", typeof(String));
            tabelaTemp.Columns.Add("nome_emp", typeof(String));
            tabelaTemp.Columns.Add("descr_teve", typeof(String));
            tabelaTemp.Columns.Add("cid_even", typeof(String));
            tabelaTemp.Columns.Add("startdt_even", typeof(DateTime));
            tabelaTemp.Columns.Add("starthr_even", typeof(string));

            carregar_tabela("select e.id_even,e.nome_even,ce.nome_emp,te.descr_teve,e.cid_even,e.startdt_even,e.starthr_even from evento e inner join cliente_emp ce on ce.id_emp=e.id_emp inner join tipo_evento te on te.id_teve=e.id_teve where e.ativo_even='1'");

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = tabelaTemp.NewRow();

                linha["id_even"] = tabela_memoria.Rows[i]["id_even"].ToString();
                linha["nome_even"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_even"].ToString());
                linha["nome_emp"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_emp"].ToString());
                linha["descr_teve"] = cripto.Decrypt(tabela_memoria.Rows[i]["descr_teve"].ToString());
                linha["cid_even"] = cripto.Decrypt(tabela_memoria.Rows[i]["cid_even"].ToString());
                linha["startdt_even"] = tabela_memoria.Rows[i]["startdt_even"].ToString();
                hora = Convert.ToDateTime(tabela_memoria.Rows[i]["starthr_even"].ToString());
                linha["starthr_even"] = hora.ToShortTimeString();

                tabelaTemp.Rows.Add(linha);
            }
            return tabelaTemp;
        }
        public DataTable eventosFiltro(string PesqEven)
        {
            DataTable tabelaTemp = new DataTable();
            DateTime hora = new DateTime();

            tabelaTemp.Columns.Add("id_even", typeof(int));
            tabelaTemp.Columns.Add("nome_even", typeof(String));
            tabelaTemp.Columns.Add("nome_emp", typeof(String));
            tabelaTemp.Columns.Add("descr_teve", typeof(String));
            tabelaTemp.Columns.Add("cid_even", typeof(String));
            tabelaTemp.Columns.Add("startdt_even", typeof(DateTime));
            tabelaTemp.Columns.Add("starthr_even", typeof(string));

            carregar_tabela("select e.id_even,e.nome_even,ce.nome_emp,te.descr_teve,e.cid_even,e.startdt_even,e.starthr_even from evento e inner join cliente_emp ce on ce.id_emp=e.id_emp inner join tipo_evento te on te.id_teve=e.id_teve where e.ativo_even='1'");

            tabelaTemp.DefaultView.RowFilter = "nome_even like '" + PesqEven + "%'";

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = tabelaTemp.NewRow();

                linha["id_even"] = tabela_memoria.Rows[i]["id_even"].ToString();
                linha["nome_even"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_even"].ToString());
                linha["nome_emp"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_emp"].ToString());
                linha["descr_teve"] = cripto.Decrypt(tabela_memoria.Rows[i]["descr_teve"].ToString());
                linha["cid_even"] = cripto.Decrypt(tabela_memoria.Rows[i]["cid_even"].ToString());
                linha["startdt_even"] = tabela_memoria.Rows[i]["startdt_even"].ToString();
                hora = Convert.ToDateTime(tabela_memoria.Rows[i]["starthr_even"].ToString());
                linha["starthr_even"] = hora.ToShortTimeString();

                tabelaTemp.Rows.Add(linha);
            }
            return tabelaTemp;
        }

        public Boolean confirmarEvento(string nomeEvento)
        {
            nomeEvento = cripto.Encrypt(nomeEvento);
            carregar_tabela("select * from evento where nome_even='" + nomeEvento + "' and ativo_even='1'");
            try
            {
                id_even = Convert.ToInt32(tabela_memoria.Rows[0]["id_even"].ToString());
                carregar_tabela("update evento set ativo_even='2' where id_even='" + id_even + "'");
                return true;
            }
            catch
            {return false;}
        }

        public Boolean RecusaEvento(string nomeEvento)
        {
            nomeEvento = cripto.Encrypt(nomeEvento);
            carregar_tabela("select * from evento where nome_even='" + nomeEvento + "' and ativo_even='1'");
            try
            {
                id_even = Convert.ToInt32(tabela_memoria.Rows[0]["id_even"].ToString());
                abstractClasse.Id_even = id_even;
                carregar_tabela("update evento set ativo_even='0' where id_even='" + id_even + "'");
                return true;
            }
            catch
            {return false;}
        }

        public Boolean RecusouEmail(string motivo)
        {
            try
            {
                carregar_tabela("select * from evento ev inner join tipo_evento teve on teve.id_teve=ev.id_teve inner join subtipo_evento subt on subt.id_subt=ev.id_subt inner join status_evento st on st.id_st=ev.id_st inner join cliente_emp emp on emp.id_emp=ev.id_emp where id_even='" + abstractClasse.Id_even + "'");
                nome_emp = cripto.Decrypt(tabela_memoria.Rows[0]["nome_emp"].ToString());
                carregar_tabela("select email_emp from cliente_emp clie inner join evento ev on ev.id_emp=clie.id_emp where ev.id_even='"+abstractClasse.Id_even+"'");
                email_emp = cripto.Decrypt(tabela_memoria.Rows[0]["email_emp"].ToString());

                Email.RecusouEvento(email_emp, nome_emp, motivo);
                return true;
            }
            catch { return false; }
        }

        public Boolean pesqEvento(int pesqEvento)
        {
            carregar_tabela("select * from evento ev inner join tipo_evento teve on teve.id_teve=ev.id_teve inner join subtipo_evento subt on subt.id_subt=ev.id_subt inner join status_evento st on st.id_st=ev.id_st inner join cliente_emp emp on emp.id_emp=ev.id_emp where id_even='"+pesqEvento+"'");

            try
            {
                id_even = Convert.ToInt32(tabela_memoria.Rows[0]["id_even"].ToString());
                descr_teve = cripto.Decrypt(tabela_memoria.Rows[0]["descr_teve"].ToString());
                descr_subt = cripto.Decrypt(tabela_memoria.Rows[0]["descr_subt"].ToString());
                tipo_st = cripto.Decrypt(tabela_memoria.Rows[0]["tipo_st"].ToString());
                nome_emp = cripto.Decrypt(tabela_memoria.Rows[0]["nome_emp"].ToString());
                nome_even = cripto.Decrypt(tabela_memoria.Rows[0]["nome_even"].ToString());
                uf_even = cripto.Decrypt(tabela_memoria.Rows[0]["uf_even"].ToString());
                cid_even = cripto.Decrypt(tabela_memoria.Rows[0]["cid_even"].ToString());
                rua_even = cripto.Decrypt(tabela_memoria.Rows[0]["rua_even"].ToString());
                numlocal_even = cripto.Decrypt(tabela_memoria.Rows[0]["numlocal_even"].ToString());
                nomelocal_even = cripto.Decrypt(tabela_memoria.Rows[0]["nomelocal_even"].ToString());
                img_even = cripto.Decrypt(tabela_memoria.Rows[0]["img_even"].ToString());
                detalhes_even = cripto.Decrypt(tabela_memoria.Rows[0]["detalhes_even"].ToString());
                startdt_even = Convert.ToDateTime(tabela_memoria.Rows[0]["startdt_even"].ToString());
                starthr_even = Convert.ToDateTime(tabela_memoria.Rows[0]["starthr_even"].ToString());
                fimdt_even = Convert.ToDateTime(tabela_memoria.Rows[0]["fimdt_even"].ToString());
                fimhr_even = Convert.ToDateTime(tabela_memoria.Rows[0]["fimhr_even"].ToString());
                ativo_even = tabela_memoria.Rows[0]["ativo_even"].ToString();
                return true;
            }
            catch { return false; }
        }
    }
}
