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
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();
        }

        private void tmrSplash__Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
