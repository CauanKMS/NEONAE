
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace NeonAnunciosDeEventos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                StreamReader arq = new StreamReader(@Application.StartupPath + "\\Config.txt");

                abstractClasse.Ip = arq.ReadLine();
                abstractClasse.Usuario = arq.ReadLine();
                abstractClasse.Senha = arq.ReadLine();

                arq.Close();

                if (ConexaoPrincipal.criar_Conexao() == false)
                {
                    Application.Run(new frmTelaConexao());
                }
                else
                {
                    Application.Run(new frmTelaSplash());
                }
            }
            catch { }
        }
    }
}
