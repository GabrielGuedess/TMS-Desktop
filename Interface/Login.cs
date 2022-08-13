using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle,
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // left
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // top
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid);// bottom
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel4.ClientRectangle,
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // left
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // top
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid);// bottom
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
    }
}
