namespace latemERPAmateurProgrammilityOpenSource.moduleStok
{
    partial class frmStokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListesi));
            this.pnlIslemler = new System.Windows.Forms.Panel();
            this.gridStoklar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIslemler
            // 
            this.pnlIslemler.Controls.Add(this.button4);
            this.pnlIslemler.Controls.Add(this.button3);
            this.pnlIslemler.Controls.Add(this.button2);
            this.pnlIslemler.Controls.Add(this.button1);
            this.pnlIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlIslemler.Location = new System.Drawing.Point(0, 383);
            this.pnlIslemler.Name = "pnlIslemler";
            this.pnlIslemler.Size = new System.Drawing.Size(800, 67);
            this.pnlIslemler.TabIndex = 0;
            // 
            // gridStoklar
            // 
            this.gridStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStoklar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridStoklar.Location = new System.Drawing.Point(0, 70);
            this.gridStoklar.Name = "gridStoklar";
            this.gridStoklar.Size = new System.Drawing.Size(800, 313);
            this.gridStoklar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageKey = "initiate_money_transfer_16px.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(32, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stok Giriş";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageKey = "request_money_16px.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(216, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stok Çıkış";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageKey = "restart_16px.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(400, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stok Güncelle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageKey = "eraser_16px.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(584, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stok Kaydını Sil";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "restart_16px.png");
            this.ımageList1.Images.SetKeyName(1, "eraser_16px.png");
            this.ımageList1.Images.SetKeyName(2, "initiate_money_transfer_16px.png");
            this.ımageList1.Images.SetKeyName(3, "request_money_16px.png");
            this.ımageList1.Images.SetKeyName(4, "search.png");
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(12, 12);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(176, 21);
            this.cmbUrunler.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.ImageKey = "search.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(12, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Ürünü Filtrele";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.gridStoklar);
            this.Controls.Add(this.pnlIslemler);
            this.MaximizeBox = false;
            this.Name = "frmStokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.TopMost = true;
            this.pnlIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemler;
        private System.Windows.Forms.DataGridView gridStoklar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Button button5;
    }
}