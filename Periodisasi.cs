using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Sejarah_Islam
{
    public partial class Periodisasi : Form
    {
        public Periodisasi()
        {
            InitializeComponent();
            TransparanP1.BackColor = Color.FromArgb(200, Color.White);
        }

        private Form formAktif = null;

        private void BukaHalaman(Form bukaForm)
        {
            if (formAktif != null)
                formAktif.Close();
            formAktif = bukaForm;
            bukaForm.TopLevel = false;
            bukaForm.FormBorderStyle = FormBorderStyle.None;
            bukaForm.Dock = DockStyle.Fill;
            TransparanP1.Controls.Add(bukaForm);
            TransparanP1.Tag = bukaForm;
            bukaForm.BringToFront();
            bukaForm.Show();
        }

        private void tombol1_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Kronologi1_1());
        }
    }
}
