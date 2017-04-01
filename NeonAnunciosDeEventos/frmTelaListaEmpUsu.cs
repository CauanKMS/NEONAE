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
    public partial class frmTelaListaEmpUsu : Form
    {
        #region acessos
        acessoADM adm = new acessoADM();
        #endregion

        #region Variáveis Globais
        #endregion

        public frmTelaListaEmpUsu()
        {
            InitializeComponent();
        }

        private void rdbListaEmp_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            //carrega a lista de adms
            gvExibirEmpUsu.DataSource = adm.ListarEmp();
            gvExibirEmpUsu.Columns[0].Width = 130;
            gvExibirEmpUsu.Columns[0].HeaderText = "Codigo";
            gvExibirEmpUsu.Columns[1].Width = 130;
            gvExibirEmpUsu.Columns[1].HeaderText = "Nome";
            gvExibirEmpUsu.Columns[2].Width = 270;
            gvExibirEmpUsu.Columns[2].HeaderText = "Email";
            abstractClasse.ClickTipo1 = "4";
        }

        private void rdbListaUsu_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            //carrega a lista de adms
            gvExibirEmpUsu.DataSource = adm.ListarUsu();
            gvExibirEmpUsu.Columns[0].Width = 130;
            gvExibirEmpUsu.Columns[0].HeaderText = "Codigo";
            gvExibirEmpUsu.Columns[1].Width = 130;
            gvExibirEmpUsu.Columns[1].HeaderText = "Nome";
            gvExibirEmpUsu.Columns[2].Width = 270;
            gvExibirEmpUsu.Columns[2].HeaderText = "Email";
            abstractClasse.ClickTipo1 = "3";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //encerra o programa
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //minimiza o programa
            this.WindowState = FormWindowState.Minimized;
        }

        private void gvExibirFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //evento ao clicar o gridView
            int xy;

            //pega a linha da celula que foi clicada
            xy = Convert.ToInt32(gvExibirEmpUsu.CurrentCell.RowIndex.ToString());

            //coloca em uma variavel abstrata o valor da celula o qual está na coluna 0 da linha xy 
            abstractClasse.ClickGridListaEmpUsu1 = gvExibirEmpUsu.Rows[xy].Cells[0].Value.ToString();

            //vai pra tela de auditoria
            Visible = false;
            frmTelaAuditoria auditoria = new frmTelaAuditoria();
            auditoria.ShowDialog();
            Close();
        }

        private void frmTelaListaEmpUsu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Esolha um: Empresa ou Usuário" + "\r\n" + "Depois clique 2x no email de alguem que aparecerá na lista para ir a auditoria");
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaADMGerenciamento geren = new frmTelaADMGerenciamento();
            geren.ShowDialog();
            Close();
        }
    }
}
