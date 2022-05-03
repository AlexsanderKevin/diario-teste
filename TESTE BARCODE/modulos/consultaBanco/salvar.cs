using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace TESTE_BARCODE {
    partial class Form1 {
        private void Salvar() {
            string strconp = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
            string comandop = "Select * from SERVICE where SO=@SO";

            OleDbConnection conp = new OleDbConnection(strconp);
            OleDbCommand comp = new OleDbCommand(comandop, conp);

            comp.Parameters.AddWithValue("SO", tbSN.Text);
            comp.CommandType = CommandType.Text;
            OleDbDataReader reader;
            conp.Open();

            try
            {
                reader = comp.ExecuteReader();
                if (reader.Read())
                {
                    if (tbVer_Status.Text != "TESTE")
                    {
                        MessageBox.Show("Maquina não registrada na zona de testes!");

                        tbSN.Clear();
                        tbOBS.Clear();

                        tbOBS.Enabled = false;
                        rbAprovado.Enabled = false;
                        rbReprovado.Enabled = false;

                        pictureBox1.Image = null;

                        tbSN.Focus();

                        return;
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
            }

            finally
            {
                conp.Close();
            }

            if (tbSN.Text == "")
            {
                MessageBox.Show("Insira o número da OS!");
                return;
            }

            if (rbAprovado.Checked == false && rbReprovado.Checked == false)
            {
                MessageBox.Show("Selecione o Status de validação do teste! <Aprovado/Reprovado>");
            }

            if (rbAprovado.Checked == true)
            {
                string valida = "TESTE";
                string strconpx = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                string comandopx = "Select * from SERVICE where SO=@SO";

                OleDbConnection conpx = new OleDbConnection(strconpx);
                OleDbCommand compx = new OleDbCommand(comandopx, conpx);

                compx.Parameters.AddWithValue("SO", tbSN.Text);
                compx.CommandType = CommandType.Text;
                OleDbDataReader leitor;
                conpx.Open();

                try
                {
                    leitor = compx.ExecuteReader();

                    if (leitor.Read())
                    {
                        tbVer_Status.Text = leitor[33].ToString();                                               

                        if (tbVer_Status.Text != valida)
                        {
                            MessageBox.Show("Maquina não registrada na zona de testes!");
                            tbSN.Clear();
                            tbOBS.Clear();

                            tbOBS.Enabled = false;
                            rbAprovado.Enabled = false;
                            rbReprovado.Enabled = false;

                            tbSN.Focus();

                            pictureBox1.Image = null;

                            return;
                        }
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.ToString());
                }

                finally
                {
                    conpx.Close();
                }

                string status_serv = "EMBALAGEM";
                string status_final = "FINALIZADO";
                string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb");
                con.Open();

                {
                    try
                    {

                        string comando = "update SERVICE  set SO = @SO, DT_TESTE=@DT_TESTE, HR_TESTE=@HR_TESTE, NAME_TESTE=@NAME_TESTE, STATUS_SERV=@STATUS_SERV, STATUS_FINAL=@STATUS_FINAL where SO = @SO";

                        OleDbConnection cons = new OleDbConnection(strcon);
                        OleDbCommand com = new OleDbCommand(comando, cons);

                        com.Parameters.Add("SO", OleDbType.VarChar).Value = tbSN.Text;
                        com.Parameters.Add("DT_TESTE", OleDbType.VarChar).Value = lbData.Text;
                        com.Parameters.Add("HR_TESTE", OleDbType.VarChar).Value = lbHora.Text;
                        com.Parameters.Add("NAME_TESTE", OleDbType.VarChar).Value = tbNome.Text;
                        com.Parameters.Add("STATUS_SERV", OleDbType.VarChar).Value = status_serv;
                        com.Parameters.Add("STATUS_FINAL", OleDbType.VarChar).Value = status_final;

                        cons.Open();
                        com.ExecuteNonQuery();

                        MessageBox.Show("Teste finalizado com sucesso!");

                        tbSN.Clear();
                        tbOBS.Clear();

                        tbOBS.Enabled = false;
                        rbAprovado.Enabled = false;
                        rbReprovado.Enabled = false;

                        pictureBox1.Image = null;

                        btMostrarAprovados.PerformClick();

                        tbSN.Focus();

                        cons.Close();
                    }

                    catch (Exception E)
                    {

                        MessageBox.Show(E.Message);
                    }

                    {
                        con.Close();
                    }
                }
            }

            else if (rbReprovado.Checked == true)
            {
                string valida = "TESTE";
                string strconpx = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                string comandopx = "Select * from SERVICE where SO=@SO";

                OleDbConnection conpx = new OleDbConnection(strconpx);
                OleDbCommand compx = new OleDbCommand(comandopx, conpx);

                compx.Parameters.AddWithValue("SO", tbSN.Text);
                compx.CommandType = CommandType.Text;
                OleDbDataReader leitor;
                conpx.Open();

                try
                {
                    leitor = compx.ExecuteReader();

                    tbOBS.Enabled = true;

                    if (leitor.Read())
                    {
                        tbVer_Status.Text = leitor[33].ToString();

                        tbOBS.Enabled = true;

                        if (tbVer_Status.Text != valida)
                        {
                            MessageBox.Show("Maquina não registrada na zona de testes!");
                            tbSN.Clear();
                            tbOBS.Clear();

                            tbOBS.Enabled = false;
                            rbAprovado.Enabled = false;
                            rbReprovado.Enabled = false;

                            tbSN.Focus();

                            pictureBox1.Image = null;

                            return;
                        }
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.ToString());
                }

                finally
                {
                    conpx.Close();
                }

                string conta_retorno1 = "";
                string strconpxd = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                string comandopxd = "Select * from SERVICE where SO=@SO";

                OleDbConnection conpxd = new OleDbConnection(strconpxd);
                OleDbCommand compxd = new OleDbCommand(comandopxd, conpxd);

                compxd.Parameters.AddWithValue("SO", tbSN.Text);
                compxd.CommandType = CommandType.Text;

                OleDbDataReader readers;

                conpxd.Open();

                try
                {
                    readers = compxd.ExecuteReader();

                    if (readers.Read())
                    {
                        tb_1Retorno.Text = readers[39].ToString();

                        if (tb_1Retorno.Text == "0° TESTE")
                        {
                            lbConta_Retorno.Text = ("1° TESTE");
                        }

                        else if (tb_1Retorno.Text == "1° TESTE")
                        {
                            lbConta_Retorno.Text = ("2° TESTE");
                        }

                        else if (tb_1Retorno.Text == "2° TESTE")
                        {
                            lbConta_Retorno.Text = ("3° TESTE");
                        }

                        else if (tb_1Retorno.Text == "3° TESTE")
                        {
                            lbConta_Retorno.Text = ("4° TESTE");
                            MessageBox.Show("Quantidade de retornos excedida! Informe o líder!");
                            tbSN.Clear();
                            tbSN.Focus();
                            tbOBS.Enabled = false;
                            return;
                        }
                    }

                    conpxd.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.ToString());
                }

                string status_serv2 = "ANALISE";
                string status_final2 = "EM ANDAMENTO";

                string strconpxy = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";

                string comandopxy = "INSERT INTO Teste_Rejeito (SO, NAME_TESTE, OBS_TESTE, DT_TESTE, HR_TESTE) VALUES (@OS, @NAME_TESTE, @OBS_TESTE, @DT_TESTE, @HR_TESTE)";

                OleDbConnection conpxy = new OleDbConnection(strconpxy);
                OleDbCommand compxy = new OleDbCommand(comandopxy, conpxy);

                compxy.Parameters.AddWithValue("SO", tbSN.Text);
                compxy.Parameters.AddWithValue("NAME_TESTE", tbNome.Text);
                compxy.Parameters.AddWithValue("OBS_TESTE", tbOBS.Text);
                compxy.Parameters.AddWithValue("DT_TESTE", lbData.Text);
                compxy.Parameters.AddWithValue("HR_TESTE", lbHora.Text);

                conpxy.Open();
                compxy.ExecuteNonQuery();

                string strconxd = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                string comandoxd = "Select * from SERVICE where SO=@SO";

                OleDbConnection conxd = new OleDbConnection(strconxd);
                OleDbCommand comxd = new OleDbCommand(comandoxd, conxd);

                comxd.Parameters.AddWithValue("SO", tbSN.Text);
                comxd.CommandType = CommandType.Text;
                conxd.Open();

                OleDbDataReader readersy;

                readersy = comxd.ExecuteReader();

                if (readersy.Read())
                {
                    tb_VerRetorno1.Text = readersy[27].ToString();
                    tb_VerRetorno2.Text = readersy[29].ToString();
                    tb_VerRetorno3.Text = readersy[31].ToString();

                    //compara se teve um primeiro retorno (verifica se há dados no campo de data de primeiro retorno)
                    if (tb_VerRetorno1.Text == string.Empty)
                    {
                        string strconx = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                        string comandox = "update SERVICE  set SO = @SO, RETORNO=@RETORNO, DATA_RETORNO=@DATA_RETORNO, STATUS_SERV=@STATUS_SERV, STATUS_FINAL=@STATUS_FINAL, 1_RETORNO=@1_RETORNO where SO = @SO";

                        OleDbConnection consx = new OleDbConnection(strconx);
                        OleDbCommand comx = new OleDbCommand(comandox, consx);

                        comx.Parameters.Add("SO", OleDbType.VarChar).Value = tbSN.Text;
                        comx.Parameters.Add("RETORNO", OleDbType.VarChar).Value = tbOBS.Text;
                        comx.Parameters.Add("DATA_RETORNO", OleDbType.VarChar).Value = lbData.Text;
                        comx.Parameters.Add("STATUS_SERV", OleDbType.VarChar).Value = status_serv2;
                        comx.Parameters.Add("STATUS_FINAL", OleDbType.VarChar).Value = status_final2;
                        comx.Parameters.Add("1_RETORNO", OleDbType.VarChar).Value = lbConta_Retorno.Text;

                        consx.Open();
                        comx.ExecuteNonQuery();

                        MessageBox.Show("Teste reprovado com sucesso!");

                        tbSN.Clear();
                        tbOBS.Clear();
                        tbDPK.Clear();
                        tbVer_Status.Clear();
                        tb_1Retorno.Clear();
                        tb_VerRetorno1.Clear();
                        tb_VerRetorno2.Clear();
                        tb_VerRetorno3.Clear();

                        tbOBS.Enabled = false;
                        rbAprovado.Enabled = false;
                        rbReprovado.Enabled = false;

                        pictureBox1.Image = null;

                        btMostrarReprovados.PerformClick();

                        lbConta_Retorno.Visible = false;

                        tbSN.Focus();

                        consx.Close();

                    }

                    else if (tb_VerRetorno2.Text == string.Empty)
                    {
                        string strconx = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                        string comandox = "update SERVICE  set SO = @SO, RETORNO1=@RETORNO1, DATA_RETORNO1=@DATA_RETORNO1, STATUS_SERV=@STATUS_SERV, STATUS_FINAL=@STATUS_FINAL, 1_RETORNO=@1_RETORNO where SO = @SO";

                        OleDbConnection consx = new OleDbConnection(strconx);
                        OleDbCommand comx = new OleDbCommand(comandox, consx);

                        comx.Parameters.Add("SO", OleDbType.VarChar).Value = tbSN.Text;
                        comx.Parameters.Add("RETORNO1", OleDbType.VarChar).Value = tbOBS.Text;
                        comx.Parameters.Add("DATA_RETORNO1", OleDbType.VarChar).Value = lbData.Text;
                        comx.Parameters.Add("STATUS_SERV", OleDbType.VarChar).Value = status_serv2;
                        comx.Parameters.Add("STATUS_FINAL", OleDbType.VarChar).Value = status_final2;
                        comx.Parameters.Add("1_RETORNO", OleDbType.VarChar).Value = lbConta_Retorno.Text;

                        consx.Open();
                        comx.ExecuteNonQuery();

                        MessageBox.Show("Teste reprovado com sucesso!");
                       
                        tbDPK.Clear();
                        tbVer_Status.Clear();
                        tb_1Retorno.Clear();
                        tb_VerRetorno1.Clear();
                        tb_VerRetorno2.Clear();
                        tb_VerRetorno3.Clear();
                        tbSN.Clear();
                        tbOBS.Clear();

                        tbOBS.Enabled = false;
                        rbAprovado.Enabled = false;
                        rbReprovado.Enabled = false;

                        pictureBox1.Image = null;

                        btMostrarReprovados.PerformClick();

                        lbConta_Retorno.Visible = false;

                        tbSN.Focus();

                        consx.Close();
                    }

                    else if (tb_VerRetorno3.Text == string.Empty)
                    {
                        string strconx = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                        string comandox = "update SERVICE  set SO = @SO, RETORNO2=@RETORNO2, DATA_RETORNO2=@DATA_RETORNO2, STATUS_SERV=@STATUS_SERV, STATUS_FINAL=@STATUS_FINAL, 1_RETORNO=@1_RETORNO where SO = @SO";

                        OleDbConnection consx = new OleDbConnection(strconx);
                        OleDbCommand comx = new OleDbCommand(comandox, consx);

                        comx.Parameters.Add("SO", OleDbType.VarChar).Value = tbSN.Text;
                        comx.Parameters.Add("RETORNO2", OleDbType.VarChar).Value = tbOBS.Text;
                        comx.Parameters.Add("DATA_RETORNO2", OleDbType.VarChar).Value = lbData.Text;
                        comx.Parameters.Add("STATUS_SERV", OleDbType.VarChar).Value = status_serv2;
                        comx.Parameters.Add("STATUS_FINAL", OleDbType.VarChar).Value = status_final2;
                        comx.Parameters.Add("1_RETORNO", OleDbType.VarChar).Value = lbConta_Retorno.Text;

                        consx.Open();
                        comx.ExecuteNonQuery();

                        MessageBox.Show("Teste reprovado com sucesso!");
                        
                        tbDPK.Clear();
                        tbVer_Status.Clear();
                        tb_1Retorno.Clear();
                        tb_VerRetorno1.Clear();
                        tb_VerRetorno2.Clear();
                        tb_VerRetorno3.Clear();
                        tbSN.Clear();
                        tbOBS.Clear();

                        tbOBS.Enabled = false;
                        rbAprovado.Enabled = false;
                        rbReprovado.Enabled = false;

                        pictureBox1.Image = null;

                        btMostrarReprovados.PerformClick();

                        lbConta_Retorno.Visible = false;

                        tbSN.Focus();

                        consx.Close();
                    }
                }

                else
                {
                    MessageBox.Show("OS não encontrada");
                    return;
                }
                conpxy.Close();
            }
        }
    }
}
