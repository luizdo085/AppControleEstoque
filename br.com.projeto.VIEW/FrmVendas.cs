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
    public partial class FrmVendas : Form
    {
        //objs cliente e clienteDAO
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        //objs de produto
        Produtos p = new Produtos();
        ProdutosDAO pdao = new ProdutosDAO();

        //variaveis
        int qtd, funcionario_id;
        decimal preco, subtotal, total;
        string entrega_retirada, endereco, nmr, bairro, cidade, estado, cpf;

        //carrinho
        DataTable carrinho = new DataTable();




        public FrmVendas(int funcionario_id)
        {
            //falando qual é o id do funcionario logado
            this.funcionario_id = funcionario_id;

            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Sub Total", typeof(decimal));

            tabelaprodutos.DataSource = carrinho;


        }


        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.RetornaDadosClientePorCpf(txtcpf.Text);
                if (cliente != null)
                {
                    txtnome.Text = cliente.nome;
                    txtendereco.Text = cliente.endereco;
                    txtnumero.Text = cliente.numero.ToString();
                    txtbairro.Text = cliente.bairro;
                    txtcidade.Text = cliente.cidade;
                    cmbestado.Text = cliente.estado;


                    //focus no codigo do produto
                    txtcodigo.Focus();
                }
                else
                {
                    txtcpf.Clear();
                    txtcpf.Focus();
                }
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.RetornaUmProdutoPorCodigo(int.Parse(txtcodigo.Text));
                if (p != null)
                {
                    txtdescricao.Text = p.descricao;
                    txtpreco.Text = p.preco.ToString();

                    //focus na qtd do produto
                    txtqtd.Focus();
                }
                else
                {
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
            }
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //pegando data atual
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtqtd.Text);
                if (qtd > 999999999)
                {
                    MessageBox.Show("Limite de quantidade atingida!");
                }
                else
                {
                    //botão add item

                    preco = decimal.Parse(txtpreco.Text);

                    subtotal = qtd * preco;

                    total += subtotal;

                    //add produto no carrinho9
                    carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdescricao.Text, qtd, preco, subtotal);

                    //exibir total
                    txttotal.Text = total.ToString();

                    //limpar campos
                    txtcodigo.Clear();
                    txtdescricao.Clear();
                    txtpreco.Clear();
                    txtqtd.Clear();

                    //foco no código
                    txtcodigo.Focus();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite o código e quantidade do produto");
            }
        }

        private void btnremoveritem_Click(object sender, EventArgs e)
        {
            //botão remover item
            decimal subproduto = decimal.Parse(tabelaprodutos.CurrentRow.Cells[4].Value.ToString());

            int indice = tabelaprodutos.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;
            txttotal.Text = total.ToString();

            MessageBox.Show("Item removido com sucesso!");
        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();


            //botão pagamentos
            DateTime data_atual = DateTime.Parse(txtdata.Text);

            endereco = txtendereco.Text;
            nmr = txtnumero.Text;
            cpf = txtcpf.Text;
            bairro = txtbairro.Text;
            cidade = txtcidade.Text;
            estado = cmbestado.Text;

            FrmPagamentos tela = new FrmPagamentos(cliente, carrinho, data_atual, entrega_retirada, funcionario_id);
            FrmEntrega tela2 = new FrmEntrega(cliente, carrinho, data_atual, entrega_retirada, funcionario_id, endereco, nmr, bairro, cidade, estado, cpf);



            if (rbtnentrega.Checked)
            {
                entrega_retirada = "entrega";

                // passando total e outros para tela pagamentos
                tela2.txttotal.Text = total.ToString();

                //this.Visible = false;
                tela2.ShowDialog();
            }
            else
            {
                entrega_retirada = "retirada";
                // passando total pra tela pagamentos
                tela.txttotal.Text = total.ToString();

                //this.Visible = false;
                tela.ShowDialog();
            }


        }

        private void rbtnentrega_Click(object sender, EventArgs e)
        {
            txtendereco.Enabled = true;
            txtnumero.Enabled = true;
            txtbairro.Enabled = true;
            txtcidade.Enabled = true;
            cmbestado.Enabled = true;
        }

        private void rbtnretirada_Click(object sender, EventArgs e)
        {
            txtendereco.Enabled = false;
            txtnumero.Enabled = false;
            txtbairro.Enabled = false;
            txtcidade.Enabled = false;
            cmbestado.Enabled = false;
        }

        private void btncancelarvenda_Click(object sender, EventArgs e)
        {
            //fechar e abrir aplicação
            DialogResult result = MessageBox.Show("Deseja cancelar a venda?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FrmVendas venda = new FrmVendas(funcionario_id);
                //Application.Exit();
                this.Dispose();
                venda.ShowDialog();
            }
        }

        private void rbtnentrega_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
