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

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogar.PerformClick();
            }
        }

        private void btMostrarAprovados_Click(object sender, EventArgs e)
        {
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

        private void btMostrarReprovados_Click(object sender, EventArgs e)
        {
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
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

        private void btOcultar_Click(object sender, EventArgs e)
        {
            dGridAprovados.Visible = false;
            dGridReprovados.Visible = false;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_horas = DateTime.Now;
            lbData.Text = data_horas.ToString("dd/MM/yyyy");

            lbHora.Text = data_horas.ToLongTimeString();
        }
    }
}
