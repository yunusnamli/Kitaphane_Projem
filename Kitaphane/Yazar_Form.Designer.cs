namespace Kitaphane
{
    partial class Yazar_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yazar_Form));
            this.pictureBox_YazarModülü = new System.Windows.Forms.PictureBox();
            this.lbl_Yazaradi = new System.Windows.Forms.Label();
            this.lbl_Ozgecmis = new System.Windows.Forms.Label();
            this.lbl_Yazarfotograf = new System.Windows.Forms.Label();
            this.lbl_Yazarmesaj = new System.Windows.Forms.Label();
            this.txtbox_Yazaradi = new System.Windows.Forms.TextBox();
            this.richtxtbox_ozgecmis = new System.Windows.Forms.RichTextBox();
            this.btn_Resimsec = new System.Windows.Forms.Button();
            this.pictureBox_YazarResim = new System.Windows.Forms.PictureBox();
            this.btn_YazarEkle = new System.Windows.Forms.Button();
            this.btn_YazarGuncelle = new System.Windows.Forms.Button();
            this.btn_YazarAra = new System.Windows.Forms.Button();
            this.btn_YazarAnasayfa = new System.Windows.Forms.Button();
            this.lbl_YazarId = new System.Windows.Forms.Label();
            this.openFileDialog_YazarResim = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YazarModülü)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YazarResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_YazarModülü
            // 
            this.pictureBox_YazarModülü.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_YazarModülü.Image")));
            this.pictureBox_YazarModülü.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_YazarModülü.Name = "pictureBox_YazarModülü";
            this.pictureBox_YazarModülü.Size = new System.Drawing.Size(569, 119);
            this.pictureBox_YazarModülü.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_YazarModülü.TabIndex = 0;
            this.pictureBox_YazarModülü.TabStop = false;
            // 
            // lbl_Yazaradi
            // 
            this.lbl_Yazaradi.AutoSize = true;
            this.lbl_Yazaradi.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yazaradi.Location = new System.Drawing.Point(8, 164);
            this.lbl_Yazaradi.Name = "lbl_Yazaradi";
            this.lbl_Yazaradi.Size = new System.Drawing.Size(80, 22);
            this.lbl_Yazaradi.TabIndex = 1;
            this.lbl_Yazaradi.Text = "Yazar Adi";
            // 
            // lbl_Ozgecmis
            // 
            this.lbl_Ozgecmis.AutoSize = true;
            this.lbl_Ozgecmis.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ozgecmis.Location = new System.Drawing.Point(8, 205);
            this.lbl_Ozgecmis.Name = "lbl_Ozgecmis";
            this.lbl_Ozgecmis.Size = new System.Drawing.Size(74, 22);
            this.lbl_Ozgecmis.TabIndex = 2;
            this.lbl_Ozgecmis.Text = "Ozgecmis";
            // 
            // lbl_Yazarfotograf
            // 
            this.lbl_Yazarfotograf.AutoSize = true;
            this.lbl_Yazarfotograf.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yazarfotograf.Location = new System.Drawing.Point(12, 348);
            this.lbl_Yazarfotograf.Name = "lbl_Yazarfotograf";
            this.lbl_Yazarfotograf.Size = new System.Drawing.Size(115, 22);
            this.lbl_Yazarfotograf.TabIndex = 3;
            this.lbl_Yazarfotograf.Text = "Yazar Fotograf";
            // 
            // lbl_Yazarmesaj
            // 
            this.lbl_Yazarmesaj.AutoSize = true;
            this.lbl_Yazarmesaj.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yazarmesaj.Location = new System.Drawing.Point(283, 411);
            this.lbl_Yazarmesaj.Name = "lbl_Yazarmesaj";
            this.lbl_Yazarmesaj.Size = new System.Drawing.Size(52, 22);
            this.lbl_Yazarmesaj.TabIndex = 4;
            this.lbl_Yazarmesaj.Text = "Mesaj";
            this.lbl_Yazarmesaj.Visible = false;
            // 
            // txtbox_Yazaradi
            // 
            this.txtbox_Yazaradi.Location = new System.Drawing.Point(110, 164);
            this.txtbox_Yazaradi.Multiline = true;
            this.txtbox_Yazaradi.Name = "txtbox_Yazaradi";
            this.txtbox_Yazaradi.Size = new System.Drawing.Size(167, 26);
            this.txtbox_Yazaradi.TabIndex = 6;
            // 
            // richtxtbox_ozgecmis
            // 
            this.richtxtbox_ozgecmis.Location = new System.Drawing.Point(110, 208);
            this.richtxtbox_ozgecmis.Name = "richtxtbox_ozgecmis";
            this.richtxtbox_ozgecmis.Size = new System.Drawing.Size(167, 96);
            this.richtxtbox_ozgecmis.TabIndex = 7;
            this.richtxtbox_ozgecmis.Text = "";
            // 
            // btn_Resimsec
            // 
            this.btn_Resimsec.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Resimsec.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Resimsec.Location = new System.Drawing.Point(11, 395);
            this.btn_Resimsec.Name = "btn_Resimsec";
            this.btn_Resimsec.Size = new System.Drawing.Size(116, 87);
            this.btn_Resimsec.TabIndex = 8;
            this.btn_Resimsec.Text = "Resim Seç";
            this.btn_Resimsec.UseVisualStyleBackColor = false;
            this.btn_Resimsec.Click += new System.EventHandler(this.btn_Resimsec_Click);
            // 
            // pictureBox_YazarResim
            // 
            this.pictureBox_YazarResim.Location = new System.Drawing.Point(134, 335);
            this.pictureBox_YazarResim.Name = "pictureBox_YazarResim";
            this.pictureBox_YazarResim.Size = new System.Drawing.Size(143, 161);
            this.pictureBox_YazarResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_YazarResim.TabIndex = 9;
            this.pictureBox_YazarResim.TabStop = false;
            this.pictureBox_YazarResim.Click += new System.EventHandler(this.pictureBox_YazarResim_Click);
            // 
            // btn_YazarEkle
            // 
            this.btn_YazarEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_YazarEkle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YazarEkle.Location = new System.Drawing.Point(451, 156);
            this.btn_YazarEkle.Name = "btn_YazarEkle";
            this.btn_YazarEkle.Size = new System.Drawing.Size(130, 57);
            this.btn_YazarEkle.TabIndex = 10;
            this.btn_YazarEkle.Text = "Ekle";
            this.btn_YazarEkle.UseVisualStyleBackColor = false;
            this.btn_YazarEkle.Click += new System.EventHandler(this.btn_YazarEkle_Click);
            // 
            // btn_YazarGuncelle
            // 
            this.btn_YazarGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_YazarGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YazarGuncelle.Location = new System.Drawing.Point(451, 232);
            this.btn_YazarGuncelle.Name = "btn_YazarGuncelle";
            this.btn_YazarGuncelle.Size = new System.Drawing.Size(130, 57);
            this.btn_YazarGuncelle.TabIndex = 11;
            this.btn_YazarGuncelle.Text = "Guncelle";
            this.btn_YazarGuncelle.UseVisualStyleBackColor = false;
            this.btn_YazarGuncelle.Click += new System.EventHandler(this.btn_YazarGuncelle_Click);
            // 
            // btn_YazarAra
            // 
            this.btn_YazarAra.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_YazarAra.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YazarAra.Location = new System.Drawing.Point(451, 313);
            this.btn_YazarAra.Name = "btn_YazarAra";
            this.btn_YazarAra.Size = new System.Drawing.Size(130, 56);
            this.btn_YazarAra.TabIndex = 12;
            this.btn_YazarAra.Text = "Arama";
            this.btn_YazarAra.UseVisualStyleBackColor = false;
            this.btn_YazarAra.Click += new System.EventHandler(this.btn_YazarAra_Click);
            // 
            // btn_YazarAnasayfa
            // 
            this.btn_YazarAnasayfa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_YazarAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_YazarAnasayfa.BackgroundImage")));
            this.btn_YazarAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_YazarAnasayfa.Location = new System.Drawing.Point(451, 388);
            this.btn_YazarAnasayfa.Name = "btn_YazarAnasayfa";
            this.btn_YazarAnasayfa.Size = new System.Drawing.Size(91, 94);
            this.btn_YazarAnasayfa.TabIndex = 13;
            this.btn_YazarAnasayfa.UseVisualStyleBackColor = false;
            this.btn_YazarAnasayfa.Click += new System.EventHandler(this.btn_YazarAnasayfa_Click);
            // 
            // lbl_YazarId
            // 
            this.lbl_YazarId.AutoSize = true;
            this.lbl_YazarId.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YazarId.Location = new System.Drawing.Point(283, 460);
            this.lbl_YazarId.Name = "lbl_YazarId";
            this.lbl_YazarId.Size = new System.Drawing.Size(25, 22);
            this.lbl_YazarId.TabIndex = 14;
            this.lbl_YazarId.Text = "Id";
            this.lbl_YazarId.Visible = false;
            // 
            // openFileDialog_YazarResim
            // 
            this.openFileDialog_YazarResim.FileName = "openFileDialog1";
            // 
            // Yazar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(593, 507);
            this.Controls.Add(this.lbl_YazarId);
            this.Controls.Add(this.btn_YazarAnasayfa);
            this.Controls.Add(this.btn_YazarAra);
            this.Controls.Add(this.btn_YazarGuncelle);
            this.Controls.Add(this.btn_YazarEkle);
            this.Controls.Add(this.pictureBox_YazarResim);
            this.Controls.Add(this.btn_Resimsec);
            this.Controls.Add(this.richtxtbox_ozgecmis);
            this.Controls.Add(this.txtbox_Yazaradi);
            this.Controls.Add(this.lbl_Yazarmesaj);
            this.Controls.Add(this.lbl_Yazarfotograf);
            this.Controls.Add(this.lbl_Ozgecmis);
            this.Controls.Add(this.lbl_Yazaradi);
            this.Controls.Add(this.pictureBox_YazarModülü);
            this.Name = "Yazar_Form";
            this.Text = "Yazar_Form";
            this.Load += new System.EventHandler(this.Yazar_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YazarModülü)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YazarResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_YazarModülü;
        private System.Windows.Forms.Label lbl_Yazaradi;
        private System.Windows.Forms.Label lbl_Ozgecmis;
        private System.Windows.Forms.Label lbl_Yazarfotograf;
        private System.Windows.Forms.Label lbl_Yazarmesaj;
        private System.Windows.Forms.TextBox txtbox_Yazaradi;
        private System.Windows.Forms.RichTextBox richtxtbox_ozgecmis;
        private System.Windows.Forms.Button btn_Resimsec;
        private System.Windows.Forms.PictureBox pictureBox_YazarResim;
        private System.Windows.Forms.Button btn_YazarEkle;
        private System.Windows.Forms.Button btn_YazarGuncelle;
        private System.Windows.Forms.Button btn_YazarAra;
        private System.Windows.Forms.Button btn_YazarAnasayfa;
        private System.Windows.Forms.Label lbl_YazarId;
        private System.Windows.Forms.OpenFileDialog openFileDialog_YazarResim;
    }
}