
namespace WindowsFormsApp1
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
            this.chechbox_cay = new System.Windows.Forms.CheckBox();
            this.checkbox_kahve = new System.Windows.Forms.CheckBox();
            this.checkbox_hamburger = new System.Windows.Forms.CheckBox();
            this.checkbox_pizza = new System.Windows.Forms.CheckBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chechbox_cay
            // 
            this.chechbox_cay.AutoSize = true;
            this.chechbox_cay.Location = new System.Drawing.Point(24, 22);
            this.chechbox_cay.Name = "chechbox_cay";
            this.chechbox_cay.Size = new System.Drawing.Size(69, 17);
            this.chechbox_cay.TabIndex = 0;
            this.chechbox_cay.Text = "Çay 2 TL";
            this.chechbox_cay.UseVisualStyleBackColor = true;
            // 
            // checkbox_kahve
            // 
            this.checkbox_kahve.AutoSize = true;
            this.checkbox_kahve.Location = new System.Drawing.Point(24, 45);
            this.checkbox_kahve.Name = "checkbox_kahve";
            this.checkbox_kahve.Size = new System.Drawing.Size(82, 17);
            this.checkbox_kahve.TabIndex = 0;
            this.checkbox_kahve.Text = "Kahve 4 TL";
            this.checkbox_kahve.UseVisualStyleBackColor = true;
            // 
            // checkbox_hamburger
            // 
            this.checkbox_hamburger.AutoSize = true;
            this.checkbox_hamburger.Location = new System.Drawing.Point(24, 68);
            this.checkbox_hamburger.Name = "checkbox_hamburger";
            this.checkbox_hamburger.Size = new System.Drawing.Size(109, 17);
            this.checkbox_hamburger.TabIndex = 0;
            this.checkbox_hamburger.Text = "Hamburger 10 TL";
            this.checkbox_hamburger.UseVisualStyleBackColor = true;
            // 
            // checkbox_pizza
            // 
            this.checkbox_pizza.AutoSize = true;
            this.checkbox_pizza.Location = new System.Drawing.Point(24, 91);
            this.checkbox_pizza.Name = "checkbox_pizza";
            this.checkbox_pizza.Size = new System.Drawing.Size(82, 17);
            this.checkbox_pizza.TabIndex = 0;
            this.checkbox_pizza.Text = "Pizza 25 TL";
            this.checkbox_pizza.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(24, 114);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 1;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TUTAR:";
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutar.Location = new System.Drawing.Point(225, 42);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(57, 20);
            this.lbl_tutar.TabIndex = 2;
            this.lbl_tutar.Text = "label1";
            this.lbl_tutar.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 183);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.checkbox_pizza);
            this.Controls.Add(this.checkbox_hamburger);
            this.Controls.Add(this.checkbox_kahve);
            this.Controls.Add(this.chechbox_cay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chechbox_cay;
        private System.Windows.Forms.CheckBox checkbox_kahve;
        private System.Windows.Forms.CheckBox checkbox_hamburger;
        private System.Windows.Forms.CheckBox checkbox_pizza;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tutar;
    }
}

