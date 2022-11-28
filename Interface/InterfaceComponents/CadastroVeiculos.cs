using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class CadastroVeiculos : UserControl
    {
        readonly Utilidades utils = new();

        LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                cadastrarVeiculo.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentVeiculos.Location = new Point(0, 0);

                    mkPlaca.ReadOnly = false;
                    mkPlaca.Cursor = Cursors.IBeam;
                    buscarPlaca.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentVeiculos.Location = new Point(0, 62);

                    mkPlaca.ReadOnly = true;
                    mkPlaca.Cursor = Cursors.No;
                    buscarPlaca.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                maskPlaca.Text = value["Placa"].ToString();

                if (value != null)
                {

                }
            }
        }

        public CadastroVeiculos()
        {
            InitializeComponent();
        }

        private void CadastroVeiculos_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelPlaca, panelAno, panelCapacidade, panelRNTRC);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarVeiculo_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarVeiculo);
        }
        private void buscarPlaca_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarPlaca);
        }

        private void cadastrarVeiculo_Click(object sender, EventArgs e)
        {
            List<string> notValidar = new();

            if (Type.Contains("Cadastro") && Validation.Validar(contentVeiculos, notValidar))
            {
               
                limpar.CleanControl(contentVeiculos);
                limpar.CleanControl(searchPanel);
            }

            if (Type.Contains("Update") && Validation.Validar(contentVeiculos, notValidar))
            {
               

                limpar.CleanControl(contentVeiculos);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarPlaca_Click(object sender, EventArgs e)
        {
            if (maskPlaca.MaskCompleted)
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM tbVeiculos WHERE Placa = '{maskPlaca.Text}'", contentVeiculos)!;

                if (dados != null)
                {
                   
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // mkCPF.Focus();
            }
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            maskPlaca.Focus();
        }

        private void maskPlaca_TextChanged(object sender, EventArgs e)
        {
            mkPlaca.Text = maskPlaca.Text;

            utils.feedbackColorInput(maskPlaca, typeData);
        }
    }
}
