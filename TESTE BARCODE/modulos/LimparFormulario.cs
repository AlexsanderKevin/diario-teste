using System;
using System.Windows.Forms;

namespace TESTE_BARCODE {
    partial class Form1 {
        private void LimparFormulario() {
            tbOS.Clear();
            tbSN.Clear();
            tbOBS.Clear();
            tbDPK.Clear();
            tb_1Retorno.Clear();
            tbVer_Status.Clear();

            tbSN.Enabled = false;
            tbOBS.Enabled = false;

            rbAprovado.Checked = false;
            rbReprovado.Checked = false;

            rbAprovado.Enabled = false;
            rbReprovado.Enabled = false;

            lbConta_Retorno.Visible = false;

            pictureBox1.Image = null;

            tbSN.Enabled = true;
            tbSN.Focus();
        }
    }
}
