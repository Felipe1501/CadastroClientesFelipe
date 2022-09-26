using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2dsfelipe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			pcbImg.BorderStyle = BorderStyle.Fixed3D;
		}

		private void btnCarregar_Click(object sender, EventArgs e)
		{
			pcbImg.Image = Properties.Resources.eu;

		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			pcbImg.Image = null;
		}

		private void pcbImg_Click(object sender, EventArgs e)
		{

		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnRetirar_Click(object sender, EventArgs e)
		{
			tbNome.Text = "";
			tbRg.Text = "";
			tbCod.Text = "";
			tbCpf.Text = "";
			tbTel.Text = "";
			tbCep.Text = "";
			tbNumero.Text = "";
			tbPais.Text = "";
			tbLogradouro.Text = "";
			tbBairro.Text = "";
			tbCidade.Text = "";
			tbEmail.Text = "";
			tbFace.Text = "";
			tbInsta.Text = "";
			pcbImg.Image = null;
		}

		private void lblRg_Click(object sender, EventArgs e)
		{

		}

		private void lblTwitter_Click(object sender, EventArgs e)
		{

		}

		private void lblCep_Click(object sender, EventArgs e)
		{

		}

		private void lblSexoM_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void lblInsta_Click(object sender, EventArgs e)
		{

		}

		private void btnIndicar_Click(object sender, EventArgs e)
		{
			pcbImg.Image = Properties.Resources.maxresdefault;
			tbNome.Text = "Peter Parker";
			tbRg.Text = "1963150155";
			tbCpf.Text = "88845884428";
			tbCod.Text = "1963";
			tbTel.Text = "40028922";
			rbSexoM.Checked = true;
			tbCep.Text = "11730000";
			tbCidade.Text = "New York";
			tbBairro.Text = "Queens";
			tbPais.Text = "Estados Unidos";
			tbLogradouro.Text = "Avenida Peixe de Couro";
			tbNumero.Text = "213";
			cbFace.Checked = true;
			tbFace.Text = "Peter Parker";

		}

		private void btnConsulta_Click(object sender, EventArgs e)
		{
			string nm, rg, cpf, cod, tel, cep, pais, log, bairro, city, num, email, insta, face;

			nm = (tbNome.Text);
			rg = (tbRg.Text);
			cpf = (tbCpf.Text);
			cod = (tbCod.Text);
			tel = (tbTel.Text);
			cep = (tbCep.Text);
			bairro = (tbBairro.Text);
			city = (tbCidade.Text);
			num = (tbNumero.Text);
			pais = (tbPais.Text);
			log = (tbLogradouro.Text);
			email = (tbEmail.Text);
			face = (tbFace.Text);
			insta = (tbInsta.Text);

			if (tbNome.Text == "")
			{
				MessageBox.Show("Sem Nome Cadastrado!!! ",
  "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{

				MessageBox.Show("SEUS DADOS FORAM CADASTRADOS! " + nm,
	"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("RG: " + rg,
	 "DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("CPF: " + cpf,
	"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("CÓDIGO: " + cod,
	"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (rbSexo.Checked)
				{
					rbSexo.Checked = true;
					MessageBox.Show("Feminino", "SEXO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					rbSexo.Checked = false;
					MessageBox.Show(" Masculino", "SEXO", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				MessageBox.Show("TELEFONE: " + tel,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("CEP: " + cep,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("LOGRADOURO: " + log,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("NÚMERO: " + num,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("Bairro: " + bairro,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("CIDADE: " + city,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("PAÍS: " + pais,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (cbEmail.Checked)
				{
					MessageBox.Show("DADOS EXTRAS EMAIL: " + email,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (cbFace.Checked)
				{
					MessageBox.Show("DADOS EXTRAS FACEBOOK: " + face,
"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else if(cbInsta.Checked) {
					MessageBox.Show("DADOS EXTRAS INSTAGRAM: " + insta,
	"DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void rbSexo_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void cbEmail_CheckedChanged(object sender, EventArgs e)
		{
			if (cbEmail.Checked)
			{
				tbEmail.ReadOnly = false;
			}
			else {
				tbEmail.ReadOnly = true;
			}
		}

		private void cbFace_CheckedChanged(object sender, EventArgs e)
		{
			if (cbFace.Checked)
			{
				tbFace.ReadOnly = false;
			}
			else {
				tbFace.ReadOnly = true;
			}
		}

		private void cbInsta_CheckedChanged(object sender, EventArgs e)
		{
			if (cbInsta.Checked)
			{
				tbInsta.ReadOnly = false;
			}
			else {
				tbInsta.ReadOnly = true;
			}
		}

		private void tbEmail_TextChanged(object sender, EventArgs e)
		{
			tbEmail.ReadOnly = true;
		}

		private void tbFace_TextChanged(object sender, EventArgs e)
		{
			tbEmail.ReadOnly = true;
		}

		private void tbInsta_TextChanged(object sender, EventArgs e)
		{
			tbEmail.ReadOnly = true;
		}
	}
}
