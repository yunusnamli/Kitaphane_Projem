namespace Kitaphane
{
    partial class Satis_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_uyesıcılno = new System.Windows.Forms.Label();
            this.lbl_uyeadsoyad = new System.Windows.Forms.Label();
            this.lbl_Kitaplistesi = new System.Windows.Forms.Label();
            this.lbl_Adet = new System.Windows.Forms.Label();
            this.lbl_Mesaj = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.bttn_Anasayfa = new System.Windows.Forms.Button();
            this.txtbox_siciluyeno = new System.Windows.Forms.TextBox();
            this.comboBox_Kitaplistesi = new System.Windows.Forms.ComboBox();
            this.txtbox_Satisadet = new System.Windows.Forms.TextBox();
            this.timer_Satis = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_uyesıcılno
            // 
            this.lbl_uyesıcılno.AutoSize = true;
            this.lbl_uyesıcılno.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyesıcılno.Location = new System.Drawing.Point(10, 159);
            this.lbl_uyesıcılno.Name = "lbl_uyesıcılno";
            this.lbl_uyesıcılno.Size = new System.Drawing.Size(99, 22);
            this.lbl_uyesıcılno.TabIndex = 1;
            this.lbl_uyesıcılno.Text = "Uye Sicil No";
            // 
            // lbl_uyeadsoyad
            // 
            this.lbl_uyeadsoyad.AutoSize = true;
            this.lbl_uyeadsoyad.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyeadsoyad.Location = new System.Drawing.Point(104, 218);
            this.lbl_uyeadsoyad.Name = "lbl_uyeadsoyad";
            this.lbl_uyeadsoyad.Size = new System.Drawing.Size(108, 22);
            this.lbl_uyeadsoyad.TabIndex = 2;
            this.lbl_uyeadsoyad.Text = "Üye Ad Soyad";
            this.lbl_uyeadsoyad.Visible = false;
            // 
            // lbl_Kitaplistesi
            // 
            this.lbl_Kitaplistesi.AutoSize = true;
            this.lbl_Kitaplistesi.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kitaplistesi.Location = new System.Drawing.Point(10, 290);
            this.lbl_Kitaplistesi.Name = "lbl_Kitaplistesi";
            this.lbl_Kitaplistesi.Size = new System.Drawing.Size(100, 22);
            this.lbl_Kitaplistesi.TabIndex = 3;
            this.lbl_Kitaplistesi.Text = "Kitap Listesi";
            // 
            // lbl_Adet
            // 
            this.lbl_Adet.AutoSize = true;
            this.lbl_Adet.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adet.Location = new System.Drawing.Point(365, 152);
            this.lbl_Adet.Name = "lbl_Adet";
            this.lbl_Adet.Size = new System.Drawing.Size(43, 22);
            this.lbl_Adet.TabIndex = 4;
            this.lbl_Adet.Text = "Adet";
            // 
            // lbl_Mesaj
            // 
            this.lbl_Mesaj.AutoSize = true;
            this.lbl_Mesaj.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Mesaj.Location = new System.Drawing.Point(55, 451);
            this.lbl_Mesaj.Name = "lbl_Mesaj";
            this.lbl_Mesaj.Size = new System.Drawing.Size(52, 22);
            this.lbl_Mesaj.TabIndex = 5;
            this.lbl_Mesaj.Text = "Mesaj";
            this.lbl_Mesaj.Visible = false;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Location = new System.Drawing.Point(365, 451);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(25, 22);
            this.lbl_Id.TabIndex = 6;
            this.lbl_Id.Text = "Id";
            this.lbl_Id.Visible = false;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Aqua;
            this.btn_Ekle.Location = new System.Drawing.Point(460, 278);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(125, 73);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // bttn_Anasayfa
            // 
            this.bttn_Anasayfa.BackColor = System.Drawing.Color.Aqua;
            this.bttn_Anasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Anasayfa.BackgroundImage")));
            this.bttn_Anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Anasayfa.Location = new System.Drawing.Point(501, 396);
            this.bttn_Anasayfa.Name = "bttn_Anasayfa";
            this.bttn_Anasayfa.Size = new System.Drawing.Size(84, 91);
            this.bttn_Anasayfa.TabIndex = 8;
            this.bttn_Anasayfa.UseVisualStyleBackColor = false;
            this.bttn_Anasayfa.Click += new System.EventHandler(this.bttn_Anasayfa_Click);
            // 
            // txtbox_siciluyeno
            // 
            this.txtbox_siciluyeno.Location = new System.Drawing.Point(133, 155);
            this.txtbox_siciluyeno.Multiline = true;
            this.txtbox_siciluyeno.Name = "txtbox_siciluyeno";
            this.txtbox_siciluyeno.Size = new System.Drawing.Size(121, 21);
            this.txtbox_siciluyeno.TabIndex = 9;
            this.txtbox_siciluyeno.TextChanged += new System.EventHandler(this.txtbox_siciluyeno_TextChanged);
            // 
            // comboBox_Kitaplistesi
            // 
            this.comboBox_Kitaplistesi.FormattingEnabled = true;
            this.comboBox_Kitaplistesi.Location = new System.Drawing.Point(133, 287);
            this.comboBox_Kitaplistesi.Name = "comboBox_Kitaplistesi";
            this.comboBox_Kitaplistesi.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Kitaplistesi.TabIndex = 10;
            this.comboBox_Kitaplistesi.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kitaplistesi_SelectedIndexChanged);
            // 
            // txtbox_Satisadet
            // 
            this.txtbox_Satisadet.Location = new System.Drawing.Point(443, 154);
            this.txtbox_Satisadet.Name = "txtbox_Satisadet";
            this.txtbox_Satisadet.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Satisadet.TabIndex = 11;
            // 
            // timer_Satis
            // 
            this.timer_Satis.Interval = 1000;
            this.timer_Satis.Tick += new System.EventHandler(this.timer_Satis_Tick);
            // 
            // Satis_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(625, 508);
            this.Controls.Add(this.txtbox_Satisadet);
            this.Controls.Add(this.comboBox_Kitaplistesi);
            this.Controls.Add(this.txtbox_siciluyeno);
            this.Controls.Add(this.bttn_Anasayfa);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Mesaj);
            this.Controls.Add(this.lbl_Adet);
            this.Controls.Add(this.lbl_Kitaplistesi);
            this.Controls.Add(this.lbl_uyeadsoyad);
            this.Controls.Add(this.lbl_uyesıcılno);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Satis_Form";
            this.Text = "Satis_Form";
            this.Load += new System.EventHandler(this.Satis_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_uyesıcılno;
        private System.Windows.Forms.Label lbl_uyeadsoyad;
        private System.Windows.Forms.Label lbl_Kitaplistesi;
        private System.Windows.Forms.Label lbl_Adet;
        private System.Windows.Forms.Label lbl_Mesaj;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button bttn_Anasayfa;
        private System.Windows.Forms.TextBox txtbox_siciluyeno;
        private System.Windows.Forms.ComboBox comboBox_Kitaplistesi;
        private System.Windows.Forms.TextBox txtbox_Satisadet;
        private System.Windows.Forms.Timer timer_Satis;
    }
}