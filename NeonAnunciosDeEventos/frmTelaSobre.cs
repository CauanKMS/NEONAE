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
    public partial class frmTelaSobre : Form
    {
        public frmTelaSobre()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            //verifica o tipo de usuario
            if (abstractClasse.Id_tipologon == 1)
            {
                //vai para o menu do ADM
                Visible = false;
                frmTelaADMMenu TelaMenu = new frmTelaADMMenu();
                TelaMenu.ShowDialog();
                Close();
            }
            else
            {
                //senão vai para o menu do Func
                Visible = false;
                frmTelaFuncMenu menuFunc = new frmTelaFuncMenu();
                menuFunc.ShowDialog();
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //encerra o projeto
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //minimiza o projeto
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
