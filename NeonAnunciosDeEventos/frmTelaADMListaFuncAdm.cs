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
    public partial class frmTelaADMListaFuncAdm : Form
    {
        acessoADM pesq = new acessoADM();

        public frmTelaADMListaFuncAdm()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            //btn volta a tela de menu do adm
            Visible = false;
            frmTelaADMGerenciamento geren = new frmTelaADMGerenciamento();
            geren.ShowDialog();
            Close();
        }

        private void rdbListaAdm_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            //carrega a lista de adms
            gvExibirFuncAdm.DataSource = pesq.listarAdms();
            gvExibirFuncAdm.Columns[0].Width = 130;
            gvExibirFuncAdm.Columns[0].HeaderText = "Codigo";
            gvExibirFuncAdm.Columns[1].Width = 130;
            gvExibirFuncAdm.Columns[1].HeaderText = "Nome";
            gvExibirFuncAdm.Columns[2].Width = 270;
            gvExibirFuncAdm.Columns[2].HeaderText = "Email";
            abstractClasse.ClickTipo1 = "1";
        }

        private void rdbListaFunc_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            //carrega a lista de funcs
            gvExibirFuncAdm.DataSource = pesq.listarFuncs();
            gvExibirFuncAdm.Columns[0].Width = 130;
            gvExibirFuncAdm.Columns[0].HeaderText = "Codigo";
            gvExibirFuncAdm.Columns[1].Width = 130;
            gvExibirFuncAdm.Columns[1].HeaderText = "Nome";
            gvExibirFuncAdm.Columns[2].Width = 270;
            gvExibirFuncAdm.Columns[2].HeaderText = "Email";
            abstractClasse.ClickTipo1 = "2";
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
            xy = Convert.ToInt32(gvExibirFuncAdm.CurrentCell.RowIndex.ToString());

            //coloca em uma variavel abstrata o valor da celula o qual está na coluna 0 da linha xy 
            abstractClasse.ClickGridListaFuncAdm1 = gvExibirFuncAdm.Rows[xy].Cells[0].Value.ToString();

            //vai pra tela de auditoria
            Visible = false;
            frmTelaAuditoria auditoria = new frmTelaAuditoria();
            auditoria.ShowDialog();
            Close();
        }

        private void frmTelaADMListaADM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Esolha um: Colaboradores e Administradores" +"\r\n" + "Depois clique 2x no email de algum dos que aparecerá na lista para ir a auditoria");
            }
        }
    }
}
