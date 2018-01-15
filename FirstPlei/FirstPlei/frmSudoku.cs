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
    public partial class frm_Sudoku : Form
    {
        public frm_Sudoku()
        {
            InitializeComponent();
        }

        static int[,] grid = new int[9, 9]; // Cria matriz 9 x 9 para armazendar os números do tabuleiro do Sudoku
        static int[,] jogo = new int[9, 9];
        static int[,] comoEstou = new int[9, 9];
        static int[,] acabei = new int[9, 9];
        bool anotar, vitoria;
        int errosComoEstou, vazioComoEstou,numComoEstou;
        static void Init(ref int[,] grid) // Método para preencher matriz com os números de um Sudoku báscio
        {

            /*
     * Sudoku básico:
     * 123456789
     * 456789123
     * 789123456
     * 234567891
     * 567891234
     * 891234567
     * 345678912
     * 678912345
     * 912345678
     */

            for (int i = 0; i < 9; i++) // Percorre o X da matriz
            {
                for (int j = 0; j < 9; j++) // Percorre o Y da matriz
                {
                    grid[i, j] = (i * 3 + i / 3 + j) % 9 + 1; // Conta que preenche corretamente o tabuleiro do Sudoku basico

                } // Fim FOR J

            } // Fim FOR I

        } // Fim método Init
        static void ChangeTwoCell(ref int[,] grid, int findValue1, int findValue2)
        {


            int xParm1, yParm1, xParm2, yParm2;
            xParm1 = yParm1 = xParm2 = yParm2 = 0;
            for (int i = 0; i < 9; i += 3)
            {

                for (int k = 0; k < 9; k += 3)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        for (int z = 0; z < 3; z++)
                        {

                            if (grid[i + j, k + z] == findValue1)
                            {
                                xParm1 = i + j;
                                yParm1 = k + z;

                            }

                            if (grid[i + j, k + z] == findValue2)
                            {
                                xParm2 = i + j;
                                yParm2 = k + z;

                            }

                        }

                    }

                    grid[xParm1, yParm1] = findValue2;
                    grid[xParm2, yParm2] = findValue1;

                }
            }
        }
        static void Update(ref int[,] grid, int shuffleLevel)
        {

            for (int repeat = 0; repeat < shuffleLevel; repeat++)
            {

                Random rand = new Random(Guid.NewGuid().GetHashCode());
                Random rand2 = new Random(Guid.NewGuid().GetHashCode());
                ChangeTwoCell(ref grid, rand.Next(1, 9), rand2.Next(1, 9));
            }
        }

        // FIM GERAR TABULEIRO

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                txtNome.Text = "";
            }

        }
        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }
        }
        private void rdFacil_CheckedChanged(object sender, EventArgs e)
        {

            btnComoEstou.Text = "Como estou? (5)";


        }
        private void rdMedio_CheckedChanged(object sender, EventArgs e)
        {
            btnComoEstou.Text = "Como estou? (3)";

        }
        private void rdDificil_CheckedChanged(object sender, EventArgs e)
        {
            btnComoEstou.Text = "Como estou? (1)";

        }
        private void digitar(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            { e.Handled = false; }
            else { e.Handled = true; }

            if (txt.Text != "" && anotar == false) { txt.Font = new Font(txt.Font.FontFamily, 28); }

        }
        private void btnComecar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "Digite seu nome" || txtNome.Text == "")
            {
                lblInfo.Text = "Por favor, digite o seu nome";
                lblInfo.BackColor = Color.FromArgb(253, 108, 108);
            }
            else
            {
                pnlCentro.Enabled = true;
                txtNome.Enabled = false;
                grpDificuldades.Enabled = false;
                btnComecar.Enabled = false;
                btnAcabei.Enabled = true;
                btnAnotar.Enabled = true;
                btnComoEstou.Enabled = true;
                btnLimpar.Enabled = true;
                btnNovo.Enabled = true;
                lblInfo.Text = "Bom jogo " + txtNome.Text;
                lblInfo.BackColor = Color.WhiteSmoke;

                if (rdFacil.Checked == true) {
                    numComoEstou = 5;
                }
                else if (rdMedio.Checked == true)
                {
                    numComoEstou = 3;
                }
                else {
                    numComoEstou = 1;
                }


                Init(ref grid); // Chama método que insere os números do tabuleiro básico na matriz
                Update(ref grid, 10); // Chama método que atualiza os valores dentro da matriz

                Random aleatorio = new Random();

                if (rdFacil.Checked == true)
                {
                    for (int i = 0; i < 42; i++)
                    {

                        int px, py = 0;
                        bool valido = false;

                        while (valido == false)
                        {

                            px = aleatorio.Next(0, 9);
                            py = aleatorio.Next(0, 9);


                            if (jogo[px, py] == 0)
                            {
                                valido = true;
                                jogo[px, py] = grid[px, py];

                            }

                        }

                    }
                }
                else if (rdMedio.Checked == true)
                {
                    for (int i = 0; i < 36; i++)
                    {

                        int px, py = 0;
                        bool valido = false;

                        while (valido == false)
                        {

                            px = aleatorio.Next(0, 9);
                            py = aleatorio.Next(0, 9);


                            if (jogo[px, py] == 0)
                            {
                                valido = true;
                                jogo[px, py] = grid[px, py];

                            }

                        }

                    }

                }
                else
                {

                    for (int i = 0; i < 30; i++)
                    {

                        int px, py = 0;
                        bool valido = false;

                        while (valido == false)
                        {

                            px = aleatorio.Next(0, 9);
                            py = aleatorio.Next(0, 9);


                            if (jogo[px, py] == 0)
                            {
                                valido = true;
                                jogo[px, py] = grid[px, py];

                            }

                        }

                    }

                }


                if (jogo[0, 0] != 0) { txt1Q1.Text = jogo[0, 0].ToString(); txt1Q1.Enabled = false; }
                if (jogo[1, 0] != 0) { txt2Q1.Text = jogo[1, 0].ToString(); txt2Q1.Enabled = false; }
                if (jogo[2, 0] != 0) { txt3Q1.Text = jogo[2, 0].ToString(); txt3Q1.Enabled = false; }
                if (jogo[0, 1] != 0) { txt4Q1.Text = jogo[0, 1].ToString(); txt4Q1.Enabled = false; }
                if (jogo[1, 1] != 0) { txt5Q1.Text = jogo[1, 1].ToString(); txt5Q1.Enabled = false; }
                if (jogo[2, 1] != 0) { txt6Q1.Text = jogo[2, 1].ToString(); txt6Q1.Enabled = false; }
                if (jogo[0, 2] != 0) { txt7Q1.Text = jogo[0, 2].ToString(); txt7Q1.Enabled = false; }
                if (jogo[1, 2] != 0) { txt8Q1.Text = jogo[1, 2].ToString(); txt8Q1.Enabled = false; }
                if (jogo[2, 2] != 0) { txt9Q1.Text = jogo[2, 2].ToString(); txt9Q1.Enabled = false; }

                if (jogo[3, 0] != 0) { txt1Q2.Text = jogo[3, 0].ToString(); txt1Q2.Enabled = false; }
                if (jogo[4, 0] != 0) { txt2Q2.Text = jogo[4, 0].ToString(); txt2Q2.Enabled = false; }
                if (jogo[5, 0] != 0) { txt3Q2.Text = jogo[5, 0].ToString(); txt3Q2.Enabled = false; }
                if (jogo[3, 1] != 0) { txt4Q2.Text = jogo[3, 1].ToString(); txt4Q2.Enabled = false; }
                if (jogo[4, 1] != 0) { txt5Q2.Text = jogo[4, 1].ToString(); txt5Q2.Enabled = false; }
                if (jogo[5, 1] != 0) { txt6Q2.Text = jogo[5, 1].ToString(); txt6Q2.Enabled = false; }
                if (jogo[3, 2] != 0) { txt7Q2.Text = jogo[3, 2].ToString(); txt7Q2.Enabled = false; }
                if (jogo[4, 2] != 0) { txt8Q2.Text = jogo[4, 2].ToString(); txt8Q2.Enabled = false; }
                if (jogo[5, 2] != 0) { txt9Q2.Text = jogo[5, 2].ToString(); txt9Q2.Enabled = false; }

                if (jogo[6, 0] != 0) { txt1Q3.Text = jogo[6, 0].ToString(); txt1Q3.Enabled = false; }
                if (jogo[7, 0] != 0) { txt2Q3.Text = jogo[7, 0].ToString(); txt2Q3.Enabled = false; }
                if (jogo[8, 0] != 0) { txt3Q3.Text = jogo[8, 0].ToString(); txt3Q3.Enabled = false; }
                if (jogo[6, 1] != 0) { txt4Q3.Text = jogo[6, 1].ToString(); txt4Q3.Enabled = false; }
                if (jogo[7, 1] != 0) { txt5Q3.Text = jogo[7, 1].ToString(); txt5Q3.Enabled = false; }
                if (jogo[8, 1] != 0) { txt6Q3.Text = jogo[8, 1].ToString(); txt6Q3.Enabled = false; }
                if (jogo[6, 2] != 0) { txt7Q3.Text = jogo[6, 2].ToString(); txt7Q3.Enabled = false; }
                if (jogo[7, 2] != 0) { txt8Q3.Text = jogo[7, 2].ToString(); txt8Q3.Enabled = false; }
                if (jogo[8, 2] != 0) { txt9Q3.Text = jogo[8, 2].ToString(); txt9Q3.Enabled = false; }

                if (jogo[0, 3] != 0) { txt1Q4.Text = jogo[0, 3].ToString(); txt1Q4.Enabled = false; }
                if (jogo[1, 3] != 0) { txt2Q4.Text = jogo[1, 3].ToString(); txt2Q4.Enabled = false; }
                if (jogo[2, 3] != 0) { txt3Q4.Text = jogo[2, 3].ToString(); txt3Q4.Enabled = false; }
                if (jogo[0, 4] != 0) { txt4Q4.Text = jogo[0, 4].ToString(); txt4Q4.Enabled = false; }
                if (jogo[1, 4] != 0) { txt5Q4.Text = jogo[1, 4].ToString(); txt5Q4.Enabled = false; }
                if (jogo[2, 4] != 0) { txt6Q4.Text = jogo[2, 4].ToString(); txt6Q4.Enabled = false; }
                if (jogo[0, 5] != 0) { txt7Q4.Text = jogo[0, 5].ToString(); txt7Q4.Enabled = false; }
                if (jogo[1, 5] != 0) { txt8Q4.Text = jogo[1, 5].ToString(); txt8Q4.Enabled = false; }
                if (jogo[2, 5] != 0) { txt9Q4.Text = jogo[2, 5].ToString(); txt9Q4.Enabled = false; }

                if (jogo[3, 3] != 0) { txt1Q5.Text = jogo[3, 3].ToString(); txt1Q5.Enabled = false; }
                if (jogo[4, 3] != 0) { txt2Q5.Text = jogo[4, 3].ToString(); txt2Q5.Enabled = false; }
                if (jogo[5, 3] != 0) { txt3Q5.Text = jogo[5, 3].ToString(); txt3Q5.Enabled = false; }
                if (jogo[3, 4] != 0) { txt4Q5.Text = jogo[3, 4].ToString(); txt4Q5.Enabled = false; }
                if (jogo[4, 4] != 0) { txt5Q5.Text = jogo[4, 4].ToString(); txt5Q5.Enabled = false; }
                if (jogo[5, 4] != 0) { txt6Q5.Text = jogo[5, 4].ToString(); txt6Q5.Enabled = false; }
                if (jogo[3, 5] != 0) { txt7Q5.Text = jogo[3, 5].ToString(); txt7Q5.Enabled = false; }
                if (jogo[4, 5] != 0) { txt8Q5.Text = jogo[4, 5].ToString(); txt8Q5.Enabled = false; }
                if (jogo[5, 5] != 0) { txt9Q5.Text = jogo[5, 5].ToString(); txt9Q5.Enabled = false; }

                if (jogo[6, 3] != 0) { txt1Q6.Text = jogo[6, 3].ToString(); txt1Q6.Enabled = false; }
                if (jogo[7, 3] != 0) { txt2Q6.Text = jogo[7, 3].ToString(); txt2Q6.Enabled = false; }
                if (jogo[8, 3] != 0) { txt3Q6.Text = jogo[8, 3].ToString(); txt3Q6.Enabled = false; }
                if (jogo[6, 4] != 0) { txt4Q6.Text = jogo[6, 4].ToString(); txt4Q6.Enabled = false; }
                if (jogo[7, 4] != 0) { txt5Q6.Text = jogo[7, 4].ToString(); txt5Q6.Enabled = false; }
                if (jogo[8, 4] != 0) { txt6Q6.Text = jogo[8, 4].ToString(); txt6Q6.Enabled = false; }
                if (jogo[6, 5] != 0) { txt7Q6.Text = jogo[6, 5].ToString(); txt7Q6.Enabled = false; }
                if (jogo[7, 5] != 0) { txt8Q6.Text = jogo[7, 5].ToString(); txt8Q6.Enabled = false; }
                if (jogo[8, 5] != 0) { txt9Q6.Text = jogo[8, 5].ToString(); txt9Q6.Enabled = false; }

                if (jogo[0, 6] != 0) { txt1Q7.Text = jogo[0, 6].ToString(); txt1Q7.Enabled = false; }
                if (jogo[1, 6] != 0) { txt2Q7.Text = jogo[1, 6].ToString(); txt2Q7.Enabled = false; }
                if (jogo[2, 6] != 0) { txt3Q7.Text = jogo[2, 6].ToString(); txt3Q7.Enabled = false; }
                if (jogo[0, 7] != 0) { txt4Q7.Text = jogo[0, 7].ToString(); txt4Q7.Enabled = false; }
                if (jogo[1, 7] != 0) { txt5Q7.Text = jogo[1, 7].ToString(); txt5Q7.Enabled = false; }
                if (jogo[2, 7] != 0) { txt6Q7.Text = jogo[2, 7].ToString(); txt6Q7.Enabled = false; }
                if (jogo[0, 8] != 0) { txt7Q7.Text = jogo[0, 8].ToString(); txt7Q7.Enabled = false; }
                if (jogo[1, 8] != 0) { txt8Q7.Text = jogo[1, 8].ToString(); txt8Q7.Enabled = false; }
                if (jogo[2, 8] != 0) { txt9Q7.Text = jogo[2, 8].ToString(); txt9Q7.Enabled = false; }

                if (jogo[3, 6] != 0) { txt1Q8.Text = jogo[3, 6].ToString(); txt1Q8.Enabled = false; }
                if (jogo[4, 6] != 0) { txt2Q8.Text = jogo[4, 6].ToString(); txt2Q8.Enabled = false; }
                if (jogo[5, 6] != 0) { txt3Q8.Text = jogo[5, 6].ToString(); txt3Q8.Enabled = false; }
                if (jogo[3, 7] != 0) { txt4Q8.Text = jogo[3, 7].ToString(); txt4Q8.Enabled = false; }
                if (jogo[4, 7] != 0) { txt5Q8.Text = jogo[4, 7].ToString(); txt5Q8.Enabled = false; }
                if (jogo[5, 7] != 0) { txt6Q8.Text = jogo[5, 7].ToString(); txt6Q8.Enabled = false; }
                if (jogo[3, 8] != 0) { txt7Q8.Text = jogo[3, 8].ToString(); txt7Q8.Enabled = false; }
                if (jogo[4, 8] != 0) { txt8Q8.Text = jogo[4, 8].ToString(); txt8Q8.Enabled = false; }
                if (jogo[5, 8] != 0) { txt9Q8.Text = jogo[5, 8].ToString(); txt9Q8.Enabled = false; }

                if (jogo[6, 6] != 0) { txt1Q9.Text = jogo[6, 6].ToString(); txt1Q9.Enabled = false; }
                if (jogo[7, 6] != 0) { txt2Q9.Text = jogo[7, 6].ToString(); txt2Q9.Enabled = false; }
                if (jogo[8, 6] != 0) { txt3Q9.Text = jogo[8, 6].ToString(); txt3Q9.Enabled = false; }
                if (jogo[6, 7] != 0) { txt4Q9.Text = jogo[6, 7].ToString(); txt4Q9.Enabled = false; }
                if (jogo[7, 7] != 0) { txt5Q9.Text = jogo[7, 7].ToString(); txt5Q9.Enabled = false; }
                if (jogo[8, 7] != 0) { txt6Q9.Text = jogo[8, 7].ToString(); txt6Q9.Enabled = false; }
                if (jogo[6, 8] != 0) { txt7Q9.Text = jogo[6, 8].ToString(); txt7Q9.Enabled = false; }
                if (jogo[7, 8] != 0) { txt8Q9.Text = jogo[7, 8].ToString(); txt8Q9.Enabled = false; }
                if (jogo[8, 8] != 0) { txt9Q9.Text = jogo[8, 8].ToString(); txt9Q9.Enabled = false; }


            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Você deseja limpar o tabuleiro?", "Limpar o tabuleiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                lblInfo.Text = "Tabuleiro limpo. Boa sorte!";
                lblInfo.BackColor = Color.WhiteSmoke;

                if (txt1Q1.Enabled == true) { txt1Q1.Text = ""; }
                if (txt2Q1.Enabled == true) { txt2Q1.Text = ""; }
                if (txt3Q1.Enabled == true) { txt3Q1.Text = ""; }
                if (txt4Q1.Enabled == true) { txt4Q1.Text = ""; }
                if (txt5Q1.Enabled == true) { txt5Q1.Text = ""; }
                if (txt6Q1.Enabled == true) { txt6Q1.Text = ""; }
                if (txt7Q1.Enabled == true) { txt7Q1.Text = ""; }
                if (txt8Q1.Enabled == true) { txt8Q1.Text = ""; }
                if (txt9Q1.Enabled == true) { txt9Q1.Text = ""; }

                if (txt1Q2.Enabled == true) { txt1Q2.Text = ""; }
                if (txt2Q2.Enabled == true) { txt2Q2.Text = ""; }
                if (txt3Q2.Enabled == true) { txt3Q2.Text = ""; }
                if (txt4Q2.Enabled == true) { txt4Q2.Text = ""; }
                if (txt5Q2.Enabled == true) { txt5Q2.Text = ""; }
                if (txt6Q2.Enabled == true) { txt6Q2.Text = ""; }
                if (txt7Q2.Enabled == true) { txt7Q2.Text = ""; }
                if (txt8Q2.Enabled == true) { txt8Q2.Text = ""; }
                if (txt9Q2.Enabled == true) { txt9Q2.Text = ""; }

                if (txt1Q3.Enabled == true) { txt1Q3.Text = ""; }
                if (txt2Q3.Enabled == true) { txt2Q3.Text = ""; }
                if (txt3Q3.Enabled == true) { txt3Q3.Text = ""; }
                if (txt4Q3.Enabled == true) { txt4Q3.Text = ""; }
                if (txt5Q3.Enabled == true) { txt5Q3.Text = ""; }
                if (txt6Q3.Enabled == true) { txt6Q3.Text = ""; }
                if (txt7Q3.Enabled == true) { txt7Q3.Text = ""; }
                if (txt8Q3.Enabled == true) { txt8Q3.Text = ""; }
                if (txt9Q3.Enabled == true) { txt9Q3.Text = ""; }

                if (txt1Q4.Enabled == true) { txt1Q4.Text = ""; }
                if (txt2Q4.Enabled == true) { txt2Q4.Text = ""; }
                if (txt3Q4.Enabled == true) { txt3Q4.Text = ""; }
                if (txt4Q4.Enabled == true) { txt4Q4.Text = ""; }
                if (txt5Q4.Enabled == true) { txt5Q4.Text = ""; }
                if (txt6Q4.Enabled == true) { txt6Q4.Text = ""; }
                if (txt7Q4.Enabled == true) { txt7Q4.Text = ""; }
                if (txt8Q4.Enabled == true) { txt8Q4.Text = ""; }
                if (txt9Q4.Enabled == true) { txt9Q4.Text = ""; }

                if (txt1Q5.Enabled == true) { txt1Q5.Text = ""; }
                if (txt2Q5.Enabled == true) { txt2Q5.Text = ""; }
                if (txt3Q5.Enabled == true) { txt3Q5.Text = ""; }
                if (txt4Q5.Enabled == true) { txt4Q5.Text = ""; }
                if (txt5Q5.Enabled == true) { txt5Q5.Text = ""; }
                if (txt6Q5.Enabled == true) { txt6Q5.Text = ""; }
                if (txt7Q5.Enabled == true) { txt7Q5.Text = ""; }
                if (txt8Q5.Enabled == true) { txt8Q5.Text = ""; }
                if (txt9Q5.Enabled == true) { txt9Q5.Text = ""; }

                if (txt1Q6.Enabled == true) { txt1Q6.Text = ""; }
                if (txt2Q6.Enabled == true) { txt2Q6.Text = ""; }
                if (txt3Q6.Enabled == true) { txt3Q6.Text = ""; }
                if (txt4Q6.Enabled == true) { txt4Q6.Text = ""; }
                if (txt5Q6.Enabled == true) { txt5Q6.Text = ""; }
                if (txt6Q6.Enabled == true) { txt6Q6.Text = ""; }
                if (txt7Q6.Enabled == true) { txt7Q6.Text = ""; }
                if (txt8Q6.Enabled == true) { txt8Q6.Text = ""; }
                if (txt9Q6.Enabled == true) { txt9Q6.Text = ""; }

                if (txt1Q7.Enabled == true) { txt1Q7.Text = ""; }
                if (txt2Q7.Enabled == true) { txt2Q7.Text = ""; }
                if (txt3Q7.Enabled == true) { txt3Q7.Text = ""; }
                if (txt4Q7.Enabled == true) { txt4Q7.Text = ""; }
                if (txt5Q7.Enabled == true) { txt5Q7.Text = ""; }
                if (txt6Q7.Enabled == true) { txt6Q7.Text = ""; }
                if (txt7Q7.Enabled == true) { txt7Q7.Text = ""; }
                if (txt8Q7.Enabled == true) { txt8Q7.Text = ""; }
                if (txt9Q7.Enabled == true) { txt9Q7.Text = ""; }

                if (txt1Q8.Enabled == true) { txt1Q8.Text = ""; }
                if (txt2Q8.Enabled == true) { txt2Q8.Text = ""; }
                if (txt3Q8.Enabled == true) { txt3Q8.Text = ""; }
                if (txt4Q8.Enabled == true) { txt4Q8.Text = ""; }
                if (txt5Q8.Enabled == true) { txt5Q8.Text = ""; }
                if (txt6Q8.Enabled == true) { txt6Q8.Text = ""; }
                if (txt7Q8.Enabled == true) { txt7Q8.Text = ""; }
                if (txt8Q8.Enabled == true) { txt8Q8.Text = ""; }
                if (txt9Q8.Enabled == true) { txt9Q8.Text = ""; }

                if (txt1Q9.Enabled == true) { txt1Q9.Text = ""; }
                if (txt2Q9.Enabled == true) { txt2Q9.Text = ""; }
                if (txt3Q9.Enabled == true) { txt3Q9.Text = ""; }
                if (txt4Q9.Enabled == true) { txt4Q9.Text = ""; }
                if (txt5Q9.Enabled == true) { txt5Q9.Text = ""; }
                if (txt6Q9.Enabled == true) { txt6Q9.Text = ""; }
                if (txt7Q9.Enabled == true) { txt7Q9.Text = ""; }
                if (txt8Q9.Enabled == true) { txt8Q9.Text = ""; }
                if (txt9Q9.Enabled == true) { txt9Q9.Text = ""; }

            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Você deseja iniciar um novo jogo (o atual será perdido)?", "Novo jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                lblInfo.Text = "Configure seu novo jogo e começe a jogar!";
                lblInfo.BackColor = Color.WhiteSmoke;
                pnlCentro.Enabled = false;
                txtNome.Enabled = true;
                grpDificuldades.Enabled = true;
                btnComecar.Enabled = true;
                btnAcabei.Enabled = false;
                btnAnotar.Enabled = false;
                btnComoEstou.Enabled = false;
                btnLimpar.Enabled = false;
                btnNovo.Enabled = false;


                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        jogo[i, j] = 0;

                    }

                }

                txt1Q1.Text = "";
                txt2Q1.Text = "";
                txt3Q1.Text = "";
                txt4Q1.Text = "";
                txt5Q1.Text = "";
                txt6Q1.Text = "";
                txt7Q1.Text = "";
                txt8Q1.Text = "";
                txt9Q1.Text = "";

                txt1Q2.Text = "";
                txt2Q2.Text = "";
                txt3Q2.Text = "";
                txt4Q2.Text = "";
                txt5Q2.Text = "";
                txt6Q2.Text = "";
                txt7Q2.Text = "";
                txt8Q2.Text = "";
                txt9Q2.Text = "";

                txt1Q3.Text = "";
                txt2Q3.Text = "";
                txt3Q3.Text = "";
                txt4Q3.Text = "";
                txt5Q3.Text = "";
                txt6Q3.Text = "";
                txt7Q3.Text = "";
                txt8Q3.Text = "";
                txt9Q3.Text = "";

                txt1Q4.Text = "";
                txt2Q4.Text = "";
                txt3Q4.Text = "";
                txt4Q4.Text = "";
                txt5Q4.Text = "";
                txt6Q4.Text = "";
                txt7Q4.Text = "";
                txt8Q4.Text = "";
                txt9Q4.Text = "";

                txt1Q5.Text = "";
                txt2Q5.Text = "";
                txt3Q5.Text = "";
                txt4Q5.Text = "";
                txt5Q5.Text = "";
                txt6Q5.Text = "";
                txt7Q5.Text = "";
                txt8Q5.Text = "";
                txt9Q5.Text = "";

                txt1Q6.Text = "";
                txt2Q6.Text = "";
                txt3Q6.Text = "";
                txt4Q6.Text = "";
                txt5Q6.Text = "";
                txt6Q6.Text = "";
                txt7Q6.Text = "";
                txt8Q6.Text = "";
                txt9Q6.Text = "";

                txt1Q7.Text = "";
                txt2Q7.Text = "";
                txt3Q7.Text = "";
                txt4Q7.Text = "";
                txt5Q7.Text = "";
                txt6Q7.Text = "";
                txt7Q7.Text = "";
                txt8Q7.Text = "";
                txt9Q7.Text = "";

                txt1Q8.Text = "";
                txt2Q8.Text = "";
                txt3Q8.Text = "";
                txt4Q8.Text = "";
                txt5Q8.Text = "";
                txt6Q8.Text = "";
                txt7Q8.Text = "";
                txt8Q8.Text = "";
                txt9Q8.Text = "";

                txt1Q9.Text = "";
                txt2Q9.Text = "";
                txt3Q9.Text = "";
                txt4Q9.Text = "";
                txt5Q9.Text = "";
                txt6Q9.Text = "";
                txt7Q9.Text = "";
                txt8Q9.Text = "";
                txt9Q9.Text = "";

                // 

                txt1Q1.Enabled = true;
                txt2Q1.Enabled = true;
                txt3Q1.Enabled = true;
                txt4Q1.Enabled = true;
                txt5Q1.Enabled = true;
                txt6Q1.Enabled = true;
                txt7Q1.Enabled = true;
                txt8Q1.Enabled = true;
                txt9Q1.Enabled = true;

                txt1Q2.Enabled = true;
                txt2Q2.Enabled = true;
                txt3Q2.Enabled = true;
                txt4Q2.Enabled = true;
                txt5Q2.Enabled = true;
                txt6Q2.Enabled = true;
                txt7Q2.Enabled = true;
                txt8Q2.Enabled = true;
                txt9Q2.Enabled = true;

                txt1Q3.Enabled = true;
                txt2Q3.Enabled = true;
                txt3Q3.Enabled = true;
                txt4Q3.Enabled = true;
                txt5Q3.Enabled = true;
                txt6Q3.Enabled = true;
                txt7Q3.Enabled = true;
                txt8Q3.Enabled = true;
                txt9Q3.Enabled = true;

                txt1Q4.Enabled = true;
                txt2Q4.Enabled = true;
                txt3Q4.Enabled = true;
                txt4Q4.Enabled = true;
                txt5Q4.Enabled = true;
                txt6Q4.Enabled = true;
                txt7Q4.Enabled = true;
                txt8Q4.Enabled = true;
                txt9Q4.Enabled = true;

                txt1Q5.Enabled = true;
                txt2Q5.Enabled = true;
                txt3Q5.Enabled = true;
                txt4Q5.Enabled = true;
                txt5Q5.Enabled = true;
                txt6Q5.Enabled = true;
                txt7Q5.Enabled = true;
                txt8Q5.Enabled = true;
                txt9Q5.Enabled = true;

                txt1Q6.Enabled = true;
                txt2Q6.Enabled = true;
                txt3Q6.Enabled = true;
                txt4Q6.Enabled = true;
                txt5Q6.Enabled = true;
                txt6Q6.Enabled = true;
                txt7Q6.Enabled = true;
                txt8Q6.Enabled = true;
                txt9Q6.Enabled = true;

                txt1Q7.Enabled = true;
                txt2Q7.Enabled = true;
                txt3Q7.Enabled = true;
                txt4Q7.Enabled = true;
                txt5Q7.Enabled = true;
                txt6Q7.Enabled = true;
                txt7Q7.Enabled = true;
                txt8Q7.Enabled = true;
                txt9Q7.Enabled = true;

                txt1Q8.Enabled = true;
                txt2Q8.Enabled = true;
                txt3Q8.Enabled = true;
                txt4Q8.Enabled = true;
                txt5Q8.Enabled = true;
                txt6Q8.Enabled = true;
                txt7Q8.Enabled = true;
                txt8Q8.Enabled = true;
                txt9Q8.Enabled = true;

                txt1Q9.Enabled = true;
                txt2Q9.Enabled = true;
                txt3Q9.Enabled = true;
                txt4Q9.Enabled = true;
                txt5Q9.Enabled = true;
                txt6Q9.Enabled = true;
                txt7Q9.Enabled = true;
                txt8Q9.Enabled = true;
                txt9Q9.Enabled = true;
            }

        }
        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (btnAnotar.Text == "Anotar possibilidades")
            {

                lblInfo.Text = "Anote os possivies números";
                lblInfo.BackColor = Color.WhiteSmoke;
                btnAnotar.Text = "Parar de anotar";
                btnAcabei.Enabled = false;
                btnComoEstou.Enabled = false;
                btnLimpar.Enabled = false;
                btnNovo.Enabled = false;
                anotar = true;

                if (txt1Q1.Text == "") { txt1Q1.Font = new Font(txt1Q1.Font.FontFamily, 12); }
                if (txt2Q1.Text == "") { txt2Q1.Font = new Font(txt2Q1.Font.FontFamily, 12); }
                if (txt3Q1.Text == "") { txt3Q1.Font = new Font(txt3Q1.Font.FontFamily, 12); }
                if (txt4Q1.Text == "") { txt4Q1.Font = new Font(txt4Q1.Font.FontFamily, 12); }
                if (txt5Q1.Text == "") { txt5Q1.Font = new Font(txt5Q1.Font.FontFamily, 12); }
                if (txt6Q1.Text == "") { txt6Q1.Font = new Font(txt6Q1.Font.FontFamily, 12); }
                if (txt7Q1.Text == "") { txt7Q1.Font = new Font(txt7Q1.Font.FontFamily, 12); }
                if (txt8Q1.Text == "") { txt8Q1.Font = new Font(txt8Q1.Font.FontFamily, 12); }
                if (txt9Q1.Text == "") { txt9Q1.Font = new Font(txt9Q1.Font.FontFamily, 12); }

                if (txt1Q2.Text == "") { txt1Q2.Font = new Font(txt1Q2.Font.FontFamily, 12); }
                if (txt2Q2.Text == "") { txt2Q2.Font = new Font(txt2Q2.Font.FontFamily, 12); }
                if (txt3Q2.Text == "") { txt3Q2.Font = new Font(txt3Q2.Font.FontFamily, 12); }
                if (txt4Q2.Text == "") { txt4Q2.Font = new Font(txt4Q2.Font.FontFamily, 12); }
                if (txt5Q2.Text == "") { txt5Q2.Font = new Font(txt5Q2.Font.FontFamily, 12); }
                if (txt6Q2.Text == "") { txt6Q2.Font = new Font(txt6Q2.Font.FontFamily, 12); }
                if (txt7Q2.Text == "") { txt7Q2.Font = new Font(txt7Q2.Font.FontFamily, 12); }
                if (txt8Q2.Text == "") { txt8Q2.Font = new Font(txt8Q2.Font.FontFamily, 12); }
                if (txt9Q2.Text == "") { txt9Q2.Font = new Font(txt9Q2.Font.FontFamily, 12); }

                if (txt1Q3.Text == "") { txt1Q3.Font = new Font(txt1Q3.Font.FontFamily, 12); }
                if (txt2Q3.Text == "") { txt2Q3.Font = new Font(txt2Q3.Font.FontFamily, 12); }
                if (txt3Q3.Text == "") { txt3Q3.Font = new Font(txt3Q3.Font.FontFamily, 12); }
                if (txt4Q3.Text == "") { txt4Q3.Font = new Font(txt4Q3.Font.FontFamily, 12); }
                if (txt5Q3.Text == "") { txt5Q3.Font = new Font(txt5Q3.Font.FontFamily, 12); }
                if (txt6Q3.Text == "") { txt6Q3.Font = new Font(txt6Q3.Font.FontFamily, 12); }
                if (txt7Q3.Text == "") { txt7Q3.Font = new Font(txt7Q3.Font.FontFamily, 12); }
                if (txt8Q3.Text == "") { txt8Q3.Font = new Font(txt8Q3.Font.FontFamily, 12); }
                if (txt9Q3.Text == "") { txt9Q3.Font = new Font(txt9Q3.Font.FontFamily, 12); }

                if (txt1Q4.Text == "") { txt1Q4.Font = new Font(txt1Q4.Font.FontFamily, 12); }
                if (txt2Q4.Text == "") { txt2Q4.Font = new Font(txt2Q4.Font.FontFamily, 12); }
                if (txt3Q4.Text == "") { txt3Q4.Font = new Font(txt3Q4.Font.FontFamily, 12); }
                if (txt4Q4.Text == "") { txt4Q4.Font = new Font(txt4Q4.Font.FontFamily, 12); }
                if (txt5Q4.Text == "") { txt5Q4.Font = new Font(txt5Q4.Font.FontFamily, 12); }
                if (txt6Q4.Text == "") { txt6Q4.Font = new Font(txt6Q4.Font.FontFamily, 12); }
                if (txt7Q4.Text == "") { txt7Q4.Font = new Font(txt7Q4.Font.FontFamily, 12); }
                if (txt8Q4.Text == "") { txt8Q4.Font = new Font(txt8Q4.Font.FontFamily, 12); }
                if (txt9Q4.Text == "") { txt9Q4.Font = new Font(txt9Q4.Font.FontFamily, 12); }

                if (txt1Q5.Text == "") { txt1Q5.Font = new Font(txt1Q5.Font.FontFamily, 12); }
                if (txt2Q5.Text == "") { txt2Q5.Font = new Font(txt2Q5.Font.FontFamily, 12); }
                if (txt3Q5.Text == "") { txt3Q5.Font = new Font(txt3Q5.Font.FontFamily, 12); }
                if (txt4Q5.Text == "") { txt4Q5.Font = new Font(txt4Q5.Font.FontFamily, 12); }
                if (txt5Q5.Text == "") { txt5Q5.Font = new Font(txt5Q5.Font.FontFamily, 12); }
                if (txt6Q5.Text == "") { txt6Q5.Font = new Font(txt6Q5.Font.FontFamily, 12); }
                if (txt7Q5.Text == "") { txt7Q5.Font = new Font(txt7Q5.Font.FontFamily, 12); }
                if (txt8Q5.Text == "") { txt8Q5.Font = new Font(txt8Q5.Font.FontFamily, 12); }
                if (txt9Q5.Text == "") { txt9Q5.Font = new Font(txt9Q5.Font.FontFamily, 12); }

                if (txt1Q6.Text == "") { txt1Q6.Font = new Font(txt1Q6.Font.FontFamily, 12); }
                if (txt2Q6.Text == "") { txt2Q6.Font = new Font(txt2Q6.Font.FontFamily, 12); }
                if (txt3Q6.Text == "") { txt3Q6.Font = new Font(txt3Q6.Font.FontFamily, 12); }
                if (txt4Q6.Text == "") { txt4Q6.Font = new Font(txt4Q6.Font.FontFamily, 12); }
                if (txt5Q6.Text == "") { txt5Q6.Font = new Font(txt5Q6.Font.FontFamily, 12); }
                if (txt6Q6.Text == "") { txt6Q6.Font = new Font(txt6Q6.Font.FontFamily, 12); }
                if (txt7Q6.Text == "") { txt7Q6.Font = new Font(txt7Q6.Font.FontFamily, 12); }
                if (txt8Q6.Text == "") { txt8Q6.Font = new Font(txt8Q6.Font.FontFamily, 12); }
                if (txt9Q6.Text == "") { txt9Q6.Font = new Font(txt9Q6.Font.FontFamily, 12); }

                if (txt1Q7.Text == "") { txt1Q7.Font = new Font(txt1Q7.Font.FontFamily, 12); }
                if (txt2Q7.Text == "") { txt2Q7.Font = new Font(txt2Q7.Font.FontFamily, 12); }
                if (txt3Q7.Text == "") { txt3Q7.Font = new Font(txt3Q7.Font.FontFamily, 12); }
                if (txt4Q7.Text == "") { txt4Q7.Font = new Font(txt4Q7.Font.FontFamily, 12); }
                if (txt5Q7.Text == "") { txt5Q7.Font = new Font(txt5Q7.Font.FontFamily, 12); }
                if (txt6Q7.Text == "") { txt6Q7.Font = new Font(txt6Q7.Font.FontFamily, 12); }
                if (txt7Q7.Text == "") { txt7Q7.Font = new Font(txt7Q7.Font.FontFamily, 12); }
                if (txt8Q7.Text == "") { txt8Q7.Font = new Font(txt8Q7.Font.FontFamily, 12); }
                if (txt9Q7.Text == "") { txt9Q7.Font = new Font(txt9Q7.Font.FontFamily, 12); }

                if (txt1Q8.Text == "") { txt1Q8.Font = new Font(txt1Q8.Font.FontFamily, 12); }
                if (txt2Q8.Text == "") { txt2Q8.Font = new Font(txt2Q8.Font.FontFamily, 12); }
                if (txt3Q8.Text == "") { txt3Q8.Font = new Font(txt3Q8.Font.FontFamily, 12); }
                if (txt4Q8.Text == "") { txt4Q8.Font = new Font(txt4Q8.Font.FontFamily, 12); }
                if (txt5Q8.Text == "") { txt5Q8.Font = new Font(txt5Q8.Font.FontFamily, 12); }
                if (txt6Q8.Text == "") { txt6Q8.Font = new Font(txt6Q8.Font.FontFamily, 12); }
                if (txt7Q8.Text == "") { txt7Q8.Font = new Font(txt7Q8.Font.FontFamily, 12); }
                if (txt8Q8.Text == "") { txt8Q8.Font = new Font(txt8Q8.Font.FontFamily, 12); }
                if (txt9Q8.Text == "") { txt9Q8.Font = new Font(txt9Q8.Font.FontFamily, 12); }

                if (txt1Q9.Text == "") { txt1Q9.Font = new Font(txt1Q9.Font.FontFamily, 12); }
                if (txt2Q9.Text == "") { txt2Q9.Font = new Font(txt2Q9.Font.FontFamily, 12); }
                if (txt3Q9.Text == "") { txt3Q9.Font = new Font(txt3Q9.Font.FontFamily, 12); }
                if (txt4Q9.Text == "") { txt4Q9.Font = new Font(txt4Q9.Font.FontFamily, 12); }
                if (txt5Q9.Text == "") { txt5Q9.Font = new Font(txt5Q9.Font.FontFamily, 12); }
                if (txt6Q9.Text == "") { txt6Q9.Font = new Font(txt6Q9.Font.FontFamily, 12); }
                if (txt7Q9.Text == "") { txt7Q9.Font = new Font(txt7Q9.Font.FontFamily, 12); }
                if (txt8Q9.Text == "") { txt8Q9.Font = new Font(txt8Q9.Font.FontFamily, 12); }
                if (txt9Q9.Text == "") { txt9Q9.Font = new Font(txt9Q9.Font.FontFamily, 12); }

            }
            else
            {

                lblInfo.Text = "Bom jogo " + txtNome.Text;
                btnAnotar.Text = "Anotar possibilidades";
                lblInfo.BackColor = Color.WhiteSmoke;
                btnAcabei.Enabled = true;
                btnComoEstou.Enabled = true;
                btnLimpar.Enabled = true;
                btnNovo.Enabled = true;
                anotar = false;

                if (txt1Q1.Text == "") { txt1Q1.Font = new Font(txt1Q1.Font.FontFamily, 28); }
                if (txt2Q1.Text == "") { txt2Q1.Font = new Font(txt2Q1.Font.FontFamily, 28); }
                if (txt3Q1.Text == "") { txt3Q1.Font = new Font(txt3Q1.Font.FontFamily, 28); }
                if (txt4Q1.Text == "") { txt4Q1.Font = new Font(txt4Q1.Font.FontFamily, 28); }
                if (txt5Q1.Text == "") { txt5Q1.Font = new Font(txt5Q1.Font.FontFamily, 28); }
                if (txt6Q1.Text == "") { txt6Q1.Font = new Font(txt6Q1.Font.FontFamily, 28); }
                if (txt7Q1.Text == "") { txt7Q1.Font = new Font(txt7Q1.Font.FontFamily, 28); }
                if (txt8Q1.Text == "") { txt8Q1.Font = new Font(txt8Q1.Font.FontFamily, 28); }
                if (txt9Q1.Text == "") { txt9Q1.Font = new Font(txt9Q1.Font.FontFamily, 28); }

                if (txt1Q2.Text == "") { txt1Q2.Font = new Font(txt1Q2.Font.FontFamily, 28); }
                if (txt2Q2.Text == "") { txt2Q2.Font = new Font(txt2Q2.Font.FontFamily, 28); }
                if (txt3Q2.Text == "") { txt3Q2.Font = new Font(txt3Q2.Font.FontFamily, 28); }
                if (txt4Q2.Text == "") { txt4Q2.Font = new Font(txt4Q2.Font.FontFamily, 28); }
                if (txt5Q2.Text == "") { txt5Q2.Font = new Font(txt5Q2.Font.FontFamily, 28); }
                if (txt6Q2.Text == "") { txt6Q2.Font = new Font(txt6Q2.Font.FontFamily, 28); }
                if (txt7Q2.Text == "") { txt7Q2.Font = new Font(txt7Q2.Font.FontFamily, 28); }
                if (txt8Q2.Text == "") { txt8Q2.Font = new Font(txt8Q2.Font.FontFamily, 28); }
                if (txt9Q2.Text == "") { txt9Q2.Font = new Font(txt9Q2.Font.FontFamily, 28); }

                if (txt1Q3.Text == "") { txt1Q3.Font = new Font(txt1Q3.Font.FontFamily, 28); }
                if (txt2Q3.Text == "") { txt2Q3.Font = new Font(txt2Q3.Font.FontFamily, 28); }
                if (txt3Q3.Text == "") { txt3Q3.Font = new Font(txt3Q3.Font.FontFamily, 28); }
                if (txt4Q3.Text == "") { txt4Q3.Font = new Font(txt4Q3.Font.FontFamily, 28); }
                if (txt5Q3.Text == "") { txt5Q3.Font = new Font(txt5Q3.Font.FontFamily, 28); }
                if (txt6Q3.Text == "") { txt6Q3.Font = new Font(txt6Q3.Font.FontFamily, 28); }
                if (txt7Q3.Text == "") { txt7Q3.Font = new Font(txt7Q3.Font.FontFamily, 28); }
                if (txt8Q3.Text == "") { txt8Q3.Font = new Font(txt8Q3.Font.FontFamily, 28); }
                if (txt9Q3.Text == "") { txt9Q3.Font = new Font(txt9Q3.Font.FontFamily, 28); }

                if (txt1Q4.Text == "") { txt1Q4.Font = new Font(txt1Q4.Font.FontFamily, 28); }
                if (txt2Q4.Text == "") { txt2Q4.Font = new Font(txt2Q4.Font.FontFamily, 28); }
                if (txt3Q4.Text == "") { txt3Q4.Font = new Font(txt3Q4.Font.FontFamily, 28); }
                if (txt4Q4.Text == "") { txt4Q4.Font = new Font(txt4Q4.Font.FontFamily, 28); }
                if (txt5Q4.Text == "") { txt5Q4.Font = new Font(txt5Q4.Font.FontFamily, 28); }
                if (txt6Q4.Text == "") { txt6Q4.Font = new Font(txt6Q4.Font.FontFamily, 28); }
                if (txt7Q4.Text == "") { txt7Q4.Font = new Font(txt7Q4.Font.FontFamily, 28); }
                if (txt8Q4.Text == "") { txt8Q4.Font = new Font(txt8Q4.Font.FontFamily, 28); }
                if (txt9Q4.Text == "") { txt9Q4.Font = new Font(txt9Q4.Font.FontFamily, 28); }

                if (txt1Q5.Text == "") { txt1Q5.Font = new Font(txt1Q5.Font.FontFamily, 28); }
                if (txt2Q5.Text == "") { txt2Q5.Font = new Font(txt2Q5.Font.FontFamily, 28); }
                if (txt3Q5.Text == "") { txt3Q5.Font = new Font(txt3Q5.Font.FontFamily, 28); }
                if (txt4Q5.Text == "") { txt4Q5.Font = new Font(txt4Q5.Font.FontFamily, 28); }
                if (txt5Q5.Text == "") { txt5Q5.Font = new Font(txt5Q5.Font.FontFamily, 28); }
                if (txt6Q5.Text == "") { txt6Q5.Font = new Font(txt6Q5.Font.FontFamily, 28); }
                if (txt7Q5.Text == "") { txt7Q5.Font = new Font(txt7Q5.Font.FontFamily, 28); }
                if (txt8Q5.Text == "") { txt8Q5.Font = new Font(txt8Q5.Font.FontFamily, 28); }
                if (txt9Q5.Text == "") { txt9Q5.Font = new Font(txt9Q5.Font.FontFamily, 28); }

                if (txt1Q6.Text == "") { txt1Q6.Font = new Font(txt1Q6.Font.FontFamily, 28); }
                if (txt2Q6.Text == "") { txt2Q6.Font = new Font(txt2Q6.Font.FontFamily, 28); }
                if (txt3Q6.Text == "") { txt3Q6.Font = new Font(txt3Q6.Font.FontFamily, 28); }
                if (txt4Q6.Text == "") { txt4Q6.Font = new Font(txt4Q6.Font.FontFamily, 28); }
                if (txt5Q6.Text == "") { txt5Q6.Font = new Font(txt5Q6.Font.FontFamily, 28); }
                if (txt6Q6.Text == "") { txt6Q6.Font = new Font(txt6Q6.Font.FontFamily, 28); }
                if (txt7Q6.Text == "") { txt7Q6.Font = new Font(txt7Q6.Font.FontFamily, 28); }
                if (txt8Q6.Text == "") { txt8Q6.Font = new Font(txt8Q6.Font.FontFamily, 28); }
                if (txt9Q6.Text == "") { txt9Q6.Font = new Font(txt9Q6.Font.FontFamily, 28); }

                if (txt1Q7.Text == "") { txt1Q7.Font = new Font(txt1Q7.Font.FontFamily, 28); }
                if (txt2Q7.Text == "") { txt2Q7.Font = new Font(txt2Q7.Font.FontFamily, 28); }
                if (txt3Q7.Text == "") { txt3Q7.Font = new Font(txt3Q7.Font.FontFamily, 28); }
                if (txt4Q7.Text == "") { txt4Q7.Font = new Font(txt4Q7.Font.FontFamily, 28); }
                if (txt5Q7.Text == "") { txt5Q7.Font = new Font(txt5Q7.Font.FontFamily, 28); }
                if (txt6Q7.Text == "") { txt6Q7.Font = new Font(txt6Q7.Font.FontFamily, 28); }
                if (txt7Q7.Text == "") { txt7Q7.Font = new Font(txt7Q7.Font.FontFamily, 28); }
                if (txt8Q7.Text == "") { txt8Q7.Font = new Font(txt8Q7.Font.FontFamily, 28); }
                if (txt9Q7.Text == "") { txt9Q7.Font = new Font(txt9Q7.Font.FontFamily, 28); }

                if (txt1Q8.Text == "") { txt1Q8.Font = new Font(txt1Q8.Font.FontFamily, 28); }
                if (txt2Q8.Text == "") { txt2Q8.Font = new Font(txt2Q8.Font.FontFamily, 28); }
                if (txt3Q8.Text == "") { txt3Q8.Font = new Font(txt3Q8.Font.FontFamily, 28); }
                if (txt4Q8.Text == "") { txt4Q8.Font = new Font(txt4Q8.Font.FontFamily, 28); }
                if (txt5Q8.Text == "") { txt5Q8.Font = new Font(txt5Q8.Font.FontFamily, 28); }
                if (txt6Q8.Text == "") { txt6Q8.Font = new Font(txt6Q8.Font.FontFamily, 28); }
                if (txt7Q8.Text == "") { txt7Q8.Font = new Font(txt7Q8.Font.FontFamily, 28); }
                if (txt8Q8.Text == "") { txt8Q8.Font = new Font(txt8Q8.Font.FontFamily, 28); }
                if (txt9Q8.Text == "") { txt9Q8.Font = new Font(txt9Q8.Font.FontFamily, 28); }

                if (txt1Q9.Text == "") { txt1Q9.Font = new Font(txt1Q9.Font.FontFamily, 28); }
                if (txt2Q9.Text == "") { txt2Q9.Font = new Font(txt2Q9.Font.FontFamily, 28); }
                if (txt3Q9.Text == "") { txt3Q9.Font = new Font(txt3Q9.Font.FontFamily, 28); }
                if (txt4Q9.Text == "") { txt4Q9.Font = new Font(txt4Q9.Font.FontFamily, 28); }
                if (txt5Q9.Text == "") { txt5Q9.Font = new Font(txt5Q9.Font.FontFamily, 28); }
                if (txt6Q9.Text == "") { txt6Q9.Font = new Font(txt6Q9.Font.FontFamily, 28); }
                if (txt7Q9.Text == "") { txt7Q9.Font = new Font(txt7Q9.Font.FontFamily, 28); }
                if (txt8Q9.Text == "") { txt8Q9.Font = new Font(txt8Q9.Font.FontFamily, 28); }
                if (txt9Q9.Text == "") { txt9Q9.Font = new Font(txt9Q9.Font.FontFamily, 28); }

            }
        }
        private void btnComoEstou_Click(object sender, EventArgs e)
        {

                numComoEstou--;
                btnComoEstou.Text = "Como estou? (" + numComoEstou + ")";

                if (numComoEstou == 0)
                {
                    btnComoEstou.Enabled = false;

                }

            if (txt1Q1.Text != "") { comoEstou[0, 0] = Convert.ToInt32(txt1Q1.Text); } else { comoEstou[0, 0] = 0; }
            if (txt2Q1.Text != "") { comoEstou[1, 0] = Convert.ToInt32(txt2Q1.Text); } else { comoEstou[1, 0] = 0; }
            if (txt3Q1.Text != "") { comoEstou[2, 0] = Convert.ToInt32(txt3Q1.Text); } else { comoEstou[2, 0] = 0; }
            if (txt4Q1.Text != "") { comoEstou[0, 1] = Convert.ToInt32(txt4Q1.Text); } else { comoEstou[0, 1] = 0; }
            if (txt5Q1.Text != "") { comoEstou[1, 1] = Convert.ToInt32(txt5Q1.Text); } else { comoEstou[1, 1] = 0; }
            if (txt6Q1.Text != "") { comoEstou[2, 1] = Convert.ToInt32(txt6Q1.Text); } else { comoEstou[2, 1] = 0; }
            if (txt7Q1.Text != "") { comoEstou[0, 2] = Convert.ToInt32(txt7Q1.Text); } else { comoEstou[0, 2] = 0; }
            if (txt8Q1.Text != "") { comoEstou[1, 2] = Convert.ToInt32(txt8Q1.Text); } else { comoEstou[1, 2] = 0; }
            if (txt9Q1.Text != "") { comoEstou[2, 2] = Convert.ToInt32(txt9Q1.Text); } else { comoEstou[2, 2] = 0; }

            if (txt1Q2.Text != "") { comoEstou[3, 0] = Convert.ToInt32(txt1Q2.Text); } else { comoEstou[3, 0] = 0; }
            if (txt2Q2.Text != "") { comoEstou[4, 0] = Convert.ToInt32(txt2Q2.Text); } else { comoEstou[4, 0] = 0; }
            if (txt3Q2.Text != "") { comoEstou[5, 0] = Convert.ToInt32(txt3Q2.Text); } else { comoEstou[5, 0] = 0; }
            if (txt4Q2.Text != "") { comoEstou[3, 1] = Convert.ToInt32(txt4Q2.Text); } else { comoEstou[3, 1] = 0; }
            if (txt5Q2.Text != "") { comoEstou[4, 1] = Convert.ToInt32(txt5Q2.Text); } else { comoEstou[4, 1] = 0; }
            if (txt6Q2.Text != "") { comoEstou[5, 1] = Convert.ToInt32(txt6Q2.Text); } else { comoEstou[5, 1] = 0; }
            if (txt7Q2.Text != "") { comoEstou[3, 2] = Convert.ToInt32(txt7Q2.Text); } else { comoEstou[3, 2] = 0; }
            if (txt8Q2.Text != "") { comoEstou[4, 2] = Convert.ToInt32(txt8Q2.Text); } else { comoEstou[4, 2] = 0; }
            if (txt9Q2.Text != "") { comoEstou[5, 2] = Convert.ToInt32(txt9Q2.Text); } else { comoEstou[5, 2] = 0; }

            if (txt1Q3.Text != "") { comoEstou[6, 0] = Convert.ToInt32(txt1Q3.Text); } else { comoEstou[6, 0] = 0; }
            if (txt2Q3.Text != "") { comoEstou[7, 0] = Convert.ToInt32(txt2Q3.Text); } else { comoEstou[7, 0] = 0; }
            if (txt3Q3.Text != "") { comoEstou[8, 0] = Convert.ToInt32(txt3Q3.Text); } else { comoEstou[8, 0] = 0; }
            if (txt4Q3.Text != "") { comoEstou[6, 1] = Convert.ToInt32(txt4Q3.Text); } else { comoEstou[6, 1] = 0; }
            if (txt5Q3.Text != "") { comoEstou[7, 1] = Convert.ToInt32(txt5Q3.Text); } else { comoEstou[7, 1] = 0; }
            if (txt6Q3.Text != "") { comoEstou[8, 1] = Convert.ToInt32(txt6Q3.Text); } else { comoEstou[8, 1] = 0; }
            if (txt7Q3.Text != "") { comoEstou[6, 2] = Convert.ToInt32(txt7Q3.Text); } else { comoEstou[6, 2] = 0; }
            if (txt8Q3.Text != "") { comoEstou[7, 2] = Convert.ToInt32(txt8Q3.Text); } else { comoEstou[7, 2] = 0; }
            if (txt9Q3.Text != "") { comoEstou[8, 2] = Convert.ToInt32(txt9Q3.Text); } else { comoEstou[8, 2] = 0; }

            if (txt1Q4.Text != "") { comoEstou[0, 3] = Convert.ToInt32(txt1Q4.Text); } else { comoEstou[0, 3] = 0; }
            if (txt2Q4.Text != "") { comoEstou[1, 3] = Convert.ToInt32(txt2Q4.Text); } else { comoEstou[1, 3] = 0; }
            if (txt3Q4.Text != "") { comoEstou[2, 3] = Convert.ToInt32(txt3Q4.Text); } else { comoEstou[2, 3] = 0; }
            if (txt4Q4.Text != "") { comoEstou[0, 4] = Convert.ToInt32(txt4Q4.Text); } else { comoEstou[0, 4] = 0; }
            if (txt5Q4.Text != "") { comoEstou[1, 4] = Convert.ToInt32(txt5Q4.Text); } else { comoEstou[1, 4] = 0; }
            if (txt6Q4.Text != "") { comoEstou[2, 4] = Convert.ToInt32(txt6Q4.Text); } else { comoEstou[2, 4] = 0; }
            if (txt7Q4.Text != "") { comoEstou[0, 5] = Convert.ToInt32(txt7Q4.Text); } else { comoEstou[0, 5] = 0; }
            if (txt8Q4.Text != "") { comoEstou[1, 5] = Convert.ToInt32(txt8Q4.Text); } else { comoEstou[1, 5] = 0; }
            if (txt9Q4.Text != "") { comoEstou[2, 5] = Convert.ToInt32(txt9Q4.Text); } else { comoEstou[2, 5] = 0; }

            if (txt1Q5.Text != "") { comoEstou[3, 3] = Convert.ToInt32(txt1Q5.Text); } else { comoEstou[3, 3] = 0; }
            if (txt2Q5.Text != "") { comoEstou[4, 3] = Convert.ToInt32(txt2Q5.Text); } else { comoEstou[4, 3] = 0; }
            if (txt3Q5.Text != "") { comoEstou[5, 3] = Convert.ToInt32(txt3Q5.Text); } else { comoEstou[5, 3] = 0; }
            if (txt4Q5.Text != "") { comoEstou[3, 4] = Convert.ToInt32(txt4Q5.Text); } else { comoEstou[3, 4] = 0; }
            if (txt5Q5.Text != "") { comoEstou[4, 4] = Convert.ToInt32(txt5Q5.Text); } else { comoEstou[4, 4] = 0; }
            if (txt6Q5.Text != "") { comoEstou[5, 4] = Convert.ToInt32(txt6Q5.Text); } else { comoEstou[5, 4] = 0; }
            if (txt7Q5.Text != "") { comoEstou[3, 5] = Convert.ToInt32(txt7Q5.Text); } else { comoEstou[3, 5] = 0; }
            if (txt8Q5.Text != "") { comoEstou[4, 5] = Convert.ToInt32(txt8Q5.Text); } else { comoEstou[4, 5] = 0; }
            if (txt9Q5.Text != "") { comoEstou[5, 5] = Convert.ToInt32(txt9Q5.Text); } else { comoEstou[5, 5] = 0; }

            if (txt1Q6.Text != "") { comoEstou[6, 3] = Convert.ToInt32(txt1Q6.Text); } else { comoEstou[6, 3] = 0; }
            if (txt2Q6.Text != "") { comoEstou[7, 3] = Convert.ToInt32(txt2Q6.Text); } else { comoEstou[7, 3] = 0; }
            if (txt3Q6.Text != "") { comoEstou[8, 3] = Convert.ToInt32(txt3Q6.Text); } else { comoEstou[8, 3] = 0; }
            if (txt4Q6.Text != "") { comoEstou[6, 4] = Convert.ToInt32(txt4Q6.Text); } else { comoEstou[6, 4] = 0; }
            if (txt5Q6.Text != "") { comoEstou[7, 4] = Convert.ToInt32(txt5Q6.Text); } else { comoEstou[7, 4] = 0; }
            if (txt6Q6.Text != "") { comoEstou[8, 4] = Convert.ToInt32(txt6Q6.Text); } else { comoEstou[8, 4] = 0; }
            if (txt7Q6.Text != "") { comoEstou[6, 5] = Convert.ToInt32(txt7Q6.Text); } else { comoEstou[6, 5] = 0; }
            if (txt8Q6.Text != "") { comoEstou[7, 5] = Convert.ToInt32(txt8Q6.Text); } else { comoEstou[7, 5] = 0; }
            if (txt9Q6.Text != "") { comoEstou[8, 5] = Convert.ToInt32(txt9Q6.Text); } else { comoEstou[8, 5] = 0; }

            if (txt1Q7.Text != "") { comoEstou[0, 6] = Convert.ToInt32(txt1Q7.Text); } else { comoEstou[0, 6] = 0; }
            if (txt2Q7.Text != "") { comoEstou[1, 6] = Convert.ToInt32(txt2Q7.Text); } else { comoEstou[1, 6] = 0; }
            if (txt3Q7.Text != "") { comoEstou[2, 6] = Convert.ToInt32(txt3Q7.Text); } else { comoEstou[2, 6] = 0; }
            if (txt4Q7.Text != "") { comoEstou[0, 7] = Convert.ToInt32(txt4Q7.Text); } else { comoEstou[0, 7] = 0; }
            if (txt5Q7.Text != "") { comoEstou[1, 7] = Convert.ToInt32(txt5Q7.Text); } else { comoEstou[1, 7] = 0; }
            if (txt6Q7.Text != "") { comoEstou[2, 7] = Convert.ToInt32(txt6Q7.Text); } else { comoEstou[2, 7] = 0; }
            if (txt7Q7.Text != "") { comoEstou[0, 8] = Convert.ToInt32(txt7Q7.Text); } else { comoEstou[0, 8] = 0; }
            if (txt8Q7.Text != "") { comoEstou[1, 8] = Convert.ToInt32(txt8Q7.Text); } else { comoEstou[1, 8] = 0; }
            if (txt9Q7.Text != "") { comoEstou[2, 8] = Convert.ToInt32(txt9Q7.Text); } else { comoEstou[2, 8] = 0; }

            if (txt1Q8.Text != "") { comoEstou[3, 6] = Convert.ToInt32(txt1Q8.Text); } else { comoEstou[3, 6] = 0; }
            if (txt2Q8.Text != "") { comoEstou[4, 6] = Convert.ToInt32(txt2Q8.Text); } else { comoEstou[4, 6] = 0; }
            if (txt3Q8.Text != "") { comoEstou[5, 6] = Convert.ToInt32(txt3Q8.Text); } else { comoEstou[5, 6] = 0; }
            if (txt4Q8.Text != "") { comoEstou[3, 7] = Convert.ToInt32(txt4Q8.Text); } else { comoEstou[3, 7] = 0; }
            if (txt5Q8.Text != "") { comoEstou[4, 7] = Convert.ToInt32(txt5Q8.Text); } else { comoEstou[4, 7] = 0; }
            if (txt6Q8.Text != "") { comoEstou[5, 7] = Convert.ToInt32(txt6Q8.Text); } else { comoEstou[5, 7] = 0; }
            if (txt7Q8.Text != "") { comoEstou[3, 8] = Convert.ToInt32(txt7Q8.Text); } else { comoEstou[3, 8] = 0; }
            if (txt8Q8.Text != "") { comoEstou[4, 8] = Convert.ToInt32(txt8Q8.Text); } else { comoEstou[4, 8] = 0; }
            if (txt9Q8.Text != "") { comoEstou[5, 8] = Convert.ToInt32(txt9Q8.Text); } else { comoEstou[5, 8] = 0; }

            if (txt1Q9.Text != "") { comoEstou[6, 6] = Convert.ToInt32(txt1Q9.Text); } else { comoEstou[6, 6] = 0; }
            if (txt2Q9.Text != "") { comoEstou[7, 6] = Convert.ToInt32(txt2Q9.Text); } else { comoEstou[7, 6] = 0; }
            if (txt3Q9.Text != "") { comoEstou[8, 6] = Convert.ToInt32(txt3Q9.Text); } else { comoEstou[8, 6] = 0; }
            if (txt4Q9.Text != "") { comoEstou[6, 7] = Convert.ToInt32(txt4Q9.Text); } else { comoEstou[6, 7] = 0; }
            if (txt5Q9.Text != "") { comoEstou[7, 7] = Convert.ToInt32(txt5Q9.Text); } else { comoEstou[7, 7] = 0; }
            if (txt6Q9.Text != "") { comoEstou[8, 7] = Convert.ToInt32(txt6Q9.Text); } else { comoEstou[8, 7] = 0; }
            if (txt7Q9.Text != "") { comoEstou[6, 8] = Convert.ToInt32(txt7Q9.Text); } else { comoEstou[6, 8] = 0; }
            if (txt8Q9.Text != "") { comoEstou[7, 8] = Convert.ToInt32(txt8Q9.Text); } else { comoEstou[7, 8] = 0; }
            if (txt9Q9.Text != "") { comoEstou[8, 8] = Convert.ToInt32(txt9Q9.Text); } else { comoEstou[8, 8] = 0; }

            errosComoEstou = 0;
            vazioComoEstou = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    if (comoEstou[i, j] != 0)
                    {

                        if (grid[i, j] != comoEstou[i, j])
                        {
                            errosComoEstou++;
                        }

                    }
                    else
                    {

                        vazioComoEstou++;

                    }

                }
            }


            lblInfo.Text = errosComoEstou + " erros, " + vazioComoEstou + " espaços vazios.";
            lblInfo.BackColor = Color.WhiteSmoke;

            
        }
        private void btnAcabei_Click(object sender, EventArgs e)
        {


            if (
                txt1Q1.Text != "" &&
                txt2Q1.Text != "" &&
                txt3Q1.Text != "" &&
                txt4Q1.Text != "" &&
                txt5Q1.Text != "" &&
                txt6Q1.Text != "" &&
                txt7Q1.Text != "" &&
                txt8Q1.Text != "" &&
                txt9Q1.Text != "" &&

                txt1Q2.Text != "" &&
                txt2Q2.Text != "" &&
                txt3Q2.Text != "" &&
                txt4Q2.Text != "" &&
                txt5Q2.Text != "" &&
                txt6Q2.Text != "" &&
                txt7Q2.Text != "" &&
                txt8Q2.Text != "" &&
                txt9Q2.Text != "" &&

                txt1Q3.Text != "" &&
                txt2Q3.Text != "" &&
                txt3Q3.Text != "" &&
                txt4Q3.Text != "" &&
                txt5Q3.Text != "" &&
                txt6Q3.Text != "" &&
                txt7Q3.Text != "" &&
                txt8Q3.Text != "" &&
                txt9Q3.Text != "" &&

                txt1Q4.Text != "" &&
                txt2Q4.Text != "" &&
                txt3Q4.Text != "" &&
                txt4Q4.Text != "" &&
                txt5Q4.Text != "" &&
                txt6Q4.Text != "" &&
                txt7Q4.Text != "" &&
                txt8Q4.Text != "" &&
                txt9Q4.Text != "" &&

                txt1Q5.Text != "" &&
                txt2Q5.Text != "" &&
                txt3Q5.Text != "" &&
                txt4Q5.Text != "" &&
                txt5Q5.Text != "" &&
                txt6Q5.Text != "" &&
                txt7Q5.Text != "" &&
                txt8Q5.Text != "" &&
                txt9Q5.Text != "" &&

                txt1Q6.Text != "" &&
                txt2Q6.Text != "" &&
                txt3Q6.Text != "" &&
                txt4Q6.Text != "" &&
                txt5Q6.Text != "" &&
                txt6Q6.Text != "" &&
                txt7Q6.Text != "" &&
                txt8Q6.Text != "" &&
                txt9Q6.Text != "" &&

                txt1Q7.Text != "" &&
                txt2Q7.Text != "" &&
                txt3Q7.Text != "" &&
                txt4Q7.Text != "" &&
                txt5Q7.Text != "" &&
                txt6Q7.Text != "" &&
                txt7Q7.Text != "" &&
                txt8Q7.Text != "" &&
                txt9Q7.Text != "" &&

                txt1Q8.Text != "" &&
                txt2Q8.Text != "" &&
                txt3Q8.Text != "" &&
                txt4Q8.Text != "" &&
                txt5Q8.Text != "" &&
                txt6Q8.Text != "" &&
                txt7Q8.Text != "" &&
                txt8Q8.Text != "" &&
                txt9Q8.Text != "" &&

                txt1Q9.Text != "" &&
                txt2Q9.Text != "" &&
                txt3Q9.Text != "" &&
                txt4Q9.Text != "" &&
                txt5Q9.Text != "" &&
                txt6Q9.Text != "" &&
                txt7Q9.Text != "" &&
                txt8Q9.Text != "" &&
                txt9Q9.Text != ""
            )
            {

                acabei[0, 0] = Convert.ToInt32(txt1Q1.Text);
                acabei[1, 0] = Convert.ToInt32(txt2Q1.Text);
                acabei[2, 0] = Convert.ToInt32(txt3Q1.Text);
                acabei[0, 1] = Convert.ToInt32(txt4Q1.Text);
                acabei[1, 1] = Convert.ToInt32(txt5Q1.Text);
                acabei[2, 1] = Convert.ToInt32(txt6Q1.Text);
                acabei[0, 2] = Convert.ToInt32(txt7Q1.Text);
                acabei[1, 2] = Convert.ToInt32(txt8Q1.Text);
                acabei[2, 2] = Convert.ToInt32(txt9Q1.Text);

                acabei[3, 0] = Convert.ToInt32(txt1Q2.Text);
                acabei[4, 0] = Convert.ToInt32(txt2Q2.Text);
                acabei[5, 0] = Convert.ToInt32(txt3Q2.Text);
                acabei[3, 1] = Convert.ToInt32(txt4Q2.Text);
                acabei[4, 1] = Convert.ToInt32(txt5Q2.Text);
                acabei[5, 1] = Convert.ToInt32(txt6Q2.Text);
                acabei[3, 2] = Convert.ToInt32(txt7Q2.Text);
                acabei[4, 2] = Convert.ToInt32(txt8Q2.Text);
                acabei[5, 2] = Convert.ToInt32(txt9Q2.Text);

                acabei[6, 0] = Convert.ToInt32(txt1Q3.Text);
                acabei[7, 0] = Convert.ToInt32(txt2Q3.Text);
                acabei[8, 0] = Convert.ToInt32(txt3Q3.Text);
                acabei[6, 1] = Convert.ToInt32(txt4Q3.Text);
                acabei[7, 1] = Convert.ToInt32(txt5Q3.Text);
                acabei[8, 1] = Convert.ToInt32(txt6Q3.Text);
                acabei[6, 2] = Convert.ToInt32(txt7Q3.Text);
                acabei[7, 2] = Convert.ToInt32(txt8Q3.Text);
                acabei[8, 2] = Convert.ToInt32(txt9Q3.Text);

                acabei[0, 3] = Convert.ToInt32(txt1Q4.Text);
                acabei[1, 3] = Convert.ToInt32(txt2Q4.Text);
                acabei[2, 3] = Convert.ToInt32(txt3Q4.Text);
                acabei[0, 4] = Convert.ToInt32(txt4Q4.Text);
                acabei[1, 4] = Convert.ToInt32(txt5Q4.Text);
                acabei[2, 4] = Convert.ToInt32(txt6Q4.Text);
                acabei[0, 5] = Convert.ToInt32(txt7Q4.Text);
                acabei[1, 5] = Convert.ToInt32(txt8Q4.Text);
                acabei[2, 5] = Convert.ToInt32(txt9Q4.Text);

                acabei[3, 3] = Convert.ToInt32(txt1Q5.Text);
                acabei[4, 3] = Convert.ToInt32(txt2Q5.Text);
                acabei[5, 3] = Convert.ToInt32(txt3Q5.Text);
                acabei[3, 4] = Convert.ToInt32(txt4Q5.Text);
                acabei[4, 4] = Convert.ToInt32(txt5Q5.Text);
                acabei[5, 4] = Convert.ToInt32(txt6Q5.Text);
                acabei[3, 5] = Convert.ToInt32(txt7Q5.Text);
                acabei[4, 5] = Convert.ToInt32(txt8Q5.Text);
                acabei[5, 5] = Convert.ToInt32(txt9Q5.Text);

                acabei[6, 3] = Convert.ToInt32(txt1Q6.Text);
                acabei[7, 3] = Convert.ToInt32(txt2Q6.Text);
                acabei[8, 3] = Convert.ToInt32(txt3Q6.Text);
                acabei[6, 4] = Convert.ToInt32(txt4Q6.Text);
                acabei[7, 4] = Convert.ToInt32(txt5Q6.Text);
                acabei[8, 4] = Convert.ToInt32(txt6Q6.Text);
                acabei[6, 5] = Convert.ToInt32(txt7Q6.Text);
                acabei[7, 5] = Convert.ToInt32(txt8Q6.Text);
                acabei[8, 5] = Convert.ToInt32(txt9Q6.Text);

                acabei[0, 6] = Convert.ToInt32(txt1Q7.Text);
                acabei[1, 6] = Convert.ToInt32(txt2Q7.Text);
                acabei[2, 6] = Convert.ToInt32(txt3Q7.Text);
                acabei[0, 7] = Convert.ToInt32(txt4Q7.Text);
                acabei[1, 7] = Convert.ToInt32(txt5Q7.Text);
                acabei[2, 7] = Convert.ToInt32(txt6Q7.Text);
                acabei[0, 8] = Convert.ToInt32(txt7Q7.Text);
                acabei[1, 8] = Convert.ToInt32(txt8Q7.Text);
                acabei[2, 8] = Convert.ToInt32(txt9Q7.Text);

                acabei[3, 6] = Convert.ToInt32(txt1Q8.Text);
                acabei[4, 6] = Convert.ToInt32(txt2Q8.Text);
                acabei[5, 6] = Convert.ToInt32(txt3Q8.Text);
                acabei[3, 7] = Convert.ToInt32(txt4Q8.Text);
                acabei[4, 7] = Convert.ToInt32(txt5Q8.Text);
                acabei[5, 7] = Convert.ToInt32(txt6Q8.Text);
                acabei[3, 8] = Convert.ToInt32(txt7Q8.Text);
                acabei[4, 8] = Convert.ToInt32(txt8Q8.Text);
                acabei[5, 8] = Convert.ToInt32(txt9Q8.Text);

                acabei[6, 6] = Convert.ToInt32(txt1Q9.Text);
                acabei[7, 6] = Convert.ToInt32(txt2Q9.Text);
                acabei[8, 6] = Convert.ToInt32(txt3Q9.Text);
                acabei[6, 7] = Convert.ToInt32(txt4Q9.Text);
                acabei[7, 7] = Convert.ToInt32(txt5Q9.Text);
                acabei[8, 7] = Convert.ToInt32(txt6Q9.Text);
                acabei[6, 8] = Convert.ToInt32(txt7Q9.Text);
                acabei[7, 8] = Convert.ToInt32(txt8Q9.Text);
                acabei[8, 8] = Convert.ToInt32(txt9Q9.Text);

                vitoria = true;

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (grid[i, j] != acabei[i, j])
                        {

                            vitoria = false;

                        }

                    }
                }

                if (vitoria == true)
                {

                    lblInfo.Text = "Parabéns, você venceu!";
                    lblInfo.BackColor = Color.FromArgb(86, 162, 235);
                    btnAcabei.Enabled = false;
                    btnAnotar.Enabled = false;
                    btnComoEstou.Enabled = false;
                    btnLimpar.Enabled = false;
                    btnNovo.Enabled = true;
                    pnlCentro.Enabled = false;
                 

                }
                else {

                    lblInfo.Text = "Infelizmente ainda existem erros!";
                    lblInfo.BackColor = Color.FromArgb(253, 108, 108);

                }


            }
            else
            {

                lblInfo.Text = "Por favor, preencha todos os campos!";
                lblInfo.BackColor = Color.FromArgb(253, 108, 108);

            }

        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
              DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer voltar para o menu? Seu jogo será perdido!", "Voltar para o menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (dialogResult == DialogResult.Yes)
              {

                  for (int i = 0; i < 9; i++)
                  {
                      for (int j = 0; j < 9; j++)
                      {

                          jogo[i, j] = 0;

                      }

                  }

                  txt1Q1.Text = "";
                  txt2Q1.Text = "";
                  txt3Q1.Text = "";
                  txt4Q1.Text = "";
                  txt5Q1.Text = "";
                  txt6Q1.Text = "";
                  txt7Q1.Text = "";
                  txt8Q1.Text = "";
                  txt9Q1.Text = "";

                  txt1Q2.Text = "";
                  txt2Q2.Text = "";
                  txt3Q2.Text = "";
                  txt4Q2.Text = "";
                  txt5Q2.Text = "";
                  txt6Q2.Text = "";
                  txt7Q2.Text = "";
                  txt8Q2.Text = "";
                  txt9Q2.Text = "";

                  txt1Q3.Text = "";
                  txt2Q3.Text = "";
                  txt3Q3.Text = "";
                  txt4Q3.Text = "";
                  txt5Q3.Text = "";
                  txt6Q3.Text = "";
                  txt7Q3.Text = "";
                  txt8Q3.Text = "";
                  txt9Q3.Text = "";

                  txt1Q4.Text = "";
                  txt2Q4.Text = "";
                  txt3Q4.Text = "";
                  txt4Q4.Text = "";
                  txt5Q4.Text = "";
                  txt6Q4.Text = "";
                  txt7Q4.Text = "";
                  txt8Q4.Text = "";
                  txt9Q4.Text = "";

                  txt1Q5.Text = "";
                  txt2Q5.Text = "";
                  txt3Q5.Text = "";
                  txt4Q5.Text = "";
                  txt5Q5.Text = "";
                  txt6Q5.Text = "";
                  txt7Q5.Text = "";
                  txt8Q5.Text = "";
                  txt9Q5.Text = "";

                  txt1Q6.Text = "";
                  txt2Q6.Text = "";
                  txt3Q6.Text = "";
                  txt4Q6.Text = "";
                  txt5Q6.Text = "";
                  txt6Q6.Text = "";
                  txt7Q6.Text = "";
                  txt8Q6.Text = "";
                  txt9Q6.Text = "";

                  txt1Q7.Text = "";
                  txt2Q7.Text = "";
                  txt3Q7.Text = "";
                  txt4Q7.Text = "";
                  txt5Q7.Text = "";
                  txt6Q7.Text = "";
                  txt7Q7.Text = "";
                  txt8Q7.Text = "";
                  txt9Q7.Text = "";

                  txt1Q8.Text = "";
                  txt2Q8.Text = "";
                  txt3Q8.Text = "";
                  txt4Q8.Text = "";
                  txt5Q8.Text = "";
                  txt6Q8.Text = "";
                  txt7Q8.Text = "";
                  txt8Q8.Text = "";
                  txt9Q8.Text = "";

                  txt1Q9.Text = "";
                  txt2Q9.Text = "";
                  txt3Q9.Text = "";
                  txt4Q9.Text = "";
                  txt5Q9.Text = "";
                  txt6Q9.Text = "";
                  txt7Q9.Text = "";
                  txt8Q9.Text = "";
                  txt9Q9.Text = "";

                  // 

                  txt1Q1.Enabled = true;
                  txt2Q1.Enabled = true;
                  txt3Q1.Enabled = true;
                  txt4Q1.Enabled = true;
                  txt5Q1.Enabled = true;
                  txt6Q1.Enabled = true;
                  txt7Q1.Enabled = true;
                  txt8Q1.Enabled = true;
                  txt9Q1.Enabled = true;

                  txt1Q2.Enabled = true;
                  txt2Q2.Enabled = true;
                  txt3Q2.Enabled = true;
                  txt4Q2.Enabled = true;
                  txt5Q2.Enabled = true;
                  txt6Q2.Enabled = true;
                  txt7Q2.Enabled = true;
                  txt8Q2.Enabled = true;
                  txt9Q2.Enabled = true;

                  txt1Q3.Enabled = true;
                  txt2Q3.Enabled = true;
                  txt3Q3.Enabled = true;
                  txt4Q3.Enabled = true;
                  txt5Q3.Enabled = true;
                  txt6Q3.Enabled = true;
                  txt7Q3.Enabled = true;
                  txt8Q3.Enabled = true;
                  txt9Q3.Enabled = true;

                  txt1Q4.Enabled = true;
                  txt2Q4.Enabled = true;
                  txt3Q4.Enabled = true;
                  txt4Q4.Enabled = true;
                  txt5Q4.Enabled = true;
                  txt6Q4.Enabled = true;
                  txt7Q4.Enabled = true;
                  txt8Q4.Enabled = true;
                  txt9Q4.Enabled = true;

                  txt1Q5.Enabled = true;
                  txt2Q5.Enabled = true;
                  txt3Q5.Enabled = true;
                  txt4Q5.Enabled = true;
                  txt5Q5.Enabled = true;
                  txt6Q5.Enabled = true;
                  txt7Q5.Enabled = true;
                  txt8Q5.Enabled = true;
                  txt9Q5.Enabled = true;

                  txt1Q6.Enabled = true;
                  txt2Q6.Enabled = true;
                  txt3Q6.Enabled = true;
                  txt4Q6.Enabled = true;
                  txt5Q6.Enabled = true;
                  txt6Q6.Enabled = true;
                  txt7Q6.Enabled = true;
                  txt8Q6.Enabled = true;
                  txt9Q6.Enabled = true;

                  txt1Q7.Enabled = true;
                  txt2Q7.Enabled = true;
                  txt3Q7.Enabled = true;
                  txt4Q7.Enabled = true;
                  txt5Q7.Enabled = true;
                  txt6Q7.Enabled = true;
                  txt7Q7.Enabled = true;
                  txt8Q7.Enabled = true;
                  txt9Q7.Enabled = true;

                  txt1Q8.Enabled = true;
                  txt2Q8.Enabled = true;
                  txt3Q8.Enabled = true;
                  txt4Q8.Enabled = true;
                  txt5Q8.Enabled = true;
                  txt6Q8.Enabled = true;
                  txt7Q8.Enabled = true;
                  txt8Q8.Enabled = true;
                  txt9Q8.Enabled = true;

                  txt1Q9.Enabled = true;
                  txt2Q9.Enabled = true;
                  txt3Q9.Enabled = true;
                  txt4Q9.Enabled = true;
                  txt5Q9.Enabled = true;
                  txt6Q9.Enabled = true;
                  txt7Q9.Enabled = true;
                  txt8Q9.Enabled = true;
                  txt9Q9.Enabled = true;



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
