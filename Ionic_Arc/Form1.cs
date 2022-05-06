using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zlib;
using Ionic.Zip;

namespace Ionic_Arc
{
    public partial class main_wndv : Form
    {
        public main_wndv()
        {
            InitializeComponent();
        }
        
        FolderBrowserDialog fo = new FolderBrowserDialog();

        private void choose_btn_Click(object sender, EventArgs e)
        {
            if(fo.ShowDialog()==DialogResult.OK)
                AdresPath.Text = fo.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Zip files (*.zip)|*.zip";
            if(AdresPath.Text!=""&&sfd.ShowDialog()==DialogResult.OK)
            {
                ZipFile zf = new ZipFile(sfd.FileName);
                zf.AddDirectory(fo.SelectedPath);
                zf.Save();
                MessageBox.Show("Файл заархивирован!","Oke");
            }
        }
    }
}
