namespace FirstPlei
{
    partial class frm_Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Splash));
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlCarregando = new System.Windows.Forms.Panel();
            this.pctrCarregando = new System.Windows.Forms.PictureBox();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.pnlRodape.SuspendLayout();
            this.pnlCarregando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.pnlCarregando);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 386);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(850, 114);
            this.pnlRodape.TabIndex = 0;
            // 
            // pnlCarregando
            // 
            this.pnlCarregando.Controls.Add(this.pctrCarregando);
            this.pnlCarregando.Controls.Add(this.lblCarregando);
            this.pnlCarregando.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCarregando.Location = new System.Drawing.Point(607, 0);
            this.pnlCarregando.Name = "pnlCarregando";
            this.pnlCarregando.Size = new System.Drawing.Size(243, 114);
            this.pnlCarregando.TabIndex = 0;
            // 
            // pctrCarregando
            // 
            this.pctrCarregando.Image = ((System.Drawing.Image)(resources.GetObject("pctrCarregando.Image")));
            this.pctrCarregando.Location = new System.Drawing.Point(98, 69);
            this.pctrCarregando.Name = "pctrCarregando";
            this.pctrCarregando.Size = new System.Drawing.Size(24, 22);
            this.pctrCarregando.TabIndex = 1;
            this.pctrCarregando.TabStop = false;
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCarregando.Location = new System.Drawing.Point(18, 73);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(77, 13);
            this.lblCarregando.TabIndex = 0;
            this.lblCarregando.Text = "CARREGANDO";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 5000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash__Tick);
            // 
            // frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.pnlRodape);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlRodape.ResumeLayout(false);
            this.pnlCarregando.ResumeLayout(false);
            this.pnlCarregando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCarregando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Panel pnlCarregando;
        private System.Windows.Forms.PictureBox pctrCarregando;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Timer tmrSplash;
    }
}

