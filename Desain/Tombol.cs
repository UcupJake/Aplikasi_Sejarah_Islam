using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace Aplikasi_Sejarah_Islam.Desain
{
    public class Tombol : Button
    {
        //Tombol Default
        private int ukuranTombol = 0;
        private int radiusTombol = 40;
        private Color warnaTombol = Color.PaleVioletRed;
        //Image image = 

//        [Category("Aplikasi Sejarah Islam")]
//        public int GetUkuranTombol()
//        {
//            return ukuranTombol;
//        }

//        public void SetUkuranTombol(int value)
//        {
//            ukuranTombol = value;
//            this.Invalidate();
//        }

//        [Category("Aplikasi Sejarah Islam")]
//        public int GetRadiusTombol()
//        {
//            return radiusTombol;
//        }

//        public void SetRadiusTombol(int value)
//        {
//            if (value <= this.Height)
//                radiusTombol = value;
//            else radiusTombol = this.Height;
//            this.Invalidate();
//        }

//        [Category("Aplikasi Sejarah Islam")]
//        public Color GetWarnaTombol()
//        {
//            return warnaTombol;
//        }

//        public void SetWarnaTombol(Color value)
//        {
//            warnaTombol = value;
//            this.Invalidate();
//        }

        //Membuat Index Baru
        [Category("Aplikasi Sejarah Islam")]
        public Color WarnaBackground
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Aplikasi Sejarah Islam")]
        public Color WarnaTeks
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("Aplikasi Sejarah Islam")]
        public int UkuranTombol { get => ukuranTombol; set => ukuranTombol = value; }
        [Category("Aplikasi Sejarah Islam")]
        public int RadiusTombol { get => radiusTombol; set => radiusTombol = value; }
        [Category("Aplikasi Sejarah Islam")]
        public Color WarnaTombol { get => warnaTombol; set => warnaTombol = value; }

        //Konstruktor
        public Tombol()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(100, 50);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Mengubah_Tombol);
        }



//        public static Bitmap ResizeImage(Image image)
//        {
//            var destRect = new Rectangle(0, 0, 450, 200);
//            var destImage = new Bitmap(450, 200);

//            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

//            using (var graphics = Graphics.FromImage(destImage))
//            {
//                graphics.CompositingMode = CompositingMode.SourceCopy;
//                graphics.CompositingQuality = CompositingQuality.HighQuality;
//                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
//                graphics.SmoothingMode = SmoothingMode.HighQuality;
//                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

//                using (var wrapMode = new ImageAttributes())
//                {
//                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
//                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
//                }
//            }

//            return destImage;
//        }

        private void Mengubah_Tombol(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (radiusTombol > this.Height)
                radiusTombol = this.Height;
        }

        //Metode UI
        private GraphicsPath GetGraphicsPath(RectangleF persegi, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(persegi.X, persegi.Y, radius, radius, 180, 90);
            path.AddArc(persegi.Width-radius, persegi.Y, radius, radius, 270, 90);
            path.AddArc(persegi.Width-radius, persegi.Height-radius, radius, radius, 0, 90);
            path.AddArc(persegi.X, persegi.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF alasPersegi = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF batasPersegi = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            //Mengubah Bentuk Tombol
            if (radiusTombol > 2)
            {
                using (GraphicsPath pathAlas = GetGraphicsPath(alasPersegi, radiusTombol))
                using (GraphicsPath pathBatas = GetGraphicsPath(batasPersegi, radiusTombol - 1F))
                using (Pen penAlas = new Pen(this.Parent.BackColor, 2))
                using (Pen penBatas = new Pen(warnaTombol, ukuranTombol))
                {
                    penBatas.Alignment = PenAlignment.Inset;
                    // Alas Tombol
                    this.Region = new Region(pathAlas);
                    pevent.Graphics.DrawPath(penAlas, pathAlas);
                    //Bentuk Batas Tombol
                    if (ukuranTombol >= 1)
                        pevent.Graphics.DrawPath(penBatas, pathBatas);
                }
            }
            else // Tombol Normal
            {
                // Alas Tombol
                this.Region = new Region(alasPersegi);
                // Batas Tombol
                if (ukuranTombol >= 1)
                {
                    using (Pen penBatas = new Pen(warnaTombol, ukuranTombol))
                    {
                        penBatas.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBatas, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_WarnaAlas);
        }

        private void Container_WarnaAlas(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
