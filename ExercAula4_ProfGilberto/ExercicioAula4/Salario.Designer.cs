namespace ExercicioAula4
{
    partial class frmSalario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblNvSal = new System.Windows.Forms.Label();
            this.lblNvSal2 = new System.Windows.Forms.Label();
            this.btnA5 = new System.Windows.Forms.Button();
            this.btnA10 = new System.Windows.Forms.Button();
            this.btnA15 = new System.Windows.Forms.Button();
            this.btnA20 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.telaInicialToolStripMenuItem});
            this.projectsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.mediaToolStripMenuItem.Text = "Media";
            this.mediaToolStripMenuItem.Click += new System.EventHandler(this.mediaToolStripMenuItem_Click);
            // 
            // telaInicialToolStripMenuItem
            // 
            this.telaInicialToolStripMenuItem.Name = "telaInicialToolStripMenuItem";
            this.telaInicialToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.telaInicialToolStripMenuItem.Text = "Tela Inicial";
            this.telaInicialToolStripMenuItem.Click += new System.EventHandler(this.telaInicialToolStripMenuItem_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblSalario.Location = new System.Drawing.Point(13, 46);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(65, 20);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário: ";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSalario.Location = new System.Drawing.Point(16, 69);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(115, 26);
            this.txtSalario.TabIndex = 2;
            // 
            // lblNvSal
            // 
            this.lblNvSal.AutoSize = true;
            this.lblNvSal.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNvSal.Location = new System.Drawing.Point(12, 290);
            this.lblNvSal.Name = "lblNvSal";
            this.lblNvSal.Size = new System.Drawing.Size(119, 20);
            this.lblNvSal.TabIndex = 3;
            this.lblNvSal.Text = "Novo Salário = ";
            // 
            // lblNvSal2
            // 
            this.lblNvSal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNvSal2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNvSal2.Location = new System.Drawing.Point(126, 290);
            this.lblNvSal2.Name = "lblNvSal2";
            this.lblNvSal2.Size = new System.Drawing.Size(192, 23);
            this.lblNvSal2.TabIndex = 4;
            // 
            // btnA5
            // 
            this.btnA5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnA5.Location = new System.Drawing.Point(231, 42);
            this.btnA5.Name = "btnA5";
            this.btnA5.Size = new System.Drawing.Size(159, 35);
            this.btnA5.TabIndex = 5;
            this.btnA5.Text = "Aumento 5%";
            this.btnA5.UseVisualStyleBackColor = true;
            this.btnA5.Click += new System.EventHandler(this.btnA5_Click);
            // 
            // btnA10
            // 
            this.btnA10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnA10.Location = new System.Drawing.Point(231, 83);
            this.btnA10.Name = "btnA10";
            this.btnA10.Size = new System.Drawing.Size(159, 36);
            this.btnA10.TabIndex = 6;
            this.btnA10.Text = "Aumento 10%";
            this.btnA10.UseVisualStyleBackColor = true;
            this.btnA10.Click += new System.EventHandler(this.btnA10_Click);
            // 
            // btnA15
            // 
            this.btnA15.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnA15.Location = new System.Drawing.Point(231, 125);
            this.btnA15.Name = "btnA15";
            this.btnA15.Size = new System.Drawing.Size(159, 36);
            this.btnA15.TabIndex = 7;
            this.btnA15.Text = "Aumento 15%";
            this.btnA15.UseVisualStyleBackColor = true;
            this.btnA15.Click += new System.EventHandler(this.btnA15_Click);
            // 
            // btnA20
            // 
            this.btnA20.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnA20.Location = new System.Drawing.Point(231, 167);
            this.btnA20.Name = "btnA20";
            this.btnA20.Size = new System.Drawing.Size(159, 34);
            this.btnA20.TabIndex = 8;
            this.btnA20.Text = "Aumento 20%";
            this.btnA20.UseVisualStyleBackColor = true;
            this.btnA20.Click += new System.EventHandler(this.btnA20_Click);
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(478, 335);
            this.Controls.Add(this.btnA20);
            this.Controls.Add(this.btnA15);
            this.Controls.Add(this.btnA10);
            this.Controls.Add(this.btnA5);
            this.Controls.Add(this.lblNvSal2);
            this.Controls.Add(this.lblNvSal);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salário V 1.0.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalario_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaInicialToolStripMenuItem;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblNvSal;
        private System.Windows.Forms.Label lblNvSal2;
        private System.Windows.Forms.Button btnA5;
        private System.Windows.Forms.Button btnA10;
        private System.Windows.Forms.Button btnA15;
        private System.Windows.Forms.Button btnA20;
    }
}