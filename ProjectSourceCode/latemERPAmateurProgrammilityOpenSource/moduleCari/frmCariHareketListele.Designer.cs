namespace latemERPAmateurProgrammilityOpenSource.moduleCari
{
    partial class frmCariHareketListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariHareketListele));
            this.gridCariHareketler = new System.Windows.Forms.DataGridView();
            this.dateBirinciTarih = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateIkinciTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCariHareketler
            // 
            this.gridCariHareketler.AllowUserToAddRows = false;
            this.gridCariHareketler.AllowUserToDeleteRows = false;
            this.gridCariHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCariHareketler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCariHareketler.Location = new System.Drawing.Point(0, 82);
            this.gridCariHareketler.Name = "gridCariHareketler";
            this.gridCariHareketler.ReadOnly = true;
            this.gridCariHareketler.Size = new System.Drawing.Size(819, 403);
            this.gridCariHareketler.TabIndex = 0;
            // 
            // dateBirinciTarih
            // 
            this.dateBirinciTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirinciTarih.Location = new System.Drawing.Point(12, 21);
            this.dateBirinciTarih.Name = "dateBirinciTarih";
            this.dateBirinciTarih.Size = new System.Drawing.Size(99, 20);
            this.dateBirinciTarih.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.ImageKey = "search.png";
            this.btnFiltrele.ImageList = this.ımageList1;
            this.btnFiltrele.Location = new System.Drawing.Point(15, 47);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(228, 29);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birinci Tarih:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "search.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İkinci Tarih:";
            // 
            // dateIkinciTarih
            // 
            this.dateIkinciTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIkinciTarih.Location = new System.Drawing.Point(117, 21);
            this.dateIkinciTarih.Name = "dateIkinciTarih";
            this.dateIkinciTarih.Size = new System.Drawing.Size(126, 20);
            this.dateIkinciTarih.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(284, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(19, 15);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = ":::";
            // 
            // frmCariHareketListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 485);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateIkinciTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.dateBirinciTarih);
            this.Controls.Add(this.gridCariHareketler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariHareketListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hareket Listesi -";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCariHareketListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCariHareketler;
        private System.Windows.Forms.DateTimePicker dateBirinciTarih;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIkinciTarih;
        private System.Windows.Forms.Label lblTitle;
    }
}