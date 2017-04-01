using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeonAnunciosDeEventos
{
    public partial class frmTelaEventosInfo : Form
    {
        acessoEvento even = new acessoEvento();

        string NomeImagem;

        public frmTelaEventosInfo()
        {
            InitializeComponent();
        }

        private void frmTelaEventosInfo_Load(object sender, EventArgs e)
        {
            even.pesqEvento(abstractClasse.Id_even);
            lblID_even.Text = abstractClasse.Id_even.ToString();
            lblTipo_even.Text = even.Descr_teve;
            lblSubtipo_even.Text = even.Descr_subt;

            lblStatus_even.Text = even.Tipo_st;
            if (lblStatus_even.Text == "a" || lblStatus_even.Text == "A")
                lblStatus_even.Text = "Evento Aberto";
            else if (lblStatus_even.Text == "p" || lblStatus_even.Text == "P")
                lblStatus_even.Text = "Evento Privado";

            lblNome_emp.Text = even.Nome_emp;
            lblNome_even.Text = even.Nome_even;
            lblUF_even.Text = even.Uf_even;
            lblCid_even.Text = even.Cid_even;
            lblRua_even.Text = even.Rua_even;
            lblNumRua_even.Text = even.Numlocal_even;
            lblNomeLocal_even.Text = even.Nomelocal_even;
            txtDetalhes.Text = even.Detalhes_even;
            lblDataInicio_even.Text = even.Startdt_even.ToShortDateString();
            lblHoraInicio_even.Text = even.Starthr_even.ToShortTimeString();
            lblDataFinal_even.Text = even.Fimdt_even.ToShortDateString();
            lblHoraFinal_even.Text = even.Fimhr_even.ToShortTimeString();

            NomeImagem = even.Img_even;

            if (NomeImagem == null)
                pctIMGevento.ImageLocation = Path.Combine(abstractClasse.LocalIMG, "semimagem.jpg");
            else
                pctIMGevento.ImageLocation = Path.Combine(abstractClasse.LocalIMG, NomeImagem);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
