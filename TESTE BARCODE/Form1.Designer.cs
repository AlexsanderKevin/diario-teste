namespace TESTE_BARCODE
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btLogar = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbSN = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbOBS = new System.Windows.Forms.Label();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbOBS = new System.Windows.Forms.TextBox();
            this.rbAprovado = new System.Windows.Forms.RadioButton();
            this.rbReprovado = new System.Windows.Forms.RadioButton();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btMostrarAprovados = new System.Windows.Forms.Button();
            this.btMostrarReprovados = new System.Windows.Forms.Button();
            this.dGridAprovados = new System.Windows.Forms.DataGridView();
            this.dGridReprovados = new System.Windows.Forms.DataGridView();
            this.lbDPK = new System.Windows.Forms.Label();
            this.imgLogoLenovo = new System.Windows.Forms.PictureBox();
            this.tbDPK = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btOcultar = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.lbConta_Retorno = new System.Windows.Forms.Label();
            this.tb_1Retorno = new System.Windows.Forms.TextBox();
            this.tbVer_Status = new System.Windows.Forms.TextBox();
            this.tb_VerRetorno1 = new System.Windows.Forms.TextBox();
            this.tb_VerRetorno2 = new System.Windows.Forms.TextBox();
            this.tb_VerRetorno3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbOS = new System.Windows.Forms.TextBox();
            this.lbOS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAprovados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridReprovados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLenovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(799, 21);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(136, 20);
            this.tbSenha.TabIndex = 0;
            this.tbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenha_KeyDown);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Black;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.White;
            this.lbSenha.Location = new System.Drawing.Point(837, 2);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(60, 16);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "SENHA";
            // 
            // btLogar
            // 
            this.btLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogar.Location = new System.Drawing.Point(832, 47);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(75, 23);
            this.btLogar.TabIndex = 2;
            this.btLogar.Text = "ENTRAR";
            this.btLogar.UseVisualStyleBackColor = true;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.Black;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.White;
            this.lbData.Location = new System.Drawing.Point(80, 13);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(49, 16);
            this.lbData.TabIndex = 3;
            this.lbData.Text = "DATA";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.Black;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(255, 13);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(51, 16);
            this.lbHora.TabIndex = 4;
            this.lbHora.Text = "HORA";
            // 
            // lbSN
            // 
            this.lbSN.AutoSize = true;
            this.lbSN.BackColor = System.Drawing.Color.Black;
            this.lbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSN.ForeColor = System.Drawing.Color.White;
            this.lbSN.Location = new System.Drawing.Point(26, 111);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(29, 16);
            this.lbSN.TabIndex = 5;
            this.lbSN.Text = "SN";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Black;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(26, 140);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(52, 16);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "NOME";
            // 
            // lbOBS
            // 
            this.lbOBS.AutoSize = true;
            this.lbOBS.BackColor = System.Drawing.Color.Black;
            this.lbOBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOBS.ForeColor = System.Drawing.Color.White;
            this.lbOBS.Location = new System.Drawing.Point(25, 167);
            this.lbOBS.Name = "lbOBS";
            this.lbOBS.Size = new System.Drawing.Size(39, 16);
            this.lbOBS.TabIndex = 7;
            this.lbOBS.Text = "OBS";
            // 
            // tbSN
            // 
            this.tbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSN.Location = new System.Drawing.Point(110, 110);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(310, 20);
            this.tbSN.TabIndex = 8;
            this.tbSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOS_KeyDown);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(110, 139);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(310, 20);
            this.tbNome.TabIndex = 9;
            // 
            // tbOBS
            // 
            this.tbOBS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOBS.Location = new System.Drawing.Point(109, 166);
            this.tbOBS.Name = "tbOBS";
            this.tbOBS.Size = new System.Drawing.Size(310, 20);
            this.tbOBS.TabIndex = 10;
            // 
            // rbAprovado
            // 
            this.rbAprovado.AutoSize = true;
            this.rbAprovado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAprovado.ForeColor = System.Drawing.Color.White;
            this.rbAprovado.Location = new System.Drawing.Point(129, 223);
            this.rbAprovado.Name = "rbAprovado";
            this.rbAprovado.Size = new System.Drawing.Size(93, 17);
            this.rbAprovado.TabIndex = 11;
            this.rbAprovado.TabStop = true;
            this.rbAprovado.Text = "APROVADO";
            this.rbAprovado.UseVisualStyleBackColor = true;
            // 
            // rbReprovado
            // 
            this.rbReprovado.AutoSize = true;
            this.rbReprovado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReprovado.ForeColor = System.Drawing.Color.White;
            this.rbReprovado.Location = new System.Drawing.Point(291, 223);
            this.rbReprovado.Name = "rbReprovado";
            this.rbReprovado.Size = new System.Drawing.Size(102, 17);
            this.rbReprovado.TabIndex = 12;
            this.rbReprovado.TabStop = true;
            this.rbReprovado.Text = "REPROVADO";
            this.rbReprovado.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(497, 69);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(103, 54);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btMostrarAprovados
            // 
            this.btMostrarAprovados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btMostrarAprovados.Enabled = false;
            this.btMostrarAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrarAprovados.Location = new System.Drawing.Point(691, 84);
            this.btMostrarAprovados.Name = "btMostrarAprovados";
            this.btMostrarAprovados.Size = new System.Drawing.Size(206, 36);
            this.btMostrarAprovados.TabIndex = 14;
            this.btMostrarAprovados.Text = "MOSTRAR\r\nAPROVADOS";
            this.btMostrarAprovados.UseVisualStyleBackColor = false;
            this.btMostrarAprovados.Click += new System.EventHandler(this.btMostrarAprovados_Click);
            // 
            // btMostrarReprovados
            // 
            this.btMostrarReprovados.BackColor = System.Drawing.Color.Red;
            this.btMostrarReprovados.Enabled = false;
            this.btMostrarReprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrarReprovados.Location = new System.Drawing.Point(691, 126);
            this.btMostrarReprovados.Name = "btMostrarReprovados";
            this.btMostrarReprovados.Size = new System.Drawing.Size(206, 36);
            this.btMostrarReprovados.TabIndex = 15;
            this.btMostrarReprovados.Text = "MOSTRAR\r\nREPROVADOS";
            this.btMostrarReprovados.UseVisualStyleBackColor = false;
            this.btMostrarReprovados.Click += new System.EventHandler(this.btMostrarReprovados_Click);
            // 
            // dGridAprovados
            // 
            this.dGridAprovados.BackgroundColor = System.Drawing.Color.Black;
            this.dGridAprovados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAprovados.Location = new System.Drawing.Point(2, 420);
            this.dGridAprovados.Name = "dGridAprovados";
            this.dGridAprovados.Size = new System.Drawing.Size(660, 170);
            this.dGridAprovados.TabIndex = 16;
            // 
            // dGridReprovados
            // 
            this.dGridReprovados.BackgroundColor = System.Drawing.Color.Black;
            this.dGridReprovados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridReprovados.Location = new System.Drawing.Point(2, 420);
            this.dGridReprovados.Name = "dGridReprovados";
            this.dGridReprovados.Size = new System.Drawing.Size(660, 175);
            this.dGridReprovados.TabIndex = 17;
            // 
            // lbDPK
            // 
            this.lbDPK.AutoSize = true;
            this.lbDPK.BackColor = System.Drawing.Color.Black;
            this.lbDPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDPK.ForeColor = System.Drawing.Color.White;
            this.lbDPK.Location = new System.Drawing.Point(-1, 245);
            this.lbDPK.Name = "lbDPK";
            this.lbDPK.Size = new System.Drawing.Size(38, 16);
            this.lbDPK.TabIndex = 19;
            this.lbDPK.Text = "DPK";
            // 
            // imgLogoLenovo
            // 
            this.imgLogoLenovo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoLenovo.Image")));
            this.imgLogoLenovo.Location = new System.Drawing.Point(777, 2);
            this.imgLogoLenovo.Name = "imgLogoLenovo";
            this.imgLogoLenovo.Size = new System.Drawing.Size(159, 50);
            this.imgLogoLenovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoLenovo.TabIndex = 20;
            this.imgLogoLenovo.TabStop = false;
            // 
            // tbDPK
            // 
            this.tbDPK.Enabled = false;
            this.tbDPK.Location = new System.Drawing.Point(581, 32);
            this.tbDPK.Name = "tbDPK";
            this.tbDPK.Size = new System.Drawing.Size(107, 20);
            this.tbDPK.TabIndex = 21;
            this.tbDPK.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(2, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(497, 152);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(103, 54);
            this.btLimpar.TabIndex = 22;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btOcultar
            // 
            this.btOcultar.Enabled = false;
            this.btOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOcultar.Location = new System.Drawing.Point(739, 170);
            this.btOcultar.Name = "btOcultar";
            this.btOcultar.Size = new System.Drawing.Size(120, 36);
            this.btOcultar.TabIndex = 23;
            this.btOcultar.Text = "OCULTAR TESTES";
            this.btOcultar.UseVisualStyleBackColor = true;
            this.btOcultar.Click += new System.EventHandler(this.btOcultar_Click);
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Image = ((System.Drawing.Image)(resources.GetObject("btLogout.Image")));
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogout.Location = new System.Drawing.Point(730, 6);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(38, 38);
            this.btLogout.TabIndex = 24;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // lbConta_Retorno
            // 
            this.lbConta_Retorno.AutoSize = true;
            this.lbConta_Retorno.BackColor = System.Drawing.Color.Lime;
            this.lbConta_Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConta_Retorno.ForeColor = System.Drawing.Color.Black;
            this.lbConta_Retorno.Location = new System.Drawing.Point(222, 49);
            this.lbConta_Retorno.Name = "lbConta_Retorno";
            this.lbConta_Retorno.Size = new System.Drawing.Size(76, 16);
            this.lbConta_Retorno.TabIndex = 25;
            this.lbConta_Retorno.Text = "1º TESTE";
            this.lbConta_Retorno.Visible = false;
            // 
            // tb_1Retorno
            // 
            this.tb_1Retorno.Enabled = false;
            this.tb_1Retorno.Location = new System.Drawing.Point(581, 103);
            this.tb_1Retorno.Name = "tb_1Retorno";
            this.tb_1Retorno.Size = new System.Drawing.Size(107, 20);
            this.tb_1Retorno.TabIndex = 26;
            this.tb_1Retorno.Visible = false;
            // 
            // tbVer_Status
            // 
            this.tbVer_Status.Enabled = false;
            this.tbVer_Status.Location = new System.Drawing.Point(581, 69);
            this.tbVer_Status.Name = "tbVer_Status";
            this.tbVer_Status.Size = new System.Drawing.Size(107, 20);
            this.tbVer_Status.TabIndex = 27;
            this.tbVer_Status.Visible = false;
            // 
            // tb_VerRetorno1
            // 
            this.tb_VerRetorno1.Enabled = false;
            this.tb_VerRetorno1.Location = new System.Drawing.Point(581, 131);
            this.tb_VerRetorno1.Name = "tb_VerRetorno1";
            this.tb_VerRetorno1.Size = new System.Drawing.Size(107, 20);
            this.tb_VerRetorno1.TabIndex = 28;
            this.tb_VerRetorno1.Visible = false;
            // 
            // tb_VerRetorno2
            // 
            this.tb_VerRetorno2.Enabled = false;
            this.tb_VerRetorno2.Location = new System.Drawing.Point(581, 157);
            this.tb_VerRetorno2.Name = "tb_VerRetorno2";
            this.tb_VerRetorno2.Size = new System.Drawing.Size(107, 20);
            this.tb_VerRetorno2.TabIndex = 29;
            this.tb_VerRetorno2.Visible = false;
            // 
            // tb_VerRetorno3
            // 
            this.tb_VerRetorno3.Enabled = false;
            this.tb_VerRetorno3.Location = new System.Drawing.Point(581, 183);
            this.tb_VerRetorno3.Name = "tb_VerRetorno3";
            this.tb_VerRetorno3.Size = new System.Drawing.Size(107, 20);
            this.tb_VerRetorno3.TabIndex = 30;
            this.tb_VerRetorno3.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbOS
            // 
            this.tbOS.Enabled = false;
            this.tbOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOS.Location = new System.Drawing.Point(110, 82);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(310, 20);
            this.tbOS.TabIndex = 32;
            // 
            // lbOS
            // 
            this.lbOS.AutoSize = true;
            this.lbOS.BackColor = System.Drawing.Color.Black;
            this.lbOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOS.ForeColor = System.Drawing.Color.White;
            this.lbOS.Location = new System.Drawing.Point(26, 83);
            this.lbOS.Name = "lbOS";
            this.lbOS.Size = new System.Drawing.Size(29, 16);
            this.lbOS.TabIndex = 31;
            this.lbOS.Text = "OS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(940, 607);
            this.Controls.Add(this.tbOS);
            this.Controls.Add(this.lbOS);
            this.Controls.Add(this.tb_VerRetorno3);
            this.Controls.Add(this.tb_VerRetorno2);
            this.Controls.Add(this.tb_VerRetorno1);
            this.Controls.Add(this.tbVer_Status);
            this.Controls.Add(this.tb_1Retorno);
            this.Controls.Add(this.lbConta_Retorno);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btOcultar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbDPK);
            this.Controls.Add(this.imgLogoLenovo);
            this.Controls.Add(this.lbDPK);
            this.Controls.Add(this.dGridReprovados);
            this.Controls.Add(this.dGridAprovados);
            this.Controls.Add(this.btMostrarReprovados);
            this.Controls.Add(this.btMostrarAprovados);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.rbReprovado);
            this.Controls.Add(this.rbAprovado);
            this.Controls.Add(this.tbOBS);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.lbOBS);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbSN);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tbSenha);
            this.Name = "Form1";
            this.Text = "TESTE 3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAprovados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridReprovados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLenovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbSN;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbOBS;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbOBS;
        private System.Windows.Forms.RadioButton rbAprovado;
        private System.Windows.Forms.RadioButton rbReprovado;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btMostrarAprovados;
        private System.Windows.Forms.Button btMostrarReprovados;
        private System.Windows.Forms.DataGridView dGridAprovados;
        private System.Windows.Forms.DataGridView dGridReprovados;
        private System.Windows.Forms.Label lbDPK;
        private System.Windows.Forms.PictureBox imgLogoLenovo;
        private System.Windows.Forms.TextBox tbDPK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btOcultar;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label lbConta_Retorno;
        private System.Windows.Forms.TextBox tb_1Retorno;
        private System.Windows.Forms.TextBox tbVer_Status;
        private System.Windows.Forms.TextBox tb_VerRetorno1;
        private System.Windows.Forms.TextBox tb_VerRetorno2;
        private System.Windows.Forms.TextBox tb_VerRetorno3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.Label lbOS;
    }
}

