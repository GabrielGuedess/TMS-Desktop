using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroNotasFicais : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                cadastrarNota.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentNotas.Location = new Point(0, 0);

                    tbChaveAcesso.ReadOnly = false;
                    tbChaveAcesso.Cursor = Cursors.IBeam;
                    buscarCod.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentNotas.Location = new Point(0, 62);

                    tbChaveAcesso.ReadOnly = true;
                    tbChaveAcesso.Cursor = Cursors.No;
                    buscarCod.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                tbSearchChaveAcesso.Text = value["CHAVE_ACESSO"].ToString();

                if (value != null)
                {
                    tbIDNotaFiscal.Text = value["NUM_ID"].ToString();
                    tbChaveAcesso.Text = value["CHAVE_ACESSO"].ToString();
                    tbNumero.Text = value["NUMERO"].ToString();
                    tbTipoNota.Text = value["TIPO"].ToString();
                    tbSerieNota.Text = value["SERIE"].ToString();
                    tbDescricaoNota.Text = value["DESCRICAO"].ToString();
                }
            }
        }

        public CadastroNotasFicais()
        {
            InitializeComponent();
            atualizarIDNota();
        }

        private void CadastroNotasFicais_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelID, panelTipo);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarNota_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarNota);
        }
        private void buscarCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCod);
        }

        private void atualizarIDNota()
        {
            ConnectDB connectDB = new ConnectDB();
            string SQL = "SELECT MAX (NUM_ID) FROM C_Nota_Fiscal";
            var dados = connectDB.pesquisar(SQL);
            string data = (string)dados!.Rows[0][0];
            string IdNota = data.Replace("F", "");
            int numID = int.Parse(IdNota);
            numID++;
            string numIDsg = numID.ToString();
            if (numIDsg.Length == 1)
            {
                numIDsg = numIDsg.Insert(numIDsg.Length - 1, "00");
            }
            else if (numIDsg.Length == 2)
                numIDsg = numIDsg.Insert(numIDsg.Length - 2, "0");
            tbIDNotaFiscal.Text = "F" + numIDsg;
        }

        private void cadastrarNota_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && validar())
            {
                string SQL = "Insert Into C_Nota_Fiscal (NUM_ID, CHAVE_ACESSO,NUMERO,TIPO,SERIE,DESCRICAO) Values";
                SQL += $"('{tbIDNotaFiscal.Text.TrimStart()} ','{tbChaveAcesso.Text}','{tbNumero.Text}', '{tbTipoNota.Text}', '{tbSerieNota.Text}', '{tbDescricaoNota.Text}')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentNotas);
                limpar.CleanControl(searchPanel);

                atualizarIDNota();
            }

            if (Type.Contains("Update") && validar())
            {
                string SQLUp = $"UPDATE C_Nota_Fiscal SET " +
                $"NUM_ID= '{tbIDNotaFiscal.Text}', " +
                $"NUMERO= '{tbNumero.Text}', " +
                $"TIPO= '{tbTipoNota.Text}', " +
                $"SERIE= '{tbSerieNota.Text}', " +
                $"DESCRICAO= '{tbDescricaoNota.Text}' " +
                $"WHERE CHAVE_ACESSO = '{tbSearchChaveAcesso.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentNotas);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarCod_Click(object sender, EventArgs e)
        {
            if (tbSearchChaveAcesso.Text != "")
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM C_Nota_Fiscal WHERE CHAVE_ACESSO = '{tbSearchChaveAcesso.Text}'", contentNotas)!;

                if (dados != null)
                {
                    tbSearchChaveAcesso.Text = dados["CHAVE_ACESSO"].ToString();

                    tbIDNotaFiscal.Text = dados["NUM_ID"].ToString();
                    tbNumero.Text = dados["NUMERO"].ToString();
                    tbTipoNota.Text = dados["TIPO"].ToString();
                    tbSerieNota.Text = dados["SERIE"].ToString();
                    tbDescricaoNota.Text = dados["DESCRICAO"].ToString();
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSearchChaveAcesso.Focus();
            }
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            tbSearchChaveAcesso.Focus();
        }

        private void tbSearchChaveAcesso_TextChanged(object sender, EventArgs e)
        {
            tbChaveAcesso.Text = tbSearchChaveAcesso.Text;

            utils.feedbackColorInputNumLetters(tbSearchChaveAcesso, typeData);
        }
        private bool validar()
        {
            if (tbChaveAcesso.Text.Length < 44)
            {
                MessageBox.Show("Chave de Acesso digitada é inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbNumero.Text == "")
            {
                MessageBox.Show("Digite o Numero da nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbTipoNota.Text == "")
            {
                MessageBox.Show("Escolha o tipo de nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbSerieNota.Text == "")
            {
                MessageBox.Show("Digite a série da nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbDescricaoNota.Text == "")
            {
                MessageBox.Show("Digite uma descrição para nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
