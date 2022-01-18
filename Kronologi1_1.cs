using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Sejarah_Islam
{
    public partial class Kronologi1_1 : Form
    {
        public Kronologi1_1()
        {
            InitializeComponent();
            TransparanK1_1.BackColor = Color.FromArgb(200, Color.White);
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
            TransparanK1_1.Controls.Add(bukaForm);
            TransparanK1_1.Tag = bukaForm;
            bukaForm.BringToFront();
            bukaForm.Show();
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            BukaHalaman(new Periodisasi());
        }

        Microsoft.Office.Interop.Word.Application application;
        Microsoft.Office.Interop.Word.Document document;
        object objectMissing = Missing.Value;
        object TmpFile = System.IO.Path.GetTempPath() + "";
        object LokasiFile = @"";

        private void TransparanK1_1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                application = new Microsoft.Office.Interop.Word.Application();
                document = application.Documents.Open(ref LokasiFile, ref objectMissing, ref objectMissing, ref objectMissing, 
                    ref objectMissing, ref objectMissing, ref objectMissing, ref objectMissing, ref objectMissing, ref objectMissing, 
                    ref objectMissing, ref objectMissing, ref objectMissing, ref objectMissing, ref objectMissing, ref objectMissing);

                // Header File
                TemuDanGanti("", "0000001");

                //Masukan file Microsoft File ke PDF
                Microsoft.Office.Interop.Word.Table table = document.Tables[1];
                int i = 2;
                for(i = 2; i < 6; i++)
                {
                    table.Rows.Add(ref objectMissing);
                    table.Cell(i, 1).Range.Text = "A00" + i;
                    table.Cell(i, 2).Range.Text = "2";
                    table.Cell(i, 3).Range.Text = "$10";
                    table.Cell(i, 4).Range.Text = "1%";
                    table.Cell(i, 4).Range.Text = "$18";
                }

                //Total
                TemuDanGanti("", "0000001");

                document.ExportAsFixedFormat(TmpFile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                PDF1.src = TmpFile.ToString();
                PDF1.Show();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //File akan kesimpan
                document.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat, false);
                application.Quit(WdSaveOptions.wdDoNotSaveChanges);
            }
        }

        private void TemuDanGanti(object TemukanTeks, object GantiTeks)
        {
            application.Selection.Find.Execute(ref TemukanTeks, true, true, false, false, false, true, false, 1, ref GantiTeks, 2, 
                false, false, false, false);
        }
    }
}
