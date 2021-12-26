namespace WindowsFormsApp3
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
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Button();
            this.epostaTXT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(150, 26);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(100, 96);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(133, 180);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(100, 20);
            this.sayi1.TabIndex = 2;
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(257, 180);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(100, 20);
            this.sayi2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(375, 178);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(75, 23);
            this.sonuc.TabIndex = 5;
            this.sonuc.Text = "sonuc";
            this.sonuc.UseVisualStyleBackColor = true;
            this.sonuc.Click += new System.EventHandler(this.button2_Click);
            // 
            // epostaTXT
            // 
            this.epostaTXT.Location = new System.Drawing.Point(133, 271);
            this.epostaTXT.Name = "epostaTXT";
            this.epostaTXT.Size = new System.Drawing.Size(100, 20);
            this.epostaTXT.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.epostaTXT);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sonuc;
        private System.Windows.Forms.TextBox epostaTXT;
        private System.Windows.Forms.Button button2;
    }
}

