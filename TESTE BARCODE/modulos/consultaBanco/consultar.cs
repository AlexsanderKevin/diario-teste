using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace TESTE_BARCODE {
    partial class Form1 {
        private void tbOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\BANCO_PCI.accdb";
                string comando = "Select * from DADOS where SN=@SN";
                OleDbConnection con = new OleDbConnection(strcon);
                OleDbCommand com = new OleDbCommand(comando, con);

                com.Parameters.AddWithValue("Id", tbSN.Text);
                com.CommandType = CommandType.Text;
                OleDbDataReader reader;
                con.Open();
                try
                {
                    reader = com.ExecuteReader();
                    if (reader.Read() && reader[18].ToString() != "")
                    {
                        tbOS.Text = reader[3].ToString();
                        tbDPK.Text = reader[18].ToString();
                                                
                        btSalvar.Enabled = true;
                        btSalvar.Focus();

                        string barcode = tbDPK.Text;
                        Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
                        using (Graphics graphics = Graphics.FromImage(bitmap))

                        {
                            Font oFont = new System.Drawing.Font("IDAutomationHC39M", 15);
                            PointF point = new PointF(2f, 2f);
                            SolidBrush black = new SolidBrush(Color.Black);
                            SolidBrush White = new SolidBrush(Color.White);

                            graphics.FillRectangle(White, 0, 0, bitmap.Width, bitmap.Height);
                            graphics.DrawString("*" + barcode + "*", oFont, black, point);
                        }

                        using (MemoryStream ms = new MemoryStream())
                        {
                            bitmap.Save(ms, ImageFormat.Png);
                            pictureBox1.Image = bitmap;
                            pictureBox1.Height = bitmap.Height;
                            pictureBox1.Width = bitmap.Width;
                        }

                        pictureBox1.Visible = true;

                        con.Close();
                    }

                    else
                    {
                        MessageBox.Show("Não há DPK registrada em banco para esta máquina!");
                        btSalvar.Enabled = true;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }

                string strcony = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\10.33.33.2\publico\SERVICE.accdb";
                string comandoy = "Select * from SERVICE where SN =@SN";

                OleDbConnection cony = new OleDbConnection(strcony);
                OleDbCommand comy = new OleDbCommand(comandoy, cony);

                comy.Parameters.AddWithValue("SN", tbSN.Text);
                comy.CommandType = CommandType.Text;

                OleDbDataReader readery;

                cony.Open();

                try
                {
                    readery = comy.ExecuteReader();

                    if (readery.Read())
                    {
                        rbAprovado.Enabled = true;
                        rbReprovado.Enabled = true;
                        btLimpar.Enabled = true;
                        tbOBS.Enabled = true;

                        string conta_retorno1 = "";
                        tb_1Retorno.Text = readery[39].ToString();
                        tbVer_Status.Text = readery[33].ToString();

                        tb_VerRetorno1.Text = readery[27].ToString();
                        tb_VerRetorno2.Text = readery[29].ToString();
                        tb_VerRetorno3.Text = readery[31].ToString();

                        if (tb_1Retorno.Text == "0° TESTE")
                        {
                            conta_retorno1 = "1° TESTE";
                            tb_1Retorno.Text = conta_retorno1;
                            lbConta_Retorno.Text = tb_1Retorno.Text;
                            lbConta_Retorno.Visible = true;
                        }

                        else if (tb_1Retorno.Text == "1° TESTE")
                        {
                            lbConta_Retorno.BackColor = Color.Yellow;
                            conta_retorno1 = "2° TESTE";
                            tb_1Retorno.Text = conta_retorno1;
                            lbConta_Retorno.Text = tb_1Retorno.Text;
                            lbConta_Retorno.Visible = true;
                        }

                        else if (tb_1Retorno.Text == "2° TESTE")
                        {
                            lbConta_Retorno.BackColor = Color.Orange;
                            conta_retorno1 = "3° TESTE";
                            tb_1Retorno.Text = conta_retorno1;
                            lbConta_Retorno.Text = tb_1Retorno.Text;
                            lbConta_Retorno.Visible = true;
                        }

                        else if (tb_1Retorno.Text == "3° TESTE")
                        {
                            lbConta_Retorno.BackColor = Color.Red;
                            conta_retorno1 = "4° TESTE";
                            tb_1Retorno.Text = conta_retorno1;
                            lbConta_Retorno.Text = tb_1Retorno.Text;
                            lbConta_Retorno.Visible = true;
                        }

                        cony.Close();

                    }

                    else
                    {
                        MessageBox.Show("SN NÃO ENCONTRADO",
                      "Sem Registro",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button1);

                        tbSN.Clear();
                        tbSN.Focus();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
        }
    }
}
