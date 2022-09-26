namespace exe2dsfelipe
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
			this.btnCarregar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.rbSexo = new System.Windows.Forms.RadioButton();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblRg = new System.Windows.Forms.Label();
			this.lblTel = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblCep = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.lblPais = new System.Windows.Forms.Label();
			this.lblInsta = new System.Windows.Forms.Label();
			this.lblFace = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.btnIndicar = new System.Windows.Forms.Button();
			this.btnAlternar = new System.Windows.Forms.Button();
			this.btnConsulta = new System.Windows.Forms.Button();
			this.btnExibir = new System.Windows.Forms.Button();
			this.btnRetirar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.lblCad = new System.Windows.Forms.Label();
			this.rbSexoM = new System.Windows.Forms.RadioButton();
			this.gbDados = new System.Windows.Forms.GroupBox();
			this.gbSexo = new System.Windows.Forms.GroupBox();
			this.tbTel = new System.Windows.Forms.TextBox();
			this.tbCpf = new System.Windows.Forms.TextBox();
			this.tbRg = new System.Windows.Forms.TextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbCod = new System.Windows.Forms.TextBox();
			this.gbEndereco = new System.Windows.Forms.GroupBox();
			this.tbCidade = new System.Windows.Forms.TextBox();
			this.tbPais = new System.Windows.Forms.TextBox();
			this.tbBairro = new System.Windows.Forms.TextBox();
			this.tbLogradouro = new System.Windows.Forms.TextBox();
			this.tbNumero = new System.Windows.Forms.TextBox();
			this.tbCep = new System.Windows.Forms.TextBox();
			this.gbExtra = new System.Windows.Forms.GroupBox();
			this.tbFace = new System.Windows.Forms.TextBox();
			this.tbInsta = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.cbInsta = new System.Windows.Forms.CheckBox();
			this.cbFace = new System.Windows.Forms.CheckBox();
			this.cbEmail = new System.Windows.Forms.CheckBox();
			this.pcbImg = new System.Windows.Forms.PictureBox();
			this.gbDados.SuspendLayout();
			this.gbSexo.SuspendLayout();
			this.gbEndereco.SuspendLayout();
			this.gbExtra.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbImg)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCarregar
			// 
			this.btnCarregar.Location = new System.Drawing.Point(679, 79);
			this.btnCarregar.Name = "btnCarregar";
			this.btnCarregar.Size = new System.Drawing.Size(75, 38);
			this.btnCarregar.TabIndex = 1;
			this.btnCarregar.Text = "CARREGAR IMAGEM";
			this.btnCarregar.UseVisualStyleBackColor = true;
			this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(679, 182);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 35);
			this.btnLimpar.TabIndex = 2;
			this.btnLimpar.Text = "LIMPAR IMAGEM";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// rbSexo
			// 
			this.rbSexo.AutoSize = true;
			this.rbSexo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSexo.Location = new System.Drawing.Point(9, 16);
			this.rbSexo.Name = "rbSexo";
			this.rbSexo.Size = new System.Drawing.Size(86, 24);
			this.rbSexo.TabIndex = 4;
			this.rbSexo.TabStop = true;
			this.rbSexo.Text = "Feminino\r\n";
			this.rbSexo.UseVisualStyleBackColor = true;
			this.rbSexo.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigo.Location = new System.Drawing.Point(22, 101);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(58, 20);
			this.lblCodigo.TabIndex = 6;
			this.lblCodigo.Text = "Código:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(22, 29);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(49, 20);
			this.lblNome.TabIndex = 7;
			this.lblNome.Text = "Nome:";
			// 
			// lblRg
			// 
			this.lblRg.AutoSize = true;
			this.lblRg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRg.Location = new System.Drawing.Point(22, 64);
			this.lblRg.Name = "lblRg";
			this.lblRg.Size = new System.Drawing.Size(32, 20);
			this.lblRg.TabIndex = 8;
			this.lblRg.Text = "RG:";
			this.lblRg.Click += new System.EventHandler(this.lblRg_Click);
			// 
			// lblTel
			// 
			this.lblTel.AutoSize = true;
			this.lblTel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTel.Location = new System.Drawing.Point(235, 101);
			this.lblTel.Name = "lblTel";
			this.lblTel.Size = new System.Drawing.Size(66, 20);
			this.lblTel.TabIndex = 9;
			this.lblTel.Text = "Telefone:";
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpf.Location = new System.Drawing.Point(262, 64);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(39, 20);
			this.lblCpf.TabIndex = 10;
			this.lblCpf.Text = "CPF:";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCity.Location = new System.Drawing.Point(534, 57);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(56, 20);
			this.lblCity.TabIndex = 12;
			this.lblCity.Text = "Cidade:";
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCep.Location = new System.Drawing.Point(20, 22);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(40, 20);
			this.lblCep.TabIndex = 13;
			this.lblCep.Text = "CEP:";
			this.lblCep.Click += new System.EventHandler(this.lblCep_Click);
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(20, 57);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(62, 20);
			this.lblNumero.TabIndex = 14;
			this.lblNumero.Text = "Número:";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBairro.Location = new System.Drawing.Point(233, 57);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(51, 20);
			this.lblBairro.TabIndex = 15;
			this.lblBairro.Text = "Bairro:";
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogradouro.Location = new System.Drawing.Point(213, 22);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(86, 20);
			this.lblLogradouro.TabIndex = 16;
			this.lblLogradouro.Text = "Logradouro:";
			// 
			// lblPais
			// 
			this.lblPais.AutoSize = true;
			this.lblPais.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPais.Location = new System.Drawing.Point(573, 22);
			this.lblPais.Name = "lblPais";
			this.lblPais.Size = new System.Drawing.Size(40, 20);
			this.lblPais.TabIndex = 17;
			this.lblPais.Text = "País:";
			// 
			// lblInsta
			// 
			this.lblInsta.AutoSize = true;
			this.lblInsta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInsta.Location = new System.Drawing.Point(20, 90);
			this.lblInsta.Name = "lblInsta";
			this.lblInsta.Size = new System.Drawing.Size(80, 20);
			this.lblInsta.TabIndex = 19;
			this.lblInsta.Text = "Instragram:";
			this.lblInsta.Click += new System.EventHandler(this.lblInsta_Click);
			// 
			// lblFace
			// 
			this.lblFace.AutoSize = true;
			this.lblFace.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFace.Location = new System.Drawing.Point(20, 57);
			this.lblFace.Name = "lblFace";
			this.lblFace.Size = new System.Drawing.Size(73, 20);
			this.lblFace.TabIndex = 20;
			this.lblFace.Text = "Facebook:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(20, 28);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(53, 20);
			this.lblEmail.TabIndex = 21;
			this.lblEmail.Text = "E-mail:";
			this.lblEmail.Click += new System.EventHandler(this.lblTwitter_Click);
			// 
			// btnIndicar
			// 
			this.btnIndicar.Location = new System.Drawing.Point(19, 448);
			this.btnIndicar.Name = "btnIndicar";
			this.btnIndicar.Size = new System.Drawing.Size(75, 23);
			this.btnIndicar.TabIndex = 22;
			this.btnIndicar.Text = "INDICAR";
			this.btnIndicar.UseVisualStyleBackColor = true;
			this.btnIndicar.Click += new System.EventHandler(this.btnIndicar_Click);
			// 
			// btnAlternar
			// 
			this.btnAlternar.Location = new System.Drawing.Point(143, 448);
			this.btnAlternar.Name = "btnAlternar";
			this.btnAlternar.Size = new System.Drawing.Size(75, 23);
			this.btnAlternar.TabIndex = 23;
			this.btnAlternar.Text = "ALTERNAR";
			this.btnAlternar.UseVisualStyleBackColor = true;
			// 
			// btnConsulta
			// 
			this.btnConsulta.Location = new System.Drawing.Point(266, 448);
			this.btnConsulta.Name = "btnConsulta";
			this.btnConsulta.Size = new System.Drawing.Size(85, 23);
			this.btnConsulta.TabIndex = 24;
			this.btnConsulta.Text = "CONSULTAR";
			this.btnConsulta.UseVisualStyleBackColor = true;
			this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
			// 
			// btnExibir
			// 
			this.btnExibir.Location = new System.Drawing.Point(407, 448);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(75, 23);
			this.btnExibir.TabIndex = 25;
			this.btnExibir.Text = "EXIBIR";
			this.btnExibir.UseVisualStyleBackColor = true;
			// 
			// btnRetirar
			// 
			this.btnRetirar.Location = new System.Drawing.Point(540, 448);
			this.btnRetirar.Name = "btnRetirar";
			this.btnRetirar.Size = new System.Drawing.Size(75, 23);
			this.btnRetirar.TabIndex = 26;
			this.btnRetirar.Text = "LIMPAR";
			this.btnRetirar.UseVisualStyleBackColor = true;
			this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(679, 448);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 27;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// lblCad
			// 
			this.lblCad.AutoSize = true;
			this.lblCad.Font = new System.Drawing.Font("Arial Narrow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblCad.Location = new System.Drawing.Point(162, 9);
			this.lblCad.Name = "lblCad";
			this.lblCad.Size = new System.Drawing.Size(394, 57);
			this.lblCad.TabIndex = 28;
			this.lblCad.Text = "Cadastro de Cliente";
			// 
			// rbSexoM
			// 
			this.rbSexoM.AutoSize = true;
			this.rbSexoM.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSexoM.Location = new System.Drawing.Point(101, 16);
			this.rbSexoM.Name = "rbSexoM";
			this.rbSexoM.Size = new System.Drawing.Size(91, 24);
			this.rbSexoM.TabIndex = 29;
			this.rbSexoM.TabStop = true;
			this.rbSexoM.Text = "Masculino";
			this.rbSexoM.UseVisualStyleBackColor = true;
			this.rbSexoM.CheckedChanged += new System.EventHandler(this.lblSexoM_CheckedChanged);
			// 
			// gbDados
			// 
			this.gbDados.Controls.Add(this.gbSexo);
			this.gbDados.Controls.Add(this.tbTel);
			this.gbDados.Controls.Add(this.tbCpf);
			this.gbDados.Controls.Add(this.tbRg);
			this.gbDados.Controls.Add(this.tbNome);
			this.gbDados.Controls.Add(this.tbCod);
			this.gbDados.Controls.Add(this.lblCpf);
			this.gbDados.Controls.Add(this.lblCodigo);
			this.gbDados.Controls.Add(this.lblNome);
			this.gbDados.Controls.Add(this.lblTel);
			this.gbDados.Controls.Add(this.lblRg);
			this.gbDados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDados.Location = new System.Drawing.Point(0, 58);
			this.gbDados.Name = "gbDados";
			this.gbDados.Size = new System.Drawing.Size(522, 173);
			this.gbDados.TabIndex = 30;
			this.gbDados.TabStop = false;
			this.gbDados.Text = "Dados Pessoais";
			// 
			// gbSexo
			// 
			this.gbSexo.Controls.Add(this.rbSexoM);
			this.gbSexo.Controls.Add(this.rbSexo);
			this.gbSexo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbSexo.Location = new System.Drawing.Point(26, 124);
			this.gbSexo.Name = "gbSexo";
			this.gbSexo.Size = new System.Drawing.Size(456, 43);
			this.gbSexo.TabIndex = 32;
			this.gbSexo.TabStop = false;
			this.gbSexo.Text = "Sexo";
			// 
			// tbTel
			// 
			this.tbTel.Location = new System.Drawing.Point(303, 98);
			this.tbTel.Name = "tbTel";
			this.tbTel.Size = new System.Drawing.Size(179, 26);
			this.tbTel.TabIndex = 34;
			// 
			// tbCpf
			// 
			this.tbCpf.Location = new System.Drawing.Point(303, 61);
			this.tbCpf.Name = "tbCpf";
			this.tbCpf.Size = new System.Drawing.Size(179, 26);
			this.tbCpf.TabIndex = 33;
			// 
			// tbRg
			// 
			this.tbRg.Location = new System.Drawing.Point(60, 61);
			this.tbRg.Name = "tbRg";
			this.tbRg.Size = new System.Drawing.Size(175, 26);
			this.tbRg.TabIndex = 32;
			// 
			// tbNome
			// 
			this.tbNome.Location = new System.Drawing.Point(73, 26);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(409, 26);
			this.tbNome.TabIndex = 31;
			// 
			// tbCod
			// 
			this.tbCod.Location = new System.Drawing.Point(82, 98);
			this.tbCod.Name = "tbCod";
			this.tbCod.Size = new System.Drawing.Size(112, 26);
			this.tbCod.TabIndex = 30;
			// 
			// gbEndereco
			// 
			this.gbEndereco.Controls.Add(this.tbCidade);
			this.gbEndereco.Controls.Add(this.tbPais);
			this.gbEndereco.Controls.Add(this.tbBairro);
			this.gbEndereco.Controls.Add(this.tbLogradouro);
			this.gbEndereco.Controls.Add(this.tbNumero);
			this.gbEndereco.Controls.Add(this.tbCep);
			this.gbEndereco.Controls.Add(this.lblCep);
			this.gbEndereco.Controls.Add(this.lblNumero);
			this.gbEndereco.Controls.Add(this.lblPais);
			this.gbEndereco.Controls.Add(this.lblCity);
			this.gbEndereco.Controls.Add(this.lblLogradouro);
			this.gbEndereco.Controls.Add(this.lblBairro);
			this.gbEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbEndereco.Location = new System.Drawing.Point(2, 234);
			this.gbEndereco.Name = "gbEndereco";
			this.gbEndereco.Size = new System.Drawing.Size(769, 94);
			this.gbEndereco.TabIndex = 30;
			this.gbEndereco.TabStop = false;
			this.gbEndereco.Text = "Endereço";
			// 
			// tbCidade
			// 
			this.tbCidade.Location = new System.Drawing.Point(596, 54);
			this.tbCidade.Name = "tbCidade";
			this.tbCidade.Size = new System.Drawing.Size(153, 26);
			this.tbCidade.TabIndex = 23;
			// 
			// tbPais
			// 
			this.tbPais.Location = new System.Drawing.Point(619, 19);
			this.tbPais.Name = "tbPais";
			this.tbPais.Size = new System.Drawing.Size(144, 26);
			this.tbPais.TabIndex = 22;
			// 
			// tbBairro
			// 
			this.tbBairro.Location = new System.Drawing.Point(286, 54);
			this.tbBairro.Name = "tbBairro";
			this.tbBairro.Size = new System.Drawing.Size(210, 26);
			this.tbBairro.TabIndex = 21;
			// 
			// tbLogradouro
			// 
			this.tbLogradouro.Location = new System.Drawing.Point(301, 19);
			this.tbLogradouro.Name = "tbLogradouro";
			this.tbLogradouro.Size = new System.Drawing.Size(265, 26);
			this.tbLogradouro.TabIndex = 20;
			// 
			// tbNumero
			// 
			this.tbNumero.Location = new System.Drawing.Point(84, 54);
			this.tbNumero.Name = "tbNumero";
			this.tbNumero.Size = new System.Drawing.Size(68, 26);
			this.tbNumero.TabIndex = 19;
			// 
			// tbCep
			// 
			this.tbCep.Location = new System.Drawing.Point(62, 19);
			this.tbCep.Name = "tbCep";
			this.tbCep.Size = new System.Drawing.Size(130, 26);
			this.tbCep.TabIndex = 18;
			// 
			// gbExtra
			// 
			this.gbExtra.Controls.Add(this.tbFace);
			this.gbExtra.Controls.Add(this.tbInsta);
			this.gbExtra.Controls.Add(this.tbEmail);
			this.gbExtra.Controls.Add(this.cbInsta);
			this.gbExtra.Controls.Add(this.cbFace);
			this.gbExtra.Controls.Add(this.cbEmail);
			this.gbExtra.Controls.Add(this.lblEmail);
			this.gbExtra.Controls.Add(this.lblFace);
			this.gbExtra.Controls.Add(this.lblInsta);
			this.gbExtra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbExtra.Location = new System.Drawing.Point(2, 320);
			this.gbExtra.Name = "gbExtra";
			this.gbExtra.Size = new System.Drawing.Size(786, 122);
			this.gbExtra.TabIndex = 31;
			this.gbExtra.TabStop = false;
			this.gbExtra.Text = "Dados Extras";
			// 
			// tbFace
			// 
			this.tbFace.Location = new System.Drawing.Point(95, 54);
			this.tbFace.Name = "tbFace";
			this.tbFace.Size = new System.Drawing.Size(559, 26);
			this.tbFace.TabIndex = 33;
			this.tbFace.TextChanged += new System.EventHandler(this.tbFace_TextChanged);
			// 
			// tbInsta
			// 
			this.tbInsta.Location = new System.Drawing.Point(106, 87);
			this.tbInsta.Name = "tbInsta";
			this.tbInsta.Size = new System.Drawing.Size(548, 26);
			this.tbInsta.TabIndex = 32;
			this.tbInsta.TextChanged += new System.EventHandler(this.tbInsta_TextChanged);
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(71, 22);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(583, 26);
			this.tbEmail.TabIndex = 31;
			this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
			// 
			// cbInsta
			// 
			this.cbInsta.AutoSize = true;
			this.cbInsta.Location = new System.Drawing.Point(673, 89);
			this.cbInsta.Name = "cbInsta";
			this.cbInsta.Size = new System.Drawing.Size(90, 24);
			this.cbInsta.TabIndex = 30;
			this.cbInsta.Text = "Instagram";
			this.cbInsta.UseVisualStyleBackColor = true;
			this.cbInsta.CheckedChanged += new System.EventHandler(this.cbInsta_CheckedChanged);
			// 
			// cbFace
			// 
			this.cbFace.AutoSize = true;
			this.cbFace.Location = new System.Drawing.Point(673, 56);
			this.cbFace.Name = "cbFace";
			this.cbFace.Size = new System.Drawing.Size(88, 24);
			this.cbFace.TabIndex = 29;
			this.cbFace.Text = "Facebook";
			this.cbFace.UseVisualStyleBackColor = true;
			this.cbFace.CheckedChanged += new System.EventHandler(this.cbFace_CheckedChanged);
			// 
			// cbEmail
			// 
			this.cbEmail.AutoSize = true;
			this.cbEmail.Location = new System.Drawing.Point(673, 27);
			this.cbEmail.Name = "cbEmail";
			this.cbEmail.Size = new System.Drawing.Size(68, 24);
			this.cbEmail.TabIndex = 28;
			this.cbEmail.Text = "E-mail";
			this.cbEmail.UseVisualStyleBackColor = true;
			this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
			// 
			// pcbImg
			// 
			this.pcbImg.Location = new System.Drawing.Point(528, 79);
			this.pcbImg.Name = "pcbImg";
			this.pcbImg.Size = new System.Drawing.Size(121, 138);
			this.pcbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbImg.TabIndex = 0;
			this.pcbImg.TabStop = false;
			this.pcbImg.Click += new System.EventHandler(this.pcbImg_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(800, 483);
			this.Controls.Add(this.gbExtra);
			this.Controls.Add(this.gbEndereco);
			this.Controls.Add(this.gbDados);
			this.Controls.Add(this.lblCad);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnRetirar);
			this.Controls.Add(this.btnExibir);
			this.Controls.Add(this.btnConsulta);
			this.Controls.Add(this.btnAlternar);
			this.Controls.Add(this.btnIndicar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCarregar);
			this.Controls.Add(this.pcbImg);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exercício 2 Felipe Barbosa";
			this.gbDados.ResumeLayout(false);
			this.gbDados.PerformLayout();
			this.gbSexo.ResumeLayout(false);
			this.gbSexo.PerformLayout();
			this.gbEndereco.ResumeLayout(false);
			this.gbEndereco.PerformLayout();
			this.gbExtra.ResumeLayout(false);
			this.gbExtra.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbImg;
		private System.Windows.Forms.Button btnCarregar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.RadioButton rbSexo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblRg;
		private System.Windows.Forms.Label lblTel;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.Label lblPais;
		private System.Windows.Forms.Label lblInsta;
		private System.Windows.Forms.Label lblFace;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Button btnIndicar;
		private System.Windows.Forms.Button btnAlternar;
		private System.Windows.Forms.Button btnConsulta;
		private System.Windows.Forms.Button btnExibir;
		private System.Windows.Forms.Button btnRetirar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label lblCad;
		private System.Windows.Forms.RadioButton rbSexoM;
		private System.Windows.Forms.GroupBox gbDados;
		private System.Windows.Forms.GroupBox gbEndereco;
		private System.Windows.Forms.GroupBox gbExtra;
		private System.Windows.Forms.CheckBox cbInsta;
		private System.Windows.Forms.CheckBox cbFace;
		private System.Windows.Forms.CheckBox cbEmail;
		private System.Windows.Forms.TextBox tbTel;
		private System.Windows.Forms.TextBox tbCpf;
		private System.Windows.Forms.TextBox tbRg;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.TextBox tbCod;
		private System.Windows.Forms.GroupBox gbSexo;
		private System.Windows.Forms.TextBox tbCidade;
		private System.Windows.Forms.TextBox tbPais;
		private System.Windows.Forms.TextBox tbBairro;
		private System.Windows.Forms.TextBox tbLogradouro;
		private System.Windows.Forms.TextBox tbNumero;
		private System.Windows.Forms.TextBox tbCep;
		private System.Windows.Forms.TextBox tbInsta;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbFace;
	}
}

