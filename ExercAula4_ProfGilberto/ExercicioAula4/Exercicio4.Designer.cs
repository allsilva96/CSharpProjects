namespace ExercicioAula4
{
    partial class FrmAula4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdade2 = new System.Windows.Forms.Label();
            this.btnIdade = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblArea2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblxx2 = new System.Windows.Forms.Label();
            this.lblxx1 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.lblx1 = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lblIdade2);
            this.panel1.Controls.Add(this.btnIdade);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.txtAnoAtual);
            this.panel1.Controls.Add(this.lblAnoAtual);
            this.panel1.Controls.Add(this.txtAnoNasc);
            this.panel1.Controls.Add(this.lblAnoNasc);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 134);
            this.panel1.TabIndex = 0;
            // 
            // lblIdade2
            // 
            this.lblIdade2.AutoSize = true;
            this.lblIdade2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdade2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblIdade2.Location = new System.Drawing.Point(364, 43);
            this.lblIdade2.Name = "lblIdade2";
            this.lblIdade2.Size = new System.Drawing.Size(27, 22);
            this.lblIdade2.TabIndex = 6;
            this.lblIdade2.Text = "    ";
            this.lblIdade2.Click += new System.EventHandler(this.lblIdade2_Click);
            // 
            // btnIdade
            // 
            this.btnIdade.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnIdade.Location = new System.Drawing.Point(304, 85);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(87, 30);
            this.btnIdade.TabIndex = 5;
            this.btnIdade.Text = "Idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblIdade.Location = new System.Drawing.Point(300, 43);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(58, 20);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade:";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtAnoAtual.Location = new System.Drawing.Point(143, 85);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(100, 26);
            this.txtAnoAtual.TabIndex = 3;
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblAnoAtual.Location = new System.Drawing.Point(52, 85);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(85, 20);
            this.lblAnoAtual.TabIndex = 2;
            this.lblAnoAtual.Text = "Ano Atual:";
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtAnoNasc.Location = new System.Drawing.Point(143, 37);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(100, 26);
            this.txtAnoNasc.TabIndex = 1;
            this.txtAnoNasc.TextChanged += new System.EventHandler(this.txtAnoNasc_TextChanged);
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblAnoNasc.Location = new System.Drawing.Point(10, 39);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(134, 20);
            this.lblAnoNasc.TabIndex = 0;
            this.lblAnoNasc.Text = "Ano Nascimento:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.btnArea);
            this.panel2.Controls.Add(this.lblArea2);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.txtRaio);
            this.panel2.Controls.Add(this.lblRaio);
            this.panel2.Location = new System.Drawing.Point(5, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 156);
            this.panel2.TabIndex = 1;
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(234, 75);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(82, 31);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblArea2
            // 
            this.lblArea2.AutoSize = true;
            this.lblArea2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblArea2.Location = new System.Drawing.Point(294, 37);
            this.lblArea2.Name = "lblArea2";
            this.lblArea2.Size = new System.Drawing.Size(33, 20);
            this.lblArea2.TabIndex = 3;
            this.lblArea2.Text = "      ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblArea.Location = new System.Drawing.Point(231, 37);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(62, 20);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Área = ";
            // 
            // txtRaio
            // 
            this.txtRaio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtRaio.Location = new System.Drawing.Point(35, 58);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(105, 26);
            this.txtRaio.TabIndex = 1;
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblRaio.Location = new System.Drawing.Point(32, 32);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(112, 20);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Valor do Raio:";
            this.lblRaio.Click += new System.EventHandler(this.lblRaio_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.lblxx2);
            this.panel3.Controls.Add(this.lblxx1);
            this.panel3.Controls.Add(this.lblx2);
            this.panel3.Controls.Add(this.lblx1);
            this.panel3.Controls.Add(this.btnCalcula);
            this.panel3.Controls.Add(this.txtC);
            this.panel3.Controls.Add(this.lblC);
            this.panel3.Controls.Add(this.txtB);
            this.panel3.Controls.Add(this.lblB);
            this.panel3.Controls.Add(this.txtA);
            this.panel3.Controls.Add(this.lblA);
            this.panel3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.panel3.Location = new System.Drawing.Point(7, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 217);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblxx2
            // 
            this.lblxx2.AutoSize = true;
            this.lblxx2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblxx2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblxx2.Location = new System.Drawing.Point(302, 135);
            this.lblxx2.Name = "lblxx2";
            this.lblxx2.Size = new System.Drawing.Size(35, 22);
            this.lblxx2.TabIndex = 10;
            this.lblxx2.Text = "      ";
            // 
            // lblxx1
            // 
            this.lblxx1.AutoSize = true;
            this.lblxx1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblxx1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblxx1.Location = new System.Drawing.Point(302, 51);
            this.lblxx1.Name = "lblxx1";
            this.lblxx1.Size = new System.Drawing.Size(31, 22);
            this.lblxx1.TabIndex = 9;
            this.lblxx1.Text = "     ";
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx2.Location = new System.Drawing.Point(267, 136);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(43, 20);
            this.lblx2.TabIndex = 8;
            this.lblx2.Text = "X2 = ";
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblx1.Location = new System.Drawing.Point(267, 53);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(39, 20);
            this.lblx1.TabIndex = 7;
            this.lblx1.Text = "X1 =";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCalcula.Location = new System.Drawing.Point(166, 81);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 29);
            this.btnCalcula.TabIndex = 6;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtC.Location = new System.Drawing.Point(38, 123);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 26);
            this.txtC.TabIndex = 5;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblC.Location = new System.Drawing.Point(17, 123);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(21, 20);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "C";
            this.lblC.Click += new System.EventHandler(this.lblC_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtB.Location = new System.Drawing.Point(38, 81);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblB.Location = new System.Drawing.Point(17, 84);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 20);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtA.Location = new System.Drawing.Point(38, 38);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblA.Location = new System.Drawing.Point(17, 38);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médiaToolStripMenuItem,
            this.salárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.projectsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // médiaToolStripMenuItem
            // 
            this.médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            this.médiaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.médiaToolStripMenuItem.Text = "Média";
            this.médiaToolStripMenuItem.Click += new System.EventHandler(this.médiaToolStripMenuItem_Click);
            // 
            // salárioToolStripMenuItem
            // 
            this.salárioToolStripMenuItem.Name = "salárioToolStripMenuItem";
            this.salárioToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.salárioToolStripMenuItem.Text = "Salário";
            this.salárioToolStripMenuItem.Click += new System.EventHandler(this.salárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmAula4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 543);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAula4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio Aula 4 V1.0.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdade2;
        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblArea2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblxx2;
        private System.Windows.Forms.Label lblxx1;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

