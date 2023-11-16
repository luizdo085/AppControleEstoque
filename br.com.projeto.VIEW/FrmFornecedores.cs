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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }



        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //botão consultar cep
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";
                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cmbestado.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //botão pessquisar
            string nome = txtpesquisa.Text;

            FornecedoresDAO dao = new FornecedoresDAO();

            tabelafornecedores.DataSource = dao.BuscarFornecedorPorNome(nome);
        }

        private void tabelafornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar os dados da linha selecionada
            txtcodigo.Text = tabelafornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = tabelafornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelafornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelafornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelafornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelafornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelafornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelafornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = tabelafornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelafornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelafornecedores.CurrentRow.Cells[11].Value.ToString();
            cmbestado.Text = tabelafornecedores.CurrentRow.Cells[12].Value.ToString();

            //alterar guia para a de dados pessoais
            tabfornecedores.SelectedTab = tabPage1;
        }





        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            //atualizar grid view quando abrir frm Fornecedores
            FornecedoresDAO dao = new FornecedoresDAO();

            tabelafornecedores.DataSource = dao.ListarFornecedores();

            // deixar numero com 00
            txtnumero.Text = "00";
        }



        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do Fornecedores
            Fornecedores obj = new Fornecedores();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cmbestado.Text;
            obj.complemento = txtcomplemento.Text;

            //2 passo criar um objeto da classe clientedao e chamar o metodo cadastrar Fornecedores
            FornecedoresDAO dao = new FornecedoresDAO();
            dao.CadastrarFornecedor(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelafornecedores.DataSource = dao.ListarFornecedores();
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            //botão excluir
            Fornecedores obj = new Fornecedores();

            //pegar o codigo
            obj.id = int.Parse(txtcodigo.Text);

            FornecedoresDAO dao = new FornecedoresDAO();

            dao.ExcluirFornecedor(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelafornecedores.DataSource = dao.ListarFornecedores();
        }

        private void btnnovo_Click_1(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do Fornecedores
            Fornecedores obj = new Fornecedores();

            obj.id = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cmbestado.Text;
            obj.complemento = txtcomplemento.Text;

            //2 passo criar um objeto da classe Fornecedoresdao e chamar o metodo cadastrar Fornecedores
            FornecedoresDAO dao = new FornecedoresDAO();
            dao.AlterarFornecedor(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelafornecedores.DataSource = dao.ListarFornecedores();
        }
    }
}
