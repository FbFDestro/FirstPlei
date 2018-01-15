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
    public partial class frmHard4 : Form
    {
        public frmHard4()
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
            frmHard3 tela_Hard3 = new frmHard3();
            tela_Hard3.ShowDialog();
        }
    }
}
