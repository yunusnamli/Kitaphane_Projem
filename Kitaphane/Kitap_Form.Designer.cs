namespace Kitaphane
{
    partial class Kitap_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_Kitapadi = new System.Windows.Forms.TextBox();
            this.lbl_Kitapadi = new System.Windows.Forms.Label();
            this.lbl_Yazarı = new System.Windows.Forms.Label();
            this.lbl_Fiyati = new System.Windows.Forms.Label();
            this.lbl_Kategori = new System.Windows.Forms.Label();
            this.lbl_Yayinevi = new System.Windows.Forms.Label();
            this.lbl_Basimyili = new System.Windows.Forms.Label();
            this.lbl_Ozet = new System.Windows.Forms.Label();
            this.lbl_Kapakresmi = new System.Windows.Forms.Label();
            this.cmbbox_Yazarı = new System.Windows.Forms.ComboBox();
            this.txtbox_Fiyati = new System.Windows.Forms.TextBox();
            this.btn_Resimsec = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Arama = new System.Windows.Forms.Button();
            this.txtbox_Basimyili = new System.Windows.Forms.TextBox();
            this.cmbbox_Kategori = new System.Windows.Forms.ComboBox();
            this.cmbbox_Yayinevi = new System.Windows.Forms.ComboBox();
            this.pictureBox_Kapakresim = new System.Windows.Forms.PictureBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Mesaj = new System.Windows.Forms.Label();
            this.btn_Anasayfa = new System.Windows.Forms.Button();
            this.timer_Kitap = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_Kitap = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox_Ozet = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kapakresim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox_Kitapadi
            // 
            this.txtbox_Kitapadi.Location = new System.Drawing.Point(20, 148);
            this.txtbox_Kitapadi.Multiline = true;
            this.txtbox_Kitapadi.Name = "txtbox_Kitapadi";
            this.txtbox_Kitapadi.Size = new System.Drawing.Size(122, 20);
            this.txtbox_Kitapadi.TabIndex = 1;
            // 
            // lbl_Kitapadi
            // 
            this.lbl_Kitapadi.AutoSize = true;
            this.lbl_Kitapadi.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kitapadi.Location = new System.Drawing.Point(16, 120);
            this.lbl_Kitapadi.Name = "lbl_Kitapadi";
            this.lbl_Kitapadi.Size = new System.Drawing.Size(79, 22);
            this.lbl_Kitapadi.TabIndex = 2;
            this.lbl_Kitapadi.Text = "Kitap Adi";
            // 
            // lbl_Yazarı
            // 
            this.lbl_Yazarı.AutoSize = true;
            this.lbl_Yazarı.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yazarı.Location = new System.Drawing.Point(16, 174);
            this.lbl_Yazarı.Name = "lbl_Yazarı";
            this.lbl_Yazarı.Size = new System.Drawing.Size(56, 22);
            this.lbl_Yazarı.TabIndex = 3;
            this.lbl_Yazarı.Text = "Yazarı";
            // 
            // lbl_Fiyati
            // 
            this.lbl_Fiyati.AutoSize = true;
            this.lbl_Fiyati.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Fiyati.Location = new System.Drawing.Point(16, 239);
            this.lbl_Fiyati.Name = "lbl_Fiyati";
            this.lbl_Fiyati.Size = new System.Drawing.Size(53, 22);
            this.lbl_Fiyati.TabIndex = 4;
            this.lbl_Fiyati.Text = "Fiyati";
            // 
            // lbl_Kategori
            // 
            this.lbl_Kategori.AutoSize = true;
            this.lbl_Kategori.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kategori.Location = new System.Drawing.Point(378, 121);
            this.lbl_Kategori.Name = "lbl_Kategori";
            this.lbl_Kategori.Size = new System.Drawing.Size(71, 22);
            this.lbl_Kategori.TabIndex = 5;
            this.lbl_Kategori.Text = "Kategori";
            // 
            // lbl_Yayinevi
            // 
            this.lbl_Yayinevi.AutoSize = true;
            this.lbl_Yayinevi.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yayinevi.Location = new System.Drawing.Point(378, 175);
            this.lbl_Yayinevi.Name = "lbl_Yayinevi";
            this.lbl_Yayinevi.Size = new System.Drawing.Size(71, 22);
            this.lbl_Yayinevi.TabIndex = 6;
            this.lbl_Yayinevi.Text = "Yayinevi";
            // 
            // lbl_Basimyili
            // 
            this.lbl_Basimyili.AutoSize = true;
            this.lbl_Basimyili.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Basimyili.Location = new System.Drawing.Point(378, 240);
            this.lbl_Basimyili.Name = "lbl_Basimyili";
            this.lbl_Basimyili.Size = new System.Drawing.Size(82, 22);
            this.lbl_Basimyili.TabIndex = 7;
            this.lbl_Basimyili.Text = "Basim Yili";
            // 
            // lbl_Ozet
            // 
            this.lbl_Ozet.AutoSize = true;
            this.lbl_Ozet.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ozet.Location = new System.Drawing.Point(18, 341);
            this.lbl_Ozet.Name = "lbl_Ozet";
            this.lbl_Ozet.Size = new System.Drawing.Size(42, 22);
            this.lbl_Ozet.TabIndex = 8;
            this.lbl_Ozet.Text = "Özet";
            // 
            // lbl_Kapakresmi
            // 
            this.lbl_Kapakresmi.AutoSize = true;
            this.lbl_Kapakresmi.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kapakresmi.Location = new System.Drawing.Point(148, 145);
            this.lbl_Kapakresmi.Name = "lbl_Kapakresmi";
            this.lbl_Kapakresmi.Size = new System.Drawing.Size(95, 22);
            this.lbl_Kapakresmi.TabIndex = 9;
            this.lbl_Kapakresmi.Text = "Kapak resmi";
            this.lbl_Kapakresmi.Click += new System.EventHandler(this.lbl_Kapakresmi_Click);
            // 
            // cmbbox_Yazarı
            // 
            this.cmbbox_Yazarı.FormattingEnabled = true;
            this.cmbbox_Yazarı.Location = new System.Drawing.Point(21, 202);
            this.cmbbox_Yazarı.Name = "cmbbox_Yazarı";
            this.cmbbox_Yazarı.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Yazarı.TabIndex = 10;
            // 
            // txtbox_Fiyati
            // 
            this.txtbox_Fiyati.Location = new System.Drawing.Point(20, 267);
            this.txtbox_Fiyati.Multiline = true;
            this.txtbox_Fiyati.Name = "txtbox_Fiyati";
            this.txtbox_Fiyati.Size = new System.Drawing.Size(121, 21);
            this.txtbox_Fiyati.TabIndex = 11;
            // 
            // btn_Resimsec
            // 
            this.btn_Resimsec.BackColor = System.Drawing.Color.Aqua;
            this.btn_Resimsec.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Resimsec.Location = new System.Drawing.Point(249, 131);
            this.btn_Resimsec.Name = "btn_Resimsec";
            this.btn_Resimsec.Size = new System.Drawing.Size(95, 49);
            this.btn_Resimsec.TabIndex = 13;
            this.btn_Resimsec.Text = "Resim Sec";
            this.btn_Resimsec.UseVisualStyleBackColor = false;
            this.btn_Resimsec.Click += new System.EventHandler(this.btn_Resimsec_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Aqua;
            this.btn_Ekle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(441, 307);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(146, 55);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Aqua;
            this.btn_Guncelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(441, 368);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(146, 51);
            this.btn_Guncelle.TabIndex = 15;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Arama
            // 
            this.btn_Arama.BackColor = System.Drawing.Color.Aqua;
            this.btn_Arama.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Arama.Location = new System.Drawing.Point(441, 425);
            this.btn_Arama.Name = "btn_Arama";
            this.btn_Arama.Size = new System.Drawing.Size(146, 58);
            this.btn_Arama.TabIndex = 16;
            this.btn_Arama.Text = "Arama";
            this.btn_Arama.UseVisualStyleBackColor = false;
            this.btn_Arama.Click += new System.EventHandler(this.btn_Arama_Click);
            // 
            // txtbox_Basimyili
            // 
            this.txtbox_Basimyili.Location = new System.Drawing.Point(383, 268);
            this.txtbox_Basimyili.Multiline = true;
            this.txtbox_Basimyili.Name = "txtbox_Basimyili";
            this.txtbox_Basimyili.Size = new System.Drawing.Size(125, 20);
            this.txtbox_Basimyili.TabIndex = 17;
            // 
            // cmbbox_Kategori
            // 
            this.cmbbox_Kategori.FormattingEnabled = true;
            this.cmbbox_Kategori.Location = new System.Drawing.Point(382, 149);
            this.cmbbox_Kategori.Name = "cmbbox_Kategori";
            this.cmbbox_Kategori.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Kategori.TabIndex = 18;
            this.cmbbox_Kategori.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Kategori_SelectedIndexChanged);
            // 
            // cmbbox_Yayinevi
            // 
            this.cmbbox_Yayinevi.FormattingEnabled = true;
            this.cmbbox_Yayinevi.Location = new System.Drawing.Point(382, 203);
            this.cmbbox_Yayinevi.Name = "cmbbox_Yayinevi";
            this.cmbbox_Yayinevi.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Yayinevi.TabIndex = 19;
            // 
            // pictureBox_Kapakresim
            // 
            this.pictureBox_Kapakresim.Location = new System.Drawing.Point(152, 186);
            this.pictureBox_Kapakresim.Name = "pictureBox_Kapakresim";
            this.pictureBox_Kapakresim.Size = new System.Drawing.Size(192, 177);
            this.pictureBox_Kapakresim.TabIndex = 20;
            this.pictureBox_Kapakresim.TabStop = false;
            this.pictureBox_Kapakresim.Click += new System.EventHandler(this.pictureBox_Kapakresim_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Location = new System.Drawing.Point(249, 390);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(22, 18);
            this.lbl_Id.TabIndex = 22;
            this.lbl_Id.Text = "Id";
            this.lbl_Id.Visible = false;
            // 
            // lbl_Mesaj
            // 
            this.lbl_Mesaj.AutoSize = true;
            this.lbl_Mesaj.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Mesaj.Location = new System.Drawing.Point(249, 447);
            this.lbl_Mesaj.Name = "lbl_Mesaj";
            this.lbl_Mesaj.Size = new System.Drawing.Size(42, 18);
            this.lbl_Mesaj.TabIndex = 23;
            this.lbl_Mesaj.Text = "Mesaj";
            this.lbl_Mesaj.Visible = false;
            // 
            // btn_Anasayfa
            // 
            this.btn_Anasayfa.BackColor = System.Drawing.Color.Aqua;
            this.btn_Anasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Anasayfa.BackgroundImage")));
            this.btn_Anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Anasayfa.Location = new System.Drawing.Point(518, 163);
            this.btn_Anasayfa.Name = "btn_Anasayfa";
            this.btn_Anasayfa.Size = new System.Drawing.Size(78, 99);
            this.btn_Anasayfa.TabIndex = 24;
            this.btn_Anasayfa.UseVisualStyleBackColor = false;
            this.btn_Anasayfa.Click += new System.EventHandler(this.btn_Anasayfa_Click);
            // 
            // timer_Kitap
            // 
            this.timer_Kitap.Interval = 1000;
            this.timer_Kitap.Tick += new System.EventHandler(this.timer_Kitap_Tick);
            // 
            // openFileDialog_Kitap
            // 
            this.openFileDialog_Kitap.FileName = "openFileDialog1";
            // 
            // richTextBox_Ozet
            // 
            this.richTextBox_Ozet.Location = new System.Drawing.Point(20, 369);
            this.richTextBox_Ozet.Name = "richTextBox_Ozet";
            this.richTextBox_Ozet.Size = new System.Drawing.Size(223, 96);
            this.richTextBox_Ozet.TabIndex = 25;
            this.richTextBox_Ozet.Text = "";
            this.richTextBox_Ozet.TextChanged += new System.EventHandler(this.richTextBox_Ozet_TextChanged);
            // 
            // Kitap_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(744, 506);
            this.Controls.Add(this.richTextBox_Ozet);
            this.Controls.Add(this.btn_Anasayfa);
            this.Controls.Add(this.lbl_Mesaj);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.pictureBox_Kapakresim);
            this.Controls.Add(this.cmbbox_Yayinevi);
            this.Controls.Add(this.cmbbox_Kategori);
            this.Controls.Add(this.txtbox_Basimyili);
            this.Controls.Add(this.btn_Arama);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Resimsec);
            this.Controls.Add(this.txtbox_Fiyati);
            this.Controls.Add(this.cmbbox_Yazarı);
            this.Controls.Add(this.lbl_Kapakresmi);
            this.Controls.Add(this.lbl_Ozet);
            this.Controls.Add(this.lbl_Basimyili);
            this.Controls.Add(this.lbl_Yayinevi);
            this.Controls.Add(this.lbl_Kategori);
            this.Controls.Add(this.lbl_Fiyati);
            this.Controls.Add(this.lbl_Yazarı);
            this.Controls.Add(this.lbl_Kitapadi);
            this.Controls.Add(this.txtbox_Kitapadi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kitap_Form";
            this.Text = "Kitap_Form";
            this.Load += new System.EventHandler(this.Kitap_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kapakresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_Kitapadi;
        private System.Windows.Forms.Label lbl_Kitapadi;
        private System.Windows.Forms.Label lbl_Yazarı;
        private System.Windows.Forms.Label lbl_Fiyati;
        private System.Windows.Forms.Label lbl_Kategori;
        private System.Windows.Forms.Label lbl_Yayinevi;
        private System.Windows.Forms.Label lbl_Basimyili;
        private System.Windows.Forms.Label lbl_Ozet;
        private System.Windows.Forms.Label lbl_Kapakresmi;
        private System.Windows.Forms.ComboBox cmbbox_Yazarı;
        private System.Windows.Forms.TextBox txtbox_Fiyati;
        private System.Windows.Forms.Button btn_Resimsec;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Arama;
        private System.Windows.Forms.TextBox txtbox_Basimyili;
        private System.Windows.Forms.ComboBox cmbbox_Kategori;
        private System.Windows.Forms.ComboBox cmbbox_Yayinevi;
        private System.Windows.Forms.PictureBox pictureBox_Kapakresim;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Mesaj;
        private System.Windows.Forms.Button btn_Anasayfa;
        private System.Windows.Forms.Timer timer_Kitap;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Kitap;
        private System.Windows.Forms.RichTextBox richTextBox_Ozet;
    }
}