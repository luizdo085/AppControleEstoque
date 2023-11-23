using AppGASeAGUA.br.com.projeto.MODEL;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGASeAGUA.br.com.projeto.VIEW
{
    public partial class FrmMenu : Form
    {
        int id_funcionario;
        string nivel;
        public FrmMenu(int id_funcionario, string nivel)
        {
            this.id_funcionario = id_funcionario;
            this.nivel = nivel;
            InitializeComponent();
            
        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuCadastraCliente_Click(object sender, EventArgs e)
        {
            //abrir tela cliente
            FrmCliente tela = new FrmCliente();
            if (nivel.Equals("Administrador"))
            {
                tela.Show();
            }
            else if (nivel.Equals("Funcionario e gerenciador de estoque"))
            {
                //Personalizar oque ele vai ter acesso
                tela.btnexcluir.Enabled = false;
                tela.Show();
            }
            //quer dizer que é apenas Funcionario
            else if (nivel.Equals("Funcionario"))
            {
                //Personalizar oque ele vai ter acesso
                tela.btnexcluir.Enabled = false;
                tela.Show();
            }

        }

        private void MenuConsultarClientes_Click(object sender, EventArgs e)
        {
            //abrir tela cliente e selecionar a tab consulta
            FrmCliente tela = new FrmCliente();
            if (nivel.Equals("Administrador"))
            {
                tela.tabclientes.SelectedTab = tela.tabConsulta;
                tela.Show();
            }
            else if (nivel.Equals("Funcionario e gerenciador de estoque"))
            {
                //Personalizar oque ele vai ter acesso
                tela.btnexcluir.Enabled = false;
                tela.tabclientes.SelectedTab = tela.tabConsulta;
                tela.Show();
            }
            //quer dizer que é apenas Funcionario
            else if (nivel.Equals("Funcionario"))
            {
                //Personalizar oque ele vai ter acesso
                tela.btnexcluir.Enabled = false;
                tela.tabclientes.SelectedTab = tela.tabConsulta;
                tela.Show();
            }
        }

        private void MenuCadastraFuncionarios_Click(object sender, EventArgs e)
        {
            //abrir tela funcionarios 
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.Show();
        }

        private void MenuConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            //abrir tela funcionarios e selecionar a tab consulta
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.tabfuncionarios.SelectedTab = tela.tabConsulta;
            tela.Show();
        }

        private void MenuFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void MenuConsultarFornecedores_Click(object sender, EventArgs e)
        {
            //abrir tela Fornecedores e selecionar a tab consulta
            FrmFornecedores tela = new FrmFornecedores();
            tela.tabfornecedores.SelectedTab = tela.tabConsulta;
            tela.Show();
        }

        private void MenuCadastraProdutos_Click(object sender, EventArgs e)
        {
            //abrir tela Produtos e selecionar a tab cadastrar
            FrmProdutos tela = new FrmProdutos();
            tela.tabprodutos.SelectedTab = tela.tabCadastrar;
            tela.Show();
        }

        private void MenuEstoque_Click(object sender, EventArgs e)
        {
            //abrir tela estoque
            FrmProdutos tela = new FrmProdutos();
            if (nivel.Equals("Administrador"))
            {

                tela.Show();
            }
            //se for funcionario gerenciador de estoque
            else if (nivel.Equals("Funcionario e gerenciador de estoque"))
            {
                //Personalizar oque ele vai ter acesso
                tela.btnsalvar.Enabled = false;
                tela.btnexcluir.Enabled = false;
                tela.txtdescricao.ReadOnly = true;
                tela.txtpreco.ReadOnly = true;
                tela.cmbfornecedores.Visible = false;
                tela.lblFornecedores.Visible = false;
                tela.Show();
            }
            //quer dizer que é apenas Funcionario
            else if (nivel.Equals("Funcionario"))
            {
                //Personalizar oque ele vai ter acesso
                tela.btnsalvar.Visible = false;
                tela.btnexcluir.Visible = false;
                tela.btneditar.Visible = false;
                tela.btnnovo.Visible = false;
                tela.txtdescricao.ReadOnly = true;
                tela.txtpreco.ReadOnly = true;
                tela.txtqtd.ReadOnly = true;
                tela.cmbfornecedores.Visible = false;
                tela.lblFornecedores.Visible = false;
                tela.Show();
            }

        }

        private void MenuNovaVenda_Click(object sender, EventArgs e)
        {
            //abrir tela de vendas
            string fun = txtFuncionario.Text;
            FrmVendas tela = new FrmVendas(id_funcionario);
            tela.txtfuncionario.Text = fun;
            tela.Show();
        }

        private void MenuHistoricoVendas_Click(object sender, EventArgs e)
        {
            //abrir tela de historico
            FrmHistorico tela = new FrmHistorico();
            tela.Show();
        }

        private void MenuCadastraFornecedores_Click(object sender, EventArgs e)
        {
            //abrir tela fornecedores
            FrmFornecedores tela = new FrmFornecedores();
            tela.Show();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            //fechar aplicação
            DialogResult result = MessageBox.Show("Você deseja sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void MenuCadastrarEntregadores_Click(object sender, EventArgs e)
        {
            //abrir tela entregadores e selecionar a tab consulta
            FrmEntregadores tela = new FrmEntregadores();
            tela.Show();
        }

        private void MenuConsultarEntergadores_Click(object sender, EventArgs e)
        {
            //instanciar a tela entregadores
            FrmEntregadores tela = new FrmEntregadores();
            tela.tabentregadores.SelectedTab = tela.tabConsulta;
            tela.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void MenuTrocaUsuario_Click(object sender, EventArgs e)
        {

            //fechar aplicação
            DialogResult result = MessageBox.Show("Você deseja trocar de usuário?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                //Application.Exit();
                this.Dispose();
                login.ShowDialog();
            }
        }
    }
}
