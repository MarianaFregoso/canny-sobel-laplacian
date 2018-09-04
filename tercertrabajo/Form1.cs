﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace tercertrabajo
{
    public partial class frmbordes : Form
    {
        Image<Bgr, byte> _ImgInput;
        public frmbordes()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _ImgInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = _ImgInput;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas segup que quieres salir?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> _ImgCanny = new Image<Gray, byte>(_ImgInput.Width, _ImgInput.Height, new Gray(0));
            _ImgCanny = _ImgInput.Canny(100, 50);
            imageBox1.Image = _ImgCanny;
        }
    }
}
