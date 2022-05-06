namespace Kitaphane
{
    partial class Kategori_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kategori_Form));
            this.pictureBox_Kategori = new System.Windows.Forms.PictureBox();
            this.lbl_Katad = new System.Windows.Forms.Label();
            this.textbox_Katad = new System.Windows.Forms.TextBox();
            this.lbl_Katadliste = new System.Windows.Forms.Label();
            this.lbl_Katyeniad = new System.Windows.Forms.Label();
            this.btn_katekle = new System.Windows.Forms.Button();
            this.btn_katguncelle = new System.Windows.Forms.Button();
            this.txtbox_yeniad = new System.Windows.Forms.TextBox();
            this.cmbBox_Katadliste = new System.Windows.Forms.ComboBox();
            this.btn_Anasayfa = new System.Windows.Forms.Button();
            this.lbl_katmesaj = new System.Windows.Forms.Label();
            this.timer_kat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kategori)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Kategori
            // 
            this.pictureBox_Kategori.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Kategori.Image")));
            this.pictureBox_Kategori.Location = new System.Drawing.Point(-24, -3);
            this.pictureBox_Kategori.Name = "pictureBox_Kategori";
            this.pictureBox_Kategori.Size = new System.Drawing.Size(584, 181);
            this.pictureBox_Kategori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Kategori.TabIndex = 0;
            this.pictureBox_Kategori.TabStop = false;
            // 
            // lbl_Katad
            // 
            this.lbl_Katad.AutoSize = true;
            this.lbl_Katad.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Katad.Location = new System.Drawing.Point(-1, 194);
            this.lbl_Katad.Name = "lbl_Katad";
            this.lbl_Katad.Size = new System.Drawing.Size(143, 25);
            this.lbl_Katad.TabIndex = 1;
            this.lbl_Katad.Text = "Kategori Ad      : ";
            // 
            // textbox_Katad
            // 
            this.textbox_Katad.Location = new System.Drawing.Point(134, 193);
            this.textbox_Katad.Multiline = true;
            this.textbox_Katad.Name = "textbox_Katad";
            this.textbox_Katad.Size = new System.Drawing.Size(148, 25);
            this.textbox_Katad.TabIndex = 2;
            // 
            // lbl_Katadliste
            // 
            this.lbl_Katadliste.AutoSize = true;
            this.lbl_Katadliste.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Katadliste.Location = new System.Drawing.Point(-1, 246);
            this.lbl_Katadliste.Name = "lbl_Katadliste";
            this.lbl_Katadliste.Size = new System.Drawing.Size(138, 25);
            this.lbl_Katadliste.TabIndex = 3;
            this.lbl_Katadliste.Text = "Kategori Adları :";
            // 
            // lbl_Katyeniad
            // 
            this.lbl_Katyeniad.AutoSize = true;
            this.lbl_Katyeniad.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Katyeniad.Location = new System.Drawing.Point(-1, 296);
            this.lbl_Katyeniad.Name = "lbl_Katyeniad";
            this.lbl_Katyeniad.Size = new System.Drawing.Size(138, 25);
            this.lbl_Katyeniad.TabIndex = 4;
            this.lbl_Katyeniad.Text = "Yeni Ad            :";
            // 
            // btn_katekle
            // 
            this.btn_katekle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_katekle.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_katekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_katekle.Location = new System.Drawing.Point(376, 184);
            this.btn_katekle.Name = "btn_katekle";
            this.btn_katekle.Size = new System.Drawing.Size(146, 79);
            this.btn_katekle.TabIndex = 5;
            this.btn_katekle.Text = "EKLE";
            this.btn_katekle.UseVisualStyleBackColor = false;
            this.btn_katekle.Click += new System.EventHandler(this.btn_katekle_Click);
            // 
            // btn_katguncelle
            // 
            this.btn_katguncelle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_katguncelle.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_katguncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_katguncelle.Location = new System.Drawing.Point(376, 284);
            this.btn_katguncelle.Name = "btn_katguncelle";
            this.btn_katguncelle.Size = new System.Drawing.Size(146, 79);
            this.btn_katguncelle.TabIndex = 6;
            this.btn_katguncelle.Text = "GUNCELLE";
            this.btn_katguncelle.UseVisualStyleBackColor = false;
            this.btn_katguncelle.Click += new System.EventHandler(this.btn_katguncelle_Click);
            // 
            // txtbox_yeniad
            // 
            this.txtbox_yeniad.Location = new System.Drawing.Point(134, 296);
            this.txtbox_yeniad.Multiline = true;
            this.txtbox_yeniad.Name = "txtbox_yeniad";
            this.txtbox_yeniad.Size = new System.Drawing.Size(148, 25);
            this.txtbox_yeniad.TabIndex = 8;
            // 
            // cmbBox_Katadliste
            // 
            this.cmbBox_Katadliste.FormattingEnabled = true;
            this.cmbBox_Katadliste.Location = new System.Drawing.Point(134, 249);
            this.cmbBox_Katadliste.Name = "cmbBox_Katadliste";
            this.cmbBox_Katadliste.Size = new System.Drawing.Size(148, 21);
            this.cmbBox_Katadliste.TabIndex = 9;
            // 
            // btn_Anasayfa
            // 
            this.btn_Anasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Anasayfa.BackgroundImage")));
            this.btn_Anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Anasayfa.Location = new System.Drawing.Point(442, 378);
            this.btn_Anasayfa.Name = "btn_Anasayfa";
            this.btn_Anasayfa.Size = new System.Drawing.Size(80, 78);
            this.btn_Anasayfa.TabIndex = 10;
            this.btn_Anasayfa.UseVisualStyleBackColor = true;
            this.btn_Anasayfa.Click += new System.EventHandler(this.btn_Anasayfa_Click);
            // 
            // lbl_katmesaj
            // 
            this.lbl_katmesaj.AutoSize = true;
            this.lbl_katmesaj.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_katmesaj.Location = new System.Drawing.Point(12, 417);
            this.lbl_katmesaj.Name = "lbl_katmesaj";
            this.lbl_katmesaj.Size = new System.Drawing.Size(58, 25);
            this.lbl_katmesaj.TabIndex = 11;
            this.lbl_katmesaj.Text = "Mesaj";
            this.lbl_katmesaj.Visible = false;
            // 
            // timer_kat
            // 
            this.timer_kat.Interval = 1000;
            this.timer_kat.Tick += new System.EventHandler(this.timer_kat_Tick);
            // 
            // Kategori_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(628, 504);
            this.Controls.Add(this.lbl_katmesaj);
            this.Controls.Add(this.btn_Anasayfa);
            this.Controls.Add(this.cmbBox_Katadliste);
            this.Controls.Add(this.txtbox_yeniad);
            this.Controls.Add(this.btn_katguncelle);
            this.Controls.Add(this.btn_katekle);
            this.Controls.Add(this.lbl_Katyeniad);
            this.Controls.Add(this.lbl_Katadliste);
            this.Controls.Add(this.textbox_Katad);
            this.Controls.Add(this.lbl_Katad);
            this.Controls.Add(this.pictureBox_Kategori);
            this.Name = "Kategori_Form";
            this.Text = "Kategori_Form";
            this.Load += new System.EventHandler(this.Kategori_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Kategori;
        private System.Windows.Forms.Label lbl_Katad;
        private System.Windows.Forms.TextBox textbox_Katad;
        private System.Windows.Forms.Label lbl_Katadliste;
        private System.Windows.Forms.Label lbl_Katyeniad;
        private System.Windows.Forms.Button btn_katekle;
        private System.Windows.Forms.Button btn_katguncelle;
        private System.Windows.Forms.TextBox txtbox_yeniad;
        private System.Windows.Forms.ComboBox cmbBox_Katadliste;
        private System.Windows.Forms.Button btn_Anasayfa;
        private System.Windows.Forms.Label lbl_katmesaj;
        private System.Windows.Forms.Timer timer_kat;

    }
}