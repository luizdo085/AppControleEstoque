using AppGASeAGUA.br.com.projeto.CONEXAO;
using AppGASeAGUA.br.com.projeto.MODEL;
using AppGASeAGUA.br.com.projeto.VIEW;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppGASeAGUA.br.com.projeto.DAO
{
    public class FuncionariosDAO
    {
        private MySqlConnection conexao;
        public FuncionariosDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();

        }
        #region cadastrar Funcionario
        public void CadastrarFuncionario(Funcionarios obj)
        {
            try
            {       
                //1 passo definir o cmd sql "insert into" 
                string sql = @"insert into tb_Funcionarios(nome,cpf,rg,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome,@cpf,rg,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion


        #region AlterarFuncionario
        //alterar Funcionario
        public void AlterarFuncionario(Funcionarios obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"update tb_Funcionarios set nome=@nome,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,
                             nivel_acesso=@nivel_acesso,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,
                             numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion


        #region ListarFuncionarios
        //listar cliente
        public DataTable ListarFuncionarios()
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelafuncionarios = new DataTable();

                string sql = "select * from tb_funcionarios";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionarios);
                conexao.Close();

                return tabelafuncionarios;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion


        #region ExcluirFuncionario
        //excluir Funcionario 
        public void ExcluirFuncionario(Funcionarios obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"delete from tb_Funcionarios where id =@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion


        #region Buscar Funcionario por nome
        //buscar Funcionario
        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelafuncionarios = new DataTable();

                string sql = "select * from tb_funcionarios where nome = @nome";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.Parameters.AddWithValue("@nome", nome);
                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionarios);
                conexao.Close();

                return tabelafuncionarios;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion


        #region Método que efetua login
        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                //1 passo criar comando sql
                string sql = @"SELECT * FROM tb_funcionarios
		                                where email = @email and senha = @senha";
                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                //abir conexão e executar cmd
                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();

                if(reader.Read())
                {
                    //que login foi realizado com sucesso
                    //pegando nivel de acesso do usuario
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");
                    int funcionario_id = reader.GetInt32("id");

                    MessageBox.Show("Seja bem vindo ao sistema, " + nome);

                    // instanciar tela para dar acesso ou n para (nivel_acesso)
                    FrmMenu telamenu = new FrmMenu(funcionario_id,nivel);
                    FrmProdutos produtos = new FrmProdutos();
                    FrmCliente cliente = new FrmCliente();

                    telamenu.txtFuncionario.Text = nome;


                    //abrir menu principal
                    //se o nivel for adiministrado
                    if (nivel.Equals("Administrador"))
                    {
                        
                        telamenu.Show();
                    }
                    //se for funcionario gerenciador de estoque
                    else if (nivel.Equals("Funcionario e gerenciador de estoque"))
                    {
                        //Personalizar oque ele vai ter acesso
                        telamenu.MenuFuncionarios.Visible = false;
                        telamenu.MenuFornecedores.Visible = false;
                        telamenu.MenuCadastraProdutos.Enabled = false;
                        telamenu.MenuEntregadores.Visible = false;
                        telamenu.MenuHistoricoVendas.Enabled = false;

                        produtos.btnsalvar.Enabled = false;
                        produtos.btnexcluir.Enabled = false;
                        produtos.txtdescricao.ReadOnly = true;
                        produtos.txtdescricao.ReadOnly = true;
                        produtos.cmbfornecedores.Visible = false;
                        produtos.lblFornecedores.Visible = false;
                        
                        cliente.btnexcluir.Enabled = false;
                        
                        telamenu.Show();
                    }
                    //quer dizer que é apenas Funcionario
                    else if (nivel.Equals("Funcionario"))
                    {
                        //Personalizar oque ele vai ter acesso
                        telamenu.MenuFuncionarios.Visible = false;
                        telamenu.MenuFornecedores.Visible = false;
                        telamenu.MenuCadastraProdutos.Enabled = false;
                        telamenu.MenuEntregadores.Visible = false;
                        telamenu.MenuHistoricoVendas.Enabled = false;

                        produtos.btnsalvar.Visible = false;
                        produtos.btnexcluir.Visible = false;
                        produtos.btneditar.Visible = false;
                        produtos.btnnovo.Visible = false;
                        produtos.cmbfornecedores.Visible = false;
                        produtos.lblFornecedores.Visible = false;

                        cliente.btnexcluir.Enabled = false;

                        telamenu.Show();
                    }

                    return true;
                }
                else
                {
                    //senha ou email foi digitado errado

                    MessageBox.Show("Email ou senha está incorreto!");
                    return false;
                }



            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
                return false;
            }
        }

        #endregion
    }
}
