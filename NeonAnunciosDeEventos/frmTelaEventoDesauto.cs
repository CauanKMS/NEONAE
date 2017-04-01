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
    public partial class frmTelaEventoDesauto : Form
    {
        acessoEvento eventos = new acessoEvento();

        public frmTelaEventoDesauto()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMotivo.Text == String.Empty)
                    MessageBox.Show("Preencha o Motivo Da desativação");
                if (eventos.RecusouEmail(txtMotivo.Text) == true)
                {
                    MessageBox.Show("Email Enviado Com Sucesso");
                    this.Close();
                }
            }
            catch { this.Close(); }
        }
    }
}
