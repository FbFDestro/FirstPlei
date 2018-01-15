using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstPlei
{
    public partial class frmHard2 : Form
    {
        public frmHard2()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHard1 tela_Hard1 = new frmHard1();
            tela_Hard1.ShowDialog();
        }

        private void lblProxima_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHard3 tela_Hard3 = new frmHard3();
            tela_Hard3.ShowDialog();
        }

        private void lnkVideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void frmHard2_Load(object sender, EventArgs e)
        {
            lnkVideo.Links.Add(14, 9, "https://www.youtube.com/watch?v=kZetJO93mBM");
        }
    }
}
