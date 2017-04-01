using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaConexao : Form
    {
        public frmTelaConexao()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            abstractClasse.Ip = txtIp.Text;
            abstractClasse.Usuario = txtUsu.Text;
            abstractClasse.Senha = txtSenha.Text;

            StreamWriter arq = new StreamWriter(@Application.StartupPath + "\\Config.txt", true, Encoding.ASCII);

            arq.WriteLine(abstractClasse.Ip);
            arq.WriteLine(abstractClasse.Usuario);
            arq.WriteLine(abstractClasse.Senha);

            arq.Close();

            if (ConexaoPrincipal.criar_Conexao() == false)
                Application.Restart();
            else
            {
                Visible = false;
                frmTelaSplash splash = new frmTelaSplash();
                splash.ShowDialog();
                Close();
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

        private void txtIp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o ip da maquina em que está seu Banco de Dados");
            }
        }

        private void txtUsu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o nome do usuário cadastrado no MySQl");
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite a senha para de acesso do MySQL");
            }
        }
    }
}
