using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace TESTE_BARCODE {
    partial class Form1 {
        private void MostrarAprovados() {
            dGridAprovados.Visible = true;
            dGridReprovados.Visible = false;

            dGridAprovados.ScrollBars = ScrollBars.Both;

            {
                string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                //define a instrução SQL
                string strSql = "Select* from SERVICE where NAME_TESTE = @NAME_TESTE and DT_TESTE = @DT_TESTE ";

                //cria a conexão com o banco de dados
                OleDbConnection con = new OleDbConnection(strProvider);
                //cria o objeto command para executar a instruçao sql
                OleDbCommand cmd = new OleDbCommand(strSql, con);
                cmd.Parameters.AddWithValue("NAME_TESTE", tbNome.Text);
                cmd.Parameters.AddWithValue("DT_TESTE", lbData.Text);


                cmd.CommandType = CommandType.Text;

                //abre a conexao
                con.Open();

                //define o tipo do comando 
                cmd.CommandType = CommandType.Text;
                //cria um dataadapter
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                //cria um objeto datatable
                DataTable clientes = new DataTable();

                //preenche o datatable via dataadapter
                da.Fill(clientes);

                //atribui o datatable ao datagridview para exibir o resultado
                dGridAprovados.DataSource = clientes;

                foreach (DataGridViewRow row in dGridAprovados.Rows)
                {
                    dGridReprovados.Visible = false;

                    dGridAprovados.Columns[1].Visible = false;
                    dGridAprovados.Columns[2].Visible = false;
                    dGridAprovados.Columns[3].Visible = false;
                    dGridAprovados.Columns[4].Visible = false;
                    dGridAprovados.Columns[5].Visible = false;
                    dGridAprovados.Columns[6].Visible = false;

                    dGridAprovados.Columns[9].Visible = false;
                    dGridAprovados.Columns[10].Visible = false;
                    dGridAprovados.Columns[11].Visible = false;
                    dGridAprovados.Columns[12].Visible = false;
                    dGridAprovados.Columns[13].Visible = false;
                    dGridAprovados.Columns[14].Visible = false;
                    dGridAprovados.Columns[15].Visible = false;
                    dGridAprovados.Columns[16].Visible = false;
                    dGridAprovados.Columns[17].Visible = false;
                    dGridAprovados.Columns[18].Visible = false;
                    dGridAprovados.Columns[19].Visible = false;
                    dGridAprovados.Columns[20].Visible = false;
                    dGridAprovados.Columns[21].Visible = false;
                    dGridAprovados.Columns[22].Visible = false;
                    dGridAprovados.Columns[23].Visible = false;
                    dGridAprovados.Columns[24].Visible = false;
                    dGridAprovados.Columns[25].Visible = false;
                    dGridAprovados.Columns[26].Visible = false;
                    dGridAprovados.Columns[27].Visible = false;
                    dGridAprovados.Columns[28].Visible = false;
                    dGridAprovados.Columns[29].Visible = false;
                    dGridAprovados.Columns[30].Visible = false;
                    dGridAprovados.Columns[31].Visible = false;

                    dGridAprovados.Columns[35].Visible = false;
                    dGridAprovados.Columns[36].Visible = false;
                    dGridAprovados.Columns[37].Visible = false;
                    dGridAprovados.Columns[38].Visible = false;
                }
                con.Close();
            }
        }

        private void MostrarReprovados() {
            dGridReprovados.Visible = false;
            dGridReprovados.Visible = true;

            dGridReprovados.ScrollBars = ScrollBars.Both;

            {
                string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                //define a instrução SQL
                string strSql = "Select* from Teste_Rejeito where NAME_TESTE = @NAME_TESTE and DT_TESTE = @DT_TESTE ";

                //cria a conexão com o banco de dados
                OleDbConnection con = new OleDbConnection(strProvider);
                //cria o objeto command para executar a instruçao sql
                OleDbCommand cmd = new OleDbCommand(strSql, con);
                cmd.Parameters.AddWithValue("NAME_TESTE", tbNome.Text);
                cmd.Parameters.AddWithValue("DT_TESTE", lbData.Text);


                cmd.CommandType = CommandType.Text;

                //abre a conexao
                con.Open();

                //define o tipo do comando 
                cmd.CommandType = CommandType.Text;
                //cria um dataadapter
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                //cria um objeto datatable
                DataTable clientes = new DataTable();

                //preenche o datatable via dataadapter
                da.Fill(clientes);

                //atribui o datatable ao datagridview para exibir o resultado
                dGridReprovados.DataSource = clientes;

                foreach (DataGridViewRow row in dGridReprovados.Rows)
                {
                    dGridAprovados.Visible = false;

                    dGridReprovados.Columns[0].Visible = true;
                    dGridReprovados.Columns[1].Visible = true;
                    dGridReprovados.Columns[2].Visible = true;
                    dGridReprovados.Columns[3].Visible = true;
                    dGridReprovados.Columns[4].Visible = true;
                }

                con.Close();

            }

        }
        private void OcultarGrid() {
            dGridAprovados.Visible = false;
            dGridReprovados.Visible = false;
        }
    }
}
