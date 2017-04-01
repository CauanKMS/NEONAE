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
    public partial class frmTelaFuncMenu : Form
    {
        #region acessos
        acessoFunc func = new acessoFunc();
        acessoAuditoria aud = new acessoAuditoria();
        #endregion

        #region Variaveis do evento auditoriaDtHr
        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;
        #endregion

        public frmTelaFuncMenu()
        {
            InitializeComponent();
        }

        private void btnTelaEventos_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaEvento evento = new frmTelaEvento();
            evento.ShowDialog();
            Close();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Realmente deseja sair?", "Sair do programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AuditoriaDtHr();
                tabelamod = "usuário"; descricao = "Saiu do Programa";
                aud.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                Visible = false;
                frmTelaLogin TelaLogin = new frmTelaLogin();
                TelaLogin.ShowDialog();
                Close();
            }
        }

        private void btnTelaPerfil_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaPerfil perfil = new frmTelaPerfil();
            perfil.ShowDialog();
            Close();
        }

        private void btnTelaSobre_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTelaSobre sobre = new frmTelaSobre();
            sobre.ShowDialog();
            Close();
        }

        public void AuditoriaDtHr()
        {
            hour = DateTime.Now.Hour.ToString();
            minute = DateTime.Now.Minute.ToString();
            minuto = Convert.ToInt32(minute);
            if (minuto >= 0 && minuto < 10)
                minute = "0" + minute;
            hora = hour + ":" + minute;
            data = DateTime.Now.ToShortDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
