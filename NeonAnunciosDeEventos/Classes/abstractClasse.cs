using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeonAnunciosDeEventos
{
    static class abstractClasse
    {
        #region Variáveis Abstratas

        #region Variaveis de IP

        static string ip, usuario, senha;

        public static string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public static string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public static string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        #endregion

        static string email_logon, nome_logon, localIMG, localBackup, dataBackup;
        static int id_logon, id_tipologon, id_usuPesq, id_even;
        static string ClickGridListaFuncAdm, ClickGridListaEmpUsu, ClickTipo, ClickGridEvento,cpf_valido;

        public static string DataBackup
        {
            get { return dataBackup; }
            set { dataBackup = value; }
        }
        public static string LocalBackup
        {
            get { return localBackup; }
            set { localBackup = value; }
        }
        public static string ClickGridEvento1
        {
            get { return ClickGridEvento; }
            set { ClickGridEvento = value; }
        }
        public static string Nome_logon
        {
            get { return nome_logon; }
            set { nome_logon = value; }
        }
        public static string Email_logon
        {
            get { return email_logon; }
            set { email_logon = value; }
        }

        public static int Id_logon
        {
            get { return id_logon; }
            set { id_logon = value; }
        }
        public static int Id_tipologon
        {
            get { return id_tipologon; }
            set { id_tipologon = value; }
        }
        public static int Id_usuPesq
        {
            get
            {
                return id_usuPesq;
            }

            set
            {
                id_usuPesq = value;
            }
        }

        public static int Id_even
        {
            get
            {
                return id_even;
            }

            set
            {
                id_even = value;
            }
        }

        public static string LocalIMG
        {
            get
            {
                return localIMG;
            }

            set
            {
                localIMG = value;
            }
        }

        public static string Cpf_valido
        {
            get
            {
                return cpf_valido;
            }

            set
            {
                cpf_valido = value;
            }
        }

        public static string ClickGridListaFuncAdm1
        {
            get
            {
                return ClickGridListaFuncAdm;
            }

            set
            {
                ClickGridListaFuncAdm = value;
            }
        }

        public static string ClickGridListaEmpUsu1
        {
            get
            {
                return ClickGridListaEmpUsu;
            }

            set
            {
                ClickGridListaEmpUsu = value;
            }
        }

        public static string ClickTipo1
        {
            get
            {
                return ClickTipo;
            }

            set
            {
                ClickTipo = value;
            }
        }

        #endregion
    }
}
