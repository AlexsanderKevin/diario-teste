using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TESTE_BARCODE
{
    public partial class Form1 : Form
    {
        DateTime data_horas;

        public Form1()
        {
            InitializeComponent();
                        
            tbOBS.Enabled = false;
            tbNome.Enabled = false;
            tbSN.Enabled = false;

            btSalvar.Enabled = false;
            btLimpar.Enabled = false;

            rbAprovado.Enabled = false;
            rbReprovado.Enabled = false;

            imgLogoLenovo.Visible = false;
            dGridAprovados.Visible = false;
            dGridReprovados.Visible = false;

            btLogout.Visible = false;

            DateTime data = DateTime.Now.Date;
            lbHora.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            lbHora.Text = data_horas.ToString("dd/MM/yyyy");

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogar.PerformClick();
            }
        }

        private void btMostrarAprovados_Click(object sender, EventArgs e)
        {
            MostrarAprovados();
        }

        private void btMostrarReprovados_Click(object sender, EventArgs e)
        {
            MostrarReprovados();
        }


        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btOcultar_Click(object sender, EventArgs e)
        {
            OcultarGrid();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_horas = DateTime.Now;
            lbData.Text = data_horas.ToString("dd/MM/yyyy");

            lbHora.Text = data_horas.ToLongTimeString();
        }
    }
}
