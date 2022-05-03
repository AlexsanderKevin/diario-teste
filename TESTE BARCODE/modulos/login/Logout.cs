using System;
using System.Windows.Forms;

namespace TESTE_BARCODE {
    partial class Form1 {
        private void Logout() {
            tbNome.Clear();
            lbSenha.Visible = true;
            tbSenha.Visible = true;
            btLogar.Visible = true;
            imgLogoLenovo.Visible = false;

            btSalvar.Enabled = false;
            btLimpar.Enabled = false;
            btMostrarAprovados.Enabled = false;
            btMostrarReprovados.Enabled = false;

            rbAprovado.Enabled = false;
            rbReprovado.Enabled = false;

            tbSN.Enabled = false;

            rbAprovado.Checked = false;
            rbReprovado.Checked = false;

            tbSenha.Focus();
        }
    }
}
