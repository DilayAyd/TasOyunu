namespace TasOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.tas1 = new System.Windows.Forms.PictureBox();
            this.tas2 = new System.Windows.Forms.PictureBox();
            this.tas3 = new System.Windows.Forms.PictureBox();
            this.anatas = new System.Windows.Forms.PictureBox();
            this.tas4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.engelgetir = new System.Windows.Forms.Button();
            this.engel1 = new System.Windows.Forms.PictureBox();
            this.engel2 = new System.Windows.Forms.PictureBox();
            this.topla = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tas4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(657, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oyun alanını görünür yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tas1
            // 
            this.tas1.BackColor = System.Drawing.Color.Transparent;
            this.tas1.Image = ((System.Drawing.Image)(resources.GetObject("tas1.Image")));
            this.tas1.Location = new System.Drawing.Point(596, 116);
            this.tas1.Name = "tas1";
            this.tas1.Size = new System.Drawing.Size(50, 50);
            this.tas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tas1.TabIndex = 1;
            this.tas1.TabStop = false;
            this.tas1.Click += new System.EventHandler(this.tas1_Click);
            // 
            // tas2
            // 
            this.tas2.BackColor = System.Drawing.Color.Transparent;
            this.tas2.Image = ((System.Drawing.Image)(resources.GetObject("tas2.Image")));
            this.tas2.Location = new System.Drawing.Point(867, 116);
            this.tas2.Name = "tas2";
            this.tas2.Size = new System.Drawing.Size(50, 50);
            this.tas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tas2.TabIndex = 2;
            this.tas2.TabStop = false;
            // 
            // tas3
            // 
            this.tas3.BackColor = System.Drawing.Color.Transparent;
            this.tas3.Image = ((System.Drawing.Image)(resources.GetObject("tas3.Image")));
            this.tas3.Location = new System.Drawing.Point(777, 116);
            this.tas3.Name = "tas3";
            this.tas3.Size = new System.Drawing.Size(50, 50);
            this.tas3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tas3.TabIndex = 3;
            this.tas3.TabStop = false;
            // 
            // anatas
            // 
            this.anatas.Image = ((System.Drawing.Image)(resources.GetObject("anatas.Image")));
            this.anatas.Location = new System.Drawing.Point(754, 269);
            this.anatas.Name = "anatas";
            this.anatas.Size = new System.Drawing.Size(50, 50);
            this.anatas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anatas.TabIndex = 4;
            this.anatas.TabStop = false;
            // 
            // tas4
            // 
            this.tas4.BackColor = System.Drawing.Color.Transparent;
            this.tas4.Image = ((System.Drawing.Image)(resources.GetObject("tas4.Image")));
            this.tas4.Location = new System.Drawing.Point(683, 116);
            this.tas4.Name = "tas4";
            this.tas4.Size = new System.Drawing.Size(50, 50);
            this.tas4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tas4.TabIndex = 5;
            this.tas4.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(336, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "Topları Diz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // engelgetir
            // 
            this.engelgetir.BackColor = System.Drawing.Color.White;
            this.engelgetir.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.engelgetir.Location = new System.Drawing.Point(475, 415);
            this.engelgetir.Name = "engelgetir";
            this.engelgetir.Size = new System.Drawing.Size(113, 64);
            this.engelgetir.TabIndex = 7;
            this.engelgetir.Text = "Engelleri Diz";
            this.engelgetir.UseVisualStyleBackColor = false;
            this.engelgetir.Click += new System.EventHandler(this.engelgetir_Click);
            // 
            // engel1
            // 
            this.engel1.BackColor = System.Drawing.Color.Transparent;
            this.engel1.Image = ((System.Drawing.Image)(resources.GetObject("engel1.Image")));
            this.engel1.Location = new System.Drawing.Point(811, 192);
            this.engel1.Name = "engel1";
            this.engel1.Size = new System.Drawing.Size(50, 50);
            this.engel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel1.TabIndex = 8;
            this.engel1.TabStop = false;
            // 
            // engel2
            // 
            this.engel2.BackColor = System.Drawing.Color.Transparent;
            this.engel2.Image = ((System.Drawing.Image)(resources.GetObject("engel2.Image")));
            this.engel2.Location = new System.Drawing.Point(705, 192);
            this.engel2.Name = "engel2";
            this.engel2.Size = new System.Drawing.Size(50, 50);
            this.engel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel2.TabIndex = 9;
            this.engel2.TabStop = false;
            // 
            // topla
            // 
            this.topla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topla.BackgroundImage")));
            this.topla.Location = new System.Drawing.Point(301, 485);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(322, 81);
            this.topla.TabIndex = 10;
            this.topla.Text = " ";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(768, 485);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(718, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seviye Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.engel2);
            this.Controls.Add(this.engel1);
            this.Controls.Add(this.engelgetir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tas4);
            this.Controls.Add(this.anatas);
            this.Controls.Add(this.tas3);
            this.Controls.Add(this.tas2);
            this.Controls.Add(this.tas1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tas4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox tas1;
        private System.Windows.Forms.PictureBox tas2;
        private System.Windows.Forms.PictureBox tas3;
        private System.Windows.Forms.PictureBox anatas;
        private System.Windows.Forms.PictureBox tas4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button engelgetir;
        private System.Windows.Forms.PictureBox engel1;
        private System.Windows.Forms.PictureBox engel2;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

