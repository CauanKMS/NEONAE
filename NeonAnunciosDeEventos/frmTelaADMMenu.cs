using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaADMMenu : Form
    {
        public frmTelaADMMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btn que leva ao gerenciamento de Func e Adm
            Visible = false;
            frmTelaADMGerenciamento geren = new frmTelaADMGerenciamento();
            geren.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //btn que leva a tela dos desenvolvedores
            Visible = false;
            frmTelaSobre TelaSobreA = new frmTelaSobre();
            TelaSobreA.ShowDialog();
            Close();
        }

        private void btnevento_Click(object sender, EventArgs e)
        {
            //btn que leva a tela de eventos
            Visible = false;
            frmTelaEvento evento = new frmTelaEvento();
            evento.ShowDialog();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //encerra o programa
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //minimiza a tela
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            //btn que desloga o adm
            DialogResult result;
            result = MessageBox.Show("Realmente deseja deslogar?", "Deslogar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //volta a tela de login
                Visible = false;
                frmTelaLogin TelaLogin = new frmTelaLogin();
                TelaLogin.ShowDialog();
                Close();
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //btn que leva tela de perfil
            Visible = false;
            frmTelaPerfil perfil = new frmTelaPerfil();
            perfil.ShowDialog();
            Close();
        }

        private void btnBackRest_Click(object sender, EventArgs e)
        {
            //btn que leva a tela de Backup
            Visible = false;
            frmTelaADMBackup BackRest = new frmTelaADMBackup();
            BackRest.ShowDialog();
            Close();
        }
    }
}
