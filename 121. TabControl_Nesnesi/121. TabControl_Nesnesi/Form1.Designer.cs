
namespace _121.TabControl_Nesnesi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.anasayfa = new System.Windows.Forms.TabPage();
            this.üyelikislemleri = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.anasayfa.SuspendLayout();
            this.üyelikislemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.anasayfa);
            this.tabControl1.Controls.Add(this.üyelikislemleri);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 247);
            this.tabControl1.TabIndex = 0;
            // 
            // anasayfa
            // 
            this.anasayfa.Controls.Add(this.label1);
            this.anasayfa.Location = new System.Drawing.Point(4, 22);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.anasayfa.Size = new System.Drawing.Size(392, 221);
            this.anasayfa.TabIndex = 0;
            this.anasayfa.Text = "Anasayfa";
            this.anasayfa.UseVisualStyleBackColor = true;
            // 
            // üyelikislemleri
            // 
            this.üyelikislemleri.Controls.Add(this.label2);
            this.üyelikislemleri.Location = new System.Drawing.Point(4, 22);
            this.üyelikislemleri.Name = "üyelikislemleri";
            this.üyelikislemleri.Padding = new System.Windows.Forms.Padding(3);
            this.üyelikislemleri.Size = new System.Drawing.Size(392, 221);
            this.üyelikislemleri.TabIndex = 1;
            this.üyelikislemleri.Text = "üyelik işlemleri";
            this.üyelikislemleri.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BURASI ANASAYFA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BURASI ÜYELİK SAYFASIDIR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 247);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.anasayfa.ResumeLayout(false);
            this.anasayfa.PerformLayout();
            this.üyelikislemleri.ResumeLayout(false);
            this.üyelikislemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage anasayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage üyelikislemleri;
        private System.Windows.Forms.Label label2;
    }
}

