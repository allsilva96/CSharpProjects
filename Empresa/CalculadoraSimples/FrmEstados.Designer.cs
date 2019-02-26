namespace CalculadoraSimples
{
    partial class FrmEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstados));
            this.lblEstados = new System.Windows.Forms.Label();
            this.btnCarregareEstados = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ltbEstados = new System.Windows.Forms.ListBox();
            this.btnCarregarLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregarLabel = new System.Windows.Forms.Button();
            this.lblSEstad = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFemin = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.gpbEscolha = new System.Windows.Forms.GroupBox();
            this.ckbManhã = new System.Windows.Forms.CheckBox();
            this.ckbTarde = new System.Windows.Forms.CheckBox();
            this.ckbNoite = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            this.gpbEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(2, 9);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(84, 22);
            this.lblEstados.TabIndex = 0;
            this.lblEstados.Text = "Estados:";
            this.lblEstados.Click += new System.EventHandler(this.lblEstados_Click);
            // 
            // btnCarregareEstados
            // 
            this.btnCarregareEstados.Enabled = false;
            this.btnCarregareEstados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregareEstados.Location = new System.Drawing.Point(5, 483);
            this.btnCarregareEstados.Name = "btnCarregareEstados";
            this.btnCarregareEstados.Size = new System.Drawing.Size(142, 29);
            this.btnCarregareEstados.TabIndex = 2;
            this.btnCarregareEstados.Text = "Carregar Estados";
            this.btnCarregareEstados.UseVisualStyleBackColor = true;
            this.btnCarregareEstados.Click += new System.EventHandler(this.btnCarregareEstados_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(5, 35);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(333, 24);
            this.cboEstados.TabIndex = 3;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            this.cboEstados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboEstados_MouseClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(198, 519);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(142, 29);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ltbEstados
            // 
            this.ltbEstados.FormattingEnabled = true;
            this.ltbEstados.ItemHeight = 16;
            this.ltbEstados.Location = new System.Drawing.Point(5, 90);
            this.ltbEstados.Name = "ltbEstados";
            this.ltbEstados.Size = new System.Drawing.Size(140, 132);
            this.ltbEstados.TabIndex = 5;
            this.ltbEstados.SelectedIndexChanged += new System.EventHandler(this.ltbEstados_SelectedIndexChanged);
            // 
            // btnCarregarLista
            // 
            this.btnCarregarLista.Location = new System.Drawing.Point(5, 519);
            this.btnCarregarLista.Name = "btnCarregarLista";
            this.btnCarregarLista.Size = new System.Drawing.Size(142, 29);
            this.btnCarregarLista.TabIndex = 6;
            this.btnCarregarLista.Text = "Carregar Lista";
            this.btnCarregarLista.UseVisualStyleBackColor = true;
            this.btnCarregarLista.Click += new System.EventHandler(this.btnCarregarLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estados:";
            // 
            // btnCarregarLabel
            // 
            this.btnCarregarLabel.Location = new System.Drawing.Point(198, 483);
            this.btnCarregarLabel.Name = "btnCarregarLabel";
            this.btnCarregarLabel.Size = new System.Drawing.Size(142, 29);
            this.btnCarregarLabel.TabIndex = 8;
            this.btnCarregarLabel.Text = " Carregar Label";
            this.btnCarregarLabel.UseVisualStyleBackColor = true;
            this.btnCarregarLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSEstad
            // 
            this.lblSEstad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSEstad.Location = new System.Drawing.Point(198, 90);
            this.lblSEstad.Name = "lblSEstad";
            this.lblSEstad.Size = new System.Drawing.Size(142, 45);
            this.lblSEstad.TabIndex = 9;
            this.lblSEstad.Text = "           ";
            // 
            // lblList
            // 
            this.lblList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblList.Location = new System.Drawing.Point(198, 177);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(142, 45);
            this.lblList.TabIndex = 10;
            this.lblList.Text = "           ";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbFemin);
            this.gpbSexo.Controls.Add(this.rdbMasc);
            this.gpbSexo.Location = new System.Drawing.Point(5, 234);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(142, 96);
            this.gpbSexo.TabIndex = 11;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(14, 31);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(81, 20);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            this.rdbMasc.CheckedChanged += new System.EventHandler(this.rdbMasc_CheckedChanged);
            // 
            // rdbFemin
            // 
            this.rdbFemin.AutoSize = true;
            this.rdbFemin.Location = new System.Drawing.Point(14, 57);
            this.rdbFemin.Name = "rdbFemin";
            this.rdbFemin.Size = new System.Drawing.Size(73, 20);
            this.rdbFemin.TabIndex = 1;
            this.rdbFemin.Text = "Feminino";
            this.rdbFemin.UseVisualStyleBackColor = true;
            this.rdbFemin.CheckedChanged += new System.EventHandler(this.rdbFemin_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSexo.Location = new System.Drawing.Point(198, 240);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(142, 45);
            this.lblSexo.TabIndex = 12;
            this.lblSexo.Text = "           ";
            // 
            // gpbEscolha
            // 
            this.gpbEscolha.Controls.Add(this.ckbNoite);
            this.gpbEscolha.Controls.Add(this.ckbTarde);
            this.gpbEscolha.Controls.Add(this.ckbManhã);
            this.gpbEscolha.Location = new System.Drawing.Point(5, 336);
            this.gpbEscolha.Name = "gpbEscolha";
            this.gpbEscolha.Size = new System.Drawing.Size(142, 119);
            this.gpbEscolha.TabIndex = 13;
            this.gpbEscolha.TabStop = false;
            this.gpbEscolha.Text = "Escolha";
            // 
            // ckbManhã
            // 
            this.ckbManhã.AutoSize = true;
            this.ckbManhã.Location = new System.Drawing.Point(14, 27);
            this.ckbManhã.Name = "ckbManhã";
            this.ckbManhã.Size = new System.Drawing.Size(68, 20);
            this.ckbManhã.TabIndex = 0;
            this.ckbManhã.Text = "Manhã";
            this.ckbManhã.UseVisualStyleBackColor = true;
            this.ckbManhã.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbTarde
            // 
            this.ckbTarde.AutoSize = true;
            this.ckbTarde.Location = new System.Drawing.Point(14, 53);
            this.ckbTarde.Name = "ckbTarde";
            this.ckbTarde.Size = new System.Drawing.Size(58, 20);
            this.ckbTarde.TabIndex = 1;
            this.ckbTarde.Text = "Tarde";
            this.ckbTarde.UseVisualStyleBackColor = true;
            // 
            // ckbNoite
            // 
            this.ckbNoite.AutoSize = true;
            this.ckbNoite.Location = new System.Drawing.Point(14, 80);
            this.ckbNoite.Name = "ckbNoite";
            this.ckbNoite.Size = new System.Drawing.Size(55, 20);
            this.ckbNoite.TabIndex = 2;
            this.ckbNoite.Text = "Noite";
            this.ckbNoite.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CalculadoraSimples.Properties.Resources.Actions_edit_delete_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(152, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 41);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(198, 302);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(142, 29);
            this.btnEscolha.TabIndex = 15;
            this.btnEscolha.Text = "Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // FrmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 557);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gpbEscolha);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblSEstad);
            this.Controls.Add(this.btnCarregarLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarregarLista);
            this.Controls.Add(this.ltbEstados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnCarregareEstados);
            this.Controls.Add(this.lblEstados);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstados";
            this.Text = "Estados";
            this.Load += new System.EventHandler(this.FrmEstados_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbEscolha.ResumeLayout(false);
            this.gpbEscolha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Button btnCarregareEstados;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox ltbEstados;
        private System.Windows.Forms.Button btnCarregarLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregarLabel;
        private System.Windows.Forms.Label lblSEstad;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbFemin;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox gpbEscolha;
        private System.Windows.Forms.CheckBox ckbNoite;
        private System.Windows.Forms.CheckBox ckbTarde;
        private System.Windows.Forms.CheckBox ckbManhã;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEscolha;
    }
}