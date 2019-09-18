using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

        }

        private void ButtonRes_Click(object sender, EventArgs e)
        {
            double x, y, z, s;
            if (double.TryParse(textBoxY.Text, out y) == false && double.TryParse(textBoxZ.Text, out z) == false && double.TryParse(textBoxX.Text, out x) == false)
            {
                MessageBox.Show("Помилка введення значення x,y,z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxX.Text, out x) == false && double.TryParse(textBoxY.Text, out y) == false)
            {
                MessageBox.Show("Помилка введення значення x,y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxX.Text, out x) == false && double.TryParse(textBoxZ.Text, out z) == false)
            {
                MessageBox.Show("Помилка введення значення x,z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxY.Text, out y) == false && double.TryParse(textBoxZ.Text, out z) == false)
            {
                MessageBox.Show("Помилка введення значення y,z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxX.Text, out x) == false)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxY.Text, out y) == false)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxZ.Text, out z) == false)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                x = Convert.ToDouble(textBoxX.Text);
                y = Convert.ToDouble(textBoxY.Text);
                z = Convert.ToDouble(textBoxZ.Text);
                double y1 = Math.Pow(y, 2 - z);
                if (y1 == Math.Asin(-0.5) || y1 == (Math.PI - Math.Asin(-0.5)))
                {
                    MessageBox.Show("Помилка, знаменник дорівнює 0!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    s = (2 * Math.Cos(x * x) - 0.5) / (0.5 + Math.Sin(y1)) + z * z / (7 - z / 3.0);
                    textBoxR.Text = s.ToString("F2");
                }
            }
        }
    }
}
