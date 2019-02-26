namespace DigitalStoreSystem
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pcbMenuPrincipal = new System.Windows.Forms.PictureBox();
            this.gpbMenuPrincipal = new System.Windows.Forms.GroupBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuPrincipal)).BeginInit();
            this.gpbMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbMenuPrincipal
            // 
            this.pcbMenuPrincipal.Image = global::DigitalStoreSystem.Properties.Resources.office365header_digitalstore;
            this.pcbMenuPrincipal.Location = new System.Drawing.Point(3, 4);
            this.pcbMenuPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMenuPrincipal.Name = "pcbMenuPrincipal";
            this.pcbMenuPrincipal.Size = new System.Drawing.Size(817, 283);
            this.pcbMenuPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMenuPrincipal.TabIndex = 0;
            this.pcbMenuPrincipal.TabStop = false;
            // 
            // gpbMenuPrincipal
            // 
            this.gpbMenuPrincipal.Controls.Add(this.btnUsuario);
            this.gpbMenuPrincipal.Controls.Add(this.btnFornecedores);
            this.gpbMenuPrincipal.Controls.Add(this.btnProdutos);
            this.gpbMenuPrincipal.Controls.Add(this.btnFuncionarios);
            this.gpbMenuPrincipal.Location = new System.Drawing.Point(3, 294);
            this.gpbMenuPrincipal.Name = "gpbMenuPrincipal";
            this.gpbMenuPrincipal.Size = new System.Drawing.Size(817, 85);
            this.gpbMenuPrincipal.TabIndex = 1;
            this.gpbMenuPrincipal.TabStop = false;
            this.gpbMenuPrincipal.Text = "Menu Principal";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(617, 32);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(185, 37);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Gerenciar Usuários";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(415, 32);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(185, 37);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.Text = "Gerenciar Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(212, 32);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(185, 37);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Gerenciar Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(9, 32);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(185, 37);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "Gerenciar Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.Location = new System.Drawing.Point(305, 393);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(185, 37);
            this.btnVoltarLogin.TabIndex = 2;
            this.btnVoltarLogin.Text = "Voltar";
            this.btnVoltarLogin.UseVisualStyleBackColor = true;
            this.btnVoltarLogin.Click += new System.EventHandler(this.btnVoltarLogin_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 442);
            this.Controls.Add(this.btnVoltarLogin);
            this.Controls.Add(this.gpbMenuPrincipal);
            this.Controls.Add(this.pcbMenuPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - DigitalStore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuPrincipal)).EndInit();
            this.gpbMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMenuPrincipal;
        private System.Windows.Forms.GroupBox gpbMenuPrincipal;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnVoltarLogin;
    }
}