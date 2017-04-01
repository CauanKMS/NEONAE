using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaADMBackup : Form
    {
        public static int minuto;
        public static string tabelamod, descricao,hour, minute, hora, data;

        public frmTelaADMBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\NeonBackupTemp"))
            {}
            else
            {
                Directory.CreateDirectory("c:\\NeonBackupTemp");
            }
            string path = "c:\\NeonBackupTemp";

            MysqlBackup_Restore(path, "backup");

            //corre uma thread com o processo que faz o backup ou restore
            System.Threading.Thread.Sleep(420);

            //quando executar fara o codigo seguinte
            //exemplo do path

            //corre uma thread com o processo que faz o backup ou restore
            Thread t = new Thread(delegate () {  MySqlProcess(path,"backup"); });
            t.Start();
        }

        //Metodo que cria o batch file com os comandos de backup ou restore
        private static void MysqlBackup_Restore(string path, string type)
        {
            //Caminho onde o mysql esta instalado
            string cmd = "\"C:/Arquivos de programas/MySQL/MySQL Server 5.1/bin/";

            //create a bath file to run the script database.
            StreamWriter sw = File.CreateText(path + "\\NeonAEBackup.cmd");
            //sw.WriteLine("c:");
            sw.WriteLine("c:");
            sw.WriteLine("cd\\");
            sw.WriteLine("cd " + cmd);

            string caminhoTemporario;
            string arquivoTemporario;

            if (type == "backup")
            {
                string dt = System.DateTime.Now.ToString().Replace("/", "_").Replace(":", "-").Replace(" ", "--");
                arquivoTemporario = "BackupNeonAE" + dt;
                caminhoTemporario = path + "\\BackupNeonAE" + dt + ".sql";
                arquivoTemporario = "BackupNeonAE" + dt;

                abstractClasse.DataBackup = dt;
                //se for backup
                sw.WriteLine("mysqldump.exe -uroot -pALUNOS --databases neonae > " + caminhoTemporario);
                sw.WriteLine("");
            }
            else
            {
                arquivoTemporario = "c:\\NeonBackupTemp\\restaurar.sql";
                //se for restore
                sw.WriteLine("mysql -uroot -pALUNOS < " + arquivoTemporario);
                sw.WriteLine("");
            }

            sw.Close();
        }

        private static void MySqlProcess(string Path, string tipo)
        {
            try
            {
                //cria o processo a correr o MySqlbackup.cmd
                Process.Start(Path + "\\NeonAEBackup.cmd");

                System.Threading.Thread.Sleep(420);
                if (tipo == "restore")
                {
                    System.Threading.Thread.Sleep(420);
                    File.Delete("c:\\NeonBackupTemp\\restaurar.sql");
                    File.Delete("c:\\NeonBackupTemp\\NeonAEBackup.cmd");

                    Directory.Delete("c:\\NeonBackupTemp");

                    acessoAuditoria aud = new acessoAuditoria();
                    AuditoriaDtHr();
                    tabelamod = "Nenhuma"; descricao = "Fez o restore do Banco de Dados do Projeto";
                    //criando auditoria
                    aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);
                }

                System.Threading.Thread.Sleep(420);
                if (tipo == "backup")
                {
                    //cria o processo a correr o MySqlbackup.cmd
                    Process.Start(Path + "\\NeonAEBackup.cmd");

                    string caminhoTemporario;
                    string arquivoTemporario;
                    string path = "c:\\NeonBackupTemp";
                    caminhoTemporario = path + "\\BackupNeonAE" + abstractClasse.DataBackup + ".sql";
                    arquivoTemporario = "BackupNeonAE" + abstractClasse.DataBackup;

                    acessoAuditoria aud = new acessoAuditoria();
                    AuditoriaDtHr();
                    tabelamod = "Nenhuma"; descricao = "Fez o Backup do Banco de Dados do Projeto";
                    //criando auditoria
                    aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                    int count2 = 0;

                    while (count2 != 1)
                    {
                        try
                        {
                            File.Move(caminhoTemporario, abstractClasse.LocalBackup + arquivoTemporario + ".sql");

                            File.Delete("c:\\NeonBackupTemp\\restaurar.sql");
                            File.Delete("c:\\NeonBackupTemp\\NeonAEBackup.cmd");

                            Directory.Delete("c:\\NeonBackupTemp");
                            count2 = 1;
                        }
                        catch
                        {
                            count2 = 0;
                        }
                    }
                }
            }
            catch { }

        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\NeonBackupTemp"))
            { }
            else
            {
                Directory.CreateDirectory("c:\\NeonBackupTemp");
            }

            opnSelecionarBackup.InitialDirectory = abstractClasse.LocalBackup;
            opnSelecionarBackup.Filter = "SQL Files (.sql)|*.sql";
            DialogResult dr = opnSelecionarBackup.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string caminhoArq = opnSelecionarBackup.FileName.Replace("/", "\\");
                File.Copy(caminhoArq, "c:\\NeonBackupTemp\\restaurar.sql");
                MysqlBackup_Restore("c:\\NeonBackupTemp", "restore");

                //corre uma thread com o processo que faz o backup ou restore
                System.Threading.Thread.Sleep(420);
                Thread t = new Thread(delegate () { MySqlProcess("c:\\NeonBackupTemp", "restore"); });
                t.Start();
            }
            else
            {
                Directory.Delete("c:\\NeonBackupTemp");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaADMMenu menu = new frmTelaADMMenu();
            menu.ShowDialog();
            Close();
        }

        public static void AuditoriaDtHr()
        {
            hora = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("yyyy/MM/dd");
        }
    }
}
