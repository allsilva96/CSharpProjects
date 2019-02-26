namespace CalculadoraSimples
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.gpoOperador = new System.Windows.Forms.GroupBox();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbMult = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpoOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(20, 166);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(279, 23);
            this.txtnum2.TabIndex = 8;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(16, 143);
            this.lblnum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(80, 17);
            this.lblnum2.TabIndex = 7;
            this.lblnum2.Text = "2º Número:";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(20, 38);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(279, 23);
            this.txtnum1.TabIndex = 6;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(16, 12);
            this.lblnum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(80, 17);
            this.lblnum1.TabIndex = 5;
            this.lblnum1.Text = "1º Número:";
            // 
            // gpoOperador
            // 
            this.gpoOperador.Controls.Add(this.rdbDiv);
            this.gpoOperador.Controls.Add(this.rdbMult);
            this.gpoOperador.Controls.Add(this.rdbSub);
            this.gpoOperador.Controls.Add(this.rdbAdicao);
            this.gpoOperador.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gpoOperador.Location = new System.Drawing.Point(20, 256);
            this.gpoOperador.Margin = new System.Windows.Forms.Padding(4);
            this.gpoOperador.Name = "gpoOperador";
            this.gpoOperador.Padding = new System.Windows.Forms.Padding(4);
            this.gpoOperador.Size = new System.Drawing.Size(280, 170);
            this.gpoOperador.TabIndex = 9;
            this.gpoOperador.TabStop = false;
            this.gpoOperador.Text = "Operadores";
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Checked = true;
            this.rdbDiv.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbDiv.Location = new System.Drawing.Point(9, 133);
            this.rdbDiv.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(88, 21);
            this.rdbDiv.TabIndex = 3;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "Divisão(/)";
            this.rdbDiv.UseVisualStyleBackColor = true;
            // 
            // rdbMult
            // 
            this.rdbMult.AutoSize = true;
            this.rdbMult.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbMult.Location = new System.Drawing.Point(9, 103);
            this.rdbMult.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMult.Name = "rdbMult";
            this.rdbMult.Size = new System.Drawing.Size(129, 21);
            this.rdbMult.TabIndex = 2;
            this.rdbMult.Text = "Multiplicação(*)";
            this.rdbMult.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbSub.Location = new System.Drawing.Point(9, 73);
            this.rdbSub.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(106, 21);
            this.rdbSub.TabIndex = 1;
            this.rdbSub.Text = "Subtração(-)";
            this.rdbSub.UseVisualStyleBackColor = true;
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdbAdicao.Location = new System.Drawing.Point(9, 42);
            this.rdbAdicao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(91, 21);
            this.rdbAdicao.TabIndex = 0;
            this.rdbAdicao.Text = "Adição(+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(365, 40);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(92, 21);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblResp
            // 
            this.lblResp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(369, 71);
            this.lblResp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(220, 64);
            this.lblResp.TabIndex = 11;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(369, 166);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(220, 47);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(369, 233);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(220, 47);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(369, 298);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 47);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 440);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpoOperador);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora V 1.1.0";
            this.gpoOperador.ResumeLayout(false);
            this.gpoOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.GroupBox gpoOperador;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbMult;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExit;
    }
}