namespace Proje
{
    partial class AnaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.basla = new System.Windows.Forms.Button();
            this.bitir = new System.Windows.Forms.Button();
            this.arastirilan_sayi = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.threadler = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolunuyor_mu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arastirilan_text = new System.Windows.Forms.Label();
            this.bolenler_sonuc = new System.Windows.Forms.WebBrowser();
            this.sonuc_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // basla
            // 
            this.basla.BackColor = System.Drawing.Color.Red;
            this.basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla.Location = new System.Drawing.Point(389, 29);
            this.basla.Margin = new System.Windows.Forms.Padding(2);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(56, 44);
            this.basla.TabIndex = 0;
            this.basla.Text = "Başla";
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // bitir
            // 
            this.bitir.BackColor = System.Drawing.Color.Red;
            this.bitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitir.Location = new System.Drawing.Point(490, 29);
            this.bitir.Margin = new System.Windows.Forms.Padding(2);
            this.bitir.Name = "bitir";
            this.bitir.Size = new System.Drawing.Size(56, 44);
            this.bitir.TabIndex = 1;
            this.bitir.Text = "Bitir";
            this.bitir.UseVisualStyleBackColor = false;
            this.bitir.Click += new System.EventHandler(this.bitir_Click);
            // 
            // arastirilan_sayi
            // 
            this.arastirilan_sayi.AutoSize = true;
            this.arastirilan_sayi.Location = new System.Drawing.Point(310, 91);
            this.arastirilan_sayi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arastirilan_sayi.Name = "arastirilan_sayi";
            this.arastirilan_sayi.Size = new System.Drawing.Size(81, 13);
            this.arastirilan_sayi.TabIndex = 2;
            this.arastirilan_sayi.Text = "Araştırılan Sayı: ";
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(310, 113);
            this.sonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(44, 13);
            this.sonuc.TabIndex = 3;
            this.sonuc.Text = "Sonuç: ";
            // 
            // threadler
            // 
            this.threadler.AutoSize = true;
            this.threadler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.threadler.Location = new System.Drawing.Point(107, 9);
            this.threadler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threadler.Name = "threadler";
            this.threadler.Size = new System.Drawing.Size(85, 20);
            this.threadler.TabIndex = 4;
            this.threadler.Text = "Threadler";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "0";
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.ColumnHeadersHeight = 20;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.baslangic,
            this.bitis,
            this.bolunuyor_mu});
            this.dgv.Location = new System.Drawing.Point(9, 29);
            this.dgv.Margin = new System.Windows.Forms.Padding(0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(281, 211);
            this.dgv.TabIndex = 5;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.no.DefaultCellStyle = dataGridViewCellStyle2;
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no.Width = 46;
            // 
            // baslangic
            // 
            this.baslangic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.baslangic.DefaultCellStyle = dataGridViewCellStyle3;
            this.baslangic.HeaderText = "Başlangıç";
            this.baslangic.Name = "baslangic";
            this.baslangic.ReadOnly = true;
            this.baslangic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.baslangic.Width = 78;
            // 
            // bitis
            // 
            this.bitis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.bitis.DefaultCellStyle = dataGridViewCellStyle4;
            this.bitis.HeaderText = "Bitiş";
            this.bitis.Name = "bitis";
            this.bitis.ReadOnly = true;
            this.bitis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bitis.Width = 51;
            // 
            // bolunuyor_mu
            // 
            this.bolunuyor_mu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.bolunuyor_mu.DefaultCellStyle = dataGridViewCellStyle5;
            this.bolunuyor_mu.HeaderText = "Bölünüyor Mu?";
            this.bolunuyor_mu.Name = "bolunuyor_mu";
            this.bolunuyor_mu.ReadOnly = true;
            this.bolunuyor_mu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bolunuyor_mu.Width = 103;
            // 
            // arastirilan_text
            // 
            this.arastirilan_text.AutoSize = true;
            this.arastirilan_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arastirilan_text.Location = new System.Drawing.Point(395, 89);
            this.arastirilan_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arastirilan_text.Name = "arastirilan_text";
            this.arastirilan_text.Size = new System.Drawing.Size(103, 15);
            this.arastirilan_text.TabIndex = 6;
            this.arastirilan_text.Text = "arastirilan_text";
            // 
            // bolenler_sonuc
            // 
            this.bolenler_sonuc.AllowNavigation = false;
            this.bolenler_sonuc.AllowWebBrowserDrop = false;
            this.bolenler_sonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bolenler_sonuc.IsWebBrowserContextMenuEnabled = false;
            this.bolenler_sonuc.Location = new System.Drawing.Point(303, 129);
            this.bolenler_sonuc.Margin = new System.Windows.Forms.Padding(0);
            this.bolenler_sonuc.Name = "bolenler_sonuc";
            this.bolenler_sonuc.ScriptErrorsSuppressed = true;
            this.bolenler_sonuc.Size = new System.Drawing.Size(339, 111);
            this.bolenler_sonuc.TabIndex = 0;
            this.bolenler_sonuc.TabStop = false;
            this.bolenler_sonuc.WebBrowserShortcutsEnabled = false;
            // 
            // sonuc_text
            // 
            this.sonuc_text.AutoSize = true;
            this.sonuc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc_text.Location = new System.Drawing.Point(395, 113);
            this.sonuc_text.Name = "sonuc_text";
            this.sonuc_text.Size = new System.Drawing.Size(76, 15);
            this.sonuc_text.TabIndex = 7;
            this.sonuc_text.Text = "sonuc_text";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 249);
            this.Controls.Add(this.sonuc_text);
            this.Controls.Add(this.bolenler_sonuc);
            this.Controls.Add(this.arastirilan_text);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.threadler);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.arastirilan_sayi);
            this.Controls.Add(this.bitir);
            this.Controls.Add(this.basla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaForm";
            this.Text = "Yaz Lab I - 2. Proje";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.Button bitir;
        private System.Windows.Forms.Label arastirilan_sayi;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Label threadler;
        private System.Windows.Forms.Label arastirilan_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolunuyor_mu;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.WebBrowser bolenler_sonuc;
        private System.Windows.Forms.Label sonuc_text;
    }
}