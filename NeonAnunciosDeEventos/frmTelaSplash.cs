using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaSplash : Form
    {
        public frmTelaSplash()
        {
            InitializeComponent();

            //inicaliza o timer
            tmrTelaSplash.Start();
            //coloca o tempo de excução
            tmrTelaSplash.Interval = 1000;

            //diz a minima e a maxima do progressBar
            pgbtime.Minimum = 0;
            pgbtime.Maximum = 500;
        }

        private void tmrTelaSplash_Tick(object sender, EventArgs e)
        {
            //se o valor da progressBar for menor que a maxima estipulada
            if (pgbtime.Value < pgbtime.Maximum)
            {
                //é adiconado a mesma o valor atual mais algum número multiplo da maxima
                pgbtime.Value = pgbtime.Value + 500;
            }
            else if (pgbtime.Value == pgbtime.Maximum)
            {
                //para o timer
                tmrTelaSplash.Stop();
                //vai pra tela de login
                Visible = false;
                frmTelaLogin TelaMenu = new frmTelaLogin();
                TelaMenu.ShowDialog();
                Close();
            }
        }

        private void frmTelaSplash_Load(object sender, EventArgs e)
        {
            //cria conexão com o banco do projeto e da base dos correios
            ConexaoPrincipal.criar_Conexao();
            Conexao.criar_Conexao();
        }

    }
}
