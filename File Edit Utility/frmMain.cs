using System;
using System.IO;
using System.Windows.Forms;

namespace FilePropertyModifier
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select file to modify";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            try
            {
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                dtpCreateTime.Value = fi.CreationTime;
                dtpModifyTime.Value = fi.LastWriteTime;
                dtpAccessTime.Value = fi.LastAccessTime;
                label1.Text = "Original file information has been loaded!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dtpCreateTime.Value > dtpModifyTime.Value)
            {
                DialogResult d = MessageBox.Show("", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {
                    return;
                }
            }
            if (dtpCreateTime.Value > dtpAccessTime.Value)
            {
                DialogResult d = MessageBox.Show("", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {
                    return;
                }
            }
            try
            {
                string path = openFileDialog1.FileName;
                if (File.Exists(path))
                {
                    FileInfo fi = new FileInfo(path);
                    if (!fi.IsReadOnly)
                    {
                        File.SetCreationTime(path, dtpCreateTime.Value);
                        File.SetLastWriteTime(path, dtpModifyTime.Value);
                        File.SetLastAccessTime(path, dtpAccessTime.Value);
                        MessageBox.Show("o(∩_∩)o", "");
                    }
                    else
                    {
                        throw new Exception("");
                    }
                }
                else
                {
                    throw new Exception("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "");
            }

        }

        private void dtpCreateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpModifyTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpAccessTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}
