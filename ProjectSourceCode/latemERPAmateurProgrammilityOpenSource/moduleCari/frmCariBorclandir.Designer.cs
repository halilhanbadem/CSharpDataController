namespace latemERPAmateurProgrammilityOpenSource.moduleCari
{
    partial class frmCariBorclandir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariBorclandir));
            this.dateIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.memAdres = new System.Windows.Forms.RichTextBox();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edtMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateIslemTarihi
            // 
            this.dateIslemTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateIslemTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIslemTarihi.Location = new System.Drawing.Point(103, 91);
            this.dateIslemTarihi.Name = "dateIslemTarihi";
            this.dateIslemTarihi.Size = new System.Drawing.Size(200, 26);
            this.dateIslemTarihi.TabIndex = 0;
            // 
            // memAdres
            // 
            this.memAdres.Location = new System.Drawing.Point(103, 206);
            this.memAdres.Name = "memAdres";
            this.memAdres.Size = new System.Drawing.Size(200, 96);
            this.memAdres.TabIndex = 2;
            this.memAdres.Text = "";
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Items.AddRange(new object[] {
            "BORÇLANDIR",
            "ALACAKLANDIR"});
            this.cmbIslemTipi.Location = new System.Drawing.Point(103, 37);
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Size = new System.Drawing.Size(200, 28);
            this.cmbIslemTipi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İşlem Tipi";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ImageKey = "ok_32px.png";
            this.btnOnayla.ImageList = this.ımageList1;
            this.btnOnayla.Location = new System.Drawing.Point(103, 317);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(200, 42);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnayla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ok_32px.png");
            this.ımageList1.Images.SetKeyName(1, "sil.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İşlem Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama";
            // 
            // edtMiktar
            // 
            this.edtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edtMiktar.Location = new System.Drawing.Point(103, 146);
            this.edtMiktar.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.edtMiktar.Name = "edtMiktar";
            this.edtMiktar.Size = new System.Drawing.Size(200, 26);
            this.edtMiktar.TabIndex = 9;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ImageKey = "sil.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(103, 365);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(200, 42);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Ekranı Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmCariBorclandir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 419);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.edtMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIslemTipi);
            this.Controls.Add(this.memAdres);
            this.Controls.Add(this.dateIslemTarihi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariBorclandir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Borçlandır/Alacaklandır -";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCariBorclandir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateIslemTarihi;
        private System.Windows.Forms.RichTextBox memAdres;
        private System.Windows.Forms.ComboBox cmbIslemTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edtMiktar;
        private System.Windows.Forms.Button btnTemizle;
    }
}