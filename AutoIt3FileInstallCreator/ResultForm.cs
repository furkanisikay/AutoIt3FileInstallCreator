using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace AutoIt3FileInstallCreator
{

    public partial class ResultForm : MaterialForm
    {
        public ResultForm(string Icerik)
        {
            InitializeComponent();
            txtÇıktı.Text = Icerik;
        }

        private void btnTabEkle_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < txtÇıktı.Lines.Length; i++)
            {
                string satir = (string)txtÇıktı.Lines[i];
                satir = satir.Insert(0, "\t");
                sb.AppendLine(satir);
            }
            string cikti = sb.ToString();
            if (cikti.EndsWith("\n"))
            {
                txtÇıktı.Text = cikti.Remove(cikti.Length - 2);
            }
        }

        private void btnTabSil_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < txtÇıktı.Lines.Length; i++)
            {
                string satir = (string)txtÇıktı.Lines[i];
                if (satir.StartsWith("\t"))
                {
                    satir = satir.Substring(1);
                }
                sb.AppendLine(satir);
            }
            string cikti = sb.ToString();
            if (cikti.EndsWith("\n"))
            {
                txtÇıktı.Text = cikti.Remove(cikti.Length - 2);
            }
        }

        private void btnBoslukSil_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string satir in txtÇıktı.Lines)
            {
                if (!string.IsNullOrEmpty(satir.Trim().Trim('\t')))
                {
                    sb.AppendLine(satir);
                }
            }
            string cikti = sb.ToString();
            if (cikti.EndsWith("\n"))
            {
                txtÇıktı.Text = cikti.Remove(cikti.Length - 2);
            }
        }

        private void btnTumunuKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtÇıktı.Text);
            MaterialMessageBox.Show("İçerik Kopyalandı!", "Bilgi", MessageBoxIcon.Information);
        }
    }
}
