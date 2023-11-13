using AppGASeAGUA.br.com.projeto.DAO;
using AppGASeAGUA.br.com.projeto.MODEL;
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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedoresDAO f_dao = new FornecedoresDAO();
            cmbfornecedores.DataSource = f_dao.ListarFornecedores();
            cmbfornecedores.DisplayMember = "nome_fantasia";
            cmbfornecedores.ValueMember = "id";

            //atualizar grid view quando abrir frm cliente
            ProdutosDAO dao = new ProdutosDAO();

            tabelaprodutos.DataSource = dao.ListarProdutos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do Produtos
            Produtos obj = new Produtos();

            obj.descricao = txtdescricao.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cmbfornecedores.SelectedValue.ToString());

            //2 passo criar um objeto da classe Produtosdao e chamar o metodo cadastrar Produto
            ProdutosDAO dao = new ProdutosDAO();
            dao.CadastrarProduto(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelaprodutos.DataSource = dao.ListarProdutos();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ProdutosDAO dao = new ProdutosDAO();

            tabelaprodutos.DataSource = dao.ListarProdutosPorNome(nome);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ProdutosDAO dao = new ProdutosDAO();

            tabelaprodutos.DataSource = dao.BuscarProdutoPorNome(nome);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Produtos obj = new Produtos();

            //pegar o codigo
            obj.id = int.Parse(txtcodigo.Text);

            ProdutosDAO dao = new ProdutosDAO();

            dao.ExcluirProduto(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelaprodutos.DataSource = dao.ListarProdutos();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do Produtos
            Produtos obj = new Produtos();

            obj.id = int.Parse(txtcodigo.Text);
            obj.descricao = txtdescricao.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cmbfornecedores.SelectedValue.ToString());

            //2 passo criar um objeto da classe Produtosdao e chamar o metodo cadastrar Produto
            ProdutosDAO dao = new ProdutosDAO();
            dao.AlterarProduto(obj);
            //limpar tela
            new Helpers().LimparTela(this);
            //atualizar tabela
            tabelaprodutos.DataSource = dao.ListarProdutos();
        }

        private void tabelaprodutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar os dados da linha selecionada
            txtcodigo.Text = tabelaprodutos.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = tabelaprodutos.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaprodutos.CurrentRow.Cells[2].Value.ToString();
            txtqtd.Text = tabelaprodutos.CurrentRow.Cells[3].Value.ToString();
            cmbfornecedores.Text = tabelaprodutos.CurrentRow.Cells[4].Value.ToString();

            //alterar guia para a de dados pessoais
            tabprodutos.SelectedTab = tabCadastrar;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabelaprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
