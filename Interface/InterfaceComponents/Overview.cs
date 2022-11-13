using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.FormsControls;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class Overview : UserControl
    {
        readonly Utilidades utils = new();

        readonly Database database = new();

        readonly LimparFormularios limpar = new();

        readonly Mapper mapper = new();

        public Dash? dash { get; set; }

        public CadastroClientes? clientes { get; set; }

        private DataRow? DataGridRequest;

        public string CacheType = "Clientes";

        bool selectOrDelete;

        public string TypeControl
        {
            get
            {
                return CacheType;
            }

            set
            {
                buscar.Text = value;

                CacheType = value.Contains("Clientes") ? CPF.Checked ? "Clientes_Fisicos" : "Clientes_Juridicos" : value;

                selectOrDelete = value.Contains("Overview");

                panelContainerRadio.Visible = false;
                contentOverview.Location = new Point(0, 62);

                database.GetData = value;
                database.isCPF = CPF.Checked;
                database.GetDataGridView(dataGridView1, maskInput);

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns.Count < 10)
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }

                mapper.mapperForOverview(value, typeData, maskInput, panelContainerRadio, contentOverview, CPF.Checked);
                mapper.mapperForDatabase(value, CPF.Checked);

                DataGridRequest = null;

                maskInput.Width = 271 - typeData.Width;
                maskInput.Location = new Point(35 + (typeData.Width + 10), 7);
            }
        }
        public Overview()
        {
            InitializeComponent();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, panel17, Color.FromArgb(0, 98, 255), false, false, false, true);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void Overview_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            utils.expansiveDataGrid(20, dataGridView1);
        }

        private void buscar_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscar);
        }

        private void CPF_CheckedChanged(object sender, EventArgs e)
        {
            if (CPF.Checked)
            {
                var clientesCPF =
                    clientes!.Controls["panel17"].Controls["tableLayoutPanel2"].Controls["panelPessoaFisica"].Controls["pessoaFisica"] as RadioButton;

                clientesCPF!.Checked = true;

                CacheType = TypeControl.Contains("Clientes") ? "Clientes_Fisicos" : TypeControl;

                mapper.mapperForDatabase(CacheType, true);

                database.isCPF = true;

                CNPJ.Checked = false;
                typeData.Text = "CPF";
                maskInput.Mask = "000.000.000-00";
                maskInput.Text = "";

                database.GetData = database.Route!;
                database.GetDataGridView(dataGridView1, maskInput);
            }
        }

        private void CNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (CNPJ.Checked)
            {
                var clientesCNPJ =
                    clientes!.Controls["panel17"].Controls["tableLayoutPanel2"].Controls["panelPessoaJuridica"].Controls["pessoaJuridica"] as RadioButton;

                clientesCNPJ!.Checked = true;

                CacheType = TypeControl.Contains("Clientes") ? "Clientes_Juridicos" : TypeControl;

                mapper.mapperForDatabase(CacheType, false);

                database.isCPF = false;

                CPF.Checked = false;
                typeData.Text = "CNPJ";
                maskInput.Mask = "00.000.000/0000-00";
                maskInput.Text = "";

                database.GetDataGridView(dataGridView1, maskInput);
            }
        }

        private void panelCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterRadioButtons(CPF, panelCPF, true, true);
        }

        private void panelCNPJ_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterRadioButtons(CNPJ, panelCNPJ, true, true);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (selectOrDelete)
            {
                database.GetDataGridView(dataGridView1, maskInput);
            }

            if (!selectOrDelete)
            {
                database.GetDataGridView(dataGridView1, maskInput, "Delete");
            }

            if (maskInput.MaskCompleted)
            {
                int rowIndex = -1;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[CPF.Checked ? "CPF" : "CNPJ"].Value.ToString()!.Equals(maskInput.Text))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

                if (rowIndex >= 0)
                {
                    dataGridView1.Rows[rowIndex].Selected = true;

                    DataRow dados = ((DataRowView)dataGridView1.Rows[rowIndex].DataBoundItem).Row;

                    DataGridRequest = dados;
                }
                else
                {
                    MessageBox.Show($"{typeData.Text} não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonVerSelecionado_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buttonVerSelecionado);
        }

        private void buttonVerSelecionado_Click(object sender, EventArgs e)
        {
            if (DataGridRequest != null)
            {
                dash!.OverviewDataRequest = DataGridRequest!;

                dash.buttonUp_Click(sender, e);

                DataGridRequest = null;
            }
            else
            {
                MessageBox.Show($"Nenhum item selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                DataRow dados = ((DataRowView)row.DataBoundItem).Row;

                DataGridRequest = dados;
            }
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            maskInput.Focus();
        }

        private void maskInput_TextChanged(object sender, EventArgs e)
        {
            utils.feedbackColorInput(maskInput, typeData);

            dataGridView1.ClearSelection();

            if (maskInput.MaskCompleted)
            {
                int rowIndex = -1;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (CNPJ.Checked ? row.Cells["CNPJ"].Value.ToString()!.Equals(maskInput.Text) : row.Cells[mapper.TypeWhereDatabase].Value.ToString()!.Equals(maskInput.Text))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

                if (rowIndex >= 0)
                {
                    dataGridView1.Rows[rowIndex].Selected = true;

                    DataRow dados = ((DataRowView)dataGridView1.Rows[rowIndex].DataBoundItem).Row;

                    DataGridRequest = dados;
                }
            }
            else
            {
                DataGridRequest = null;
            }
        }
    }
}
