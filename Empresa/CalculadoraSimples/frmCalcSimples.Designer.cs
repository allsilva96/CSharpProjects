namespace CalculadoraSimples
{
    partial class FrmCalcSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalcSimples));
            this.lblResultado = new System.Windows.Forms.Label();
            this.gpbCalcSim = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAd = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.gpbCalcSim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(0, 268);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(171, 32);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpbCalcSim
            // 
            this.gpbCalcSim.Controls.Add(this.lblResult);
            this.gpbCalcSim.Controls.Add(this.btnExit);
            this.gpbCalcSim.Controls.Add(this.btnLimp);
            this.gpbCalcSim.Controls.Add(this.btnDiv);
            this.gpbCalcSim.Controls.Add(this.btnMult);
            this.gpbCalcSim.Controls.Add(this.btnSub);
            this.gpbCalcSim.Controls.Add(this.btnAd);
            this.gpbCalcSim.Controls.Add(this.txtnum2);
            this.gpbCalcSim.Controls.Add(this.lblnum2);
            this.gpbCalcSim.Controls.Add(this.txtnum1);
            this.gpbCalcSim.Controls.Add(this.lblnum1);
            this.gpbCalcSim.Controls.Add(this.lblResultado);
            this.gpbCalcSim.Location = new System.Drawing.Point(12, 12);
            this.gpbCalcSim.Name = "gpbCalcSim";
            this.gpbCalcSim.Size = new System.Drawing.Size(171, 302);
            this.gpbCalcSim.TabIndex = 1;
            this.gpbCalcSim.TabStop = false;
            this.gpbCalcSim.Text = "Calculadora";
            this.gpbCalcSim.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblResult.Location = new System.Drawing.Point(0, 251);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 17);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Resultado:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(107, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.BackColor = System.Drawing.Color.DimGray;
            this.btnLimp.FlatAppearance.BorderSize = 2;
            this.btnLimp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnLimp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLimp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.ForeColor = System.Drawing.Color.White;
            this.btnLimp.Location = new System.Drawing.Point(107, 131);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(42, 39);
            this.btnLimp.TabIndex = 9;
            this.btnLimp.Text = "C";
            this.btnLimp.UseVisualStyleBackColor = false;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.DimGray;
            this.btnDiv.FlatAppearance.BorderSize = 2;
            this.btnDiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(59, 196);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(42, 39);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.DimGray;
            this.btnMult.FlatAppearance.BorderSize = 2;
            this.btnMult.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnMult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMult.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.White;
            this.btnMult.Location = new System.Drawing.Point(11, 196);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(42, 39);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.DimGray;
            this.btnSub.FlatAppearance.BorderSize = 2;
            this.btnSub.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSub.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(58, 131);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(42, 39);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAd
            // 
            this.btnAd.BackColor = System.Drawing.Color.DimGray;
            this.btnAd.FlatAppearance.BorderSize = 2;
            this.btnAd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnAd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAd.ForeColor = System.Drawing.Color.White;
            this.btnAd.Location = new System.Drawing.Point(10, 131);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(42, 39);
            this.btnAd.TabIndex = 5;
            this.btnAd.Text = "+";
            this.btnAd.UseVisualStyleBackColor = false;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(10, 94);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(147, 23);
            this.txtnum2.TabIndex = 4;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(7, 77);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(80, 17);
            this.lblnum2.TabIndex = 3;
            this.lblnum2.Text = "2º Número:";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(10, 50);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(147, 23);
            this.txtnum1.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(7, 30);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(80, 17);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "1º Número:";
            // 
            // FrmCalcSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 318);
            this.Controls.Add(this.gpbCalcSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caculadora V 1.0.0";
            this.Load += new System.EventHandler(this.FrmCalcSimples_Load);
            this.gpbCalcSim.ResumeLayout(false);
            this.gpbCalcSim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gpbCalcSim;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblResult;
    }
}

