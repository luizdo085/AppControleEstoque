namespace AppGASeAGUA.br.com.projeto.VIEW
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            MenuCliente = new ToolStripMenuItem();
            MenuCadastraCliente = new ToolStripMenuItem();
            MenuConsultarClientes = new ToolStripMenuItem();
            MenuFuncionarios = new ToolStripMenuItem();
            MenuCadastraFuncionarios = new ToolStripMenuItem();
            MenuConsultarFuncionarios = new ToolStripMenuItem();
            MenuEntregadores = new ToolStripMenuItem();
            MenuCadastrarEntregadores = new ToolStripMenuItem();
            MenuConsultarEntergadores = new ToolStripMenuItem();
            MenuFornecedores = new ToolStripMenuItem();
            MenuCadastraFornecedores = new ToolStripMenuItem();
            MenuConsultarFornecedores = new ToolStripMenuItem();
            MenuProdutos = new ToolStripMenuItem();
            MenuCadastraProdutos = new ToolStripMenuItem();
            MenuEstoque = new ToolStripMenuItem();
            MenuVendas = new ToolStripMenuItem();
            MenuNovaVenda = new ToolStripMenuItem();
            MenuHistoricoVendas = new ToolStripMenuItem();
            MenuConfiguracoes = new ToolStripMenuItem();
            MenuTrocaUsuario = new ToolStripMenuItem();
            MenuSair = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtWhats = new ToolStripStatusLabel();
            txtYtb = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            txtFuncionario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = Properties.Resources.fundo_login_certo;
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuCliente, MenuFuncionarios, MenuEntregadores, MenuFornecedores, MenuProdutos, MenuVendas, MenuConfiguracoes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(936, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // MenuCliente
            // 
            MenuCliente.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastraCliente, MenuConsultarClientes });
            MenuCliente.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuCliente.ForeColor = Color.White;
            MenuCliente.Name = "MenuCliente";
            MenuCliente.Size = new Size(97, 26);
            MenuCliente.Text = "Clientes";
            // 
            // MenuCadastraCliente
            // 
            MenuCadastraCliente.BackColor = Color.White;
            MenuCadastraCliente.ForeColor = Color.Navy;
            MenuCadastraCliente.Name = "MenuCadastraCliente";
            MenuCadastraCliente.Size = new Size(252, 26);
            MenuCadastraCliente.Text = "Cadastrar Clientes";
            MenuCadastraCliente.Click += MenuCadastraCliente_Click;
            // 
            // MenuConsultarClientes
            // 
            MenuConsultarClientes.BackColor = Color.White;
            MenuConsultarClientes.ForeColor = Color.Navy;
            MenuConsultarClientes.Name = "MenuConsultarClientes";
            MenuConsultarClientes.Size = new Size(252, 26);
            MenuConsultarClientes.Text = "Consulta Clientes";
            MenuConsultarClientes.Click += MenuConsultarClientes_Click;
            // 
            // MenuFuncionarios
            // 
            MenuFuncionarios.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastraFuncionarios, MenuConsultarFuncionarios });
            MenuFuncionarios.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuFuncionarios.ForeColor = Color.White;
            MenuFuncionarios.Name = "MenuFuncionarios";
            MenuFuncionarios.Size = new Size(145, 26);
            MenuFuncionarios.Text = "Funcionarios";
            // 
            // MenuCadastraFuncionarios
            // 
            MenuCadastraFuncionarios.BackColor = Color.White;
            MenuCadastraFuncionarios.ForeColor = Color.Navy;
            MenuCadastraFuncionarios.Name = "MenuCadastraFuncionarios";
            MenuCadastraFuncionarios.Size = new Size(300, 26);
            MenuCadastraFuncionarios.Text = "Cadastrar Funcionarios";
            MenuCadastraFuncionarios.Click += MenuCadastraFuncionarios_Click;
            // 
            // MenuConsultarFuncionarios
            // 
            MenuConsultarFuncionarios.BackColor = Color.White;
            MenuConsultarFuncionarios.ForeColor = Color.Navy;
            MenuConsultarFuncionarios.Name = "MenuConsultarFuncionarios";
            MenuConsultarFuncionarios.Size = new Size(300, 26);
            MenuConsultarFuncionarios.Text = "Consultar Funcionarios";
            MenuConsultarFuncionarios.Click += MenuConsultarFuncionarios_Click;
            // 
            // MenuEntregadores
            // 
            MenuEntregadores.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastrarEntregadores, MenuConsultarEntergadores });
            MenuEntregadores.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuEntregadores.ForeColor = Color.White;
            MenuEntregadores.Name = "MenuEntregadores";
            MenuEntregadores.Size = new Size(149, 26);
            MenuEntregadores.Text = "Entregadores";
            // 
            // MenuCadastrarEntregadores
            // 
            MenuCadastrarEntregadores.BackColor = Color.White;
            MenuCadastrarEntregadores.ForeColor = Color.Navy;
            MenuCadastrarEntregadores.Name = "MenuCadastrarEntregadores";
            MenuCadastrarEntregadores.Size = new Size(304, 26);
            MenuCadastrarEntregadores.Text = "Cadastrar Entregadores";
            MenuCadastrarEntregadores.Click += MenuCadastrarEntregadores_Click;
            // 
            // MenuConsultarEntergadores
            // 
            MenuConsultarEntergadores.BackColor = Color.White;
            MenuConsultarEntergadores.ForeColor = Color.Navy;
            MenuConsultarEntergadores.Name = "MenuConsultarEntergadores";
            MenuConsultarEntergadores.Size = new Size(304, 26);
            MenuConsultarEntergadores.Text = "Consultar Entregadores";
            MenuConsultarEntergadores.Click += MenuConsultarEntergadores_Click;
            // 
            // MenuFornecedores
            // 
            MenuFornecedores.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastraFornecedores, MenuConsultarFornecedores });
            MenuFornecedores.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuFornecedores.ForeColor = Color.White;
            MenuFornecedores.Name = "MenuFornecedores";
            MenuFornecedores.Size = new Size(153, 26);
            MenuFornecedores.Text = "Fornecedores";
            MenuFornecedores.Click += MenuFornecedores_Click;
            // 
            // MenuCadastraFornecedores
            // 
            MenuCadastraFornecedores.BackColor = Color.White;
            MenuCadastraFornecedores.ForeColor = Color.Navy;
            MenuCadastraFornecedores.Name = "MenuCadastraFornecedores";
            MenuCadastraFornecedores.Size = new Size(308, 26);
            MenuCadastraFornecedores.Text = "Cadastrar Fornecedores";
            MenuCadastraFornecedores.Click += MenuCadastraFornecedores_Click;
            // 
            // MenuConsultarFornecedores
            // 
            MenuConsultarFornecedores.BackColor = Color.White;
            MenuConsultarFornecedores.ForeColor = Color.Navy;
            MenuConsultarFornecedores.Name = "MenuConsultarFornecedores";
            MenuConsultarFornecedores.Size = new Size(308, 26);
            MenuConsultarFornecedores.Text = "Consultar Fornecedores";
            MenuConsultarFornecedores.Click += MenuConsultarFornecedores_Click;
            // 
            // MenuProdutos
            // 
            MenuProdutos.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastraProdutos, MenuEstoque });
            MenuProdutos.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuProdutos.ForeColor = Color.White;
            MenuProdutos.Name = "MenuProdutos";
            MenuProdutos.Size = new Size(108, 26);
            MenuProdutos.Text = "Produtos";
            // 
            // MenuCadastraProdutos
            // 
            MenuCadastraProdutos.BackColor = Color.White;
            MenuCadastraProdutos.ForeColor = Color.Navy;
            MenuCadastraProdutos.Name = "MenuCadastraProdutos";
            MenuCadastraProdutos.Size = new Size(276, 26);
            MenuCadastraProdutos.Text = "Cadastrar Produto";
            MenuCadastraProdutos.Click += MenuCadastraProdutos_Click;
            // 
            // MenuEstoque
            // 
            MenuEstoque.BackColor = Color.White;
            MenuEstoque.ForeColor = Color.Navy;
            MenuEstoque.Name = "MenuEstoque";
            MenuEstoque.Size = new Size(276, 26);
            MenuEstoque.Text = "Estoque de Produtos";
            MenuEstoque.Click += MenuEstoque_Click;
            // 
            // MenuVendas
            // 
            MenuVendas.DropDownItems.AddRange(new ToolStripItem[] { MenuNovaVenda, MenuHistoricoVendas });
            MenuVendas.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuVendas.ForeColor = Color.White;
            MenuVendas.Name = "MenuVendas";
            MenuVendas.Size = new Size(91, 26);
            MenuVendas.Text = "Vendas";
            // 
            // MenuNovaVenda
            // 
            MenuNovaVenda.BackColor = Color.White;
            MenuNovaVenda.ForeColor = Color.Navy;
            MenuNovaVenda.Name = "MenuNovaVenda";
            MenuNovaVenda.Size = new Size(265, 26);
            MenuNovaVenda.Text = "Nova Venda";
            MenuNovaVenda.Click += MenuNovaVenda_Click;
            // 
            // MenuHistoricoVendas
            // 
            MenuHistoricoVendas.BackColor = Color.White;
            MenuHistoricoVendas.ForeColor = Color.Navy;
            MenuHistoricoVendas.Name = "MenuHistoricoVendas";
            MenuHistoricoVendas.Size = new Size(265, 26);
            MenuHistoricoVendas.Text = "Historico de Vendas";
            MenuHistoricoVendas.Click += MenuHistoricoVendas_Click;
            // 
            // MenuConfiguracoes
            // 
            MenuConfiguracoes.DropDownItems.AddRange(new ToolStripItem[] { MenuTrocaUsuario, MenuSair });
            MenuConfiguracoes.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuConfiguracoes.ForeColor = Color.White;
            MenuConfiguracoes.ImageScaling = ToolStripItemImageScaling.None;
            MenuConfiguracoes.Name = "MenuConfiguracoes";
            MenuConfiguracoes.Size = new Size(159, 26);
            MenuConfiguracoes.Text = "Configurações";
            // 
            // MenuTrocaUsuario
            // 
            MenuTrocaUsuario.BackColor = Color.White;
            MenuTrocaUsuario.ForeColor = Color.Navy;
            MenuTrocaUsuario.Name = "MenuTrocaUsuario";
            MenuTrocaUsuario.Size = new Size(247, 26);
            MenuTrocaUsuario.Text = "Trocar de Usuario";
            MenuTrocaUsuario.Click += MenuTrocaUsuario_Click;
            // 
            // MenuSair
            // 
            MenuSair.BackColor = Color.White;
            MenuSair.ForeColor = Color.Navy;
            MenuSair.Name = "MenuSair";
            MenuSair.Size = new Size(247, 26);
            MenuSair.Text = "Sair do Sistema";
            MenuSair.Click += MenuSair_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackgroundImage = Properties.Resources.fundo_login_certo;
            statusStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            statusStrip1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtWhats, txtYtb, toolStripStatusLabel2, toolStripStatusLabel3, txtFuncionario });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(936, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(187, 17);
            toolStripStatusLabel1.Text = "Entrem em contato conosco ";
            // 
            // txtWhats
            // 
            txtWhats.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtWhats.ForeColor = Color.White;
            txtWhats.Image = Properties.Resources.whatsapp_logo;
            txtWhats.Name = "txtWhats";
            txtWhats.Size = new Size(27, 17);
            txtWhats.Text = " ";
            // 
            // txtYtb
            // 
            txtYtb.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtYtb.ForeColor = Color.White;
            txtYtb.Image = Properties.Resources.logo_youtube;
            txtYtb.Name = "txtYtb";
            txtYtb.Size = new Size(31, 17);
            txtYtb.Text = "  ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel2.ForeColor = Color.White;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(298, 17);
            toolStripStatusLabel2.Text = " Suporte de Segunda à Sexta das 9:00 à 18:00";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel3.ForeColor = Color.White;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(86, 17);
            toolStripStatusLabel3.Text = "Funcionario:";
            // 
            // txtFuncionario
            // 
            txtFuncionario.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFuncionario.ForeColor = Color.White;
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.Size = new Size(87, 17);
            txtFuncionario.Text = "LuizMatheus";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Luizinho_resized__1___1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menu Principal - Água e Gás";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel txtWhats;
        private ToolStripStatusLabel txtYtb;
        private ToolStripStatusLabel toolStripStatusLabel3;
        public ToolStripMenuItem MenuCliente;
        public ToolStripMenuItem MenuCadastraCliente;
        public ToolStripMenuItem MenuConsultarClientes;
        public ToolStripMenuItem MenuFuncionarios;
        public ToolStripMenuItem MenuCadastraFuncionarios;
        public ToolStripMenuItem MenuConsultarFuncionarios;
        public ToolStripMenuItem MenuFornecedores;
        public ToolStripMenuItem MenuCadastraFornecedores;
        public ToolStripMenuItem MenuConsultarFornecedores;
        public ToolStripMenuItem MenuProdutos;
        public ToolStripMenuItem MenuCadastraProdutos;
        public ToolStripMenuItem MenuEstoque;
        public ToolStripMenuItem MenuVendas;
        public ToolStripMenuItem MenuNovaVenda;
        public ToolStripMenuItem MenuHistoricoVendas;
        public ToolStripMenuItem MenuConfiguracoes;
        public ToolStripMenuItem MenuTrocaUsuario;
        public ToolStripMenuItem MenuSair;
        public ToolStripStatusLabel txtFuncionario;
        private ToolStripMenuItem MenuCadastrarEntregadores;
        public ToolStripMenuItem MenuConsultarEntergadores;
        public ToolStripMenuItem MenuEntregadores;
    }
}