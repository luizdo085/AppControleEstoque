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
            components = new System.ComponentModel.Container();
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
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            txtFuncionario = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = Properties.Resources.fundo_login_certo;
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuCliente, MenuFuncionarios, MenuEntregadores, MenuFornecedores, MenuProdutos, MenuVendas, MenuConfiguracoes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1539, 39);
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
            MenuCliente.Size = new Size(120, 33);
            MenuCliente.Text = "Clientes";
            // 
            // MenuCadastraCliente
            // 
            MenuCadastraCliente.BackColor = Color.White;
            MenuCadastraCliente.ForeColor = Color.Navy;
            MenuCadastraCliente.Name = "MenuCadastraCliente";
            MenuCadastraCliente.Size = new Size(310, 34);
            MenuCadastraCliente.Text = "Cadastrar Clientes";
            MenuCadastraCliente.Click += MenuCadastraCliente_Click;
            // 
            // MenuConsultarClientes
            // 
            MenuConsultarClientes.BackColor = Color.White;
            MenuConsultarClientes.ForeColor = Color.Navy;
            MenuConsultarClientes.Name = "MenuConsultarClientes";
            MenuConsultarClientes.Size = new Size(310, 34);
            MenuConsultarClientes.Text = "Consulta Clientes";
            MenuConsultarClientes.Click += MenuConsultarClientes_Click;
            // 
            // MenuFuncionarios
            // 
            MenuFuncionarios.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastraFuncionarios, MenuConsultarFuncionarios });
            MenuFuncionarios.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuFuncionarios.ForeColor = Color.White;
            MenuFuncionarios.Name = "MenuFuncionarios";
            MenuFuncionarios.Size = new Size(179, 33);
            MenuFuncionarios.Text = "Funcionarios";
            // 
            // MenuCadastraFuncionarios
            // 
            MenuCadastraFuncionarios.BackColor = Color.White;
            MenuCadastraFuncionarios.ForeColor = Color.Navy;
            MenuCadastraFuncionarios.Name = "MenuCadastraFuncionarios";
            MenuCadastraFuncionarios.Size = new Size(371, 34);
            MenuCadastraFuncionarios.Text = "Cadastrar Funcionarios";
            MenuCadastraFuncionarios.Click += MenuCadastraFuncionarios_Click;
            // 
            // MenuConsultarFuncionarios
            // 
            MenuConsultarFuncionarios.BackColor = Color.White;
            MenuConsultarFuncionarios.ForeColor = Color.Navy;
            MenuConsultarFuncionarios.Name = "MenuConsultarFuncionarios";
            MenuConsultarFuncionarios.Size = new Size(371, 34);
            MenuConsultarFuncionarios.Text = "Consultar Funcionarios";
            MenuConsultarFuncionarios.Click += MenuConsultarFuncionarios_Click;
            // 
            // MenuEntregadores
            // 
            MenuEntregadores.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastrarEntregadores, MenuConsultarEntergadores });
            MenuEntregadores.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuEntregadores.ForeColor = Color.White;
            MenuEntregadores.Name = "MenuEntregadores";
            MenuEntregadores.Size = new Size(181, 33);
            MenuEntregadores.Text = "Entregadores";
            // 
            // MenuCadastrarEntregadores
            // 
            MenuCadastrarEntregadores.BackColor = Color.White;
            MenuCadastrarEntregadores.ForeColor = Color.Navy;
            MenuCadastrarEntregadores.Name = "MenuCadastrarEntregadores";
            MenuCadastrarEntregadores.Size = new Size(373, 34);
            MenuCadastrarEntregadores.Text = "Cadastrar Entregadores";
            MenuCadastrarEntregadores.Click += MenuCadastrarEntregadores_Click;
            // 
            // MenuConsultarEntergadores
            // 
            MenuConsultarEntergadores.BackColor = Color.White;
            MenuConsultarEntergadores.ForeColor = Color.Navy;
            MenuConsultarEntergadores.Name = "MenuConsultarEntergadores";
            MenuConsultarEntergadores.Size = new Size(373, 34);
            MenuConsultarEntergadores.Text = "Consultar Entregadores";
            MenuConsultarEntergadores.Click += MenuConsultarEntergadores_Click;
            // 
            // MenuFornecedores
            // 
            MenuFornecedores.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastraFornecedores, MenuConsultarFornecedores });
            MenuFornecedores.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuFornecedores.ForeColor = Color.White;
            MenuFornecedores.Name = "MenuFornecedores";
            MenuFornecedores.Size = new Size(185, 33);
            MenuFornecedores.Text = "Fornecedores";
            MenuFornecedores.Click += MenuFornecedores_Click;
            // 
            // MenuCadastraFornecedores
            // 
            MenuCadastraFornecedores.BackColor = Color.White;
            MenuCadastraFornecedores.ForeColor = Color.Navy;
            MenuCadastraFornecedores.Name = "MenuCadastraFornecedores";
            MenuCadastraFornecedores.Size = new Size(377, 34);
            MenuCadastraFornecedores.Text = "Cadastrar Fornecedores";
            MenuCadastraFornecedores.Click += MenuCadastraFornecedores_Click;
            // 
            // MenuConsultarFornecedores
            // 
            MenuConsultarFornecedores.BackColor = Color.White;
            MenuConsultarFornecedores.ForeColor = Color.Navy;
            MenuConsultarFornecedores.Name = "MenuConsultarFornecedores";
            MenuConsultarFornecedores.Size = new Size(377, 34);
            MenuConsultarFornecedores.Text = "Consultar Fornecedores";
            MenuConsultarFornecedores.Click += MenuConsultarFornecedores_Click;
            // 
            // MenuProdutos
            // 
            MenuProdutos.DropDownItems.AddRange(new ToolStripItem[] { MenuCadastraProdutos, MenuEstoque });
            MenuProdutos.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuProdutos.ForeColor = Color.White;
            MenuProdutos.Name = "MenuProdutos";
            MenuProdutos.Size = new Size(133, 33);
            MenuProdutos.Text = "Produtos";
            // 
            // MenuCadastraProdutos
            // 
            MenuCadastraProdutos.BackColor = Color.White;
            MenuCadastraProdutos.ForeColor = Color.Navy;
            MenuCadastraProdutos.Name = "MenuCadastraProdutos";
            MenuCadastraProdutos.Size = new Size(343, 34);
            MenuCadastraProdutos.Text = "Cadastrar Produto";
            MenuCadastraProdutos.Click += MenuCadastraProdutos_Click;
            // 
            // MenuEstoque
            // 
            MenuEstoque.BackColor = Color.White;
            MenuEstoque.ForeColor = Color.Navy;
            MenuEstoque.Name = "MenuEstoque";
            MenuEstoque.Size = new Size(343, 34);
            MenuEstoque.Text = "Estoque de Produtos";
            MenuEstoque.Click += MenuEstoque_Click;
            // 
            // MenuVendas
            // 
            MenuVendas.DropDownItems.AddRange(new ToolStripItem[] { MenuNovaVenda, MenuHistoricoVendas });
            MenuVendas.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MenuVendas.ForeColor = Color.White;
            MenuVendas.Name = "MenuVendas";
            MenuVendas.Size = new Size(111, 33);
            MenuVendas.Text = "Vendas";
            // 
            // MenuNovaVenda
            // 
            MenuNovaVenda.BackColor = Color.White;
            MenuNovaVenda.ForeColor = Color.Navy;
            MenuNovaVenda.Name = "MenuNovaVenda";
            MenuNovaVenda.Size = new Size(330, 34);
            MenuNovaVenda.Text = "Nova Venda";
            MenuNovaVenda.Click += MenuNovaVenda_Click;
            // 
            // MenuHistoricoVendas
            // 
            MenuHistoricoVendas.BackColor = Color.White;
            MenuHistoricoVendas.ForeColor = Color.Navy;
            MenuHistoricoVendas.Name = "MenuHistoricoVendas";
            MenuHistoricoVendas.Size = new Size(330, 34);
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
            MenuConfiguracoes.Size = new Size(195, 33);
            MenuConfiguracoes.Text = "Configurações";
            // 
            // MenuTrocaUsuario
            // 
            MenuTrocaUsuario.BackColor = Color.White;
            MenuTrocaUsuario.ForeColor = Color.Navy;
            MenuTrocaUsuario.Name = "MenuTrocaUsuario";
            MenuTrocaUsuario.Size = new Size(304, 34);
            MenuTrocaUsuario.Text = "Trocar de Usuario";
            MenuTrocaUsuario.Click += MenuTrocaUsuario_Click;
            // 
            // MenuSair
            // 
            MenuSair.BackColor = Color.White;
            MenuSair.ForeColor = Color.Navy;
            MenuSair.Name = "MenuSair";
            MenuSair.Size = new Size(304, 34);
            MenuSair.Text = "Sair do Sistema";
            MenuSair.Click += MenuSair_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackgroundImage = Properties.Resources.fundo_login_certo;
            statusStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            statusStrip1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel3, txtFuncionario, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 575);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1539, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel3.ForeColor = Color.White;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(101, 19);
            toolStripStatusLabel3.Text = "Funcionario:";
            // 
            // txtFuncionario
            // 
            txtFuncionario.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFuncionario.ForeColor = Color.White;
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.Size = new Size(108, 19);
            txtFuncionario.Text = "LuizMatheus";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(24, 19);
            toolStripStatusLabel1.Text = "...";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click_1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Luizinho_resized__1___1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1539, 600);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}