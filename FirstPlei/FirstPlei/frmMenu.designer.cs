namespace FirstPlei
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuLinks = new System.Windows.Forms.Panel();
            this.lblBtnCred = new System.Windows.Forms.Label();
            this.lblBtnVelha = new System.Windows.Forms.Label();
            this.lblBtnMemo = new System.Windows.Forms.Label();
            this.lblBtnSudoku = new System.Windows.Forms.Label();
            this.pnlMenuLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(559, 541);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlMenuLinks
            // 
            this.pnlMenuLinks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMenuLinks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenuLinks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenuLinks.BackgroundImage")));
            this.pnlMenuLinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMenuLinks.Controls.Add(this.lblBtnCred);
            this.pnlMenuLinks.Controls.Add(this.lblBtnVelha);
            this.pnlMenuLinks.Controls.Add(this.lblBtnMemo);
            this.pnlMenuLinks.Controls.Add(this.lblBtnSudoku);
            this.pnlMenuLinks.Location = new System.Drawing.Point(19, 17);
            this.pnlMenuLinks.Name = "pnlMenuLinks";
            this.pnlMenuLinks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlMenuLinks.Size = new System.Drawing.Size(521, 506);
            this.pnlMenuLinks.TabIndex = 9;
            // 
            // lblBtnCred
            // 
            this.lblBtnCred.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnCred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnCred.Location = new System.Drawing.Point(9, 460);
            this.lblBtnCred.Name = "lblBtnCred";
            this.lblBtnCred.Size = new System.Drawing.Size(499, 36);
            this.lblBtnCred.TabIndex = 3;
            this.lblBtnCred.Click += new System.EventHandler(this.lblBtnCred_Click);
            // 
            // lblBtnVelha
            // 
            this.lblBtnVelha.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnVelha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnVelha.Location = new System.Drawing.Point(265, 329);
            this.lblBtnVelha.Name = "lblBtnVelha";
            this.lblBtnVelha.Size = new System.Drawing.Size(245, 122);
            this.lblBtnVelha.TabIndex = 2;
            this.lblBtnVelha.Click += new System.EventHandler(this.lblBtnVelha_Click);
            // 
            // lblBtnMemo
            // 
            this.lblBtnMemo.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnMemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnMemo.Location = new System.Drawing.Point(12, 329);
            this.lblBtnMemo.Name = "lblBtnMemo";
            this.lblBtnMemo.Size = new System.Drawing.Size(245, 122);
            this.lblBtnMemo.TabIndex = 1;
            this.lblBtnMemo.Click += new System.EventHandler(this.lblBtnMemo_Click);
            // 
            // lblBtnSudoku
            // 
            this.lblBtnSudoku.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnSudoku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnSudoku.Location = new System.Drawing.Point(11, 196);
            this.lblBtnSudoku.Name = "lblBtnSudoku";
            this.lblBtnSudoku.Size = new System.Drawing.Size(499, 124);
            this.lblBtnSudoku.TabIndex = 0;
            this.lblBtnSudoku.Click += new System.EventHandler(this.lblBtnSudoku_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(559, 541);
            this.Controls.Add(this.pnlMenuLinks);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(575, 580);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstPlei - Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fechatudo);
            this.pnlMenuLinks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMenuLinks;
        private System.Windows.Forms.Label lblBtnCred;
        private System.Windows.Forms.Label lblBtnVelha;
        private System.Windows.Forms.Label lblBtnMemo;
        private System.Windows.Forms.Label lblBtnSudoku;


    }
}