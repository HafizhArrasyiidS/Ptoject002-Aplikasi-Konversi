using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace convert
{
    public partial class Form2 : Form
    {
        bool sidebarExpand;
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form2()
        {
            InitializeComponent();
            
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panel2.Width -= 10;
                if (panel2.Width == panel2.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panel2.Width += 10;
                if (panel2.Width == panel2.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage8);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage4);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private string FormatNumber(double number)
        {
            return number.ToString("#,0.########");
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage7);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox10.Text, out double inputValue))
            {
                double convertedValue = ConvertDataSize(inputValue, comboBox7.SelectedItem.ToString(), comboBox8.SelectedItem.ToString());
                textBox9.Text = convertedValue.ToString("0.###");
            }
            
        }

        private double ConvertDataSize(double value, string fromUnit, string toUnit)
        {
            string[] units = { "Byte", "Kilobyte", "Megabyte", "Gigabyte" };
            double[] multipliers = { 1, 1000, 1000 * 1000, 1000 * 1000 * 1000 };

            int fromIndex = Array.IndexOf(units, fromUnit);
            int toIndex = Array.IndexOf(units, toUnit);

            double convertedValue = value * multipliers[fromIndex] / multipliers[toIndex];
            return convertedValue;
        }

        

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox5.SelectedItem.ToString();
            string value2 = comboBox6.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if (value1 == "kg")
            {
                if (value2 == "kg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "hg")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1000;
                }
            }

            if (value1 == "hg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "hg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 100;
                }
            }

            if (value1 == "dag")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 10;
                }
            }

            if (value1 == "g")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "g")
                {
                    hasil = angka / 1;
                }
            }
            if (value1 == "hg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "hg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 100;
                }
            }
            if (value1 == "dag")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 10;
                }
            }
            if (value1 == "g")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1;
                }
            }
            textBox6.Text = hasil.ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                double n_suhu, h_suhu;

                n_suhu = Convert.ToDouble(tbn_suhu.Text);

                //celcius to
                if (cb_suhu.Text == "Celcius" && cbh_suhu.Text == "Celcius")
                {
                    h_suhu = n_suhu;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Celcius" && cbh_suhu.Text == "Fahrenheit")
                {
                    h_suhu = (n_suhu * 9 / 5) + 32;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Celcius" && cbh_suhu.Text == "Kelvin")
                {
                    h_suhu = n_suhu + 273.15;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Celcius" && cbh_suhu.Text == "Reamur")
                {
                    h_suhu = n_suhu * 4 / 5;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                //Fahrenheit to
                else
                if (cb_suhu.Text == "Fahrenheit" && cbh_suhu.Text == "Celcius")
                {
                    h_suhu = (n_suhu - 32) * 5 / 9;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Fahrenheit" && cbh_suhu.Text == "Fahrenheit")
                {
                    h_suhu = n_suhu;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Fahrenheit" && cbh_suhu.Text == "Kelvin")
                {
                    h_suhu = (n_suhu - 32) * 5 / 9 + 273.15;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Fahrenheit" && cbh_suhu.Text == "Reamur")
                {
                    h_suhu = (n_suhu - 32) * 4 / 9;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                //Kelvin to
                else
                if (cb_suhu.Text == "Kelvin" && cbh_suhu.Text == "Celcius")
                {
                    h_suhu = n_suhu - 273.15;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Kelvin" && cbh_suhu.Text == "Fahrenheit")
                {
                    h_suhu = ((n_suhu - 273.15) * 9 / 5) + 32;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Kelvin" && cbh_suhu.Text == "Kelvin")
                {
                    h_suhu = n_suhu;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Kelvin" && cbh_suhu.Text == "Reamur")
                {
                    h_suhu = (n_suhu - 273.15) * 4 / 5;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                //reamur to
                else
                if (cb_suhu.Text == "Reamur" && cbh_suhu.Text == "Celcius")
                {
                    h_suhu = n_suhu * 5 / 4;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Reamur" && cbh_suhu.Text == "Fahrenheit")
                {
                    h_suhu = (n_suhu * 9 / 4) + 32;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Reamur" && cbh_suhu.Text == "Kelvin")
                {
                    h_suhu = n_suhu * 5 / 4 + 273.15;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }

                else
                if (cb_suhu.Text == "Reamur" && cbh_suhu.Text == "Reamur")
                {
                    h_suhu = n_suhu;
                    tbh_suhu.Text = Convert.ToString(h_suhu);

                }
                else
                {
                    MessageBox.Show("tidak ada item yang dipilih");
                }
            }
        }
    

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox3.SelectedItem.ToString();
            string value2 = comboBox9.SelectedItem.ToString();

            double n_wk = double.Parse(textBox3.Text);
            double h_wk = 0;

            if (value1 == "milidetik")
            {
                if (value2 == "milidetik")
                {
                    h_wk = n_wk;
                }

                else
                if (value2 == "detik")
                {
                    h_wk = n_wk / 1000;
                }

                else
                if (value2 == "menit")
                {
                    h_wk = n_wk / (1000 * 60);
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk / (60000 * 60);
                }
                else
                {
                    MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                }


            }
            else
            if (value1 == "detik")
            {
                if (value2 == "milidetik")
                {
                    h_wk = n_wk * 1000;
                }

                else
                if (value2 == "detik")
                {
                    h_wk = n_wk;
                }

                else
                if (value2 == "menit")
                {
                    h_wk = n_wk / 60;
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk / (60 * 60);
                }
                else
                if (value2 == "hari")
                {
                    h_wk = n_wk / (3600 * 24);
                }
                if (value2 == "minggu")
                {
                    h_wk = n_wk / (3600 * 24 * 7);
                }
                if (value2 == "bulan")
                {
                    h_wk = n_wk / (3600 * 24 * 7 * 30);
                }
                if (value2 == "tahun")
                {
                    h_wk = n_wk / (3600 * 24 * 7 * 30 * 12);
                }
            }
            else
            if (value1 == "menit")
            {
                if (value2 == "milidetik")
                {
                    h_wk = n_wk * 60000;
                }

                else
                if (value2 == "detik")
                {
                    h_wk = n_wk * 60;
                }

                else
                if (value2 == "menit")
                {
                    h_wk = n_wk;
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk / 60;
                }
                else
                if (value2 == "hari")
                {
                    h_wk = n_wk / (60 * 24);
                }
                if (value2 == "minggu")
                {
                    h_wk = n_wk / (60 * 24 * 7);
                }
                if (value2 == "bulan")
                {
                    h_wk = n_wk / (60 * 24 * 7 * 30);
                }
                if (value2 == "tahun")
                {
                    h_wk = n_wk / (60 * 24 * 7 * 30 * 12);
                }
            }
            else
            if (value1 == "jam")
            {
                if (value2 == "milidetik")
                {
                    h_wk = n_wk * (60000 * 60);
                }

                else
                if (value2 == "detik")
                {
                    h_wk = n_wk * (60 * 60);
                }

                else
                if (value2 == "menit")
                {
                    h_wk = n_wk * 60;
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk;
                }
                else
                if (value2 == "hari")
                {
                    h_wk = n_wk / 24;
                }
                if (value2 == "minggu")
                {
                    h_wk = n_wk / (24 * 7);
                }
                if (value2 == "bulan")
                {
                    h_wk = n_wk / (24 * 7 * 30);
                }
                if (value2 == "tahun")
                {
                    h_wk = n_wk / (24 * 7 * 30 * 12);
                }
            }
            else
            if (value1 == "hari")
            {
                if (value2 == "detik")
                {
                    h_wk = n_wk * (60 * 60 * 24);
                }

                else
                if (value2 == "menit")
                {
                    h_wk = n_wk * 1440;
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk * 24;
                }
                else
                if (value2 == "hari")
                {
                    h_wk = n_wk;
                }
                else
                if (value2 == "minggu")
                {
                    h_wk = n_wk / 7;
                }
                else
                if (value2 == "bulan")
                {
                    h_wk = n_wk / 30;
                }
                else
                if (value2 == "tahun")
                {
                    h_wk = n_wk / 365;
                }
                else
                {
                    MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                }
            }
            else
            if (value1 == "minggu")
            {
                if (value2 == "detik")
                {
                    h_wk = n_wk * 604800;
                }

                else
                if (value2 == "menit")
                {
                    h_wk = n_wk * 10080;
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk * 168;
                }
                else
                if (value2 == "hari")
                {
                    h_wk = n_wk * 7;
                }
                else
                if (value2 == "minggu")
                {
                    h_wk = n_wk;
                }
                else
                if (value2 == "bulan")
                {
                    h_wk = n_wk / 4.345;
                }
                else
                if (value2 == "tahun")
                {
                    h_wk = n_wk / 52.143;
                }
                else
                {
                    MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                }
            }
            else
            if (value1 == "bulan")
            {
                if (value2 == "menit")
                {
                    h_wk = n_wk * 43800;
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk * 730;
                }
                else
                if (value2 == "hari")
                {
                    h_wk = n_wk * 30;
                }
                else
                if (value2 == "minggu")
                {
                    h_wk = n_wk * 4.345;
                }
                else
                if (value2 == "bulan")
                {
                    h_wk = n_wk;
                }
                else
                if (value2 == "tahun")
                {
                    h_wk = n_wk / 12;
                }
                else
                {
                    MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                }
            }

            else
            if (value1 == "tahun")
            {
                if (value2 == "menit")
                {
                    h_wk = n_wk * 525600;
                }

                else
                if (value2 == "jam")
                {
                    h_wk = n_wk * 6760;
                }
                else
                if (value2 == "hari")
                {
                    h_wk = n_wk * 365;
                }
                else
                if (value2 == "minggu")
                {
                    h_wk = n_wk * 52.1429;
                }
                else
                if (value2 == "bulan")
                {
                    h_wk = n_wk * 12;
                }
                else
                if (value2 == "tahun")
                {
                    h_wk = n_wk;
                }
                else
                {
                    MessageBox.Show("maaf untuk perhitungan ini tidak bisa di lakukan");
                }
            }
            textBox4.Text = FormatNumber(h_wk);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox2.Text);

            double hasil = 0;

            if (value1 == "km")
            {
                if (value2 == "km")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "hm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1000;
                }
            }

            if (value1 == "hm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "hm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 100;
                }
            }

            if (value1 == "dam")
            {
                if (value2 == "km")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 10;
                }
            }

            if (value1 == "m")
            {
                if (value2 == "km")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 1;
                }
            }
            if (value1 == "hm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "hm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 100;
                }
            }
            if (value1 == "dam")
            {
                if (value2 == "km")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 10;
                }
            }
            if (value1 == "m")
            {
                if (value2 == "km")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1;
                }
            }
            textBox5.Text = hasil.ToString();
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void tbn_suhu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void tbh_suhu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

