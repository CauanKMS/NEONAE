using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace NeonAnunciosDeEventos
{
    class acessoAuditoria
    {
        #region variaveis

        int id_auda, id_adm;
        string tabelamod_adm, desc_adm, hora_adm, data_adm;

        public string Tabelamod_adm
        {
            get
            {
                return tabelamod_adm;
            }

            set
            {
                tabelamod_adm = value;
            }
        }

        public string Desc_adm
        {
            get
            {
                return desc_adm;
            }

            set
            {
                desc_adm = value;
            }
        }

        public string Hora_adm
        {
            get
            {
                return hora_adm;
            }

            set
            {
                hora_adm = value;
            }
        }

        public string Data_adm
        {
            get
            {
                return data_adm;
            }

            set
            {
                data_adm = value;
            }
        }

        public int Id_auda
        {
            get
            {
                return id_auda;
            }

            set
            {
                id_auda = value;
            }
        }

        public int Id_adm
        {
            get
            {
                return id_adm;
            }

            set
            {
                id_adm = value;
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

        //cadastrar auditoria do adm
        public void cadAudAdm(int id_usu, string tabelamod, string descricao, string hora, string data)
        {
            carregar_tabela("insert into aud_adm values(0,'" + id_usu + "','" + tabelamod + "','" + descricao + "','" + hora + "','" + data + "')");
        }

        //cadastrar auditoria do funcionario
        public void cadAudFunc(int id_usu, string tabelamod, string descricao, string hora, string data)
        {
            carregar_tabela("insert into aud_func values(0,'" + id_usu + "','" + tabelamod + "','" + descricao + "','" + hora + "','" + data + "')");
        }

        public DataTable pesqAuditoriaAdm(string pesqAud)//auditoria do adm
        {
            DataTable tabelaTemp = new DataTable();

            tabelaTemp.Columns.Add("id_auda", typeof(int));
            tabelaTemp.Columns.Add("id_adm", typeof(int));
            tabelaTemp.Columns.Add("tabelamod_adm", typeof(String));
            tabelaTemp.Columns.Add("desc_adm", typeof(String));
            tabelaTemp.Columns.Add("hora_adm", typeof(String));
            tabelaTemp.Columns.Add("data_adm", typeof(String));

            carregar_tabela("select * from aud_adm aadm inner join usuario u on u.id_usu=aadm.id_adm where u.id_usu='"+pesqAud+"' and u.ativo_usu='1'");

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = tabelaTemp.NewRow();

                linha["id_auda"] = tabela_memoria.Rows[i]["id_auda"].ToString();
                linha["id_adm"] = tabela_memoria.Rows[i]["id_adm"].ToString();
                linha["tabelamod_adm"] = tabela_memoria.Rows[i]["tabelamod_adm"].ToString();
                linha["desc_adm"] = tabela_memoria.Rows[i]["desc_adm"].ToString();
                linha["hora_adm"] = tabela_memoria.Rows[i]["hora_adm"].ToString();
                linha["data_adm"] = tabela_memoria.Rows[i]["data_adm"].ToString();

                tabelaTemp.Rows.Add(linha);
            }
            return tabelaTemp;
        }
        public DataTable pesqAuditoriaFunc(string pesqAud)//auditoria do funcionario
        {
            DataTable tabelaTemp = new DataTable();

            tabelaTemp.Columns.Add("id_audf", typeof(int));
            tabelaTemp.Columns.Add("id_func", typeof(int));
            tabelaTemp.Columns.Add("tabelamod_func", typeof(String));
            tabelaTemp.Columns.Add("desc_func", typeof(String));
            tabelaTemp.Columns.Add("hora_func", typeof(String));
            tabelaTemp.Columns.Add("data_func", typeof(String));

            carregar_tabela("select * from aud_func afunc inner join usuario u on u.id_usu=afunc.id_func where u.id_usu='" + pesqAud + "' and u.ativo_usu='1'");

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = tabelaTemp.NewRow();

                linha["id_audf"] = tabela_memoria.Rows[i]["id_audf"].ToString();
                linha["id_func"] = tabela_memoria.Rows[i]["id_func"].ToString();
                linha["tabelamod_func"] = tabela_memoria.Rows[i]["tabelamod_func"].ToString();
                linha["desc_func"] = tabela_memoria.Rows[i]["desc_func"].ToString();
                linha["hora_func"] = tabela_memoria.Rows[i]["hora_func"].ToString();
                linha["data_func"] = tabela_memoria.Rows[i]["data_func"].ToString();

                tabelaTemp.Rows.Add(linha);
            }
            return tabelaTemp;
        }

        public DataTable pesqAuditoriaUsu(string pesqAud)//auditoria do usuario
        {
            DataTable tabelaTemp = new DataTable();

            tabelaTemp.Columns.Add("id_audu", typeof(int));
            tabelaTemp.Columns.Add("id_usu", typeof(int));
            tabelaTemp.Columns.Add("tabelamod_usu", typeof(String));
            tabelaTemp.Columns.Add("desc_usu", typeof(String));
            tabelaTemp.Columns.Add("hora_usu", typeof(String));
            tabelaTemp.Columns.Add("data_usu", typeof(String));

            carregar_tabela("select * from aud_usu ausu inner join usuario u on u.id_usu=ausu.id_usu where u.id_usu='" + pesqAud + "' and u.ativo_usu='1'");

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = tabelaTemp.NewRow();

                linha["id_audu"] = tabela_memoria.Rows[i]["id_audu"].ToString();
                linha["id_usu"] = tabela_memoria.Rows[i]["id_usu"].ToString();
                linha["tabelamod_usu"] = tabela_memoria.Rows[i]["tabelamod_usu"].ToString();
                linha["desc_usu"] = tabela_memoria.Rows[i]["desc_usu"].ToString();
                linha["hora_usu"] = tabela_memoria.Rows[i]["hora_usu"].ToString();
                linha["data_usu"] = tabela_memoria.Rows[i]["data_usu"].ToString();

                tabelaTemp.Rows.Add(linha);
            }
            return tabelaTemp;
        }

        public DataTable pesqAuditoriaEmp(string pesqAud)//auditoria da empresa
        {
            DataTable tabelaTemp = new DataTable();

            tabelaTemp.Columns.Add("id_aude", typeof(int));
            tabelaTemp.Columns.Add("id_emp", typeof(int));
            tabelaTemp.Columns.Add("tabelamod_emp", typeof(String));
            tabelaTemp.Columns.Add("desc_emp", typeof(String));
            tabelaTemp.Columns.Add("hora_emp", typeof(String));
            tabelaTemp.Columns.Add("data_emp", typeof(String));

            carregar_tabela("select * from aud_emp aemp inner join cliente_emp clie on clie.id_emp=aemp.id_emp where clie.id_emp='" + pesqAud + "' and clie.ativo_emp='1'");

            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                DataRow linha = tabelaTemp.NewRow();

                linha["id_aude"] = tabela_memoria.Rows[i]["id_aude"].ToString();
                linha["id_emp"] = tabela_memoria.Rows[i]["id_emp"].ToString();
                linha["tabelamod_emp"] = tabela_memoria.Rows[i]["tabelamod_emp"].ToString();
                linha["desc_emp"] = tabela_memoria.Rows[i]["desc_emp"].ToString();
                linha["hora_emp"] = tabela_memoria.Rows[i]["hora_emp"].ToString();
                linha["data_emp"] = tabela_memoria.Rows[i]["data_emp"].ToString();

                tabelaTemp.Rows.Add(linha);
            }
            return tabelaTemp;
        }
    }
}
