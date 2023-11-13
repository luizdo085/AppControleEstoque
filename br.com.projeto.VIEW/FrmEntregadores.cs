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
    public partial class FrmEntregadores : Form
    {
        public FrmEntregadores()
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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do entregadores
            Entregadores obj = new Entregadores();

            obj.nome = txtnome.Text;
            obj.cpf = txtcpf.Text;
            obj.rg = txtrg.Text;
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

            //2 passo criar um objeto da classe entregadores dao e chamar o metodo cadastrar entregadores
            EntregadoresDAO dao = new EntregadoresDAO();
            dao.CadastrarEntregador(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelaEntregadores.DataSource = dao.ListarEntregadores();
        }

        private void FrmEntregadores_Load(object sender, EventArgs e)
        {
            //atualizar grid view quando abrir frm Entregadores
            EntregadoresDAO dao = new EntregadoresDAO();

            tabelaEntregadores.DataSource = dao.ListarEntregadores();

            // deixar numero com 00
            txtnumero.Text = "00";
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Entregadores obj = new Entregadores();

            //pegar o codigo
            obj.id = int.Parse(txtcodigo.Text);

            EntregadoresDAO dao = new EntregadoresDAO();

            dao.ExcluirEntregador(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelaEntregadores.DataSource = dao.ListarEntregadores();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do Entregadores
            Entregadores obj = new Entregadores();

            obj.id = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.cpf = txtcpf.Text;
            obj.rg = txtrg.Text;
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

            //2 passo criar um objeto da classe Entregadoresdao e chamar o metodo cadastrar Entregadores
            EntregadoresDAO dao = new EntregadoresDAO();
            dao.AlterarEntregador(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelaEntregadores.DataSource = dao.ListarEntregadores();
        }

        private void tabelaEntregadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar os dados da linha selecionada
            txtcodigo.Text = tabelaEntregadores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaEntregadores.CurrentRow.Cells[1].Value.ToString();
            txtcpf.Text = tabelaEntregadores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelaEntregadores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelaEntregadores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelaEntregadores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelaEntregadores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelaEntregadores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelaEntregadores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = tabelaEntregadores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelaEntregadores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelaEntregadores.CurrentRow.Cells[11].Value.ToString();
            cmbestado.Text = tabelaEntregadores.CurrentRow.Cells[12].Value.ToString();

            //alterar guia para a de dados pessoais
            tabentregadores.SelectedTab = tabPage1;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //botão pessquisar
            string nome = txtpesquisa.Text;

            EntregadoresDAO dao = new EntregadoresDAO();

            tabelaEntregadores.DataSource = dao.BuscarEntregadorPorNome(nome);
        }
    }
}
