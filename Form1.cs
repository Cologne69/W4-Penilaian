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
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }
        public static int counter = 0;
        //DataTable tabelData = new DataTable();
        public static int counterArray = 11;
        public static string[] dataNama = new string[counterArray];
        public static string[] dataAlamat = new string[counterArray];
        public static string[] dataTelp = new string[counterArray];
        
        public void form_main_Load(object sender, EventArgs e)
        {
            /*DataRow dr = tabelData.NewRow();
            tabelData.Columns.Add("Nama"); 
            tabelData.Columns.Add("Alamat"); 
            tabelData.Columns.Add("Telp");*/
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            counter=counter+1;
            
            dataNama[counter-1]= txt_nama.Text;
            dataAlamat[counter-1]=txt_alamat.Text;
            dataTelp[counter-1]= txt_telp.Text;
            txt_nama.Text = "";
            txt_alamat.Text = "";
            txt_telp.Text = "";


            if (counter>10)
            {
                MessageBox.Show("Data sudah penuh!");
                counter = counter - 1;
;            }
        }
        
        private void btn_nextdata_Click(object sender, EventArgs e)
        {
            Form2 formData = new Form2();
            form_main fromMain = new form_main();   
            formData.Show();
            this.Hide();

        }

        private void txt_telp_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}