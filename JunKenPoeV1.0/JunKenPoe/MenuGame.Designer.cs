namespace JunKenPoe
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mnOp = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMenuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spcPrinc = new System.Windows.Forms.SplitContainer();
            this.gpbPLACAR = new System.Windows.Forms.GroupBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblPCPU = new System.Windows.Forms.Label();
            this.lblPUsu = new System.Windows.Forms.Label();
            this.lblCPUP = new System.Windows.Forms.Label();
            this.lblUsuP = new System.Windows.Forms.Label();
            this.gpbCPU = new System.Windows.Forms.GroupBox();
            this.gpbUsu = new System.Windows.Forms.GroupBox();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.picUsu = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.mnOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrinc)).BeginInit();
            this.spcPrinc.Panel1.SuspendLayout();
            this.spcPrinc.Panel2.SuspendLayout();
            this.spcPrinc.SuspendLayout();
            this.gpbPLACAR.SuspendLayout();
            this.gpbCPU.SuspendLayout();
            this.gpbUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // mnOp
            // 
            this.mnOp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.frmMenuGame});
            this.mnOp.Location = new System.Drawing.Point(0, 0);
            this.mnOp.Name = "mnOp";
            this.mnOp.Size = new System.Drawing.Size(632, 24);
            this.mnOp.TabIndex = 0;
            this.mnOp.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMenuGame
            // 
            this.frmMenuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.frmMenuGame.Name = "frmMenuGame";
            this.frmMenuGame.Size = new System.Drawing.Size(52, 20);
            this.frmMenuGame.Text = "About";
            this.frmMenuGame.Click += new System.EventHandler(this.frmMenuGame_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // spcPrinc
            // 
            this.spcPrinc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPrinc.Location = new System.Drawing.Point(0, 24);
            this.spcPrinc.Name = "spcPrinc";
            this.spcPrinc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcPrinc.Panel1
            // 
            this.spcPrinc.Panel1.Controls.Add(this.gpbPLACAR);
            this.spcPrinc.Panel1.Controls.Add(this.gpbCPU);
            this.spcPrinc.Panel1.Controls.Add(this.gpbUsu);
            this.spcPrinc.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // spcPrinc.Panel2
            // 
            this.spcPrinc.Panel2.Controls.Add(this.btnTesoura);
            this.spcPrinc.Panel2.Controls.Add(this.btnPapel);
            this.spcPrinc.Panel2.Controls.Add(this.btnPedra);
            this.spcPrinc.Size = new System.Drawing.Size(632, 463);
            this.spcPrinc.SplitterDistance = 229;
            this.spcPrinc.TabIndex = 1;
            // 
            // gpbPLACAR
            // 
            this.gpbPLACAR.Controls.Add(this.lblX);
            this.gpbPLACAR.Controls.Add(this.lblPCPU);
            this.gpbPLACAR.Controls.Add(this.lblPUsu);
            this.gpbPLACAR.Controls.Add(this.lblCPUP);
            this.gpbPLACAR.Controls.Add(this.lblUsuP);
            this.gpbPLACAR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gpbPLACAR.Location = new System.Drawing.Point(210, 10);
            this.gpbPLACAR.Name = "gpbPLACAR";
            this.gpbPLACAR.Size = new System.Drawing.Size(200, 199);
            this.gpbPLACAR.TabIndex = 2;
            this.gpbPLACAR.TabStop = false;
            this.gpbPLACAR.Text = "PLACAR";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(89, 59);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(33, 32);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X";
            // 
            // lblPCPU
            // 
            this.lblPCPU.AutoSize = true;
            this.lblPCPU.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPCPU.Location = new System.Drawing.Point(151, 59);
            this.lblPCPU.Name = "lblPCPU";
            this.lblPCPU.Size = new System.Drawing.Size(30, 32);
            this.lblPCPU.TabIndex = 3;
            this.lblPCPU.Text = "0";
            // 
            // lblPUsu
            // 
            this.lblPUsu.AutoSize = true;
            this.lblPUsu.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUsu.Location = new System.Drawing.Point(36, 59);
            this.lblPUsu.Name = "lblPUsu";
            this.lblPUsu.Size = new System.Drawing.Size(30, 32);
            this.lblPUsu.TabIndex = 2;
            this.lblPUsu.Text = "0";
            this.lblPUsu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCPUP
            // 
            this.lblCPUP.AutoSize = true;
            this.lblCPUP.Location = new System.Drawing.Point(148, 32);
            this.lblCPUP.Name = "lblCPUP";
            this.lblCPUP.Size = new System.Drawing.Size(33, 16);
            this.lblCPUP.TabIndex = 1;
            this.lblCPUP.Text = "CPU";
            this.lblCPUP.Click += new System.EventHandler(this.lblCPUP_Click);
            // 
            // lblUsuP
            // 
            this.lblUsuP.AutoSize = true;
            this.lblUsuP.Location = new System.Drawing.Point(22, 32);
            this.lblUsuP.Name = "lblUsuP";
            this.lblUsuP.Size = new System.Drawing.Size(62, 16);
            this.lblUsuP.TabIndex = 0;
            this.lblUsuP.Text = "Jogador";
            this.lblUsuP.Click += new System.EventHandler(this.lblUsuP_Click);
            // 
            // gpbCPU
            // 
            this.gpbCPU.Controls.Add(this.picCPU);
            this.gpbCPU.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gpbCPU.Location = new System.Drawing.Point(421, 9);
            this.gpbCPU.Name = "gpbCPU";
            this.gpbCPU.Size = new System.Drawing.Size(209, 217);
            this.gpbCPU.TabIndex = 1;
            this.gpbCPU.TabStop = false;
            this.gpbCPU.Text = "CPU: ";
            this.gpbCPU.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // gpbUsu
            // 
            this.gpbUsu.Controls.Add(this.picUsu);
            this.gpbUsu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUsu.Location = new System.Drawing.Point(4, 9);
            this.gpbUsu.Name = "gpbUsu";
            this.gpbUsu.Size = new System.Drawing.Size(209, 217);
            this.gpbUsu.TabIndex = 0;
            this.gpbUsu.TabStop = false;
            this.gpbUsu.Text = "Jogador:";
            this.gpbUsu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::JunKenPoe.Properties.Resources.Tesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Location = new System.Drawing.Point(421, 19);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(200, 199);
            this.btnTesoura.TabIndex = 2;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::JunKenPoe.Properties.Resources.Papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(210, 19);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(205, 199);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::JunKenPoe.Properties.Resources.Pedra;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Location = new System.Drawing.Point(3, 19);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(200, 199);
            this.btnPedra.TabIndex = 0;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // picUsu
            // 
            this.picUsu.Location = new System.Drawing.Point(3, 18);
            this.picUsu.Name = "picUsu";
            this.picUsu.Size = new System.Drawing.Size(200, 199);
            this.picUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsu.TabIndex = 0;
            this.picUsu.TabStop = false;
            this.picUsu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picCPU
            // 
            this.picCPU.Location = new System.Drawing.Point(6, 18);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(200, 199);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 0;
            this.picCPU.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 487);
            this.Controls.Add(this.spcPrinc);
            this.Controls.Add(this.mnOp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnOp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "JOKENPO - V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnOp.ResumeLayout(false);
            this.mnOp.PerformLayout();
            this.spcPrinc.Panel1.ResumeLayout(false);
            this.spcPrinc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPrinc)).EndInit();
            this.spcPrinc.ResumeLayout(false);
            this.gpbPLACAR.ResumeLayout(false);
            this.gpbPLACAR.PerformLayout();
            this.gpbCPU.ResumeLayout(false);
            this.gpbUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnOp;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmMenuGame;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer spcPrinc;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.GroupBox gpbUsu;
        private System.Windows.Forms.GroupBox gpbCPU;
        private System.Windows.Forms.GroupBox gpbPLACAR;
        private System.Windows.Forms.Label lblUsuP;
        private System.Windows.Forms.Label lblCPUP;
        private System.Windows.Forms.Label lblPUsu;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblPCPU;
        private System.Windows.Forms.PictureBox picUsu;
        private System.Windows.Forms.PictureBox picCPU;
    }
}

