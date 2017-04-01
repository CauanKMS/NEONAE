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
    public partial class frmTelaADMGerenciamento : Form
    {
        public frmTelaADMGerenciamento()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaADMMenu TelaMenuADM = new frmTelaADMMenu();
            TelaMenuADM.ShowDialog();
            Close();
        }

        private void btnCadsFuncAdm_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaADMCadastroFuncAdm TelaADMCadastro = new frmTelaADMCadastroFuncAdm();
            TelaADMCadastro.ShowDialog();
            Close();
        }

        private void btnListaAdm_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaADMListaFuncAdm listaAdm = new frmTelaADMListaFuncAdm();
            listaAdm.ShowDialog();
            Close();
        }

        private void btnPesqAdm_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaPerfil updeA = new frmTelaPerfil();
            updeA.ShowDialog();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Realmente deseja deslogar?", "Deslogar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Visible = false;
                frmTelaLogin TelaLogin = new frmTelaLogin();
                TelaLogin.ShowDialog();
                Close();
            }
        }

        private void btnlistaEmpUsu_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaListaEmpUsu EmpUsu = new frmTelaListaEmpUsu();
            EmpUsu.ShowDialog();
            Close();
        }
    }
}
