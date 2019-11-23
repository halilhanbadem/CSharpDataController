namespace latemERPAmateurProgrammilityOpenSource.moduleCari
{
    partial class frmCariListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariListele));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorclandir = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnCariHareket = new System.Windows.Forms.Button();
            this.btnCariSil = new System.Windows.Forms.Button();
            this.btnCariGuncelle = new System.Windows.Forms.Button();
            this.btnCariEkle = new System.Windows.Forms.Button();
            this.gridCariler = new System.Windows.Forms.DataGridView();
            this.txtFiltrele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBorclandir);
            this.panel1.Controls.Add(this.btnCariHareket);
            this.panel1.Controls.Add(this.btnCariSil);
            this.panel1.Controls.Add(this.btnCariGuncelle);
            this.panel1.Controls.Add(this.btnCariEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 101);
            this.panel1.TabIndex = 2;
            // 
            // btnBorclandir
            // 
            this.btnBorclandir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorclandir.ImageKey = "banknotes_16px.png";
            this.btnBorclandir.ImageList = this.ımageList2;
            this.btnBorclandir.Location = new System.Drawing.Point(816, 28);
            this.btnBorclandir.Name = "btnBorclandir";
            this.btnBorclandir.Size = new System.Drawing.Size(214, 44);
            this.btnBorclandir.TabIndex = 4;
            this.btnBorclandir.Text = "Borçlandır / Alacaklandır";
            this.btnBorclandir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorclandir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorclandir.UseVisualStyleBackColor = true;
            this.btnBorclandir.Click += new System.EventHandler(this.btnBorclandir_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "banknotes_16px.png");
            this.ımageList2.Images.SetKeyName(1, "eraser_16px.png");
            this.ımageList2.Images.SetKeyName(2, "filled_plus_2_math_16px.png");
            this.ımageList2.Images.SetKeyName(3, "restart_16px.png");
            this.ımageList2.Images.SetKeyName(4, "show_property_16px.png");
            // 
            // btnCariHareket
            // 
            this.btnCariHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariHareket.ImageKey = "show_property_16px.png";
            this.btnCariHareket.ImageList = this.ımageList2;
            this.btnCariHareket.Location = new System.Drawing.Point(617, 28);
            this.btnCariHareket.Name = "btnCariHareket";
            this.btnCariHareket.Size = new System.Drawing.Size(190, 44);
            this.btnCariHareket.TabIndex = 3;
            this.btnCariHareket.Text = "Cari Hesap Hareketleri";
            this.btnCariHareket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariHareket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCariHareket.UseVisualStyleBackColor = true;
            this.btnCariHareket.Click += new System.EventHandler(this.btnCariHareket_Click);
            // 
            // btnCariSil
            // 
            this.btnCariSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariSil.ImageKey = "eraser_16px.png";
            this.btnCariSil.ImageList = this.ımageList2;
            this.btnCariSil.Location = new System.Drawing.Point(406, 28);
            this.btnCariSil.Name = "btnCariSil";
            this.btnCariSil.Size = new System.Drawing.Size(200, 44);
            this.btnCariSil.TabIndex = 2;
            this.btnCariSil.Text = "Seçili Cariyi Sil";
            this.btnCariSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCariSil.UseVisualStyleBackColor = true;
            this.btnCariSil.Click += new System.EventHandler(this.btnCariSil_Click);
            // 
            // btnCariGuncelle
            // 
            this.btnCariGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariGuncelle.ImageKey = "restart_16px.png";
            this.btnCariGuncelle.ImageList = this.ımageList2;
            this.btnCariGuncelle.Location = new System.Drawing.Point(202, 28);
            this.btnCariGuncelle.Name = "btnCariGuncelle";
            this.btnCariGuncelle.Size = new System.Drawing.Size(195, 44);
            this.btnCariGuncelle.TabIndex = 1;
            this.btnCariGuncelle.Text = "Seçili Cariyi Güncelle";
            this.btnCariGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCariGuncelle.UseVisualStyleBackColor = true;
            this.btnCariGuncelle.Click += new System.EventHandler(this.btnCariGuncelle_Click);
            // 
            // btnCariEkle
            // 
            this.btnCariEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariEkle.ImageKey = "filled_plus_2_math_16px.png";
            this.btnCariEkle.ImageList = this.ımageList2;
            this.btnCariEkle.Location = new System.Drawing.Point(11, 28);
            this.btnCariEkle.Name = "btnCariEkle";
            this.btnCariEkle.Size = new System.Drawing.Size(185, 44);
            this.btnCariEkle.TabIndex = 0;
            this.btnCariEkle.Text = "Yeni Cari Ekle";
            this.btnCariEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCariEkle.UseVisualStyleBackColor = true;
            this.btnCariEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridCariler
            // 
            this.gridCariler.AllowUserToAddRows = false;
            this.gridCariler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCariler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCariler.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridCariler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCariler.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridCariler.Location = new System.Drawing.Point(0, 95);
            this.gridCariler.Name = "gridCariler";
            this.gridCariler.ReadOnly = true;
            this.gridCariler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridCariler.Size = new System.Drawing.Size(1043, 322);
            this.gridCariler.TabIndex = 3;
            // 
            // txtFiltrele
            // 
            this.txtFiltrele.Location = new System.Drawing.Point(12, 25);
            this.txtFiltrele.Name = "txtFiltrele";
            this.txtFiltrele.Size = new System.Drawing.Size(354, 20);
            this.txtFiltrele.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arama Sözcüğü(Cari Unvan, Cari Adı && Soyadı veya Cari İl)";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.ImageKey = "search.png";
            this.btnFiltrele.ImageList = this.ımageList1;
            this.btnFiltrele.Location = new System.Drawing.Point(12, 51);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(354, 38);
            this.btnFiltrele.TabIndex = 6;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "search.png");
            // 
            // frmCariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 518);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltrele);
            this.Controls.Add(this.gridCariler);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCariListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hesapları Listeleme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCariListele_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorclandir;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btnCariHareket;
        private System.Windows.Forms.Button btnCariSil;
        private System.Windows.Forms.Button btnCariGuncelle;
        private System.Windows.Forms.Button btnCariEkle;
        private System.Windows.Forms.TextBox txtFiltrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView gridCariler;
    }
}