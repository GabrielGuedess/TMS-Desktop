using GMap.NET.Internals;
using Interface.Properties;
using System.Runtime.ConstrainedExecution;
using System;
using System.Numerics;

namespace Interface
{
    public partial class ClienteCNPJ : UserControl
    {
        public string TypeControl
        {
            set { cadastrarCNPJ.Text = value; }
        }

        public ClienteCNPJ()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if(mkCNPJ.Text.Length < 14)
            {
                MessageBox.Show("O campo CNPF é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCNPJ.Focus();
                return false;
            }
            if (tbRazaoSocial.Text == string.Empty)
            {
                MessageBox.Show("O campo Razão Social é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbRazaoSocial.Focus();
                return false;
            }

            if (tbNomeFantasia.Text == "")
            {
                MessageBox.Show("O campo Nome Fantasia é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNomeFantasia.Focus();
                return false;
            }
            if (mkTelefone.Text.Length > 1 && mkTelefone.Text.Length < 10)
            {
                MessageBox.Show("O campo Telefone é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkTelefone.Focus();
                return false;
            }
            if (mkCelular.MaskCompleted ==false)
            {
                MessageBox.Show("O campo Celular é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCelular.Focus();
                return false;
            }
            if (mkInscricaoEstatudal.MaskCompleted == false)
            {
                MessageBox.Show("O campo Inscrição Estadual é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkInscricaoEstatudal.Focus();
                return false;
            }
            if (comboSituacaoCNPJ.Text == string.Empty)
            {
                MessageBox.Show("O campo Situação é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboSituacaoCNPJ.Focus();
                return false;
            }
            if (tbEmail.Text == string.Empty)
            {
                MessageBox.Show("O campo Email é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Focus();
                return false;
            }
            if (mkCEP.MaskCompleted == false)
            {
                MessageBox.Show("O campo CEP é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCEP.Focus();
                return false;
            }
            if (tbNumCasa.Text == string.Empty)
            {
                MessageBox.Show("O campo Num é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumCasa.Focus();
                return false;
            }
            if (tbBairro.Text == string.Empty)
            {
                MessageBox.Show("O campo Bairro é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbBairro.Focus();
                return false;
            }
            if (comboCidade.Text == string.Empty)
            {
                MessageBox.Show("O campo Cidade é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCidade.Focus();
                return false;
            }
            if (comboUF.Text == string.Empty)
            {
                MessageBox.Show("O campo UF é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboUF.Focus();
                return false;
            }
            if (mkCNPJ.MaskCompleted == false)
            {
                MessageBox.Show("O campo CNPJ é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCNPJ.Focus();
                return false;
            }
            if(tbLogradouro.Text == string.Empty)
            {
                MessageBox.Show("O campo Logradouro é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLogradouro.Focus();
                return false;
            }
            return true;
        }

        private void cadastrarCNPJ_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                string SQL = "insert into Pessoa_Juridica (CNPJ, Raz_Soc, Nom_Fan, Ins_Est, Tel, Situacao, Num_Cel, Email," +
                    " CEP, Endereco, Numero, Comple, Bairro, Cidade, UF) values";
                SQL += "('" + mkCNPJ.Text + "','" + tbRazaoSocial.Text + "" +
                    "','" + tbNomeFantasia.Text + "','" + mkInscricaoEstatudal.Text + "','"
                    + mkTelefone.Text + "','" + comboSituacaoCNPJ.Text + "','" + mkCelular.Text + "','"
                    + tbEmail.Text + "','" + mkCEP.Text + "','" + tbLogradouro.Text + "','" + tbNumCasa.Text + "" +
                    "','" + tbComplemento.Text + "','" + tbBairro.Text + "','" + comboCidade.Text + "','"
                    + comboUF.Text + "')";


                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentCNPJ);
            }
        }
    }
}
