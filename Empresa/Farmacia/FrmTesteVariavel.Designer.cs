namespace Farmacia
{
    partial class FrmTesteVariavel
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
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblNCompleto = new System.Windows.Forms.Label();
            this.btnVerdadeiro = new System.Windows.Forms.Button();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.btnFalso = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(12, 11);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(113, 56);
            this.BtnMostrar.TabIndex = 0;
            this.BtnMostrar.Text = "&Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 94);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 58);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Location = new System.Drawing.Point(141, 11);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(306, 56);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMostrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNCompleto
            // 
            this.lblNCompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNCompleto.Location = new System.Drawing.Point(141, 94);
            this.lblNCompleto.Name = "lblNCompleto";
            this.lblNCompleto.Size = new System.Drawing.Size(306, 58);
            this.lblNCompleto.TabIndex = 3;
            this.lblNCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVerdadeiro
            // 
            this.btnVerdadeiro.Location = new System.Drawing.Point(12, 218);
            this.btnVerdadeiro.Name = "btnVerdadeiro";
            this.btnVerdadeiro.Size = new System.Drawing.Size(113, 58);
            this.btnVerdadeiro.TabIndex = 4;
            this.btnVerdadeiro.Text = "Verdadeiro";
            this.btnVerdadeiro.UseVisualStyleBackColor = true;
            this.btnVerdadeiro.Click += new System.EventHandler(this.btnBandeira_Click);
            // 
            // lblBandeira
            // 
            this.lblBandeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBandeira.Location = new System.Drawing.Point(141, 218);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(245, 58);
            this.lblBandeira.TabIndex = 5;
            // 
            // btnFalso
            // 
            this.btnFalso.Location = new System.Drawing.Point(12, 300);
            this.btnFalso.Name = "btnFalso";
            this.btnFalso.Size = new System.Drawing.Size(113, 58);
            this.btnFalso.TabIndex = 6;
            this.btnFalso.Text = "Falso";
            this.btnFalso.UseVisualStyleBackColor = true;
            this.btnFalso.Click += new System.EventHandler(this.btnFalso_Click);
            // 
            // lblNum
            // 
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(141, 295);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(79, 63);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "    ";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTesteVariavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 367);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnFalso);
            this.Controls.Add(this.lblBandeira);
            this.Controls.Add(this.btnVerdadeiro);
            this.Controls.Add(this.lblNCompleto);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTesteVariavel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Variavel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblNCompleto;
        private System.Windows.Forms.Button btnVerdadeiro;
        private System.Windows.Forms.Label lblBandeira;
        private System.Windows.Forms.Button btnFalso;
        private System.Windows.Forms.Label lblNum;
    }
}