using Interface.Properties;

namespace Interface
{
    public partial class Login : Form
    {

        readonly Utilidades utils = new();
        public Login()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, panel3, Color.FromArgb(30, 30, 36), true, true, true, true);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, panel4, Color.FromArgb(30, 30, 36), true, true, true, true);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Image = Image.FromFile("C:\\Users\\Gabriel\\Downloads\\eye.png");
                textBox2.PasswordChar = '\0';
                checkBox1.BackColor = Color.FromArgb(8, 8, 11);
            }
            else
            {
                checkBox1.Image = Image.FromFile("C:\\Users\\Gabriel\\Downloads\\eyeOpen.png");
                textBox2.PasswordChar = '*';
                checkBox1.BackColor = Color.FromArgb(8, 8, 11);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dash Form = new Dash();

            this.Hide();

            Form.ShowDialog();

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            utils.expansivePanels(20, panel1);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, button1);
        }
    }
}
