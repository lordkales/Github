
namespace _134.DataGridView
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.btn_goster = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.btn_goster);
            this.groupBox1.Controls.Add(this.txt_soyisim);
            this.groupBox1.Controls.Add(this.lbl_soyisim);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.lbl_isim);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEMLER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(39, 50);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "id";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(65, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(164, 20);
            this.txt_id.TabIndex = 1;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(35, 76);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(24, 13);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "isim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(65, 73);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(164, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(19, 102);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(40, 13);
            this.lbl_soyisim.TabIndex = 0;
            this.lbl_soyisim.Text = "soyisim";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(65, 99);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(164, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // btn_goster
            // 
            this.btn_goster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_goster.Location = new System.Drawing.Point(22, 125);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(207, 32);
            this.btn_goster.TabIndex = 2;
            this.btn_goster.Text = "GÖSTER";
            this.btn_goster.UseVisualStyleBackColor = false;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ekle.Location = new System.Drawing.Point(22, 163);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(207, 32);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_sil.Location = new System.Drawing.Point(22, 201);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(207, 32);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Khaki;
            this.btn_guncelle.Location = new System.Drawing.Point(22, 239);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(207, 32);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.soyisim});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(306, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(377, 90);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // isim
            // 
            this.isim.HeaderText = "İSİM";
            this.isim.Name = "isim";
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "SOYİSİM";
            this.soyisim.Name = "soyisim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
    }
}

