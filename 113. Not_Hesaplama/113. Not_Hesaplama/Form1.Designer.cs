namespace _113._Not_Hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_not1 = new System.Windows.Forms.TextBox();
            this.textbox_not2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ortalamasonuc = new System.Windows.Forms.Label();
            this.buton_hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_not1
            // 
            this.textbox_not1.Location = new System.Drawing.Point(74, 24);
            this.textbox_not1.Name = "textbox_not1";
            this.textbox_not1.Size = new System.Drawing.Size(55, 23);
            this.textbox_not1.TabIndex = 0;
            // 
            // textbox_not2
            // 
            this.textbox_not2.Location = new System.Drawing.Point(74, 53);
            this.textbox_not2.Name = "textbox_not2";
            this.textbox_not2.Size = new System.Drawing.Size(55, 23);
            this.textbox_not2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Not";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Not";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ortalama:";
            // 
            // lbl_ortalamasonuc
            // 
            this.lbl_ortalamasonuc.AutoSize = true;
            this.lbl_ortalamasonuc.Location = new System.Drawing.Point(236, 44);
            this.lbl_ortalamasonuc.Name = "lbl_ortalamasonuc";
            this.lbl_ortalamasonuc.Size = new System.Drawing.Size(38, 15);
            this.lbl_ortalamasonuc.TabIndex = 4;
            this.lbl_ortalamasonuc.Text = "label4";
            // 
            // buton_hesapla
            // 
            this.buton_hesapla.Location = new System.Drawing.Point(74, 94);
            this.buton_hesapla.Name = "buton_hesapla";
            this.buton_hesapla.Size = new System.Drawing.Size(67, 28);
            this.buton_hesapla.TabIndex = 5;
            this.buton_hesapla.Text = "HESAPLA";
            this.buton_hesapla.UseVisualStyleBackColor = true;
            this.buton_hesapla.Click += new System.EventHandler(this.buton_hesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 339);
            this.Controls.Add(this.buton_hesapla);
            this.Controls.Add(this.lbl_ortalamasonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_not2);
            this.Controls.Add(this.textbox_not1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textbox_not1;
        private TextBox textbox_not2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_ortalamasonuc;
        private Button buton_hesapla;
    }
}