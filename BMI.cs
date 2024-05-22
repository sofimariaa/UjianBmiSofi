using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIsejahtera
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double beradbadan;
            double tinggibadan;
            double hasilbmi;

            beradbadan = Convert.ToDouble(beradBadan.Text);
            tinggibadan= (0.01 * Convert.ToDouble(tinggiBadan.Text)) *(0.01 * Convert.ToDouble(tinggiBadan.Text));

            hasilbmi = beradbadan / tinggibadan;

            hasilBmi.Text = hasilbmi.ToString();

            if (hasilbmi < 18.5)
            {
                lblketerangan.Text = namaanda.Text + " berad Badan anda kurang";

            }
            else if (hasilbmi < 18.5 && hasilbmi <= 22.9)
            {
                lblketerangan.Text = namaanda.Text + " berad Badan anda normal";
            }
            else if (hasilbmi < 23 && hasilbmi <= 29.9)
            {
                lblketerangan.Text = namaanda.Text + " berad Badan anda berlebihan (cenderung obesitas)";
            }
            else
            {
                lblketerangan.Text = namaanda.Text + " berad Badan anda obesitas";
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult psn = MessageBox.Show("ingin menghapus data BMI"+"?","Hapus Data BMI", MessageBoxButtons.YesNo);
            if (psn == DialogResult.Yes)
            {
                namaanda.Text = " ";
                usia.Text = " ";
                jenis.Text= " ";
                tinggiBadan.Text = " ";
                beradBadan.Text= " ";
                hasilBmi.Text = " ";
                lblketerangan.Text = " ";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult psn = MessageBox.Show("Ingin keluar Dari Halaman ini" + "?", "Keluar dari halaman", MessageBoxButtons.YesNo);
            if (psn == DialogResult.Yes)
            {
                namaanda.Text = " ";
                usia.Text = " ";
                jenis.Text = " ";
                tinggiBadan.Text = " ";
                beradBadan.Text = " ";
                hasilBmi.Text = " ";
                lblketerangan.Text = " ";

                selesai form = new selesai();
                form.ShowDialog();


                

            }
        }
    }
    }

