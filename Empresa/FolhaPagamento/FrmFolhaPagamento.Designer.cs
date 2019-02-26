namespace FolhaPagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.lblClubLazer = new System.Windows.Forms.Label();
            this.cboClubLazer = new System.Windows.Forms.ComboBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblSalFolha = new System.Windows.Forms.Label();
            this.txtSalFolha = new System.Windows.Forms.TextBox();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.btnNvConsulta = new System.Windows.Forms.Button();
            this.lblValorDesc = new System.Windows.Forms.Label();
            this.txtValorDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(13, 50);
            this.dtpDataFolha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(128, 23);
            this.dtpDataFolha.TabIndex = 0;
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Location = new System.Drawing.Point(10, 29);
            this.lblDataFolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(106, 17);
            this.lblDataFolha.TabIndex = 1;
            this.lblDataFolha.Text = "Data da Folha:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 98);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(55, 17);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(12, 118);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(129, 23);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Location = new System.Drawing.Point(12, 158);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(129, 21);
            this.ckbPlanoSaude.TabIndex = 4;
            this.ckbPlanoSaude.Text = "Plano de Saúde";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            this.ckbPlanoSaude.CheckedChanged += new System.EventHandler(this.ckbPlanoSaude_CheckedChanged);
            // 
            // lblClubLazer
            // 
            this.lblClubLazer.AutoSize = true;
            this.lblClubLazer.Location = new System.Drawing.Point(12, 206);
            this.lblClubLazer.Name = "lblClubLazer";
            this.lblClubLazer.Size = new System.Drawing.Size(106, 17);
            this.lblClubLazer.TabIndex = 5;
            this.lblClubLazer.Text = "Clube do Lazer";
            // 
            // cboClubLazer
            // 
            this.cboClubLazer.FormattingEnabled = true;
            this.cboClubLazer.Location = new System.Drawing.Point(15, 226);
            this.cboClubLazer.Name = "cboClubLazer";
            this.cboClubLazer.Size = new System.Drawing.Size(171, 25);
            this.cboClubLazer.TabIndex = 6;
            this.cboClubLazer.SelectedIndexChanged += new System.EventHandler(this.cboClubLazer_SelectedIndexChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(255, 29);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(95, 29);
            this.btnCalcula.TabIndex = 7;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblSalFolha
            // 
            this.lblSalFolha.AutoSize = true;
            this.lblSalFolha.Location = new System.Drawing.Point(218, 81);
            this.lblSalFolha.Name = "lblSalFolha";
            this.lblSalFolha.Size = new System.Drawing.Size(94, 17);
            this.lblSalFolha.TabIndex = 8;
            this.lblSalFolha.Text = "Salário Folha:";
            this.lblSalFolha.Click += new System.EventHandler(this.lblSalFolha_Click);
            // 
            // txtSalFolha
            // 
            this.txtSalFolha.Enabled = false;
            this.txtSalFolha.Location = new System.Drawing.Point(356, 78);
            this.txtSalFolha.Name = "txtSalFolha";
            this.txtSalFolha.Size = new System.Drawing.Size(152, 23);
            this.txtSalFolha.TabIndex = 9;
            this.txtSalFolha.TextChanged += new System.EventHandler(this.txtSalFolha_TextChanged);
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Location = new System.Drawing.Point(218, 110);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(132, 17);
            this.lblImpostoRenda.TabIndex = 10;
            this.lblImpostoRenda.Text = "Imposto de Renda:";
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Enabled = false;
            this.txtImpostoRenda.Location = new System.Drawing.Point(356, 107);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(152, 23);
            this.txtImpostoRenda.TabIndex = 11;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(218, 168);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(106, 17);
            this.lblSalarioLiquido.TabIndex = 12;
            this.lblSalarioLiquido.Text = "Salário Liquido:";
            this.lblSalarioLiquido.Click += new System.EventHandler(this.lblSalarioLiquido_Click);
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Location = new System.Drawing.Point(356, 165);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(152, 23);
            this.txtSalLiquido.TabIndex = 13;
            // 
            // btnNvConsulta
            // 
            this.btnNvConsulta.Location = new System.Drawing.Point(356, 29);
            this.btnNvConsulta.Name = "btnNvConsulta";
            this.btnNvConsulta.Size = new System.Drawing.Size(127, 29);
            this.btnNvConsulta.TabIndex = 14;
            this.btnNvConsulta.Text = "Nova Consulta";
            this.btnNvConsulta.UseVisualStyleBackColor = true;
            this.btnNvConsulta.Click += new System.EventHandler(this.btnNvConsulta_Click);
            // 
            // lblValorDesc
            // 
            this.lblValorDesc.AutoSize = true;
            this.lblValorDesc.Location = new System.Drawing.Point(216, 139);
            this.lblValorDesc.Name = "lblValorDesc";
            this.lblValorDesc.Size = new System.Drawing.Size(134, 17);
            this.lblValorDesc.TabIndex = 15;
            this.lblValorDesc.Text = "Valor do Desconto:";
            // 
            // txtValorDesc
            // 
            this.txtValorDesc.Enabled = false;
            this.txtValorDesc.Location = new System.Drawing.Point(356, 136);
            this.txtValorDesc.Name = "txtValorDesc";
            this.txtValorDesc.Size = new System.Drawing.Size(100, 23);
            this.txtValorDesc.TabIndex = 16;
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 344);
            this.Controls.Add(this.txtValorDesc);
            this.Controls.Add(this.lblValorDesc);
            this.Controls.Add(this.btnNvConsulta);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.txtSalFolha);
            this.Controls.Add(this.lblSalFolha);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.cboClubLazer);
            this.Controls.Add(this.lblClubLazer);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.Controls.Add(this.dtpDataFolha);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.Label lblClubLazer;
        private System.Windows.Forms.ComboBox cboClubLazer;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblSalFolha;
        private System.Windows.Forms.TextBox txtSalFolha;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.Button btnNvConsulta;
        private System.Windows.Forms.Label lblValorDesc;
        private System.Windows.Forms.TextBox txtValorDesc;
    }
}