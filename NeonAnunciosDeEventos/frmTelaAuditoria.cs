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
    public partial class frmTelaAuditoria : Form
    {
        acessoAuditoria audadm = new acessoAuditoria();

        public frmTelaAuditoria()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmTelaADMAuditoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (abstractClasse.ClickTipo1 == "1")
                {
                    //se for do tipo adm
                    gvAudADM.DataSource = audadm.pesqAuditoriaAdm(abstractClasse.ClickGridListaFuncAdm1);

                }
                else if (abstractClasse.ClickTipo1 == "2")
                {
                    //se for do tipo func
                    gvAudADM.DataSource = audadm.pesqAuditoriaFunc(abstractClasse.ClickGridListaFuncAdm1);

                }
                else if (abstractClasse.ClickTipo1 == "3")
                {
                    //se for do tipo usuario
                    gvAudADM.DataSource = audadm.pesqAuditoriaUsu(abstractClasse.ClickGridListaEmpUsu1);

                }
                else if (abstractClasse.ClickTipo1 == "4")
                {
                    //se for do tipo empresa
                    gvAudADM.DataSource = audadm.pesqAuditoriaEmp(abstractClasse.ClickGridListaEmpUsu1);
                }
                gvAudADM.Columns[0].Width = 27;
                gvAudADM.Columns[0].HeaderText = "ID";
                gvAudADM.Columns[1].Width = 36;
                gvAudADM.Columns[1].HeaderText = "ID ADM";
                gvAudADM.Columns[2].Width = 73;
                gvAudADM.Columns[2].HeaderText = "Tabela Modificada";
                gvAudADM.Columns[3].Width = 397;
                gvAudADM.Columns[3].HeaderText = "Descricao";
                gvAudADM.Columns[4].Width = 37;
                gvAudADM.Columns[4].HeaderText = "Hora";
                gvAudADM.Columns[5].Width = 65;
                gvAudADM.Columns[5].HeaderText = "Data";
            }
            catch { }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (abstractClasse.ClickTipo1 == "1" || abstractClasse.ClickTipo1 == "2")
            {
                Visible = false;
                frmTelaADMListaFuncAdm listaFuncAdm = new frmTelaADMListaFuncAdm();
                listaFuncAdm.ShowDialog();
                Close();
            }
            else
            {
                Visible = false;
                frmTelaListaEmpUsu listaEmpUsu = new frmTelaListaEmpUsu();
                listaEmpUsu.ShowDialog();
                Close();
            }
        }

        private void frmTelaADMAuditoria_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Esta é uma tela de Visualização, não há ações a serem tomadas");
            }
        }
    }
}
