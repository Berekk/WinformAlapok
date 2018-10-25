using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformAlapokOOPGyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnKuldes_MouseHover(object sender, EventArgs e)
        {
            btnKuldes.ForeColor = Color.Aqua;
        }

        private void btnSzinvaltas_MouseHover(object sender, EventArgs e)
        {
            btnSzinvaltas.ForeColor = Color.Aqua;
        }

        private void btnKuldes_MouseLeave(object sender, EventArgs e)
        {
            btnKuldes.ForeColor = SystemColors.ControlText;
        }

        private void btnSzinvaltas_MouseLeave(object sender, EventArgs e)
        {
            btnSzinvaltas.ForeColor = SystemColors.ControlText;
        }

        private void btnKuldes_Click(object sender, EventArgs e)
        {
            label.Text = textBox.Text;
        }

        private void kiiratas(Emberek vmi)
        {
            listBox.Items.Clear();
            string[] words = vmi.ToString().Split('|');
            foreach (var i in words)
            {
                listBox.Items.Add(i);
            }

        }

        private void btnSzinvaltas_Click(object sender, EventArgs e)
        {
            if (label.ForeColor!=Color.Red)
            {
                label.ForeColor = Color.Red;
            }
            else
            {
                label.ForeColor = Color.Blue;
            }

        }

        private void btnHarmadikFeladat_Click(object sender, EventArgs e)
        {
            Emberek valami = new Emberek(Convert.ToInt32(numericUpDown.Value));
            kiiratas(valami);

            lblAtlagosTestSuly.Text = "Átlagos testsúly: " + Convert.ToString(valami.atlagosTestSuly());
            lblAtlagosMagassag.Text = "Átlagos magasság: " + Convert.ToString(valami.atlagosTestMagassag());
            lblLegnagyobbTTI.Text = "Legnagyob TTI: " + Convert.ToString(valami.legnagyobbTTISorszam());
            lblLegkisebbTTI.Text = "Legkisebb TTI: " + Convert.ToString(valami.legkisebbTTISorszam());
            lblElsoNormal.Text = "Első normál testalkatú: " + Convert.ToString(valami.egyEmberKiiras(valami.elsoNormalTestalkat()));
        }

        private void lblCounter_MouseClick(object sender, MouseEventArgs e)
        {
            int temp = Convert.ToInt32(lblCounter.Text);
            if (e.Button == MouseButtons.Left)
            {
                temp++;
                lblCounter.Text = Convert.ToString(temp);
            }
            else
            {
                temp--;
                lblCounter.Text = Convert.ToString(temp);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;

            switch (e.KeyCode)
            {

                case Keys.PageUp:
                    y = 0;
                    break;
                case Keys.PageDown:
                    y = (1080 - this.Height);
                    break;
                case Keys.End:
                    x = (1920 - this.Width);
                    break;
                case Keys.Home:
                    x = 0;
                    break;
                case Keys.Left:
                    x -= 20;
                    break;
                case Keys.Up:
                    y -= 20;
                    break;
                case Keys.Right:
                    x += 20;
                    break;
                case Keys.Down:
                    y += 20;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    break;
            }

            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }
            if (x > (1920 - this.Width))
            {
                x = (1920 - this.Width);
            }
            if (y > (1080 - this.Height))
            {
                y = (1080 - this.Height);
            }

            this.Location = new Point(x, y);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox4.Focus();
        }
    }
}
