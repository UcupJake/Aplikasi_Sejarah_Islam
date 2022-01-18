using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Aplikasi_Sejarah_Islam
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
            Transparan.BackColor = Color.FromArgb(175, Color.White);
            DesainAplikasi();
            //int w = 10;
            //Size ukuran = new Size(450, 200);
            //bool ukuranGambar = Convert.ToBoolean(w);
            //Bitmap bitmap1 = new Bitmap(@"D:\Pictures\Tugas\Tugas PABS\Tugas Kuliah\Sejarah-Agama-Islam.jpg", ukuranGambar);
            //Bitmap bitmap2 = new Bitmap(@"D:\Pictures\Tugas\Tugas PABS\Tugas Kuliah\Abu-Bakar.jpg");
            //Bitmap bitmap3 = new Bitmap(@"D:\Pictures\Tugas\Tugas PABS\Tugas Kuliah\Abu-Bakar.jpg");
            //TombolUtama1.Image = bitmap1;
            //TombolUtama2.Image = bitmap2;
            //TombolUtama3.Image = bitmap3;
            //TombolUtama1.Image = (Image)(new Bitmap(@"D:\Pictures\Tugas\Tugas PABS\Tugas Kuliah\Sejarah-Agama-Islam.jpg"));

            //            TombolUtama1.BackgroundImageLayout = ImageLayout.Stretch;

            //Mengubah ukuran jendela aplikasi tanpa border default
            //            FormBorderStyle = FormBorderStyle.None;
            //            DoubleBuffered = true;
            //            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //private const int cGrip = 16;      // Ukuran Grip (Pegangan)
        //private const int cCaption = 32;   // Tinggi Caption Bar;



        //        protected override void OnPaint(PaintEventArgs e)
        //        {
        //base.OnPaint(e);

        //            Rectangle rectangle = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
        //            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rectangle);
        //rectangle = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
        //e.Graphics.FillRectangle(Brushes.DarkBlue, rectangle);
        //        }




        //Mengubah ukuran jendela aplikasi tanpa border default
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;

        //Aplikasi bisa diperbesar dan diperkecil
        protected override void WndProc(ref Message m)
        {
//            if (m.Msg == 0x84)
//            {  // Trap WM_NCHITTEST
//                Point pos = new Point(m.LParam.ToInt32());
//                pos = PointToClient(pos);
//                if (pos.Y < cCaption)
//                {
//                    m.Result = (IntPtr)2;  // HTCAPTION
//                    return;
//                }
//                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
//                {
//                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
//                    return;
 //               }
 //           }
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.Style |= 262144;
                return createParams;
            }
        }

        //Aplikasi bisa di-drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void DesainAplikasi()
        {
            SubPeriodisasi.Visible = false;
        }

        private void SembunyikanSubMenu()
        {
            if (SubPeriodisasi.Visible == true)
                SubPeriodisasi.Visible = false;
        }

        private void TampilkanSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                SembunyikanSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Transparan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NamaAplikasi_Click(object sender, EventArgs e)
        {

        }

        //Close, Maximize, dan Minimize
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestoreDown.Visible = true;
            Maximize.Visible = false;
        }

        private void RestoreDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestoreDown.Visible = false;
            Maximize.Visible = true;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Taskbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Logo_Click(object sender, EventArgs e)
        {
//            if (MenuNavigasi.Width == 65)
//            {
//                MenuNavigasi.Width = 250;
//            }
//            else
//                MenuNavigasi.Width = 65;
        }

        private void TombolMenu_Click(object sender, EventArgs e)
        {
            //            if (MenuNavigasi.Width == 56)
            //            {
            //                MenuNavigasi.Width = 250;
            //            }
            //            else
            //                MenuNavigasi.Width = 56;

            this.Hide();
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();

        }

        private void Periodisasi_Click(object sender, EventArgs e)
        {
            TampilkanSubMenu(SubPeriodisasi);
        }

        //Pindah ke halaman lain
        private Form formAktif = null;

        private void BukaHalaman(Form bukaForm)
        {
            if (formAktif != null)
                formAktif.Close();
            formAktif = bukaForm;
            bukaForm.TopLevel = false;
            bukaForm.FormBorderStyle = FormBorderStyle.None;
            bukaForm.Dock = DockStyle.Fill;
            PanelPeriodisasi.Controls.Add(bukaForm);
            PanelPeriodisasi.Tag = bukaForm;
            bukaForm.BringToFront();
            bukaForm.Show();
        }

        private void Periodisasi1_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi());
            SembunyikanSubMenu();
        }

        private void Periodisasi2_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi2());
            SembunyikanSubMenu();
        }

        private void Periodisasi3_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi3());
            SembunyikanSubMenu();
        }

        private void Periodisasi4_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi4());
            SembunyikanSubMenu();
        }

        private void Periodisasi5_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi5());
            SembunyikanSubMenu();
        }

        private void Periodisasi6_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi6());
            SembunyikanSubMenu();
        }

        private void PanelPeriodisasi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelPeriodisasi_Resize(object sender, EventArgs e)
        {
//            ResizeControl();
        }

        //Bisa Scrolling tanpa menganggu Gambar Latar Belakang (Background Image)
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool LockWindowUpdate(IntPtr hWnd);

        private void PanelPeriodisasi_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.First)
            {
                LockWindowUpdate(this.Handle);
            }
            else
            {
                LockWindowUpdate(IntPtr.Zero);
                PanelPeriodisasi.Update();
                if (e.Type != ScrollEventType.Last) LockWindowUpdate(this.Handle);
            }
        }

        //Fitur Aplikasi diperbesar
        //private Rectangle normalAplikasi;
        private Size normalFitur;
        private Rectangle perbesarFitur1;
        private Rectangle perbesarFitur2;
        private Rectangle perbesarFitur3;
        private Rectangle perbesarFitur4;
        private Rectangle perbesarFitur5;
        private Rectangle perbesarFitur6;

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            normalFitur = Size;
            perbesarFitur1 = new Rectangle(TombolUtama1.Location.X, TombolUtama1.Location.Y, TombolUtama1.Width, TombolUtama1.Height);
            perbesarFitur2 = new Rectangle(TombolUtama2.Location.X, TombolUtama2.Location.Y, TombolUtama2.Width, TombolUtama2.Height);
            perbesarFitur3 = new Rectangle(TombolUtama3.Location.X, TombolUtama3.Location.Y, TombolUtama3.Width, TombolUtama3.Height);
            perbesarFitur4 = new Rectangle(TombolUtama4.Location.X, TombolUtama4.Location.Y, TombolUtama4.Width, TombolUtama4.Height);
            perbesarFitur5 = new Rectangle(TombolUtama5.Location.X, TombolUtama5.Location.Y, TombolUtama5.Width, TombolUtama5.Height);
            perbesarFitur6 = new Rectangle(TombolUtama6.Location.X, TombolUtama6.Location.Y, TombolUtama6.Width, TombolUtama6.Height);
        }

        private void ResizeControl()
        {
            ResizeChildrenControl(perbesarFitur1, TombolUtama1);
            ResizeChildrenControl(perbesarFitur2, TombolUtama2);
            ResizeChildrenControl(perbesarFitur3, TombolUtama3);
            ResizeChildrenControl(perbesarFitur4, TombolUtama4);
            ResizeChildrenControl(perbesarFitur5, TombolUtama5);
            ResizeChildrenControl(perbesarFitur6, TombolUtama6);
        }

        private void ResizeChildrenControl(Rectangle perbesaranNormal, Control control)
        {
            float xRasio = (float)(Width) / (float)(normalFitur.Width);
            float yRasio = (float)(Height) / (float)(normalFitur.Height);

            int newX = (int)(perbesaranNormal.X * xRasio);
            int newY = (int)(perbesaranNormal.Y * yRasio);

            int newWidth = (int)(perbesaranNormal.Width * xRasio);
            int newHeigth = (int)(perbesaranNormal.Height * yRasio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeigth);
        }

        //        private void ResizeControl(Rectangle r, Control c)
        //        {
        //            float xRasio = (float)(Width) / (float)(normalFitur.Width);
        //            float yRasio = (float)(Height) / (float)(normalFitur.Height);

        //            int newX = (int)(r.Width * xRasio);
        //            int newY = (int)(r.Height * yRasio);

        //            int newWidth = (int)(r.Width * xRasio);
        //            int newHeight = (int)(r.Height * yRasio);

        //            c.Location = new Point(newX, newY);
        //            c.Size = new Size(newWidth, newHeight);
        //        }

        private void MenuUtama_Resize(object sender, EventArgs e)
        {
            //ResizeControl(perbesarFitur1, TombolUtama1);
            //ResizeControl(perbesarFitur2, TombolUtama2);
            //ResizeControl(perbesarFitur3, TombolUtama3);
            //ResizeControl(perbesarFitur4, TombolUtama4);
            //ResizeControl(perbesarFitur5, TombolUtama5);
            //ResizeControl(perbesarFitur6, TombolUtama6);
            //ResizeControl();
        }

        //Pindah ke halaman lain
        private void TombolUtama1_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi());
        }

        private void TombolUtama2_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi2());
        }

        private void TombolUtama3_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi3());
        }

        private void TombolUtama4_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi4());
        }

        private void TombolUtama5_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi5());
        }

        private void TombolUtama6_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi6());
        }
    }
}
