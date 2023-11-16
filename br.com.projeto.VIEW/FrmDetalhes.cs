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
    public partial class FrmDetalhes : Form
    {
        int venda_id;

        public FrmDetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            //Carrega tela de detalhes
            ItensVendasDAO dao = new ItensVendasDAO();

            tabelaitens.DataSource = dao.ListarItensPorVenda(venda_id);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txttotalvenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

            if (txtobsexclui.Text == "")
            {
                MessageBox.Show("É necessario justificar o por que você vai excluir a venda");
            }
            else
            {
                ProdutosDAO p_dao = new ProdutosDAO();
                int qtd_estoque, qtd_comprado, estoque_atualizada;


                Vendas vendas = new Vendas();
                vendas.id = venda_id;
                vendas.observacao = txtobsexclui.Text;

                VendasDAO dao = new VendasDAO();
                dao.ExcluirVenda(vendas);

                ItensVendas ivenda = new ItensVendas();
                ivenda.venda_id = venda_id;

                ItensVendasDAO idao = new ItensVendasDAO();
                idao.ExcluirItemVenda(ivenda);

                //fazendo o estorno no estoque
                foreach (DataRow linha in tabelaitens.Rows)
                {

                    ivenda.produto_id = int.Parse(linha["Código"].ToString());
                    ivenda.qtd = int.Parse(linha["Quantidade"].ToString());

                    //aumento no estoque
                    qtd_estoque = p_dao.RetornaEstoqueAtual(ivenda.produto_id);
                    qtd_comprado = ivenda.qtd;

                    estoque_atualizada = qtd_estoque + qtd_comprado;

                    p_dao.AumentaEstoque(ivenda.produto_id, estoque_atualizada);

                    this.Close();
                }

                this.Dispose();

                new FrmHistorico().ShowDialog();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
