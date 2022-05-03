using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TESTE_BARCODE {
    partial class Form1 {
        private void logar() {
            string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
            string comando = "Select * from NOME where SENHA =@SENHA";
            OleDbConnection con = new OleDbConnection(strcon);
            OleDbCommand com = new OleDbCommand(comando, con);

            com.Parameters.AddWithValue("Senha", tbSenha.Text);
            com.CommandType = CommandType.Text;
            OleDbDataReader reader;
            con.Open();
            try
            {
                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    tbNome.Text = reader[0].ToString();
                    lbSenha.Visible = false;
                    tbSenha.Visible = false;
                    btLogar.Visible = false;

                    rbAprovado.Enabled = false;
                    rbReprovado.Enabled = false;

                    imgLogoLenovo.Visible = true;

                    btMostrarAprovados.Enabled = true;
                    btMostrarReprovados.Enabled = true;
                    btOcultar.Enabled = true;

                    tbSN.Enabled = true;

                    btLogout.Visible = true;

                    rbAprovado.Checked = false;
                    rbReprovado.Checked = false;

                    tbSN.Focus();

                    con.Close();
                }
                else
                    MessageBox.Show("Senha incorreta! Usuário não encontrado");
                tbSenha.Clear();
                tbSenha.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
            }
            con.Close();
        }
    }
}
