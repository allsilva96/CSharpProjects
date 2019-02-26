namespace PictureBoxZoom
{
    partial class FrmZoom
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcontar = new System.Windows.Forms.Label();
            this.btnZoom2 = new System.Windows.Forms.Button();
            this.btnOrig = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.lblClq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureBoxZoom.Properties.Resources.inglaterra;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblClq);
            this.panel1.Controls.Add(this.lblcontar);
            this.panel1.Controls.Add(this.btnZoom2);
            this.panel1.Controls.Add(this.btnOrig);
            this.panel1.Controls.Add(this.btnZoom);
            this.panel1.Location = new System.Drawing.Point(2, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 38);
            this.panel1.TabIndex = 1;
            // 
            // lblcontar
            // 
            this.lblcontar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcontar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontar.ForeColor = System.Drawing.Color.White;
            this.lblcontar.Location = new System.Drawing.Point(237, 5);
            this.lblcontar.Name = "lblcontar";
            this.lblcontar.Size = new System.Drawing.Size(68, 30);
            this.lblcontar.TabIndex = 3;
            this.lblcontar.Text = "0";
            this.lblcontar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcontar.Click += new System.EventHandler(this.lblcontar_Click);
            // 
            // btnZoom2
            // 
            this.btnZoom2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnZoom2.Location = new System.Drawing.Point(10, 5);
            this.btnZoom2.Name = "btnZoom2";
            this.btnZoom2.Size = new System.Drawing.Size(107, 30);
            this.btnZoom2.TabIndex = 2;
            this.btnZoom2.Text = "Zoom -";
            this.btnZoom2.UseVisualStyleBackColor = true;
            this.btnZoom2.Click += new System.EventHandler(this.btnZoom2_Click);
            // 
            // btnOrig
            // 
            this.btnOrig.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnOrig.Location = new System.Drawing.Point(463, 5);
            this.btnOrig.Name = "btnOrig";
            this.btnOrig.Size = new System.Drawing.Size(113, 30);
            this.btnOrig.TabIndex = 1;
            this.btnOrig.Text = "Tamanho Original";
            this.btnOrig.UseVisualStyleBackColor = true;
            this.btnOrig.Click += new System.EventHandler(this.btnOrig_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnZoom.Location = new System.Drawing.Point(123, 5);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(108, 30);
            this.btnZoom.TabIndex = 0;
            this.btnZoom.Text = "Zoom +";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // lblClq
            // 
            this.lblClq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClq.ForeColor = System.Drawing.Color.White;
            this.lblClq.Location = new System.Drawing.Point(311, 5);
            this.lblClq.Name = "lblClq";
            this.lblClq.Size = new System.Drawing.Size(100, 30);
            this.lblClq.TabIndex = 4;
            this.lblClq.Text = "Clique(s)";
            this.lblClq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expande Imagem e Conta Cliques";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnZoom2;
        private System.Windows.Forms.Button btnOrig;
        private System.Windows.Forms.Label lblcontar;
        private System.Windows.Forms.Label lblClq;
    }
}

