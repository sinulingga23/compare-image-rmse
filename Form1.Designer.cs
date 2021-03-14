namespace MetopelP6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_bandingkan_gambar = new System.Windows.Forms.Button();
            this.btn_upl_gambar2 = new System.Windows.Forms.Button();
            this.btn_upl_gambar1 = new System.Windows.Forms.Button();
            this.gb_gambar2 = new System.Windows.Forms.GroupBox();
            this.gambar2 = new System.Windows.Forms.PictureBox();
            this.gb_gambar1 = new System.Windows.Forms.GroupBox();
            this.gambar1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hasil_rmse = new System.Windows.Forms.Label();
            this.btn_matriks_rgb_gambar1 = new System.Windows.Forms.Button();
            this.btn_matriks_rgb_gambar2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_gambar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambar2)).BeginInit();
            this.gb_gambar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_bandingkan_gambar);
            this.groupBox1.Controls.Add(this.btn_upl_gambar2);
            this.groupBox1.Controls.Add(this.btn_upl_gambar1);
            this.groupBox1.Controls.Add(this.gb_gambar2);
            this.groupBox1.Controls.Add(this.gb_gambar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Utama";
            // 
            // btn_bandingkan_gambar
            // 
            this.btn_bandingkan_gambar.Location = new System.Drawing.Point(344, 221);
            this.btn_bandingkan_gambar.Name = "btn_bandingkan_gambar";
            this.btn_bandingkan_gambar.Size = new System.Drawing.Size(101, 23);
            this.btn_bandingkan_gambar.TabIndex = 5;
            this.btn_bandingkan_gambar.Text = "Bandingkan";
            this.btn_bandingkan_gambar.UseVisualStyleBackColor = true;
            this.btn_bandingkan_gambar.Click += new System.EventHandler(this.btn_bandingkan_gambar_Click);
            // 
            // btn_upl_gambar2
            // 
            this.btn_upl_gambar2.Location = new System.Drawing.Point(548, 195);
            this.btn_upl_gambar2.Name = "btn_upl_gambar2";
            this.btn_upl_gambar2.Size = new System.Drawing.Size(101, 23);
            this.btn_upl_gambar2.TabIndex = 4;
            this.btn_upl_gambar2.Text = "Upload Gambar 2";
            this.btn_upl_gambar2.UseVisualStyleBackColor = true;
            this.btn_upl_gambar2.Click += new System.EventHandler(this.btn_upl_gambar2_Click);
            // 
            // btn_upl_gambar1
            // 
            this.btn_upl_gambar1.Location = new System.Drawing.Point(129, 196);
            this.btn_upl_gambar1.Name = "btn_upl_gambar1";
            this.btn_upl_gambar1.Size = new System.Drawing.Size(101, 23);
            this.btn_upl_gambar1.TabIndex = 3;
            this.btn_upl_gambar1.Text = "Upload Gambar 1";
            this.btn_upl_gambar1.UseVisualStyleBackColor = true;
            this.btn_upl_gambar1.Click += new System.EventHandler(this.btn_upl_gambar1_Click);
            // 
            // gb_gambar2
            // 
            this.gb_gambar2.Controls.Add(this.gambar2);
            this.gb_gambar2.Location = new System.Drawing.Point(405, 19);
            this.gb_gambar2.Name = "gb_gambar2";
            this.gb_gambar2.Size = new System.Drawing.Size(380, 170);
            this.gb_gambar2.TabIndex = 2;
            this.gb_gambar2.TabStop = false;
            this.gb_gambar2.Text = "Gambar 2";
            // 
            // gambar2
            // 
            this.gambar2.Location = new System.Drawing.Point(6, 19);
            this.gambar2.Name = "gambar2";
            this.gambar2.Size = new System.Drawing.Size(368, 145);
            this.gambar2.TabIndex = 1;
            this.gambar2.TabStop = false;
            // 
            // gb_gambar1
            // 
            this.gb_gambar1.Controls.Add(this.gambar1);
            this.gb_gambar1.Location = new System.Drawing.Point(7, 20);
            this.gb_gambar1.Name = "gb_gambar1";
            this.gb_gambar1.Size = new System.Drawing.Size(380, 170);
            this.gb_gambar1.TabIndex = 0;
            this.gb_gambar1.TabStop = false;
            this.gb_gambar1.Text = "Gambar 1";
            // 
            // gambar1
            // 
            this.gambar1.Location = new System.Drawing.Point(6, 19);
            this.gambar1.Name = "gambar1";
            this.gambar1.Size = new System.Drawing.Size(368, 145);
            this.gambar1.TabIndex = 0;
            this.gambar1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hasil_rmse);
            this.groupBox2.Location = new System.Drawing.Point(19, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasil";
            // 
            // hasil_rmse
            // 
            this.hasil_rmse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hasil_rmse.Location = new System.Drawing.Point(44, 60);
            this.hasil_rmse.Name = "hasil_rmse";
            this.hasil_rmse.Size = new System.Drawing.Size(523, 47);
            this.hasil_rmse.TabIndex = 0;
            this.hasil_rmse.Text = "-";
            this.hasil_rmse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_matriks_rgb_gambar1
            // 
            this.btn_matriks_rgb_gambar1.Location = new System.Drawing.Point(663, 278);
            this.btn_matriks_rgb_gambar1.Name = "btn_matriks_rgb_gambar1";
            this.btn_matriks_rgb_gambar1.Size = new System.Drawing.Size(128, 21);
            this.btn_matriks_rgb_gambar1.TabIndex = 6;
            this.btn_matriks_rgb_gambar1.Text = "Matriks RGB Gambar 1";
            this.btn_matriks_rgb_gambar1.UseVisualStyleBackColor = true;
            this.btn_matriks_rgb_gambar1.Click += new System.EventHandler(this.btn_matriks_rgb_gambar1_Click);
            // 
            // btn_matriks_rgb_gambar2
            // 
            this.btn_matriks_rgb_gambar2.Location = new System.Drawing.Point(663, 305);
            this.btn_matriks_rgb_gambar2.Name = "btn_matriks_rgb_gambar2";
            this.btn_matriks_rgb_gambar2.Size = new System.Drawing.Size(128, 21);
            this.btn_matriks_rgb_gambar2.TabIndex = 7;
            this.btn_matriks_rgb_gambar2.Text = "Matriks RGB Gambar 2";
            this.btn_matriks_rgb_gambar2.UseVisualStyleBackColor = true;
            this.btn_matriks_rgb_gambar2.Click += new System.EventHandler(this.btn_matriks_rgb_gambar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 442);
            this.Controls.Add(this.btn_matriks_rgb_gambar2);
            this.Controls.Add(this.btn_matriks_rgb_gambar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pencocokan 2 Gambar - RMSE";
            this.groupBox1.ResumeLayout(false);
            this.gb_gambar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gambar2)).EndInit();
            this.gb_gambar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gambar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_gambar2;
        private System.Windows.Forms.GroupBox gb_gambar1;
        private System.Windows.Forms.PictureBox gambar1;
        private System.Windows.Forms.PictureBox gambar2;
        private System.Windows.Forms.Button btn_upl_gambar2;
        private System.Windows.Forms.Button btn_upl_gambar1;
        private System.Windows.Forms.Button btn_bandingkan_gambar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_matriks_rgb_gambar1;
        private System.Windows.Forms.Button btn_matriks_rgb_gambar2;
        private System.Windows.Forms.Label hasil_rmse;
    }
}

