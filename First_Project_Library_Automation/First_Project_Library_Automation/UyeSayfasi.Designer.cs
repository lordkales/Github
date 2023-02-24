
namespace First_Project_Library_Automation
{
    partial class UyeSayfasi
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
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.txt_kitap = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dataGridView22 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView22)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(12, 43);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(60, 20);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(176, 43);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(48, 20);
            this.btn_yenile.TabIndex = 1;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // txt_kitap
            // 
            this.txt_kitap.Location = new System.Drawing.Point(78, 43);
            this.txt_kitap.Name = "txt_kitap";
            this.txt_kitap.Size = new System.Drawing.Size(74, 20);
            this.txt_kitap.TabIndex = 2;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(12, 341);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(74, 29);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // dataGridView22
            // 
            this.dataGridView22.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView22.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView22.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfasayisi,
            this.basimyili});
            this.dataGridView22.Location = new System.Drawing.Point(12, 88);
            this.dataGridView22.Name = "dataGridView22";
            this.dataGridView22.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView22.Size = new System.Drawing.Size(688, 261);
            this.dataGridView22.TabIndex = 5;
            // 
            // kitapid
            // 
            this.kitapid.FillWeight = 50F;
            this.kitapid.HeaderText = "ID";
            this.kitapid.Name = "kitapid";
            // 
            // kitapisim
            // 
            this.kitapisim.FillWeight = 95.36802F;
            this.kitapisim.HeaderText = "KİTAP İSİM";
            this.kitapisim.Name = "kitapisim";
            // 
            // kitapyazar
            // 
            this.kitapyazar.FillWeight = 95.36802F;
            this.kitapyazar.HeaderText = "KİTAP YAZAR";
            this.kitapyazar.Name = "kitapyazar";
            // 
            // kitapdili
            // 
            this.kitapdili.FillWeight = 95.36802F;
            this.kitapdili.HeaderText = "KİTAP DİLİ";
            this.kitapdili.Name = "kitapdili";
            // 
            // yayinevi
            // 
            this.yayinevi.FillWeight = 95.36802F;
            this.yayinevi.HeaderText = "YAYINEVİ";
            this.yayinevi.Name = "yayinevi";
            // 
            // tur
            // 
            this.tur.FillWeight = 70F;
            this.tur.HeaderText = "TÜR";
            this.tur.Name = "tur";
            // 
            // adet
            // 
            this.adet.FillWeight = 70F;
            this.adet.HeaderText = "ADET";
            this.adet.Name = "adet";
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.FillWeight = 70F;
            this.sayfasayisi.HeaderText = "SAYFA SAYISI";
            this.sayfasayisi.Name = "sayfasayisi";
            // 
            // basimyili
            // 
            this.basimyili.FillWeight = 95.36802F;
            this.basimyili.HeaderText = "BASIM YILI";
            this.basimyili.Name = "basimyili";
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 382);
            this.Controls.Add(this.dataGridView22);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.txt_kitap);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_ara);
            this.Name = "UyeSayfasi";
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox txt_kitap;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dataGridView22;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyili;
    }
}