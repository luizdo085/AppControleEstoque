using AppGASeAGUA.br.com.projeto.DAO;
using AppGASeAGUA.br.com.projeto.MODEL;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGASeAGUA.br.com.projeto.VIEW
{


    public partial class FrmPagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime data_atual;
        String entrega_retirada, forma_pagamento;
        int funcionario_id;



        public class PagamentosEntregaRetirada
        {
            //atributos 
        }
        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime data_atual, string entrega_retirada, int funcionario_id)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.data_atual = data_atual;
            this.entrega_retirada = entrega_retirada;
            this.funcionario_id = funcionario_id;


            InitializeComponent();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

            //botão finalizar uma venda
            try
            {
                decimal v_dinheiro, v_cartao, troco, total_pago, total;

                ProdutosDAO p_dao = new ProdutosDAO();
                int qtd_estoque, qtd_comprado, estoque_atualizada;

                v_dinheiro = decimal.Parse(txtdinheiro.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                //calcular total pago
                total_pago = v_cartao + v_dinheiro;

                if (total_pago < total)
                {
                    MessageBox.Show("Total pago é menor que total da venda!");
                }
                else
                {
                    if (decimal.Parse(txtdinheiro.Text) > 0)
                    {
                        if (decimal.Parse(txtcartao.Text) > 0)
                        {
                            forma_pagamento = "Dinheiro e Cartão";

                        }
                        else
                        {
                            forma_pagamento = "Dinheiro";
                        }
                    }
                    else
                    {
                        forma_pagamento = "Cartão";
                    }

                    // calcular troco
                    troco = total_pago - total;

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
                    txttroco.Text = troco.ToString();
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

                    MessageBox.Show("Venda realizada com sucesso!");

                    this.Dispose();

                    new FrmVendas(funcionario_id).ShowDialog();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            //carrega tela
            txttroco.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnimpimir_Click(object sender, EventArgs e)
        {
            

            ImprimeVenda.Print();


        }

        private void ImprimeVenda_PrintPage(System.Object sender, PrintPageEventArgs e)
        {
            string texto = (@"LGG ÁGUA E GÁS
Cliente: " + 
                "Entrega" +
                "Endereço: Humberto Raul"+
                "Total é: " + txttotal.Text);
            Font tipo_fonte = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point local = new Point(50, 50);

            e.Graphics.DrawString(texto, tipo_fonte, cor, local);
        }
               

    }
}
