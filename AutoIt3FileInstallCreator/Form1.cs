using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace AutoIt3FileInstallCreator
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.AddFormToManage(this);
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.ShowNewFolderButton = true;
                fbd.Description = "Dosyaların bulunduğu ana klasörü seçin.";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtKlasor.Text = fbd.SelectedPath;
                }
            }

        }


        private void OrnekCiktiyiOlustur()
        {
            string kaynak = Application.ExecutablePath;
            bool kokDizinDahil = chckKaynakDahil.Checked;
            bool kokDizinHedefeDahil = chckHedefAnaDizinDahil.Checked;
            txtOrnekCikti.Text = CiktiOlustur(kaynak, System.IO.Path.GetDirectoryName(kaynak), txtHedefDizinFormat.Text, kokDizinDahil, kokDizinHedefeDahil);
        }

        private string CiktiOlustur(string kaynak, string anaDizin, string format, bool kokDizinDahil, bool kokDizinHedefeDahil)
        {
            string path = kaynak;
            if (!kokDizinDahil)
            {
                DirectoryInfo info = Directory.GetParent(anaDizin);
                path = kaynak.Remove(0, info.FullName.Length + 1);
            }
            string hedef = string.Format(format, kaynak);
            if (!kokDizinHedefeDahil)
            {
                hedef = string.Format(format, kaynak.Remove(0, anaDizin.Length + 1));
            }
            return string.Format("FileInstall(\"{0}\", {1}, 1)", path, hedef);
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtKlasor.Text))
            {
                MaterialMessageBox.Show("Girilen Klasör bulunamadı!", "Hata", MessageBoxIcon.Error);
            }

            string icerik = KlasorCiktiOlustur(txtKlasor.Text);

            using (ResultForm frmResult = new ResultForm(icerik))
            {
                frmResult.ShowDialog();
            }
        }

        private string KlasorCiktiOlustur(string text)
        {
            StringBuilder sb = new StringBuilder();
            bool kokDizinDahil = chckKaynakDahil.Checked;
            bool kokDizinHedefeDahil = chckHedefAnaDizinDahil.Checked;
            string anaDizin = txtKlasor.Text;
            string format = txtHedefDizinFormat.Text;

            string folderPath = text;
            if (chckSubFolderCreate.Checked && folderPath != anaDizin )
            {
                if (!kokDizinHedefeDahil)
                {
                    folderPath = folderPath.Remove(0, anaDizin.Length + 1);
                }
                sb.AppendLine(string.Format("DirCreate({0})", string.Format(format, folderPath)));
            }

            string[] directories = Directory.GetDirectories(text);

            foreach (string folder in directories)
            {
                sb.AppendLine(KlasorCiktiOlustur(folder));
            }

            string[] files = Directory.GetFiles(text);
            foreach (string filePath in files)
            {
               
                sb.AppendLine(CiktiOlustur(filePath, anaDizin, format, kokDizinDahil, kokDizinHedefeDahil));
            }

            return sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrnekCiktiyiOlustur();
        }

        private void txtHedefDizinFormat_TextChanged(object sender, EventArgs e)
        {
            OrnekCiktiyiOlustur();
        }

        private void chckKaynakDahil_CheckedChanged(object sender, EventArgs e)
        {
            OrnekCiktiyiOlustur();
        }

        private void chckHedefAnaDizinDahil_CheckedChanged(object sender, EventArgs e)
        {
            OrnekCiktiyiOlustur();
        }
    }
}
