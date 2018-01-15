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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }


        private void lblBtnSudoku_Click(object sender, EventArgs e)
        {
           /* frm_Jogo tela_Jogo = new frm_Jogo();
            tela_Jogo.Show();*/

            frm_Sudoku tela_Sudoku = new frm_Sudoku();
            tela_Sudoku.Show();
            this.Hide();
        }

        private void lblBtnMemo_Click(object sender, EventArgs e)
        {
         
            frmJogoMemo tela_Memo = new frmJogoMemo();
            tela_Memo.Show();
        this.Hide();
        }
        private void lblBtnVelha_Click(object sender, EventArgs e)
        {

            frm_Velha tela_Velha = new frm_Velha();
            tela_Velha.Show();
            this.Hide();

        }

        private void fechatudo(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBtnCred_Click(object sender, EventArgs e)
        {
        frmCreditos tela_Creditos = new frmCreditos();
        tela_Creditos.ShowDialog();
        }
    }
}
