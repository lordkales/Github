
namespace _119.RadioButton_Nesnesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.radio_kadin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(69, 14);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(70, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(69, 48);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(70, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(75, 78);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(53, 17);
            this.radio_erkek.TabIndex = 2;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // radio_kadin
            // 
            this.radio_kadin.AutoSize = true;
            this.radio_kadin.Location = new System.Drawing.Point(76, 101);
            this.radio_kadin.Name = "radio_kadin";
            this.radio_kadin.Size = new System.Drawing.Size(52, 17);
            this.radio_kadin.TabIndex = 3;
            this.radio_kadin.TabStop = true;
            this.radio_kadin.Text = "Kadın";
            this.radio_kadin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cinsiyet:";
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(43, 124);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(85, 27);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Text = "YAZDIR";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 175);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.radio_kadin);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.RadioButton radio_kadin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_yazdir;
    }
}

