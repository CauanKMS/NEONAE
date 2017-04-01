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
    public partial class frmTelaEvento : Form
    {
        #region acessos
        acessoEvento eventos = new acessoEvento();
        acessoAuditoria auditoria = new acessoAuditoria();
        #endregion

        #region Variaveis do evento auditoriaDtHr
        string tabelamod, descricao, hour, minute, hora, data;
        int minuto;
        #endregion

        public frmTelaEvento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (abstractClasse.Id_tipologon == 1)
            {
                Visible = false;
                frmTelaADMMenu menuAdm = new frmTelaADMMenu();
                menuAdm.ShowDialog();
                Close();
            }
            else
            {
                Visible = false;
                frmTelaFuncMenu menuFunc = new frmTelaFuncMenu();
                menuFunc.ShowDialog();
                Close();
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            if (txtnomeEven.Text == string.Empty)
            { MessageBox.Show("Por Favor Digite o nome do evento");}
            else if (abstractClasse.ClickGridEvento1 == string.Empty || abstractClasse.Id_even.ToString() == string.Empty)
            { MessageBox.Show("Por favor veja as informações do evento Primeiramente"); }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Realmente deseja autorizar o evento?", "Autorizar Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (eventos.confirmarEvento(txtnomeEven.Text) == true)
                    {
                        MessageBox.Show("Evento Autorizado");

                        AuditoriaDtHr();
                        tabelamod = "Evento"; descricao = "Autorizou um Evento";
                        auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                        gveventos.DataSource = eventos.eventosNaoAuto();
                        txtnomeEven.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Nome de evento não corresponde ao requerimento ou não cadastrado ou não selecionado");
                    }
                }
            }
        }

        private void btnEventonaoproprio_Click(object sender, EventArgs e)
        {
            if (txtnomeEven.Text == string.Empty)
            { MessageBox.Show("Por Favor Digite o nome do evento");}
            else if(abstractClasse.ClickGridEvento1 == string.Empty || abstractClasse.Id_even.ToString() == string.Empty)
            { MessageBox.Show("Por favor veja as informações do evento Primeiramente"); }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Realmente deseja excluir o evento?", "Excluir Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (eventos.RecusaEvento(txtnomeEven.Text) == true)
                    {
                        frmTelaEventoDesauto evenDes = new frmTelaEventoDesauto();
                        evenDes.ShowDialog();

                        MessageBox.Show("Evento não autorizado, Exclusão concluida");

                        AuditoriaDtHr();
                        tabelamod = "Evento"; descricao = "Negou a Autorização do Evento";
                        auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                        tabelamod = "Evento"; descricao = "Enviou um Email a empresa que cadastrou o evento";
                        auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                        gveventos.DataSource = eventos.eventosNaoAuto();
                        txtnomeEven.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Nome de evento não corresponde ao requerimento ou não cadastrado ou não selecionado");
                    }
                }
            }
        }

        private void frmTelaADMEvento_Load(object sender, EventArgs e)
        {
            gveventos.DataSource = eventos.eventosNaoAuto();
            gveventos.Columns[0].Width = 27;
            gveventos.Columns[0].HeaderText = "ID";
            gveventos.Columns[1].Width = 180; 
            gveventos.Columns[1].HeaderText = "Nome";
            gveventos.Columns[2].Width = 130; 
            gveventos.Columns[2].HeaderText = "Empresa";
            gveventos.Columns[3].Width = 181;
            gveventos.Columns[3].HeaderText = "Tipo";
            gveventos.Columns[4].Width = 80;
            gveventos.Columns[4].HeaderText = "Cidade";
            gveventos.Columns[5].Width = 70;
            gveventos.Columns[5].HeaderText = "Data";
            gveventos.Columns[6].Width = 45;
            gveventos.Columns[6].HeaderText = "Hora";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtnomeEven_TextChanged(object sender, EventArgs e)
        {
            gveventos.DataSource = eventos.eventosFiltro(txtnomeEven.Text);
        }

        private void gveventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //variavel que vai pegar o id do evento
            int celulaEscolhida;

            //aqui ela ganha o valor da linha que foi clicada
            celulaEscolhida = Convert.ToInt32(gveventos.CurrentCell.RowIndex.ToString());

            //a variavel abstrata guarda o nome do evento
            abstractClasse.ClickGridEvento1 = gveventos.Rows[celulaEscolhida].Cells[1].Value.ToString();

            //ele vai e verifica se o id do evento existe 
            if (eventos.pesqEvento(Convert.ToInt32(gveventos.Rows[celulaEscolhida].Cells[0].Value)) == true)
            {
                //guarda o id do evento em uma vairavel abstrata
                abstractClasse.Id_even = Convert.ToInt32(gveventos.Rows[celulaEscolhida].Cells[0].Value);

                //auditoria
                AuditoriaDtHr();
                tabelamod = "Evento"; descricao = "Vizualizou as informações de um evento escolhido";
                auditoria.cadAudAdm(abstractClasse.Id_logon, tabelamod, descricao, hora, data);

                //abre a tela de mais informaçoes dos eventos
                frmTelaEventosInfo ev_info = new frmTelaEventosInfo();
                ev_info.ShowDialog();
            }

            //txtnomeEven recebe o nome do evento;
            txtnomeEven.Text = abstractClasse.ClickGridEvento1;
        }

        public void AuditoriaDtHr()
        {
            data = DateTime.Now.ToString("yyyy/MM/dd");
            hora = DateTime.Now.ToString("HH:mm");
        }

        private void txtnomeEven_DoubleClick(object sender, EventArgs e)
        {
            txtnomeEven.Text = "";
        }

        private void frmTelaADMEvento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("caso deseje ver as informações do evento, clique 2x no nome do evento");
            }
        }

        private void txtnomeEven_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                MessageBox.Show("Digite o nome do evento" + "\r\n" + "caso clique 2x no txtnomeEven o nome é apagado");
            }
        }
    }
}
