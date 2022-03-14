namespace W4_Penilaian
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_prevdata = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.txt_showtelp = new System.Windows.Forms.TextBox();
            this.txt_showalamat = new System.Windows.Forms.TextBox();
            this.txt_shownama = new System.Windows.Forms.TextBox();
            this.lbl_telp = new System.Windows.Forms.Label();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.btn_nextdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_prevdata
            // 
            this.btn_prevdata.Location = new System.Drawing.Point(121, 141);
            this.btn_prevdata.Name = "btn_prevdata";
            this.btn_prevdata.Size = new System.Drawing.Size(75, 23);
            this.btn_prevdata.TabIndex = 15;
            this.btn_prevdata.Text = "Prev Data";
            this.btn_prevdata.UseVisualStyleBackColor = true;
            this.btn_prevdata.Click += new System.EventHandler(this.btn_prevdata_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.Location = new System.Drawing.Point(40, 141);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(75, 23);
            this.btn_kembali.TabIndex = 14;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // txt_showtelp
            // 
            this.txt_showtelp.Location = new System.Drawing.Point(77, 77);
            this.txt_showtelp.Name = "txt_showtelp";
            this.txt_showtelp.Size = new System.Drawing.Size(204, 23);
            this.txt_showtelp.TabIndex = 13;
            // 
            // txt_showalamat
            // 
            this.txt_showalamat.Location = new System.Drawing.Point(77, 53);
            this.txt_showalamat.Name = "txt_showalamat";
            this.txt_showalamat.Size = new System.Drawing.Size(414, 23);
            this.txt_showalamat.TabIndex = 12;
            // 
            // txt_shownama
            // 
            this.txt_shownama.Location = new System.Drawing.Point(77, 28);
            this.txt_shownama.Name = "txt_shownama";
            this.txt_shownama.Size = new System.Drawing.Size(237, 23);
            this.txt_shownama.TabIndex = 11;
            // 
            // lbl_telp
            // 
            this.lbl_telp.AutoSize = true;
            this.lbl_telp.Location = new System.Drawing.Point(40, 80);
            this.lbl_telp.Name = "lbl_telp";
            this.lbl_telp.Size = new System.Drawing.Size(31, 15);
            this.lbl_telp.TabIndex = 10;
            this.lbl_telp.Text = "Telp:";
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Location = new System.Drawing.Point(23, 56);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(48, 15);
            this.lbl_alamat.TabIndex = 9;
            this.lbl_alamat.Text = "Alamat:";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(29, 31);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(42, 15);
            this.lbl_nama.TabIndex = 8;
            this.lbl_nama.Text = "Nama:";
            // 
            // btn_nextdata
            // 
            this.btn_nextdata.Location = new System.Drawing.Point(202, 141);
            this.btn_nextdata.Name = "btn_nextdata";
            this.btn_nextdata.Size = new System.Drawing.Size(75, 23);
            this.btn_nextdata.TabIndex = 16;
            this.btn_nextdata.Text = "Next Data";
            this.btn_nextdata.UseVisualStyleBackColor = true;
            this.btn_nextdata.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(553, 209);
            this.Controls.Add(this.btn_nextdata);
            this.Controls.Add(this.btn_prevdata);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.txt_showtelp);
            this.Controls.Add(this.txt_showalamat);
            this.Controls.Add(this.txt_shownama);
            this.Controls.Add(this.lbl_telp);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.lbl_nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_prevdata;
        private Button btn_kembali;
        private TextBox txt_showtelp;
        private TextBox txt_showalamat;
        private TextBox txt_shownama;
        private Label lbl_telp;
        private Label lbl_alamat;
        private Label lbl_nama;
        private Button btn_nextdata;
    }
}