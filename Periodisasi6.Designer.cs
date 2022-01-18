
namespace Aplikasi_Sejarah_Islam
{
    partial class Periodisasi6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Periodisasi6));
            this.TransparanP6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NamaPeriodisasi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tombol1 = new Aplikasi_Sejarah_Islam.Desain.Tombol();
            this.TransparanP6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TransparanP6
            // 
            this.TransparanP6.Controls.Add(this.label1);
            this.TransparanP6.Controls.Add(this.NamaPeriodisasi);
            this.TransparanP6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransparanP6.Location = new System.Drawing.Point(0, 0);
            this.TransparanP6.Name = "TransparanP6";
            this.TransparanP6.Size = new System.Drawing.Size(1060, 665);
            this.TransparanP6.TabIndex = 0;
            this.TransparanP6.Paint += new System.Windows.Forms.PaintEventHandler(this.TransparanP6_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 40);
            this.label1.TabIndex = 30;
            this.label1.Text = "Dinasti Umayyah";
            // 
            // NamaPeriodisasi
            // 
            this.NamaPeriodisasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NamaPeriodisasi.AutoSize = true;
            this.NamaPeriodisasi.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPeriodisasi.Location = new System.Drawing.Point(281, 35);
            this.NamaPeriodisasi.Name = "NamaPeriodisasi";
            this.NamaPeriodisasi.Size = new System.Drawing.Size(502, 46);
            this.NamaPeriodisasi.TabIndex = 2;
            this.NamaPeriodisasi.Text = "Perkembangan Islam di Indonesia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tombol1
            // 
            this.tombol1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tombol1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tombol1.FlatAppearance.BorderSize = 0;
            this.tombol1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol1.ForeColor = System.Drawing.Color.White;
            this.tombol1.Location = new System.Drawing.Point(505, 181);
            this.tombol1.Name = "tombol1";
            this.tombol1.RadiusTombol = 50;
            this.tombol1.Size = new System.Drawing.Size(50, 50);
            this.tombol1.TabIndex = 26;
            this.tombol1.UkuranTombol = 0;
            this.tombol1.UseVisualStyleBackColor = false;
            this.tombol1.WarnaBackground = System.Drawing.Color.LightSkyBlue;
            this.tombol1.WarnaTeks = System.Drawing.Color.White;
            this.tombol1.WarnaTombol = System.Drawing.Color.PaleVioletRed;
            // 
            // Periodisasi6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 665);
            this.Controls.Add(this.tombol1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TransparanP6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Periodisasi6";
            this.Text = "Periodisasi6";
            this.TransparanP6.ResumeLayout(false);
            this.TransparanP6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TransparanP6;
        private System.Windows.Forms.Label NamaPeriodisasi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Desain.Tombol tombol1;
        private System.Windows.Forms.Label label1;
    }
}