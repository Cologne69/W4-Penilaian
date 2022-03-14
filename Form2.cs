using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_Penilaian
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int counterdua = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            txt_showalamat.Enabled = false; 
            txt_showtelp.Enabled = false; 
            txt_shownama.Enabled = false;

            txt_showalamat.Text = form_main.dataAlamat[0];
            txt_showtelp.Text = form_main.dataTelp[0];
            txt_shownama.Text = form_main.dataNama[0];
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            this.Close();
            form_main fromMain = new form_main();
            fromMain.Show();
        }

        private void btn_prevdata_Click(object sender, EventArgs e)
        {
            counterdua = counterdua - 1;
            if(counterdua < 0)
            {
                MessageBox.Show("Data sudah data pertama");
                counterdua = counterdua + 1;
            }
            txt_shownama.Text = form_main.dataNama[counterdua];
            txt_showtelp.Text = form_main.dataTelp[counterdua];
            txt_showalamat.Text = form_main.dataAlamat[counterdua];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            counterdua = counterdua + 1;
            
            if(counterdua >= 10)
            {
                MessageBox.Show("Data sudah data terakhir");
                counterdua = counterdua - 1;

            }
            if (counterdua> form_main.counter-1)
            {
                MessageBox.Show("Data sudah data terakhir");
                counterdua = counterdua - 1;
            }
            txt_shownama.Text = form_main.dataNama[counterdua];
            txt_showtelp.Text = form_main.dataTelp[counterdua];
            txt_showalamat.Text = form_main.dataAlamat[counterdua];
        }
    }
}
