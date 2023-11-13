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
using System.Xml.Linq;

namespace AppGASeAGUA.br.com.projeto.VIEW
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do cliente
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text;
            obj.cpf = txtcpf.Text;
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

            //2 passo criar um objeto da classe clientedao e chamar o metodo cadastrar cliente
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelaclientes.DataSource = dao.ListarClientes();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            //atualizar grid view quando abrir frm cliente
            ClienteDAO dao = new ClienteDAO();

            tabelaclientes.DataSource = dao.ListarClientes();

            // deixar numero com 00
            txtnumero.Text = "00";
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Cliente obj = new Cliente();

            //pegar o codigo
            obj.id = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.ExcluirCliente(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelaclientes.DataSource = dao.ListarClientes();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            {
                //1 passo receber dados dentro do objeto modelo do cliente
                Cliente obj = new Cliente();

                obj.id = int.Parse(txtcodigo.Text);
                obj.nome = txtnome.Text;
                obj.cpf = txtcpf.Text;
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

                //2 passo criar um objeto da classe clientedao e chamar o metodo cadastrar cliente
                ClienteDAO dao = new ClienteDAO();
                dao.AlterarCliente(obj);

                //Limpar tela
                new Helpers().LimparTela(this);

                //atualizar tabela
                tabelaclientes.DataSource = dao.ListarClientes();
            }
        }

        private void tabelaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar os dados da linha selecionada
            txtcodigo.Text = tabelaclientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaclientes.CurrentRow.Cells[1].Value.ToString();
            txtcpf.Text = tabelaclientes.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelaclientes.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelaclientes.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelaclientes.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelaclientes.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelaclientes.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelaclientes.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = tabelaclientes.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelaclientes.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelaclientes.CurrentRow.Cells[11].Value.ToString();
            cmbestado.Text = tabelaclientes.CurrentRow.Cells[12].Value.ToString();

            //alterar guia para a de dados pessoais
            tabclientes.SelectedTab = tabPage1;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //botão pessquisar
            string nome = txtpesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaclientes.DataSource = dao.BuscarClientePorNome(nome);
        }

        private void txtcidade_TextChanged(object sender, EventArgs e)
        {

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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabelaclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
