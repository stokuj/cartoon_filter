using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace GraphicFilter
{
    public partial class Form1 : Form
    {
        private ImageOperator imageOperator;
        private int cores = 1;
        private OpenFileDialog dialogWithImage = new OpenFileDialog();
        private string imageLink = "";

        public Form1()
        {
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                cores += int.Parse(item["NumberOfCores"].ToString());
            }
            imageOperator = new ImageOperator();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    inputPictureBox.ImageLocation = ofd.FileName;
                    imageLink = ofd.FileName;
                    this.dialogWithImage = ofd;
                }
                if (imageLink != "")
                {
                    imageOperator.image = Image.FromFile(imageLink);
                    inputPictureBox.Image = imageOperator.image;
                    imageOperator.bitmapFromImage();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputPictureBox.Image != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                if((int)numericUpDown1.Value > 0 && (int)numericUpDown1.Value <= 100)
                {
                    imageOperator.createRGB((int)numericUpDown1.Value, radioBtnASM.Checked);
                    imageOperator.ApplyEffect((int)numericUpDown1.Value, radioBtnASM.Checked, cores);
                    imageOperator.AfterImageFromRGB();
                    outputPictureBox.Image = imageOperator.afterImage;
                    if (radioBtnASM.Checked)
                        AssemblerCounterLabel.Text = Decimal.Round((Decimal)imageOperator.time, 2).ToString() + " ms";
                    else
                        CppCounterLabel.Text = Decimal.Round((Decimal)imageOperator.time, 2).ToString() + " ms";
                    imageOperator.time = 0;
                }
                else
                {
                    MessageBox.Show("Apply density", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("No photo choosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}