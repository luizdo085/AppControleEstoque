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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void txtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
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

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do funcionarios
            Funcionarios obj = new Funcionarios();

            obj.nome = txtnome.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cmbcargo.Text;
            obj.nivel_acesso = cmbnivelacesso.Text;
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
            FuncionariosDAO dao = new FuncionariosDAO();
            dao.CadastrarFuncionario(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelafuncionarios.DataSource = dao.ListarFuncionarios();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            Funcionarios obj = new Funcionarios();

            //pegar o codigo
            obj.id = int.Parse(txtcodigo.Text);

            FuncionariosDAO dao = new FuncionariosDAO();

            dao.ExcluirFuncionario(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelafuncionarios.DataSource = dao.ListarFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //1 passo receber dados dentro do objeto modelo do Funcionarios
            Funcionarios obj = new Funcionarios();

            obj.id = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cmbcargo.Text;
            obj.nivel_acesso = cmbnivelacesso.Text;
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
            FuncionariosDAO dao = new FuncionariosDAO();
            dao.AlterarFuncionario(obj);

            //Limpar tela
            new Helpers().LimparTela(this);

            //atualizar tabela
            tabelafuncionarios.DataSource = dao.ListarFuncionarios();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //botão pessquisar
            string nome = txtpesquisa.Text;

            FuncionariosDAO dao = new FuncionariosDAO();

            tabelafuncionarios.DataSource = dao.BuscarFuncionarioPorNome(nome);
        }

        private void tabelafuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar os dados da linha selecionada
            txtcodigo.Text = tabelafuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelafuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelafuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelafuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelafuncionarios.CurrentRow.Cells[5].Value.ToString();
            cmbcargo.Text = tabelafuncionarios.CurrentRow.Cells[6].Value.ToString();
            cmbnivelacesso.Text = tabelafuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelafuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelafuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelafuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelafuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelafuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = tabelafuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = tabelafuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = tabelafuncionarios.CurrentRow.Cells[15].Value.ToString();
            cmbestado.Text = tabelafuncionarios.CurrentRow.Cells[16].Value.ToString();

            //alterar guia para a de dados pessoais
            tabfuncionarios.SelectedTab = tabPage1;
        }

        private void FrmFuncionarios_Load_1(object sender, EventArgs e)
        {
            //atualizar grid view quando abrir frm Funcionarios
            FuncionariosDAO dao = new FuncionariosDAO();

            tabelafuncionarios.DataSource = dao.ListarFuncionarios();

            // deixar numero com 00
            txtnumero.Text = "00";
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
