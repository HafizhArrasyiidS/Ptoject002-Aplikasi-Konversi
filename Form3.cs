using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convert
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka = int.Parse(textBox1.Text);

            var hasil = 0;
            if (radioButtonKG1.Checked)
            {
                if (radioButtonKG2.Checked)
                {
                    hasil = angka * 1;
                }
                else if (radioButtonHG2.Checked)
                {
                    hasil = angka * 10;
                }
                else if (radioButtonDAG2.Checked)
                {
                    hasil = angka * 100;
                }
                else if (radioButtonG2.Checked)
                {
                    hasil = angka * 1000;
                }
            }

            if (radioButtonHG1.Checked)
            {
                if (radioButtonKG2.Checked) 
                {
                    hasil = angka / 1;
                }
                else if (radioButtonHG2.Checked)
                {
                    hasil = angka * 1;
                }
                else if (radioButtonDAG2.Checked)
                {
                   hasil = angka * 10;
                }
                else if (radioButtonG2.Checked)
                {
                    hasil = angka * 100;
                }
            }

            if (radioButtonDAG1.Checked)
            {
               if (radioButtonKG2.Checked )
                {
                    hasil = angka / 100;
                }
               else if (radioButtonHG2.Checked)
                {
                    hasil = angka / 10;
                }
               else if (radioButtonDAG2.Checked)
                {
                    hasil = angka * 1;
                }
               else if (radioButtonG2.Checked )
                {
                    hasil = angka * 10;
                }
            }

            if (radioButtonG1.Checked)
            {
                if (radioButtonKG2.Checked)
                {
                    hasil = angka / 1000;
                }
                else if (radioButtonHG2.Checked)
                {
                    hasil = angka / 100;
                }
                else if (radioButtonDAG2.Checked)
                {
                    hasil = angka / 10;
                }
                else if (radioButtonG2.Checked)
                {
                    hasil = angka / 1;
                }
            }
            
            
            MessageBox.Show("Hasil = " + hasil);
        }
    }
}
