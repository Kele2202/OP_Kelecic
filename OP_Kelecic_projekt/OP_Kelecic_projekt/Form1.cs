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
using System.Threading;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace OP_Kelecic_projekt
{
    public partial class Form1 : Form
    {
        Bitmap image;
        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;

        public Form1()
        {
            InitializeComponent();
            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBW_Click(object sender, EventArgs e)
        {
            using (BW toGrayscale = new BW(150, 200))
            {
                toGrayscale.DoEdit(image);
                pbEdit.Image = image;
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            using (RemoveRed toRed = new RemoveRed(150, 200))
            {
                pbEdit.Image = toRed.DoEdit(image);
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            using (RemoveGreen toGreen = new RemoveGreen(150, 200))
            {
                pbEdit.Image = toGreen.DoEdit(image);
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            using (RemoveBlue toBlue = new RemoveBlue(150, 200))
            {
                pbEdit.Image = toBlue.DoEdit(image);
            }
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdLoad = new OpenFileDialog())
            {
                ofdLoad.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofdLoad.ShowDialog() == DialogResult.OK)
                {
                    pbEdit.Image = null;
                    image = new Bitmap(Image.FromFile(ofdLoad.FileName), 150, 200);
                    pbEdit.Image = image;

                }
                pbOriginal.Image = image;
            }
        }
    }
}
