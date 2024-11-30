namespace ArabaYarisi
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.bizim_araba = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.yol2 = new System.Windows.Forms.PictureBox();
            this.yol1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizim_araba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(310, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Puan :";
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.Location = new System.Drawing.Point(438, 502);
            this.puan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(51, 37);
            this.puan.TabIndex = 13;
            this.puan.Text = "00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.bizim_araba);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol2);
            this.panel1.Controls.Add(this.yol1);
            this.panel1.Location = new System.Drawing.Point(139, -27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ArabaYarisi.Properties.Resources.start_1_;
            this.button1.Location = new System.Drawing.Point(317, 581);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 91);
            this.button1.TabIndex = 12;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carpma
            // 
            this.carpma.Image = global::ArabaYarisi.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(264, 274);
            this.carpma.Margin = new System.Windows.Forms.Padding(4);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(64, 64);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.carpma.TabIndex = 12;
            this.carpma.TabStop = false;
            // 
            // bizim_araba
            // 
            this.bizim_araba.Image = global::ArabaYarisi.Properties.Resources.araba9;
            this.bizim_araba.Location = new System.Drawing.Point(221, 361);
            this.bizim_araba.Margin = new System.Windows.Forms.Padding(4);
            this.bizim_araba.Name = "bizim_araba";
            this.bizim_araba.Size = new System.Drawing.Size(87, 159);
            this.bizim_araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizim_araba.TabIndex = 6;
            this.bizim_araba.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::ArabaYarisi.Properties.Resources.araba5;
            this.araba2.Location = new System.Drawing.Point(383, 143);
            this.araba2.Margin = new System.Windows.Forms.Padding(4);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(58, 117);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.araba2.TabIndex = 5;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::ArabaYarisi.Properties.Resources.araba4;
            this.araba1.Location = new System.Drawing.Point(68, 59);
            this.araba1.Margin = new System.Windows.Forms.Padding(4);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(60, 127);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.araba1.TabIndex = 4;
            this.araba1.TabStop = false;
            // 
            // yol2
            // 
            this.yol2.Location = new System.Drawing.Point(-3, -785);
            this.yol2.Margin = new System.Windows.Forms.Padding(4);
            this.yol2.Name = "yol2";
            this.yol2.Size = new System.Drawing.Size(513, 775);
            this.yol2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol2.TabIndex = 3;
            this.yol2.TabStop = false;
            // 
            // yol1
            // 
            this.yol1.Image = global::ArabaYarisi.Properties.Resources.yol;
            this.yol1.Location = new System.Drawing.Point(-3, -273);
            this.yol1.Margin = new System.Windows.Forms.Padding(4);
            this.yol1.Name = "yol1";
            this.yol1.Size = new System.Drawing.Size(513, 775);
            this.yol1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol1.TabIndex = 2;
            this.yol1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(779, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizim_araba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.PictureBox bizim_araba;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.PictureBox yol2;
        private System.Windows.Forms.PictureBox yol1;
        private System.Windows.Forms.Timer timer1;
    }
}

