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
    public partial class frmHard1 : Form
    {
        public frmHard1()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblProxima_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHard2 tela_Hard2 = new frmHard2();
            tela_Hard2.ShowDialog();
        }
    }
}
