
namespace Aplikasi_Sejarah_Islam
{
    partial class Kronologi1_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kronologi1_1));
            this.TransparanK1_1 = new System.Windows.Forms.Panel();
            this.PDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.NamaPeriodisasi = new System.Windows.Forms.Label();
            this.Keluar = new System.Windows.Forms.Button();
            this.TransparanK1_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // TransparanK1_1
            // 
            this.TransparanK1_1.Controls.Add(this.PDF1);
            this.TransparanK1_1.Controls.Add(this.NamaPeriodisasi);
            this.TransparanK1_1.Controls.Add(this.Keluar);
            this.TransparanK1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransparanK1_1.Location = new System.Drawing.Point(0, 0);
            this.TransparanK1_1.Name = "TransparanK1_1";
            this.TransparanK1_1.Size = new System.Drawing.Size(1060, 665);
            this.TransparanK1_1.TabIndex = 0;
            this.TransparanK1_1.Paint += new System.Windows.Forms.PaintEventHandler(this.TransparanK1_1_Paint);
            // 
            // PDF1
            // 
            this.PDF1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PDF1.Enabled = true;
            this.PDF1.Location = new System.Drawing.Point(35, 110);
            this.PDF1.Name = "PDF1";
            this.PDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF1.OcxState")));
            this.PDF1.Size = new System.Drawing.Size(960, 510);
            this.PDF1.TabIndex = 0;
            // 
            // NamaPeriodisasi
            // 
            this.NamaPeriodisasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NamaPeriodisasi.AutoSize = true;
            this.NamaPeriodisasi.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPeriodisasi.Location = new System.Drawing.Point(335, 35);
            this.NamaPeriodisasi.Name = "NamaPeriodisasi";
            this.NamaPeriodisasi.Size = new System.Drawing.Size(371, 46);
            this.NamaPeriodisasi.TabIndex = 22;
            this.NamaPeriodisasi.Text = "Masa Sebelum Kenabian";
            // 
            // Keluar
            // 
            this.Keluar.FlatAppearance.BorderSize = 0;
            this.Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keluar.Image = ((System.Drawing.Image)(resources.GetObject("Keluar.Image")));
            this.Keluar.Location = new System.Drawing.Point(0, 0);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(60, 60);
            this.Keluar.TabIndex = 21;
            this.Keluar.UseVisualStyleBackColor = true;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // Kronologi1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 665);
            this.Controls.Add(this.TransparanK1_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kronologi1_1";
            this.Text = "Kronologi1_1";
            this.TransparanK1_1.ResumeLayout(false);
            this.TransparanK1_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TransparanK1_1;
        private System.Windows.Forms.Button Keluar;
        private System.Windows.Forms.Label NamaPeriodisasi;
        private AxAcroPDFLib.AxAcroPDF PDF1;
    }
}