using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Xml;  
using System.Xml.Linq;


namespace NeonAnunciosDeEventos
{
  abstract class Conexao
    {
        static MySqlConnection conectar;
        static MySqlDataReader banco = null;
        static MySqlCommand usar;

        public static MySqlConnection Conectar
        {
            get { return Conexao.conectar; }
            set { Conexao.conectar = value; }
        }

        public static String criar_Conexao()
        {
            if (conectar != null)
            {
                conectar.Close();
            }

            string configuracao = string.Format("server={0};user id={1}; password={2};database=mysql; pooling=true", abstractClasse.Ip, abstractClasse.Usuario, abstractClasse.Senha);

            try
            {
                conectar = new MySqlConnection(configuracao);
                conectar.Open();
            }
            catch (MySqlException erro)
            {
                return ("Erro ao conectar - Verificar se o micro principal está ligado");
            }
            
            usar = new MySqlCommand("use base_correios", conectar);

            try
            {
                banco = usar.ExecuteReader();
            }
            catch (MySqlException erro)
            {
                return ("Erro ao conectar - Verificar se o micro principal está ligado");
            }
            finally
            {
                if (banco != null)
                {
                    banco.Close();
                }
            }
            return ("Conexão OK!!!");
        }

        public static void fechar()
        {
            conectar.Close();
            banco.Close();
        }     

    }
}
