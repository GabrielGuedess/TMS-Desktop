using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class CadastroRoutes : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                button2.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentRotas.Location = new Point(0, 0);

                    tbIDRota.ReadOnly = false;
                    tbIDRota.Cursor = Cursors.IBeam;
                    buscarRota.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentRotas.Location = new Point(0, 62);

                    tbIDRota.ReadOnly = true;
                    tbIDRota.Cursor = Cursors.No;
                    buscarRota.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                IdRotas.Text = value["ID_Rota"].ToString();

                if (value != null)
                {
                    tbIDRota.Text = value["ID_Rota"].ToString();
                    tbStatusViagem.Text = value["S_Viagem"].ToString();
                    tbMotorista.Text = value["Motorista"].ToString();
                    comboVeiculo.Text = value["Veiculos"].ToString();
                    tbDistanciaTotal.Text = value["D_Total"].ToString();
                    tbProgresso.Text = value["Progresso"].ToString();
                    tbEntrega.Text = value["Entrega"].ToString();
                    tbProximaEntrega.Text = value["P_Destino"].ToString();
                    tbCustoEstimado.Text = value["C_Estimado"].ToString();
                    tbConhecimentoTransporte.Text = value["C_Transp"].ToString();
                }
            }
        }
        public CadastroRoutes()
        {
            InitializeComponent();
        }

        private void CadastroRoutes_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
            map.MouseWheelZoomEnabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            map.Visible = true;
            map.Height = 500;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;

            //double lat1 = Convert.ToDouble(Convert.ToDouble(latitude1.Text));
            //double lon1 = Convert.ToDouble(Convert.ToDouble(long1.Text));

            //double lat2 = Convert.ToDouble(Convert.ToDouble(latitude2.Text));
            // double lon2 = Convert.ToDouble(Convert.ToDouble(long2.Text));

            //PointLatLng point = new PointLatLng(lat1, lon1);

            //map.Position = point;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;

            // _points.Add(new PointLatLng(lat1, lon1));
            //  _points.Add(new PointLatLng(lat2, lon2));

            //var route = GoogleMapProvider.Instance.GetRoute(new PointLatLng(lat1, lon1), new PointLatLng(lat2, lon2), false, false, 14);

            //var r = new GMapRoute(route.Points, "Your Route");

            //GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            //var routes = new GMapOverlay("routes");

            var markers = new GMapOverlay("markers");

            //.Routes.Add(r);

            //map.Overlays.Add(routes);

            //markers.Markers.Add(marker);

            //map.Overlays.Add(markers);

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, button1);

            contentRotas.Location = new Point(0, 62);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, button2);
        }

        private void buscarRota_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarRota);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && Validation.Validar(contentRotas))
            {
                string SQL = "Insert Into Rotas (ID_Rota, Entrega, Motorista, Veiculos, D_Total, " +
                    "S_Viagem, C_Estimado, Progresso, P_Destino, C_Transp) Values " +
                    $"('{tbIDRota.Text}', '{tbEntrega.Text}', '{tbMotorista.Text}', '{comboVeiculo.Text}', " +
                    $"'{tbDistanciaTotal.Text}', '{tbStatusViagem.Text}', '{tbCustoEstimado.Text}', " +
                    $"'{tbProgresso.Text}', '{tbProximaEntrega.Text}', '{tbConhecimentoTransporte.Text}')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentRotas);
                limpar.CleanControl(searchPanel);
            }

            if (Type.Contains("Update") && Validation.Validar(contentRotas))
            {
                string SQLUp = $"UPDATE Rotas SET " +
                $"Entrega= '{tbEntrega.Text}', " +
                $"Motorista= '{tbMotorista.Text}', " +
                $"Veiculos= '{comboVeiculo.Text}', " +
                $"D_Total= '{tbDistanciaTotal.Text}', " +
                $"S_Viagem= '{tbStatusViagem.Text}', " +
                $"C_Estimado= '{tbCustoEstimado.Text}', " +
                $"Progresso= '{tbProgresso.Text}', " +
                $"P_Destino= '{tbProximaEntrega.Text}', " +
                $"C_Transp= '{tbConhecimentoTransporte.Text}' " +
                $"WHERE ID_Rota = '{IdRotas.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentRotas);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarRota_Click(object sender, EventArgs e)
        {
            if (IdRotas.Text != "")
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM Rotas WHERE ID_Rota = '{IdRotas.Text}'", contentRotas)!;

                if (dados != null)
                {
                    IdRotas.Text = dados["ID_Rota"].ToString();

                    tbEntrega.Text = dados["Entrega"].ToString();
                    tbMotorista.Text = dados["Motorista"].ToString();
                    comboVeiculo.Text = dados["Veiculos"].ToString();
                    tbDistanciaTotal.Text = dados["D_Total"].ToString();
                    tbStatusViagem.Text = dados["S_Viagem"].ToString();
                    tbCustoEstimado.Text = dados["C_Estimado"].ToString();
                    tbProgresso.Text = dados["Progresso"].ToString();
                    tbProximaEntrega.Text = dados["P_Destino"].ToString();
                    tbConhecimentoTransporte.Text = dados["C_Transp"].ToString();
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdRotas.Focus();
            }
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void CadastroRoutes_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            IdRotas.Focus();
        }

        private void IdRotas_TextChanged(object sender, EventArgs e)
        {
            tbIDRota.Text = IdRotas.Text;

            utils.feedbackColorInputNum(IdRotas, typeData);
        }
    }
}
