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
    public partial class frm_Velha : Form
    {
        char vez;
        int jX, jO, nE;

        public frm_Velha()
        {
            InitializeComponent();
        }




        private void txtNomeX_Enter(object sender, EventArgs e)
        {
            if (txtNomeX.Text == "Digite o nome do jogador X")
            {
                txtNomeX.Text = "";
            }
        }

        private void txtNomeX_Leave(object sender, EventArgs e)
        {
            if (txtNomeX.Text == "")
            {
                txtNomeX.Text = "Digite o nome do jogador X";
            }
        }

        private void txtNomeO_Enter(object sender, EventArgs e)
        {

            if (txtNomeO.Text == "Digite o nome do jogador O")
            {
                txtNomeO.Text = "";
            }

        }

        private void txtNomeO_Leave(object sender, EventArgs e)
        {
            if (txtNomeO.Text == "")
            {
                txtNomeO.Text = "Digite o nome do jogador O";
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            if (txtNomeX.Text == "Digite o nome do jogador X" || txtNomeX.Text == "" || txtNomeO.Text == "Digite o nome do jogador O" || txtNomeO.Text == "")
            {
                lblInfo.Text = "Por favor, digite os nomes corretamente!";
                lblInfo.BackColor = Color.FromArgb(253, 108, 108);
            }
            else
            {

                btnComecar.Enabled = false;
                btnReiniciar.Enabled = true;
                btnNovoJogo.Enabled = true;
                lblInfo.Text = "Bom jogo, " + txtNomeX.Text + " (X) começa!";
                lblInfo.BackColor = Color.WhiteSmoke;

                grpPlacar.Enabled = true;

                nE = jX = jO = 0;

                lblX.Text = "Jogador X:   " + jX;
                lblO.Text = "Jogador O:   " + jO;
                lblE.Text = "Empates:    " + nE;

                txtNomeX.Enabled = false;
                txtNomeO.Enabled = false;

                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";

                vez = 'x';

                pnlCentro.Enabled = true;

                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;

            }


        }

        private void clique(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            btn.Enabled = false;

            if (vez == 'x')
            {

                btn.Text = "X";
                vez = 'o';
                lblInfo.Text = "É a vez de " + txtNomeO.Text + " (O)";

            }
            else
            {

                btn.Text = "O";
                vez = 'x';
                lblInfo.Text = "É a vez de " + txtNomeX.Text + " (X)";

            }


            fim();

        }


        private void fim()
        {

            if ((btn1.Text + btn2.Text + btn3.Text == "XXX") || (btn4.Text + btn5.Text + btn6.Text == "XXX") || (btn7.Text + btn8.Text + btn9.Text == "XXX") || (btn1.Text + btn4.Text + btn7.Text == "XXX") || (btn2.Text + btn5.Text + btn8.Text == "XXX") || (btn3.Text + btn6.Text + btn9.Text == "XXX") || (btn3.Text + btn5.Text + btn7.Text == "XXX") || (btn1.Text + btn5.Text + btn9.Text == "XXX"))
            {

                lblInfo.Text = "Parabéns, " + txtNomeX.Text + " (X) ganhou!";
                lblInfo.BackColor = Color.FromArgb(86, 162, 235);
                pnlCentro.Enabled = false;
                vez = 'x';
                jX += 1;
                lblX.Text = "Jogador X:   " + jX;

            }
            else if ((btn1.Text + btn2.Text + btn3.Text == "OOO") || (btn4.Text + btn5.Text + btn6.Text == "OOO") || (btn7.Text + btn8.Text + btn9.Text == "OOO") || (btn1.Text + btn4.Text + btn7.Text == "OOO") || (btn2.Text + btn5.Text + btn8.Text == "OOO") || (btn3.Text + btn6.Text + btn9.Text == "OOO") || (btn3.Text + btn5.Text + btn7.Text == "OOO") || (btn1.Text + btn5.Text + btn9.Text == "OOO"))
            {

                lblInfo.Text = "Parabéns, " + txtNomeO.Text + " (O) ganhou!";
                lblInfo.BackColor = Color.FromArgb(86, 162, 235);
                pnlCentro.Enabled = false;
                vez = 'o';
                jO += 1;
                lblO.Text = "Jogador O:   " + jO;

            }
            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {

                lblInfo.Text = "DEU VELHA!";
                lblInfo.BackColor = Color.FromArgb(253, 108, 108);
                pnlCentro.Enabled = false;
                nE += 1;
                lblE.Text = "Empates:    " + nE;

            }

         
         


        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            pnlCentro.Enabled = true;

            if (vez == 'x')
            {

                lblInfo.Text = "É a vez de " + txtNomeX.Text + " (X)";
            }
            else {

                lblInfo.Text = "É a vez de " + txtNomeO.Text + " (O)";
            }
            lblInfo.BackColor = Color.WhiteSmoke;

        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {


             DialogResult dialogResult = MessageBox.Show("Ao iníciar um novo jogo o nome dos jadores e o placar serão perdidios. Tem certeza que quer iniciar um novo jogo?", "Novo jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dialogResult == DialogResult.Yes)
             {


                 txtNomeX.Enabled = true;
                 txtNomeO.Enabled = true;
                 txtNomeX.Text = "Digite o nome do jogador X";
                 txtNomeO.Text = "Digite o nome do jogador O";

                 pnlCentro.Enabled = false;

                 nE = jX = jO = 0;

                 lblX.Text = "Jogador X:   " + jX;
                 lblO.Text = "Jogador O:   " + jO;
                 lblE.Text = "Empates:    " + nE;

                 btnReiniciar.Enabled = false;
                 btnNovoJogo.Enabled = false;
                 btnComecar.Enabled = true;

             }

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer voltar para o menu? Seu jogo será perdido!", "Voltar para o menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dialogResult == DialogResult.Yes)
             {

                 frm_Menu tela_Menu = new frm_Menu();
                 tela_Menu.Show();
                 this.Hide();

             }
        }

        private void fechatudo(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }


    }
}






