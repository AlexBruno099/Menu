namespace TESSTE
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoRestritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deusSejaLouvadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvidoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picConfig = new System.Windows.Forms.PictureBox();
            this.picCompras = new System.Windows.Forms.PictureBox();
            this.picNFe = new System.Windows.Forms.PictureBox();
            this.picBanco = new System.Windows.Forms.PictureBox();
            this.picCaixa = new System.Windows.Forms.PictureBox();
            this.picPagar = new System.Windows.Forms.PictureBox();
            this.picReceber = new System.Windows.Forms.PictureBox();
            this.PicFornecedor = new System.Windows.Forms.PictureBox();
            this.picEstoque = new System.Windows.Forms.PictureBox();
            this.picClientes = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.atualizaçãoToolStripMenuItem,
            this.utilitariosToolStripMenuItem,
            this.acessoRestritoToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.deusSejaLouvadoToolStripMenuItem,
            this.ouvidoriaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1905, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // atualizaçãoToolStripMenuItem
            // 
            this.atualizaçãoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.atualizaçãoToolStripMenuItem.Name = "atualizaçãoToolStripMenuItem";
            this.atualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.atualizaçãoToolStripMenuItem.Text = "Atualização";
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitariosToolStripMenuItem.Text = "Utilitarios";
            // 
            // acessoRestritoToolStripMenuItem
            // 
            this.acessoRestritoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.acessoRestritoToolStripMenuItem.Name = "acessoRestritoToolStripMenuItem";
            this.acessoRestritoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.acessoRestritoToolStripMenuItem.Text = "Acesso Restrito";
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.suporteToolStripMenuItem.Text = "Suporte";
            // 
            // deusSejaLouvadoToolStripMenuItem
            // 
            this.deusSejaLouvadoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deusSejaLouvadoToolStripMenuItem.Name = "deusSejaLouvadoToolStripMenuItem";
            this.deusSejaLouvadoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.deusSejaLouvadoToolStripMenuItem.Text = "Deus seja louvado";
            // 
            // ouvidoriaToolStripMenuItem
            // 
            this.ouvidoriaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ouvidoriaToolStripMenuItem.Name = "ouvidoriaToolStripMenuItem";
            this.ouvidoriaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ouvidoriaToolStripMenuItem.Text = "Ouvidoria";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(115, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(297, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Receber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(206, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(477, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Caixa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(386, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(832, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Configuração";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(751, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Compras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(660, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "NF-e";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(569, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Banco";
            // 
            // picConfig
            // 
            this.picConfig.Image = global::TESSTE.Properties.Resources.icons8_configurações_30;
            this.picConfig.Location = new System.Drawing.Point(829, 28);
            this.picConfig.Name = "picConfig";
            this.picConfig.Size = new System.Drawing.Size(73, 66);
            this.picConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfig.TabIndex = 20;
            this.picConfig.TabStop = false;
            // 
            // picCompras
            // 
            this.picCompras.Image = global::TESSTE.Properties.Resources.icons8_adicionar_o_carrinho_de_compras_50;
            this.picCompras.Location = new System.Drawing.Point(740, 28);
            this.picCompras.Name = "picCompras";
            this.picCompras.Size = new System.Drawing.Size(73, 66);
            this.picCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompras.TabIndex = 18;
            this.picCompras.TabStop = false;
            // 
            // picNFe
            // 
            this.picNFe.Image = global::TESSTE.Properties.Resources.icons8_nota_fiscal_electrónica_48;
            this.picNFe.Location = new System.Drawing.Point(649, 28);
            this.picNFe.Name = "picNFe";
            this.picNFe.Size = new System.Drawing.Size(73, 66);
            this.picNFe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNFe.TabIndex = 16;
            this.picNFe.TabStop = false;
            // 
            // picBanco
            // 
            this.picBanco.Image = global::TESSTE.Properties.Resources.icons8_banco_100;
            this.picBanco.Location = new System.Drawing.Point(558, 28);
            this.picBanco.Name = "picBanco";
            this.picBanco.Size = new System.Drawing.Size(73, 66);
            this.picBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanco.TabIndex = 14;
            this.picBanco.TabStop = false;
            // 
            // picCaixa
            // 
            this.picCaixa.Image = global::TESSTE.Properties.Resources.icons8_caixa_automático_50;
            this.picCaixa.Location = new System.Drawing.Point(466, 28);
            this.picCaixa.Name = "picCaixa";
            this.picCaixa.Size = new System.Drawing.Size(73, 66);
            this.picCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCaixa.TabIndex = 12;
            this.picCaixa.TabStop = false;
            // 
            // picPagar
            // 
            this.picPagar.Image = global::TESSTE.Properties.Resources.icons8_pagar_50;
            this.picPagar.Location = new System.Drawing.Point(375, 28);
            this.picPagar.Name = "picPagar";
            this.picPagar.Size = new System.Drawing.Size(73, 66);
            this.picPagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPagar.TabIndex = 10;
            this.picPagar.TabStop = false;
            // 
            // picReceber
            // 
            this.picReceber.Image = global::TESSTE.Properties.Resources.icons8_receber_50;
            this.picReceber.Location = new System.Drawing.Point(286, 28);
            this.picReceber.Name = "picReceber";
            this.picReceber.Size = new System.Drawing.Size(73, 66);
            this.picReceber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReceber.TabIndex = 8;
            this.picReceber.TabStop = false;
            this.picReceber.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PicFornecedor
            // 
            this.PicFornecedor.Image = global::TESSTE.Properties.Resources.entregador;
            this.PicFornecedor.Location = new System.Drawing.Point(195, 28);
            this.PicFornecedor.Name = "PicFornecedor";
            this.PicFornecedor.Size = new System.Drawing.Size(73, 66);
            this.PicFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFornecedor.TabIndex = 6;
            this.PicFornecedor.TabStop = false;
            this.PicFornecedor.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picEstoque
            // 
            this.picEstoque.Image = global::TESSTE.Properties.Resources.trabalhador_carregando_caixas;
            this.picEstoque.Location = new System.Drawing.Point(104, 28);
            this.picEstoque.Name = "picEstoque";
            this.picEstoque.Size = new System.Drawing.Size(73, 66);
            this.picEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEstoque.TabIndex = 4;
            this.picEstoque.TabStop = false;
            this.picEstoque.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picClientes
            // 
            this.picClientes.Image = global::TESSTE.Properties.Resources.do_utilizador;
            this.picClientes.Location = new System.Drawing.Point(13, 28);
            this.picClientes.Name = "picClientes";
            this.picClientes.Size = new System.Drawing.Size(73, 66);
            this.picClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClientes.TabIndex = 2;
            this.picClientes.TabStop = false;
            this.picClientes.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1905, 111);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picConfig);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picCompras);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.picNFe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picCaixa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picReceber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PicFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picClientes);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNFe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.PictureBox picClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picReceber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picCaixa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picConfig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picCompras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picNFe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picBanco;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoRestritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deusSejaLouvadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvidoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

