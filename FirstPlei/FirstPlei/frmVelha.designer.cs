namespace FirstPlei
{
    partial class frm_Velha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Velha));
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlVoltarMenu = new System.Windows.Forms.Panel();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.grpPlacar = new System.Windows.Forms.GroupBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtNomeO = new System.Windows.Forms.TextBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.txtNomeX = new System.Windows.Forms.TextBox();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pctrLogoSudoku = new System.Windows.Forms.PictureBox();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            this.pnlVoltarMenu.SuspendLayout();
            this.grpPlacar.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogoSudoku)).BeginInit();
            this.pnlCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.White;
            this.pnlLateral.Controls.Add(this.pnlVoltarMenu);
            this.pnlLateral.Controls.Add(this.grpPlacar);
            this.pnlLateral.Controls.Add(this.btnNovoJogo);
            this.pnlLateral.Controls.Add(this.lblInfo);
            this.pnlLateral.Controls.Add(this.btnReiniciar);
            this.pnlLateral.Controls.Add(this.txtNomeO);
            this.pnlLateral.Controls.Add(this.btnComecar);
            this.pnlLateral.Controls.Add(this.txtNomeX);
            this.pnlLateral.Controls.Add(this.pnlCabecalho);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(295, 652);
            this.pnlLateral.TabIndex = 0;
            // 
            // pnlVoltarMenu
            // 
            this.pnlVoltarMenu.Controls.Add(this.btnVoltarMenu);
            this.pnlVoltarMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlVoltarMenu.Location = new System.Drawing.Point(0, 608);
            this.pnlVoltarMenu.Name = "pnlVoltarMenu";
            this.pnlVoltarMenu.Size = new System.Drawing.Size(295, 44);
            this.pnlVoltarMenu.TabIndex = 15;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltarMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVoltarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVoltarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltarMenu.Location = new System.Drawing.Point(11, 3);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(272, 30);
            this.btnVoltarMenu.TabIndex = 7;
            this.btnVoltarMenu.Text = "Voltar para o menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // grpPlacar
            // 
            this.grpPlacar.Controls.Add(this.lblE);
            this.grpPlacar.Controls.Add(this.lblO);
            this.grpPlacar.Controls.Add(this.lblX);
            this.grpPlacar.Enabled = false;
            this.grpPlacar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlacar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpPlacar.Location = new System.Drawing.Point(10, 273);
            this.grpPlacar.Name = "grpPlacar";
            this.grpPlacar.Size = new System.Drawing.Size(272, 86);
            this.grpPlacar.TabIndex = 14;
            this.grpPlacar.TabStop = false;
            this.grpPlacar.Text = "Placar";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblE.Location = new System.Drawing.Point(6, 62);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(57, 16);
            this.lblE.TabIndex = 2;
            this.lblE.Text = "Empates";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblO.Location = new System.Drawing.Point(6, 41);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(66, 16);
            this.lblO.TabIndex = 1;
            this.lblO.Text = "Jogador O";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblX.Location = new System.Drawing.Point(6, 20);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(65, 16);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Jogador X";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovoJogo.Enabled = false;
            this.btnNovoJogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNovoJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNovoJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovoJogo.Location = new System.Drawing.Point(10, 237);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(272, 30);
            this.btnNovoJogo.TabIndex = 13;
            this.btnNovoJogo.TabStop = false;
            this.btnNovoJogo.Text = "Novo jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo.Location = new System.Drawing.Point(10, 365);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(272, 47);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Começe a jogar";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReiniciar.Location = new System.Drawing.Point(10, 201);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(272, 30);
            this.btnReiniciar.TabIndex = 11;
            this.btnReiniciar.TabStop = false;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtNomeO
            // 
            this.txtNomeO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeO.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeO.Location = new System.Drawing.Point(10, 135);
            this.txtNomeO.Margin = new System.Windows.Forms.Padding(10);
            this.txtNomeO.Name = "txtNomeO";
            this.txtNomeO.Size = new System.Drawing.Size(272, 20);
            this.txtNomeO.TabIndex = 2;
            this.txtNomeO.Text = "Digite o nome do jogador O";
            this.txtNomeO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeO.Enter += new System.EventHandler(this.txtNomeO_Enter);
            this.txtNomeO.Leave += new System.EventHandler(this.txtNomeO_Leave);
            // 
            // btnComecar
            // 
            this.btnComecar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComecar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnComecar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComecar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnComecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComecar.Location = new System.Drawing.Point(10, 165);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(272, 30);
            this.btnComecar.TabIndex = 0;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // txtNomeX
            // 
            this.txtNomeX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeX.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeX.Location = new System.Drawing.Point(10, 108);
            this.txtNomeX.Margin = new System.Windows.Forms.Padding(10);
            this.txtNomeX.Name = "txtNomeX";
            this.txtNomeX.Size = new System.Drawing.Size(272, 20);
            this.txtNomeX.TabIndex = 1;
            this.txtNomeX.Text = "Digite o nome do jogador X";
            this.txtNomeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeX.Enter += new System.EventHandler(this.txtNomeX_Enter);
            this.txtNomeX.Leave += new System.EventHandler(this.txtNomeX_Leave);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Controls.Add(this.pctrLogoSudoku);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(295, 103);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // pctrLogoSudoku
            // 
            this.pctrLogoSudoku.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctrLogoSudoku.Image = ((System.Drawing.Image)(resources.GetObject("pctrLogoSudoku.Image")));
            this.pctrLogoSudoku.Location = new System.Drawing.Point(0, 0);
            this.pctrLogoSudoku.Name = "pctrLogoSudoku";
            this.pctrLogoSudoku.Size = new System.Drawing.Size(295, 102);
            this.pctrLogoSudoku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogoSudoku.TabIndex = 0;
            this.pctrLogoSudoku.TabStop = false;
            // 
            // pnlCentro
            // 
            this.pnlCentro.Controls.Add(this.btn9);
            this.pnlCentro.Controls.Add(this.btn8);
            this.pnlCentro.Controls.Add(this.btn7);
            this.pnlCentro.Controls.Add(this.btn6);
            this.pnlCentro.Controls.Add(this.btn5);
            this.pnlCentro.Controls.Add(this.btn4);
            this.pnlCentro.Controls.Add(this.btn3);
            this.pnlCentro.Controls.Add(this.btn2);
            this.pnlCentro.Controls.Add(this.btn1);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Enabled = false;
            this.pnlCentro.Location = new System.Drawing.Point(295, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(657, 652);
            this.pnlCentro.TabIndex = 1;
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(434, 432);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(200, 200);
            this.btn9.TabIndex = 60;
            this.btn9.TabStop = false;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.clique);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(228, 432);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(200, 200);
            this.btn8.TabIndex = 59;
            this.btn8.TabStop = false;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.clique);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(22, 432);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(200, 200);
            this.btn7.TabIndex = 58;
            this.btn7.TabStop = false;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.clique);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(434, 226);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(200, 200);
            this.btn6.TabIndex = 57;
            this.btn6.TabStop = false;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.clique);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(228, 226);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(200, 200);
            this.btn5.TabIndex = 56;
            this.btn5.TabStop = false;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.clique);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(22, 226);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(200, 200);
            this.btn4.TabIndex = 55;
            this.btn4.TabStop = false;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.clique);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(434, 20);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 200);
            this.btn3.TabIndex = 54;
            this.btn3.TabStop = false;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.clique);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(228, 20);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 200);
            this.btn2.TabIndex = 53;
            this.btn2.TabStop = false;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.clique);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(22, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 200);
            this.btn1.TabIndex = 52;
            this.btn1.TabStop = false;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.clique);
            // 
            // frm_Velha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 652);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.pnlLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(968, 690);
            this.Name = "frm_Velha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstPlei - Jogo da velha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fechatudo);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.pnlVoltarMenu.ResumeLayout(false);
            this.grpPlacar.ResumeLayout(false);
            this.grpPlacar.PerformLayout();
            this.pnlCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogoSudoku)).EndInit();
            this.pnlCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.PictureBox pctrLogoSudoku;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.TextBox txtNomeX;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.TextBox txtNomeO;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.GroupBox grpPlacar;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel pnlVoltarMenu;
        private System.Windows.Forms.Button btnVoltarMenu;
    }
}