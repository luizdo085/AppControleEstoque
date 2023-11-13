using AppGASeAGUA.br.com.projeto.DAO;
using AppGASeAGUA.br.com.projeto.MODEL;
using MySqlX.XDevAPI.Common;
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

    public partial class FrmEntrega : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();
        DataTable carrinho = new DataTable();
        DateTime data_atual;
        String entrega_retirada, forma_pagamento;
        int funcionario_id;
        string endereco, nmr, bairro, cidade, estado, cpf;
        public FrmEntrega(Cliente cliente, DataTable carrinho, DateTime data_atual, string entrega_retirada, int funcionario_id, string endereco, string nmr, string bairro, string cidade, string estado, string cpf)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.data_atual = data_atual;
            this.entrega_retirada = entrega_retirada;
            this.funcionario_id = funcionario_id;
            this.endereco = endereco;
            this.nmr = nmr;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cpf = cpf;
            InitializeComponent();
        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfrpagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtfrpagamento.Text == "Dinheiro")
            {
                txttroco.ReadOnly = false;
            }
            else
            {
                txttroco.ReadOnly = true;
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirVenda_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            cliente = cdao.RetornaDadosClientePorCpf(cpf);
            string texto = (@"  LGG ÁGUA E GÁS

        ENTREGA

CLIENTE: " + cliente.nome +
@" 
ENDEREÇO: " + endereco + " Nº: " + nmr + @"
BAIRRO: " + bairro + @"
CIDADE: " + cidade + "-" + estado + @"

TOTAL: " + txttotal.Text + @"
FORMA DE PAGAMENTO: " + txtfrpagamento.Text);
            //falta colocar troco e obs


            Font tipo_fonte = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point local = new Point(50, 50);

            e.Graphics.DrawString(texto, tipo_fonte, cor, local);
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            //botão finalizar uma venda
            try
            {
                decimal total;

                ProdutosDAO p_dao = new ProdutosDAO();
                int qtd_estoque, qtd_comprado, estoque_atualizada;

                // pegando o valor do total
                total = decimal.Parse(txttotal.Text);

                Vendas vendas = new Vendas();

                //pegando id do cliente
                vendas.cliente_id = cliente.id;
                vendas.data_venda = data_atual;
                vendas.total_venda = total;
                vendas.observacao = txtobs.Text;
                vendas.entrega_retirada = entrega_retirada;
                vendas.forma_pagamento = forma_pagamento;
                vendas.funcionario_id = funcionario_id;



                VendasDAO vdao = new VendasDAO();
                vdao.CadastrarVenda(vendas);

                //cadastrar item da venda
                //percorrendo os itens do carrinho

                foreach (DataRow linha in carrinho.Rows)
                {
                    ItensVendas item = new ItensVendas();
                    item.venda_id = vdao.RetornaIdUltimaVenda();
                    item.produto_id = int.Parse(linha["Código"].ToString());
                    item.qtd = int.Parse(linha["Qtd"].ToString());
                    item.sub_total = decimal.Parse(linha["Sub Total"].ToString());

                    //baixa no estoque
                    qtd_estoque = p_dao.RetornaEstoqueAtual(item.produto_id);
                    qtd_comprado = item.qtd;

                    estoque_atualizada = qtd_estoque - qtd_comprado;

                    p_dao.BaixaEstoque(item.produto_id, estoque_atualizada);
                    ItensVendasDAO idao = new ItensVendasDAO();
                    idao.CadastrarItem(item);

                    this.Close();

                }


                //imprimir dados da venda
                const string message = "Venda finalizada com sucesso, deseja imprimir dados de entrega?";
                const string caption = "Venda Finalizada";
                var messagemtela = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messagemtela == DialogResult.Yes)
                {
                    ImprimirVenda.Print();
                }
                else
                {
                    this.Dispose();

                    new FrmVendas(funcionario_id).ShowDialog();
                }


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
            }


        }
    }
}
