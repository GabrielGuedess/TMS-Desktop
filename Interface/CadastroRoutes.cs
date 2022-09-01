using GMap.NET;
using GMap.NET.Internals;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using Interface.Properties;
using Microsoft.VisualBasic.Logging;

namespace Interface
{
    public partial class CadastroRoutes : UserControl
    {
        readonly Utilidades utils = new();

        public string TypeControl
        {
            set
            {
                cadastrarRota.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentRotas.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentRotas.Location = new Point(0, 62);
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
            utils.expansiveButton(10, calcularRota);

            contentRotas.Location = new Point(0, 62);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarRota);
        }

        private bool validar()
        {
            if(tbIDRota.Text == String.Empty)
            {
                MessageBox.Show("O campo Id Rota é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbIDRota.Focus();
                return false;
            }
            else if(tbStatusViagem.Text == string.Empty)
            {
                MessageBox.Show("O campo Codigo Status da Viagem é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbStatusViagem.Focus();
                return false;
            }
            else if(tbMotorista.Text == string.Empty)
            {
                MessageBox.Show("O campo Codigo Motorista(s) é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbMotorista.Focus();
                return false;
            }
            else if (tbProgresso.Text == string.Empty)
            {
                MessageBox.Show("O campo Codigo Progresso é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbProgresso.Focus();
                return false;
            }
            else if (tbEntrega.Text == string.Empty)
            {
                MessageBox.Show("O campo Entrega é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbEntrega.Focus();
                return false;
            }
            else if (comboVeiculo.Text == string.Empty)
            {
                MessageBox.Show("O campo Veículo(s) é Obrigatorio", "Erro", MessageBoxButtons.OK);
                comboVeiculo.Focus();
                return false;
            }
            else if (tbDistanciaTotal.Text == string.Empty)
            {
                MessageBox.Show("O campo Distancia total é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbDistanciaTotal.Focus();
                return false;
            }
            else if (tbProximaEntrega.Text == string.Empty)
            {
                MessageBox.Show("O campo Proxima Entrega é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbProximaEntrega.Focus();
                return false;
            }
            else if (tbCustoEstimado.Text == string.Empty)
            {
                MessageBox.Show("O campo Custo Estimado é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbCustoEstimado.Focus();
                return false;
            }
            else if (tbConhecimentoTransporte.Text == string.Empty)
            {
                MessageBox.Show("O campo Conhecimento de Transporte é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbConhecimentoTransporte.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                string SQL = "Insert Into Rotas (ID_Rota, Entrega, Motorista, Veiculos, D_Total, " +
                    "S_Viagem, C_Estimado, Progresso, P_Destino, C_Transp) Values " +
                    $"('{tbIDRota.Text}', '{tbEntrega.Text}', '{tbMotorista.Text}', '{comboVeiculo.Text}', " +
                    $"'{tbDistanciaTotal.Text}', '{tbStatusViagem.Text}', '{tbCustoEstimado.Text}', " +
                    $"'{tbProgresso.Text}', '{tbProximaEntrega.Text}', '{tbConhecimentoTransporte.Text}')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentRotas);
            }
        }
    }
}
