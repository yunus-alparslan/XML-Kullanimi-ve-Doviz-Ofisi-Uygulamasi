
namespace XML_Kullanımı_ve_Döviz_Ofisi_Uygulamasıı
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
            this.labeldolarlıs = new System.Windows.Forms.Label();
            this.labeldolarsatıs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelavrosatıs = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelavroalıs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonhesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonsatınal = new System.Windows.Forms.Button();
            this.textBoxkalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxtutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxmiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxkur = new System.Windows.Forms.TextBox();
            this.buttonalısdolar = new System.Windows.Forms.Button();
            this.buttonsatısdolar = new System.Windows.Forms.Button();
            this.buttonavro = new System.Windows.Forms.Button();
            this.buttonalısavro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış :";
            // 
            // labeldolarlıs
            // 
            this.labeldolarlıs.AutoSize = true;
            this.labeldolarlıs.Location = new System.Drawing.Point(126, 53);
            this.labeldolarlıs.Name = "labeldolarlıs";
            this.labeldolarlıs.Size = new System.Drawing.Size(44, 19);
            this.labeldolarlıs.TabIndex = 1;
            this.labeldolarlıs.Text = "NULL";
            // 
            // labeldolarsatıs
            // 
            this.labeldolarsatıs.AutoSize = true;
            this.labeldolarsatıs.Location = new System.Drawing.Point(126, 87);
            this.labeldolarsatıs.Name = "labeldolarsatıs";
            this.labeldolarsatıs.Size = new System.Drawing.Size(44, 19);
            this.labeldolarsatıs.TabIndex = 3;
            this.labeldolarsatıs.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satış :";
            // 
            // labelavrosatıs
            // 
            this.labelavrosatıs.AutoSize = true;
            this.labelavrosatıs.Location = new System.Drawing.Point(122, 187);
            this.labelavrosatıs.Name = "labelavrosatıs";
            this.labelavrosatıs.Size = new System.Drawing.Size(44, 19);
            this.labelavrosatıs.TabIndex = 7;
            this.labelavrosatıs.Text = "NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satış :";
            // 
            // labelavroalıs
            // 
            this.labelavroalıs.AutoSize = true;
            this.labelavroalıs.Location = new System.Drawing.Point(122, 157);
            this.labelavroalıs.Name = "labelavroalıs";
            this.labelavroalıs.Size = new System.Drawing.Size(44, 19);
            this.labelavroalıs.TabIndex = 5;
            this.labelavroalıs.Text = "NULL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış :";
            // 
            // buttonhesapla
            // 
            this.buttonhesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonhesapla.Location = new System.Drawing.Point(33, 155);
            this.buttonhesapla.Name = "buttonhesapla";
            this.buttonhesapla.Size = new System.Drawing.Size(100, 35);
            this.buttonhesapla.TabIndex = 8;
            this.buttonhesapla.Text = "Hesapla";
            this.buttonhesapla.UseVisualStyleBackColor = true;
            this.buttonhesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kur :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsatınal);
            this.groupBox1.Controls.Add(this.textBoxkalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxtutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxmiktar);
            this.groupBox1.Controls.Add(this.buttonhesapla);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxkur);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(305, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 194);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonsatınal
            // 
            this.buttonsatınal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsatınal.Location = new System.Drawing.Point(139, 155);
            this.buttonsatınal.Name = "buttonsatınal";
            this.buttonsatınal.Size = new System.Drawing.Size(100, 35);
            this.buttonsatınal.TabIndex = 17;
            this.buttonsatınal.Text = "Satın Al";
            this.buttonsatınal.UseVisualStyleBackColor = true;
            this.buttonsatınal.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxkalan
            // 
            this.textBoxkalan.Location = new System.Drawing.Point(67, 125);
            this.textBoxkalan.Name = "textBoxkalan";
            this.textBoxkalan.Size = new System.Drawing.Size(220, 24);
            this.textBoxkalan.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan :";
            // 
            // textBoxtutar
            // 
            this.textBoxtutar.Location = new System.Drawing.Point(67, 95);
            this.textBoxtutar.Name = "textBoxtutar";
            this.textBoxtutar.Size = new System.Drawing.Size(220, 24);
            this.textBoxtutar.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar :";
            // 
            // textBoxmiktar
            // 
            this.textBoxmiktar.Location = new System.Drawing.Point(67, 66);
            this.textBoxmiktar.Name = "textBoxmiktar";
            this.textBoxmiktar.Size = new System.Drawing.Size(220, 24);
            this.textBoxmiktar.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Miktar :";
            // 
            // textBoxkur
            // 
            this.textBoxkur.Enabled = false;
            this.textBoxkur.Location = new System.Drawing.Point(67, 36);
            this.textBoxkur.Name = "textBoxkur";
            this.textBoxkur.Size = new System.Drawing.Size(220, 24);
            this.textBoxkur.TabIndex = 10;
            this.textBoxkur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonalısdolar
            // 
            this.buttonalısdolar.Location = new System.Drawing.Point(189, 53);
            this.buttonalısdolar.Name = "buttonalısdolar";
            this.buttonalısdolar.Size = new System.Drawing.Size(33, 25);
            this.buttonalısdolar.TabIndex = 11;
            this.buttonalısdolar.Text = "...";
            this.buttonalısdolar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonalısdolar.UseVisualStyleBackColor = true;
            this.buttonalısdolar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonsatısdolar
            // 
            this.buttonsatısdolar.Location = new System.Drawing.Point(189, 87);
            this.buttonsatısdolar.Name = "buttonsatısdolar";
            this.buttonsatısdolar.Size = new System.Drawing.Size(33, 25);
            this.buttonsatısdolar.TabIndex = 12;
            this.buttonsatısdolar.Text = "...";
            this.buttonsatısdolar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonsatısdolar.UseVisualStyleBackColor = true;
            this.buttonsatısdolar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonavro
            // 
            this.buttonavro.Location = new System.Drawing.Point(189, 187);
            this.buttonavro.Name = "buttonavro";
            this.buttonavro.Size = new System.Drawing.Size(33, 25);
            this.buttonavro.TabIndex = 14;
            this.buttonavro.Text = "...";
            this.buttonavro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonavro.UseVisualStyleBackColor = true;
            this.buttonavro.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonalısavro
            // 
            this.buttonalısavro.Location = new System.Drawing.Point(189, 153);
            this.buttonalısavro.Name = "buttonalısavro";
            this.buttonalısavro.Size = new System.Drawing.Size(33, 25);
            this.buttonalısavro.TabIndex = 13;
            this.buttonalısavro.Text = "...";
            this.buttonalısavro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonalısavro.UseVisualStyleBackColor = true;
            this.buttonalısavro.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(890, 420);
            this.Controls.Add(this.buttonavro);
            this.Controls.Add(this.buttonalısavro);
            this.Controls.Add(this.buttonsatısdolar);
            this.Controls.Add(this.buttonalısdolar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelavrosatıs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelavroalıs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labeldolarsatıs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeldolarlıs);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeldolarlıs;
        private System.Windows.Forms.Label labeldolarsatıs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelavrosatıs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelavroalıs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonhesapla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxkalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxtutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxmiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxkur;
        private System.Windows.Forms.Button buttonalısdolar;
        private System.Windows.Forms.Button buttonsatısdolar;
        private System.Windows.Forms.Button buttonavro;
        private System.Windows.Forms.Button buttonalısavro;
        private System.Windows.Forms.Button buttonsatınal;
    }
}

