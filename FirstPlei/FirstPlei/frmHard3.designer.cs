namespace FirstPlei
{
    partial class frmHard3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHard3));
            this.lblAnterior = new System.Windows.Forms.Label();
            this.lblProxima = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnterior
            // 
            this.lblAnterior.BackColor = System.Drawing.Color.Transparent;
            this.lblAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAnterior.Location = new System.Drawing.Point(33, 545);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(45, 45);
            this.lblAnterior.TabIndex = 7;
            this.lblAnterior.Click += new System.EventHandler(this.lblAnterior_Click);
            // 
            // lblProxima
            // 
            this.lblProxima.BackColor = System.Drawing.Color.Transparent;
            this.lblProxima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProxima.Location = new System.Drawing.Point(830, 546);
            this.lblProxima.Name = "lblProxima";
            this.lblProxima.Size = new System.Drawing.Size(45, 45);
            this.lblProxima.TabIndex = 6;
            this.lblProxima.Click += new System.EventHandler(this.lblProxima_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.BackColor = System.Drawing.Color.Transparent;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Location = new System.Drawing.Point(830, 26);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(45, 45);
            this.lblFechar.TabIndex = 5;
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // frmHard3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(905, 615);
            this.Controls.Add(this.lblAnterior);
            this.Controls.Add(this.lblProxima);
            this.Controls.Add(this.lblFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHard3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FisrtPlei - Impressora III";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Label lblProxima;
        private System.Windows.Forms.Label lblFechar;
    }
}