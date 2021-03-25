using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(amount_txt.Text);
            if (fromcombo1.SelectedItem == "Rupiah" && tocombo2.SelectedItem == "US Dollar")
            {
                float conver = (float)i / 14468;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "US Dollar" && tocombo2.SelectedItem == "Rupiah")
            {
                float conver = (float)i * 14468;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Rupiah" && tocombo2.SelectedItem == "Euro")
            {
                float conver = (float)i / 17055;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Rupiah")
            {
                float conver = (float)i * 17055;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Rupiah" && tocombo2.SelectedItem == "Ringgit")
            {
                float conver = (float)i / 3501;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Ringgit" && tocombo2.SelectedItem == "Rupiah")
            {
                float conver = (float)i * 3501;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Ringgit" && tocombo2.SelectedItem == "US Dollar")
            {
                float conver = (float)i / (float)4.13;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "US Dollar" && tocombo2.SelectedItem == "Ringgit")
            {
                float conver = (float)i * (float)4.13;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Ringgit" && tocombo2.SelectedItem == "Euro")
            {
                float conver = (float)i / (float)4.87;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Ringgit")
            {
                float conver = (float)i / (float)4.87;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "US Dollar")
            {
                float conver = (float)i * (float)1.18;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "US Dollar" && tocombo2.SelectedItem == "Euro")
            {
                float conver = (float)i / (float)1.18;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "US Dollar" && tocombo2.SelectedItem == "US Dollar")
            {
                int conver = i;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Euro")
            {
                int conver = i;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Rupiah" && tocombo2.SelectedItem == "Rupiah")
            {
                int conver = i;
                textBox1.Text = conver.ToString();
            }
            else if (fromcombo1.SelectedItem == "Ringgit" && tocombo2.SelectedItem == "Ringgit")
            {
                int conver = i;
                textBox1.Text = conver.ToString();
            }
        }
    }
}
