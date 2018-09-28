namespace Sexta8Semestre
{
    partial class s01_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s01_Welcome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.llblCickToGo = new System.Windows.Forms.LinkLabel();
            this.pbLoadText = new System.Windows.Forms.PictureBox();
            this.pClickToGo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadText)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 40F);
            this.lblWelcome.Location = new System.Drawing.Point(200, 336);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(699, 80);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Seja Bem-Vindo (a)";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // llblCickToGo
            // 
            this.llblCickToGo.AutoSize = true;
            this.llblCickToGo.Font = new System.Drawing.Font("Verdana", 20F);
            this.llblCickToGo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblCickToGo.LinkColor = System.Drawing.Color.Black;
            this.llblCickToGo.Location = new System.Drawing.Point(216, 448);
            this.llblCickToGo.Name = "llblCickToGo";
            this.llblCickToGo.Size = new System.Drawing.Size(656, 41);
            this.llblCickToGo.TabIndex = 1;
            this.llblCickToGo.TabStop = true;
            this.llblCickToGo.Text = "Clique para acessar o menu de vagas";
            this.llblCickToGo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCickToGo_LinkClicked);
            // 
            // pbLoadText
            // 
            this.pbLoadText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLoadText.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadText.Image")));
            this.pbLoadText.Location = new System.Drawing.Point(968, 240);
            this.pbLoadText.Name = "pbLoadText";
            this.pbLoadText.Size = new System.Drawing.Size(392, 272);
            this.pbLoadText.TabIndex = 2;
            this.pbLoadText.TabStop = false;
            this.pbLoadText.Click += new System.EventHandler(this.pbLoadText_Click);
            // 
            // pClickToGo
            // 
            this.pClickToGo.Location = new System.Drawing.Point(0, 0);
            this.pClickToGo.Name = "pClickToGo";
            this.pClickToGo.Size = new System.Drawing.Size(1400, 768);
            this.pClickToGo.TabIndex = 3;
            this.pClickToGo.Click += new System.EventHandler(this.pClickToGo_Click);
            // 
            // s01_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1406, 778);
            this.Controls.Add(this.pbLoadText);
            this.Controls.Add(this.llblCickToGo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pClickToGo);
            this.Name = "s01_Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s01_Welcome";
            this.Load += new System.EventHandler(this.s01_Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel llblCickToGo;
        private System.Windows.Forms.PictureBox pbLoadText;
        private System.Windows.Forms.Panel pClickToGo;
    }
}