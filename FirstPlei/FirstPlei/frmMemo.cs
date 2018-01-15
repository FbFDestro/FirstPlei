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
    public partial class frmJogoMemo : Form
    {
        public frmJogoMemo()
        {
            InitializeComponent();
        }

        static int[] imagens = new int[9];
        static int[] jafoiImg = new int[9];
        static int[] aux = new int[4];
        static int[] jafoiAux = new int[4];
        Random rdImg = new Random();
        int imgNumero, img, foi, cliques, imagem1, imagem2, img1num, img2num, pontos1, pontos2, vencedor1, vencedor2;
        string vez;

        private void txtNome1_Enter(object sender, EventArgs e)
        {
            if (txtNome1.Text == "Nome do jogador 1")
            {
                txtNome1.Text = "";
            }
        }
        private void txtNome1_Leave(object sender, EventArgs e)
        {
            if (txtNome1.Text == "")
            {
                txtNome1.Text = "Nome do jogador 1";
            }
        }
        private void txtNome2_Enter(object sender, EventArgs e)
        {

            if (txtNome2.Text == "Nome do jogador 2")
            {
                txtNome2.Text = "";
            }
        }
        private void txtNome2_Leave(object sender, EventArgs e)
        {
            if (txtNome2.Text == "")
            {
                txtNome2.Text = "Nome do jogador 2";
            }
        }
        private void btnComecar_Click_1(object sender, EventArgs e)
        {

            if (txtNome1.Text == "Nome do jogador 1" || txtNome1.Text == "" || txtNome2.Text == "Nome do jogador 2" || txtNome2.Text == "")
            {
                lblInfo.Text = "Por favor, digite os nomes corretamente!";
                lblInfo.BackColor = Color.FromArgb(253, 108, 108);
            }
            else
            {
                vez  = txtNome1.Text;

                lblInfo.Text = "Bom jogo, " + vez + " começa!";
                lblInfo.BackColor = Color.WhiteSmoke;
                btnNovo.Enabled = true;
                pnlCentro.Enabled = true;
                btnComecar.Enabled = false;
                btnReiniciar.Enabled = true;

                // Zerando variaveis: 

                cliques = imagem1 = imagem2 = img1num = img2num = pontos1 = pontos2 = vencedor1 = vencedor2 = 0;
            

                geraImagens();

            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {

            pctr1.Image = FirstPlei.Properties.Resources.capa;
            pctr2.Image = FirstPlei.Properties.Resources.capa;
            pctr3.Image = FirstPlei.Properties.Resources.capa;
            pctr4.Image = FirstPlei.Properties.Resources.capa;
            pctr5.Image = FirstPlei.Properties.Resources.capa;
            pctr6.Image = FirstPlei.Properties.Resources.capa;
            pctr7.Image = FirstPlei.Properties.Resources.capa;
            pctr8.Image = FirstPlei.Properties.Resources.capa;
            pctr9.Image = FirstPlei.Properties.Resources.capa;

            pctr1.Enabled = true;
            pctr2.Enabled = true;
            pctr3.Enabled = true;
            pctr4.Enabled = true;
            pctr5.Enabled = true;
            pctr6.Enabled = true;
            pctr7.Enabled = true;
            pctr8.Enabled = true;
            pctr9.Enabled = true;

            btnComecar.Enabled = true;
            btnNovo.Enabled = false;
            btnReiniciar.Enabled = false;
            pnlCentro.Enabled = false;

            txtNome1.Text = "Nome do jogador 1";
            txtNome2.Text = "Nome do jogador 2";

            lblJ1P.Text = "Jogador 1";
            lblJ2P.Text = "Jogador 2";
            lblJ1G.Text = "Jogador 1";
            lblJ2G.Text = "Jogador 2";

            lblInfo.Text = "Começe a jogar";

        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            pctr1.Image = FirstPlei.Properties.Resources.capa;
            pctr2.Image = FirstPlei.Properties.Resources.capa;
            pctr3.Image = FirstPlei.Properties.Resources.capa;
            pctr4.Image = FirstPlei.Properties.Resources.capa;
            pctr5.Image = FirstPlei.Properties.Resources.capa;
            pctr6.Image = FirstPlei.Properties.Resources.capa;
            pctr7.Image = FirstPlei.Properties.Resources.capa;
            pctr8.Image = FirstPlei.Properties.Resources.capa;
            pctr9.Image = FirstPlei.Properties.Resources.capa;

            pctr1.Enabled = true;
            pctr2.Enabled = true;
            pctr3.Enabled = true;
            pctr4.Enabled = true;
            pctr5.Enabled = true;
            pctr6.Enabled = true;
            pctr7.Enabled = true;
            pctr8.Enabled = true;
            pctr9.Enabled = true;


            pnlCentro.Enabled = true;

            lblJ1P.Text = "Jogador 1";
            lblJ2P.Text = "Jogador 2";

            lblInfo.Text = vez + ", inicie o novo jogo!";
            

            cliques = imagem1 = imagem2 = img1num = img2num = pontos1 = pontos2 = 0;
            geraImagens();
          
        }

        public void geraImagens()
        {

                for (int i = 0; i < 9; i++)
                {
                    imagens[i] = 0;
                    jafoiImg[i] = 0;
                }

                for (int i = 0; i < 4; i++) {
                    aux[i] = 0;
                    jafoiAux[i] = 0;
                }

                bool valido = false;
                bool todos = false;

                while (todos == false)
                {

                    valido = false;

                    for (int i = 0; i < 4; i++)
                    {
                        valido = false;
                        if (aux[i] == 0)
                        {
                            while (valido == false)
                            {

                                aux[i] = rdImg.Next(1, 12);
                                int x = 0;

                                for (int j = 0; j < 4; j++)
                                {
                                    if (jafoiAux[j] != aux[i])
                                    {
                                        x++;
                                    }
                                }
                                if (x == 4)
                                {
                                    valido = true;
                                    jafoiAux[i] = aux[i];

                                }
                            }
                        }
                    }


                    valido = false;
                    while (valido == false)
                    {
                        foi = 0;
                        img = rdImg.Next(0, 9);
                        if (imagens[img] == 0)
                        {
                            imgNumero = rdImg.Next(1, 5);
                            imagens[img] = imgNumero;
                            for (int i = 0; i < 9; i++)
                            {
                                if (jafoiImg[i] == imagens[img])
                                {
                                    foi++;
                                }
                            }
                            if (foi < 2)
                            {
                                valido = true;
                                foi = 0;
                                for (int i = 0; i < 9; i++)
                                {
                                    if (jafoiImg[i] == 0)
                                    {
                                        jafoiImg[i] = imagens[img];
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                imagens[img] = 0;
                                img = 0;
                                valido = false;
                                foi = 0;
                            }
                        }
                    }
                    for (int i = 0; i < 9; i++)
                    {

                        if (jafoiImg[i] != 0)
                        {
                            foi++;
                        }
                    }
                    if (foi > 7)
                    {
                        todos = true;
                    }
                }


            for (int i = 0; i < 9; i++)
            {
                if (imagens[i] == 0)
                {
                    imagens[i] = 12;
                    jafoiImg[8] = 12;
                    break;
                }
            }


            for (int i = 0; i < 9; i++)
            {

                if (imagens[i] == 1)
                {
                    imagens[i] = aux[0];
                }
                else if (imagens[i] == 2)
                {
                    imagens[i] = aux[1];
                }
                else if (imagens[i] == 3)
                {
                    imagens[i] = aux[2];
                }
                else if (imagens[i] == 4)
                {
                    imagens[i] = aux[3];
                }
            

        }
}

        public void fimpartida()
        {

            if (pontos1 + pontos2 == 5)
            {

                if (pontos1 > pontos2)
                {
                    vencedor1++;
                    lblJ1G.Text = "Jogador 1 --  " + vencedor1;
                    DialogResult dialogResult = MessageBox.Show("Parabéns " + txtNome1.Text + " você venceu! Deseja conhecer como funciona uma impressora?", "A partida acabou!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (dialogResult == DialogResult.Yes){

                     frmHard1 tela_Hard1 = new frmHard1();
                     tela_Hard1.ShowDialog();
                 
                 }
                    

                }
                else
                {
                    vencedor2++;
                    lblJ2G.Text = "Jogador 2 --  " + vencedor2;
                    DialogResult dialogResult = MessageBox.Show("Parabéns " + txtNome2.Text + " você venceu! Deseja conhecer como funciona uma impressora?", "A partida acabou!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        frmHard1 tela_Hard1 = new frmHard1();
                        tela_Hard1.ShowDialog();

                    }

                }

            }

        }

        private void pctr1_Click(object sender, EventArgs e)
        {

            cliques++;
            pctr1.Enabled = false;

            if (imagens[0] == 1)
            {
                pctr1.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[0] == 2)
            {
                pctr1.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[0] == 3)
            {
                pctr1.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[0] == 4)
            {
                pctr1.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[0] == 5)
            {
                pctr1.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[0] == 6)
            {
                pctr1.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[0] == 7)
            {
                pctr1.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[0] == 8)
            {
                pctr1.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[0] == 9)
            {
                pctr1.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[0] == 10)
            {
                pctr1.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[0] == 11)
            {
                pctr1.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[0] == 12)
            {
                pctr1.Image = FirstPlei.Properties.Resources._12;
            }

            // AEEEEEEEE

            if (cliques == 1)
            {
                imagem1 = imagens[0];
                img1num = 1;

                if (imagens[0] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }

            }
            else if (cliques == 2)
            {

                imagem2 = imagens[0];
                img2num = 1;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;


                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;
                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {

                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();

        }
        private void pctr2_Click(object sender, EventArgs e)
        {

            cliques++;
            pctr2.Enabled = false;

            if (imagens[1] == 1)
            {
                pctr2.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[1] == 2)
            {
                pctr2.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[1] == 3)
            {
                pctr2.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[1] == 4)
            {
                pctr2.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[1] == 5)
            {
                pctr2.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[1] == 6)
            {
                pctr2.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[1] == 7)
            {
                pctr2.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[1] == 8)
            {
                pctr2.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[1] == 9)
            {
                pctr2.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[1] == 10)
            {
                pctr2.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[1] == 11)
            {
                pctr2.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[1] == 12)
            {
                pctr2.Image = FirstPlei.Properties.Resources._12;
            }
            if (cliques == 1)
            {
                imagem1 = imagens[1];
                img1num = 2;

                if (imagens[1] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }

            }
            else if (cliques == 2)
            {

                imagem2 = imagens[1];
                img2num = 2;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {

                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();
        }
        private void pctr3_Click(object sender, EventArgs e)
        {
            cliques++;
            pctr3.Enabled = false;

            if (imagens[2] == 1)
            {
                pctr3.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[2] == 2)
            {
                pctr3.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[2] == 3)
            {
                pctr3.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[2] == 4)
            {
                pctr3.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[2] == 5)
            {
                pctr3.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[2] == 6)
            {
                pctr3.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[2] == 7)
            {
                pctr3.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[2] == 8)
            {
                pctr3.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[2] == 9)
            {
                pctr3.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[2] == 10)
            {
                pctr3.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[2] == 11)
            {
                pctr3.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[2] == 12)
            {
                pctr3.Image = FirstPlei.Properties.Resources._12;
            }

            if (cliques == 1)
            {
                imagem1 = imagens[2];
                img1num = 3;

                if (imagens[2] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
            }
            else if (cliques == 2)
            {

                imagem2 = imagens[2];
                img2num = 3;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {

                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }


                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();
        }
        private void pctr4_Click(object sender, EventArgs e)
        {
            cliques++;
            pctr4.Enabled = false;

            if (imagens[3] == 1)
            {
                pctr4.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[3] == 2)
            {
                pctr4.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[3] == 3)
            {
                pctr4.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[3] == 4)
            {
                pctr4.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[3] == 5)
            {
                pctr4.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[3] == 6)
            {
                pctr4.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[3] == 7)
            {
                pctr4.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[3] == 8)
            {
                pctr4.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[3] == 9)
            {
                pctr4.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[3] == 10)
            {
                pctr4.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[3] == 11)
            {
                pctr4.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[3] == 12)
            {
                pctr4.Image = FirstPlei.Properties.Resources._12;
            }

            if (cliques == 1)
            {
                imagem1 = imagens[3];
                img1num = 4;

                if (imagens[3] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }

            }
            else if (cliques == 2)
            {

                imagem2 = imagens[3];
                img2num = 4;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();
        }
        private void pctr5_Click(object sender, EventArgs e)
        {
            cliques++;
            pctr5.Enabled = false;

            if (imagens[4] == 1)
            {
                pctr5.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[4] == 2)
            {
                pctr5.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[4] == 3)
            {
                pctr5.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[4] == 4)
            {
                pctr5.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[4] == 5)
            {
                pctr5.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[4] == 6)
            {
                pctr5.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[4] == 7)
            {
                pctr5.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[4] == 8)
            {
                pctr5.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[4] == 9)
            {
                pctr5.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[4] == 10)
            {
                pctr5.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[4] == 11)
            {
                pctr5.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[4] == 12)
            {
                pctr5.Image = FirstPlei.Properties.Resources._12;
            }

            if (cliques == 1)
            {
                imagem1 = imagens[4];
                img1num = 5;
                if (imagens[4] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }

            }
            else if (cliques == 2)
            {

                imagem2 = imagens[4];
                img2num = 5;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {

                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();
        }
        private void pctr6_Click(object sender, EventArgs e)
        {
            cliques++;
            pctr6.Enabled = false;

            if (imagens[5] == 1)
            {
                pctr6.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[5] == 2)
            {
                pctr6.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[5] == 3)
            {
                pctr6.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[5] == 4)
            {
                pctr6.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[5] == 5)
            {
                pctr6.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[5] == 6)
            {
                pctr6.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[5] == 7)
            {
                pctr6.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[5] == 8)
            {
                pctr6.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[5] == 9)
            {
                pctr6.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[5] == 10)
            {
                pctr6.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[5] == 11)
            {
                pctr6.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[5] == 12)
            {
                pctr6.Image = FirstPlei.Properties.Resources._12;
            }

            if (cliques == 1)
            {
                imagem1 = imagens[5];
                img1num = 6;
                if (imagens[5] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }

            }
            else if (cliques == 2)
            {

                imagem2 = imagens[5];
                img2num = 6;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {

                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }


                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();
        }
        private void pctr7_Click(object sender, EventArgs e)
        {
            cliques++;
            pctr7.Enabled = false;

            if (imagens[6] == 1)
            {
                pctr7.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[6] == 2)
            {
                pctr7.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[6] == 3)
            {
                pctr7.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[6] == 4)
            {
                pctr7.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[6] == 5)
            {
                pctr7.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[6] == 6)
            {
                pctr7.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[6] == 7)
            {
                pctr7.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[6] == 8)
            {
                pctr7.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[6] == 9)
            {
                pctr7.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[6] == 10)
            {
                pctr7.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[6] == 11)
            {
                pctr7.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[6] == 12)
            {
                pctr7.Image = FirstPlei.Properties.Resources._12;
            }

            if (cliques == 1)
            {
                imagem1 = imagens[6];
                img1num = 7;
                if (imagens[6] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
            }
            else if (cliques == 2)
            {

                imagem2 = imagens[6];
                img2num = 7;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {

                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }


                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();
        }
        private void pctr8_Click(object sender, EventArgs e)
        {
            cliques++;
            pctr8.Enabled = false;

            if (imagens[7] == 1)
            {
                pctr8.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[7] == 2)
            {
                pctr8.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[7] == 3)
            {
                pctr8.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[7] == 4)
            {
                pctr8.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[7] == 5)
            {
                pctr8.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[7] == 6)
            {
                pctr8.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[7] == 7)
            {
                pctr8.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[7] == 8)
            {
                pctr8.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[7] == 9)
            {
                pctr8.Image = FirstPlei.Properties.Resources._9;
            }
            else if (imagens[7] == 10)
            {
                pctr8.Image = FirstPlei.Properties.Resources._10;
            }
            else if (imagens[7] == 11)
            {
                pctr8.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[7] == 12)
            {
                pctr8.Image = FirstPlei.Properties.Resources._12;

            }

            if (cliques == 1)
            {
                imagem1 = imagens[7];
                img1num = 8;
                if (imagens[7] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }

            }
            else if (cliques == 2)
            {

                imagem2 = imagens[7];
                img2num = 8;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }


                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();
        }
        private void pctr9_Click(object sender, EventArgs e)
        {

            cliques++;
            pctr9.Enabled = false;

            if (imagens[8] == 1)
            {
                pctr9.Image = FirstPlei.Properties.Resources._1;
            }
            else if (imagens[8] == 2)
            {
                pctr9.Image = FirstPlei.Properties.Resources._2;
            }
            else if (imagens[8] == 3)
            {
                pctr9.Image = FirstPlei.Properties.Resources._3;
            }
            else if (imagens[8] == 4)
            {
                pctr9.Image = FirstPlei.Properties.Resources._4;
            }
            else if (imagens[8] == 5)
            {
                pctr9.Image = FirstPlei.Properties.Resources._5;
            }
            else if (imagens[8] == 6)
            {
                pctr9.Image = FirstPlei.Properties.Resources._6;
            }
            else if (imagens[8] == 7)
            {
                pctr9.Image = FirstPlei.Properties.Resources._7;
            }
            else if (imagens[8] == 8)
            {
                pctr9.Image = FirstPlei.Properties.Resources._8;
            }
            else if (imagens[8] == 9)
            {
                pctr9.Image = FirstPlei.Properties.Resources._9;

            }
            else if (imagens[8] == 10)
            {
                pctr9.Image = FirstPlei.Properties.Resources._10;

            }
            else if (imagens[8] == 11)
            {
                pctr9.Image = FirstPlei.Properties.Resources._11;
            }
            else if (imagens[8] == 12)
            {
                pctr9.Image = FirstPlei.Properties.Resources._12;
            }

            if (cliques == 1)
            {
                imagem1 = imagens[8];
                img1num = 9;
                if (imagens[8] == 12)
                {

                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "Carta coringa, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }

            }
            else if (cliques == 2)
            {

                imagem2 = imagens[8];
                img2num = 9;

                if (imagem1 == imagem2)
                {
                    cliques = imagem1 = imagem2 = img1num = img2num = 0;

                    if (vez == txtNome1.Text)
                    {

                        pontos1++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ1P.Text = "Jogador 1  --  " + pontos1;

                    }
                    else
                    {
                        pontos2++;
                        lblInfo.Text = "As imagens conhecidem, continue jogando " + vez;
                        lblJ2P.Text = "Jogador 2  --  " + pontos2;
                    }

                }
                else
                {
                    if (vez == txtNome1.Text)
                    {
                        vez = txtNome2.Text;
                    }
                    else
                    {
                        vez = txtNome1.Text;
                    }

                    lblInfo.Text = "As imagens não conhecidem. Vez de " + vez;

                    DialogResult dialogResult = MessageBox.Show("Infelizmente as imagens não conhecidem. Boa sorte na próxima!", "As imagens não conhecidem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {

                        if (img1num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img1num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img1num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img1num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img1num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img1num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img1num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img1num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img1num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }

                        if (img2num == 1)
                        {
                            pctr1.Image = FirstPlei.Properties.Resources.capa;
                            pctr1.Enabled = true;
                        }
                        else if (img2num == 2)
                        {
                            pctr2.Image = FirstPlei.Properties.Resources.capa;
                            pctr2.Enabled = true;
                        }
                        else if (img2num == 3)
                        {
                            pctr3.Image = FirstPlei.Properties.Resources.capa;
                            pctr3.Enabled = true;
                        }
                        else if (img2num == 4)
                        {
                            pctr4.Image = FirstPlei.Properties.Resources.capa;
                            pctr4.Enabled = true;
                        }
                        else if (img2num == 5)
                        {
                            pctr5.Image = FirstPlei.Properties.Resources.capa;
                            pctr5.Enabled = true;
                        }
                        else if (img2num == 6)
                        {
                            pctr6.Image = FirstPlei.Properties.Resources.capa;
                            pctr6.Enabled = true;
                        }
                        else if (img2num == 7)
                        {
                            pctr7.Image = FirstPlei.Properties.Resources.capa;
                            pctr7.Enabled = true;
                        }
                        else if (img2num == 8)
                        {
                            pctr8.Image = FirstPlei.Properties.Resources.capa;
                            pctr8.Enabled = true;
                        }
                        else if (img2num == 9)
                        {
                            pctr9.Image = FirstPlei.Properties.Resources.capa;
                            pctr9.Enabled = true;
                        }


                        cliques = imagem1 = imagem2 = img1num = img2num = 0;
                    }
                }
            }

            fimpartida();

        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            frmHard1 tela_Hard1 = new frmHard1();
            tela_Hard1.ShowDialog();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza quer voltar para o menu? Seu jogo será perdido!" , "Voltar para o menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
