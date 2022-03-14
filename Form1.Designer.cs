namespace W4_Penilaian
{
    partial class form_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_telp = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_telp = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_lihatdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(27, 37);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(42, 15);
            this.lbl_nama.TabIndex = 0;
            this.lbl_nama.Text = "Nama:";
            this.lbl_nama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Location = new System.Drawing.Point(21, 62);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(48, 15);
            this.lbl_alamat.TabIndex = 1;
            this.lbl_alamat.Text = "Alamat:";
            // 
            // lbl_telp
            // 
            this.lbl_telp.AutoSize = true;
            this.lbl_telp.Location = new System.Drawing.Point(38, 86);
            this.lbl_telp.Name = "lbl_telp";
            this.lbl_telp.Size = new System.Drawing.Size(31, 15);
            this.lbl_telp.TabIndex = 2;
            this.lbl_telp.Text = "Telp:";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(75, 34);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(237, 23);
            this.txt_nama.TabIndex = 3;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(75, 59);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(414, 23);
            this.txt_alamat.TabIndex = 4;
            // 
            // txt_telp
            // 
            this.txt_telp.Location = new System.Drawing.Point(75, 83);
            this.txt_telp.Name = "txt_telp";
            this.txt_telp.Size = new System.Drawing.Size(204, 23);
            this.txt_telp.TabIndex = 5;
            this.txt_telp.TextChanged += new System.EventHandler(this.txt_telp_TextChanged);
            this.txt_telp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(38, 147);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 6;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_lihatdata
            // 
            this.btn_lihatdata.Location = new System.Drawing.Point(132, 147);
            this.btn_lihatdata.Name = "btn_lihatdata";
            this.btn_lihatdata.Size = new System.Drawing.Size(75, 23);
            this.btn_lihatdata.TabIndex = 7;
            this.btn_lihatdata.Text = "Lihat Data";
            this.btn_lihatdata.UseVisualStyleBackColor = true;
            this.btn_lihatdata.Click += new System.EventHandler(this.btn_nextdata_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 220);
            this.Controls.Add(this.btn_lihatdata);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_telp);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.lbl_telp);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.lbl_nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nama;
        private Label lbl_alamat;
        private Label lbl_telp;
        private TextBox txt_nama;
        private TextBox txt_alamat;
        private TextBox txt_telp;
        private Button btn_simpan;
        private Button btn_lihatdata;
    }
}