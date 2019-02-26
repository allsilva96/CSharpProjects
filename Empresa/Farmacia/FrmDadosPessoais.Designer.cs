namespace Farmacia
{
    partial class FrmDadosPessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDadosPessoais));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeDP = new System.Windows.Forms.Label();
            this.txtNomeDP = new System.Windows.Forms.TextBox();
            this.lblCargoDP = new System.Windows.Forms.Label();
            this.txtCargoDP = new System.Windows.Forms.TextBox();
            this.lblTelefoneDP = new System.Windows.Forms.Label();
            this.lblDepartamentoDP = new System.Windows.Forms.Label();
            this.cboDepartamentoDP = new System.Windows.Forms.ComboBox();
            this.btnCadastroDP = new System.Windows.Forms.Button();
            this.btnExitDP = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFemin = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.ckbCrian = new System.Windows.Forms.CheckBox();
            this.ckbJov = new System.Windows.Forms.CheckBox();
            this.ckbAdul = new System.Windows.Forms.CheckBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ltbEscolha = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados Pessoais";
            // 
            // lblNomeDP
            // 
            this.lblNomeDP.AutoSize = true;
            this.lblNomeDP.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDP.Location = new System.Drawing.Point(76, 74);
            this.lblNomeDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeDP.Name = "lblNomeDP";
            this.lblNomeDP.Size = new System.Drawing.Size(59, 21);
            this.lblNomeDP.TabIndex = 1;
            this.lblNomeDP.Text = "Nome: ";
            // 
            // txtNomeDP
            // 
            this.txtNomeDP.Location = new System.Drawing.Point(134, 71);
            this.txtNomeDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeDP.MaxLength = 100;
            this.txtNomeDP.Name = "txtNomeDP";
            this.txtNomeDP.Size = new System.Drawing.Size(475, 29);
            this.txtNomeDP.TabIndex = 2;
            // 
            // lblCargoDP
            // 
            this.lblCargoDP.AutoSize = true;
            this.lblCargoDP.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoDP.Location = new System.Drawing.Point(76, 113);
            this.lblCargoDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargoDP.Name = "lblCargoDP";
            this.lblCargoDP.Size = new System.Drawing.Size(55, 21);
            this.lblCargoDP.TabIndex = 3;
            this.lblCargoDP.Text = "Cargo:";
            // 
            // txtCargoDP
            // 
            this.txtCargoDP.Location = new System.Drawing.Point(134, 110);
            this.txtCargoDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCargoDP.MaxLength = 100;
            this.txtCargoDP.Name = "txtCargoDP";
            this.txtCargoDP.Size = new System.Drawing.Size(475, 29);
            this.txtCargoDP.TabIndex = 4;
            // 
            // lblTelefoneDP
            // 
            this.lblTelefoneDP.AutoSize = true;
            this.lblTelefoneDP.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneDP.Location = new System.Drawing.Point(63, 147);
            this.lblTelefoneDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoneDP.Name = "lblTelefoneDP";
            this.lblTelefoneDP.Size = new System.Drawing.Size(68, 21);
            this.lblTelefoneDP.TabIndex = 5;
            this.lblTelefoneDP.Text = "Telefone:";
            // 
            // lblDepartamentoDP
            // 
            this.lblDepartamentoDP.AutoSize = true;
            this.lblDepartamentoDP.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoDP.Location = new System.Drawing.Point(18, 181);
            this.lblDepartamentoDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoDP.Name = "lblDepartamentoDP";
            this.lblDepartamentoDP.Size = new System.Drawing.Size(113, 21);
            this.lblDepartamentoDP.TabIndex = 7;
            this.lblDepartamentoDP.Text = "Departamento:";
            this.lblDepartamentoDP.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboDepartamentoDP
            // 
            this.cboDepartamentoDP.FormattingEnabled = true;
            this.cboDepartamentoDP.Items.AddRange(new object[] {
            "Recursos Humanos",
            "Secretaria",
            "Administração Central",
            "Almoxarifado"});
            this.cboDepartamentoDP.Location = new System.Drawing.Point(134, 181);
            this.cboDepartamentoDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDepartamentoDP.Name = "cboDepartamentoDP";
            this.cboDepartamentoDP.Size = new System.Drawing.Size(329, 29);
            this.cboDepartamentoDP.TabIndex = 8;
            // 
            // btnCadastroDP
            // 
            this.btnCadastroDP.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroDP.Image")));
            this.btnCadastroDP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroDP.Location = new System.Drawing.Point(134, 421);
            this.btnCadastroDP.Name = "btnCadastroDP";
            this.btnCadastroDP.Size = new System.Drawing.Size(117, 45);
            this.btnCadastroDP.TabIndex = 12;
            this.btnCadastroDP.Text = "&Cadastrar";
            this.btnCadastroDP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroDP.UseVisualStyleBackColor = true;
            this.btnCadastroDP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExitDP
            // 
            this.btnExitDP.Image = ((System.Drawing.Image)(resources.GetObject("btnExitDP.Image")));
            this.btnExitDP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitDP.Location = new System.Drawing.Point(364, 421);
            this.btnExitDP.Name = "btnExitDP";
            this.btnExitDP.Size = new System.Drawing.Size(93, 45);
            this.btnExitDP.TabIndex = 13;
            this.btnExitDP.Text = "&Voltar";
            this.btnExitDP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitDP.UseVisualStyleBackColor = true;
            this.btnExitDP.Click += new System.EventHandler(this.btnExitDP_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(82, 230);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 21);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo:";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(134, 230);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(95, 25);
            this.rdbMasc.TabIndex = 9;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFemin
            // 
            this.rdbFemin.AutoSize = true;
            this.rdbFemin.Location = new System.Drawing.Point(253, 230);
            this.rdbFemin.Name = "rdbFemin";
            this.rdbFemin.Size = new System.Drawing.Size(89, 25);
            this.rdbFemin.TabIndex = 10;
            this.rdbFemin.TabStop = true;
            this.rdbFemin.Text = "Feminino";
            this.rdbFemin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 29);
            this.textBox1.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(82, 314);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 21);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo:";
            // 
            // ckbCrian
            // 
            this.ckbCrian.AutoSize = true;
            this.ckbCrian.Location = new System.Drawing.Point(134, 314);
            this.ckbCrian.Name = "ckbCrian";
            this.ckbCrian.Size = new System.Drawing.Size(79, 25);
            this.ckbCrian.TabIndex = 15;
            this.ckbCrian.Text = "Criança";
            this.ckbCrian.UseVisualStyleBackColor = true;
            // 
            // ckbJov
            // 
            this.ckbJov.AutoSize = true;
            this.ckbJov.Location = new System.Drawing.Point(134, 346);
            this.ckbJov.Name = "ckbJov";
            this.ckbJov.Size = new System.Drawing.Size(71, 25);
            this.ckbJov.TabIndex = 16;
            this.ckbJov.Text = "Jovem";
            this.ckbJov.UseVisualStyleBackColor = true;
            // 
            // ckbAdul
            // 
            this.ckbAdul.AutoSize = true;
            this.ckbAdul.Location = new System.Drawing.Point(134, 378);
            this.ckbAdul.Name = "ckbAdul";
            this.ckbAdul.Size = new System.Drawing.Size(74, 25);
            this.ckbAdul.TabIndex = 17;
            this.ckbAdul.Text = "Adulto";
            this.ckbAdul.UseVisualStyleBackColor = true;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(294, 314);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(64, 21);
            this.lblEscolha.TabIndex = 18;
            this.lblEscolha.Text = "Escolha:";
            // 
            // ltbEscolha
            // 
            this.ltbEscolha.FormattingEnabled = true;
            this.ltbEscolha.ItemHeight = 21;
            this.ltbEscolha.Items.AddRange(new object[] {
            "Calça",
            "Camisa",
            "Gravata",
            "Saia",
            "Sapato",
            "Chinelo",
            "Blusa"});
            this.ltbEscolha.Location = new System.Drawing.Point(364, 315);
            this.ltbEscolha.Name = "ltbEscolha";
            this.ltbEscolha.Size = new System.Drawing.Size(156, 88);
            this.ltbEscolha.TabIndex = 19;
            this.ltbEscolha.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FrmDadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 497);
            this.Controls.Add(this.ltbEscolha);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.ckbAdul);
            this.Controls.Add(this.ckbJov);
            this.Controls.Add(this.ckbCrian);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdbFemin);
            this.Controls.Add(this.rdbMasc);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnExitDP);
            this.Controls.Add(this.btnCadastroDP);
            this.Controls.Add(this.cboDepartamentoDP);
            this.Controls.Add(this.lblDepartamentoDP);
            this.Controls.Add(this.lblTelefoneDP);
            this.Controls.Add(this.txtCargoDP);
            this.Controls.Add(this.lblCargoDP);
            this.Controls.Add(this.txtNomeDP);
            this.Controls.Add(this.lblNomeDP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDadosPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Pessoais";
            this.Load += new System.EventHandler(this.FrmDadosPessoais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeDP;
        private System.Windows.Forms.TextBox txtNomeDP;
        private System.Windows.Forms.Label lblCargoDP;
        private System.Windows.Forms.TextBox txtCargoDP;
        private System.Windows.Forms.Label lblTelefoneDP;
        private System.Windows.Forms.Label lblDepartamentoDP;
        private System.Windows.Forms.ComboBox cboDepartamentoDP;
        private System.Windows.Forms.Button btnCadastroDP;
        private System.Windows.Forms.Button btnExitDP;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rdbFemin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox ckbCrian;
        private System.Windows.Forms.CheckBox ckbJov;
        private System.Windows.Forms.CheckBox ckbAdul;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.ListBox ltbEscolha;
    }
}