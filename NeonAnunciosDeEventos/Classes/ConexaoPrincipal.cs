using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace NeonAnunciosDeEventos
{
        abstract class ConexaoPrincipal
        {
            static MySqlConnection conectar;

            public static MySqlConnection Conectar
            {
                get { return ConexaoPrincipal.conectar; }
                set { ConexaoPrincipal.conectar = value; }
            }

            public static Boolean criar_Conexao()
            {
                // verificando se existe uma conexão, fecha esta conexão
                if (conectar != null)
                {
                    conectar.Close();
                }

                // serve para configurar os parametros do banco de dados
                string configuracao = string.Format("server={0};user id={1}; password={2};database=mysql; pooling=false", abstractClasse.Ip,abstractClasse.Usuario,abstractClasse.Senha);
                //abstractClasse.Ip, abstractClasse.Usuario, abstractClasse.Senha);

                // tenta estabelecer conectar
                try
                {
                    conectar = new MySqlConnection(configuracao);
                    conectar.Open();
                }// caso não consiga exibe erro de conexão
                catch (MySqlException erro)
                {
                    return false;
                }

                // criar um banco em branco na memória
                MySqlDataReader banco = null;

                // fazer uso do banco escolhido
                MySqlCommand usar = new MySqlCommand("use neonae", conectar);

                // tenta criar o banco
                try
                {
                    banco = usar.ExecuteReader();
                }// caso ocorra erro
                catch (MySqlException erro)
                {
                    return false;
                }// no fim fecha
                finally
                {
                    if (banco != null)
                    {
                        banco.Close();
                    }
                }

                return true;
            }
        }
    }

