namespace FolhaPagamento
{
    partial class FrmFolhaSalarioV2
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
            this.btnNvConsulta = new System.Windows.Forms.Button();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.txtSalFolha = new System.Windows.Forms.TextBox();
            this.lblSalFolha = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.cboClubLazer = new System.Windows.Forms.ComboBox();
            this.lblClubLazer = new System.Windows.Forms.Label();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnNvConsulta
            // 
            this.btnNvConsulta.Location = new System.Drawing.Point(476, 28);
            this.btnNvConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnNvConsulta.Name = "btnNvConsulta";
            this.btnNvConsulta.Size = new System.Drawing.Size(169, 38);
            this.btnNvConsulta.TabIndex = 29;
            this.btnNvConsulta.Text = "Nova Consulta";
            this.btnNvConsulta.UseVisualStyleBackColor = true;
            this.btnNvConsulta.Click += new System.EventHandler(this.btnNvConsulta_Click);
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Location = new System.Drawing.Point(476, 158);
            this.txtSalLiquido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(201, 23);
            this.txtSalLiquido.TabIndex = 28;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(292, 162);
            this.lblSalarioLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(106, 17);
            this.lblSalarioLiquido.TabIndex = 27;
            this.lblSalarioLiquido.Text = "Salário Liquido:";
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Enabled = false;
            this.txtImpostoRenda.Location = new System.Drawing.Point(476, 118);
            this.txtImpostoRenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(201, 23);
            this.txtImpostoRenda.TabIndex = 26;
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Location = new System.Drawing.Point(292, 122);
            this.lblImpostoRenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(132, 17);
            this.lblImpostoRenda.TabIndex = 25;
            this.lblImpostoRenda.Text = "Imposto de Renda:";
            // 
            // txtSalFolha
            // 
            this.txtSalFolha.Enabled = false;
            this.txtSalFolha.Location = new System.Drawing.Point(476, 80);
            this.txtSalFolha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalFolha.Name = "txtSalFolha";
            this.txtSalFolha.Size = new System.Drawing.Size(201, 23);
            this.txtSalFolha.TabIndex = 24;
            // 
            // lblSalFolha
            // 
            this.lblSalFolha.AutoSize = true;
            this.lblSalFolha.Location = new System.Drawing.Point(292, 84);
            this.lblSalFolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalFolha.Name = "lblSalFolha";
            this.lblSalFolha.Size = new System.Drawing.Size(94, 17);
            this.lblSalFolha.TabIndex = 23;
            this.lblSalFolha.Text = "Salário Folha:";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(295, 28);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(127, 38);
            this.btnCalcula.TabIndex = 22;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // cboClubLazer
            // 
            this.cboClubLazer.FormattingEnabled = true;
            this.cboClubLazer.Location = new System.Drawing.Point(15, 246);
            this.cboClubLazer.Margin = new System.Windows.Forms.Padding(4);
            this.cboClubLazer.Name = "cboClubLazer";
            this.cboClubLazer.Size = new System.Drawing.Size(227, 25);
            this.cboClubLazer.TabIndex = 21;
            this.cboClubLazer.SelectedIndexChanged += new System.EventHandler(this.cboClubLazer_SelectedIndexChanged);
            // 
            // lblClubLazer
            // 
            this.lblClubLazer.AutoSize = true;
            this.lblClubLazer.Location = new System.Drawing.Point(15, 225);
            this.lblClubLazer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubLazer.Name = "lblClubLazer";
            this.lblClubLazer.Size = new System.Drawing.Size(106, 17);
            this.lblClubLazer.TabIndex = 20;
            this.lblClubLazer.Text = "Clube do Lazer";
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Location = new System.Drawing.Point(17, 177);
            this.ckbPlanoSaude.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(129, 21);
            this.ckbPlanoSaude.TabIndex = 19;
            this.ckbPlanoSaude.Text = "Plano de Saúde";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            this.ckbPlanoSaude.CheckedChanged += new System.EventHandler(this.ckbPlanoSaude_CheckedChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(17, 132);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(171, 23);
            this.txtSalario.TabIndex = 18;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(17, 106);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(55, 17);
            this.lblSalario.TabIndex = 17;
            this.lblSalario.Text = "Salário:";
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Location = new System.Drawing.Point(15, 16);
            this.lblDataFolha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(106, 17);
            this.lblDataFolha.TabIndex = 16;
            this.lblDataFolha.Text = "Data da Folha:";
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(19, 43);
            this.dtpDataFolha.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(169, 23);
            this.dtpDataFolha.TabIndex = 15;
            // 
            // FrmFolhaSalarioV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 389);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFolhaSalarioV2";
            this.Text = "FrmFolhaSalarioV2";
            this.Load += new System.EventHandler(this.FrmFolhaSalarioV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNvConsulta;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.TextBox txtSalFolha;
        private System.Windows.Forms.Label lblSalFolha;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.ComboBox cboClubLazer;
        private System.Windows.Forms.Label lblClubLazer;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
    }
}