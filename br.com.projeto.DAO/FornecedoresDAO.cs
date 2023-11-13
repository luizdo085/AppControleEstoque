using AppGASeAGUA.br.com.projeto.CONEXAO;
using AppGASeAGUA.br.com.projeto.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGASeAGUA.br.com.projeto.DAO
{
    public class FornecedoresDAO
    {
        private MySqlConnection conexao;
        public FornecedoresDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();

        }
        #region cadastrar Fornecedores
        public void CadastrarFornecedor(Fornecedores obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"insert into tb_Fornecedores(nome_fantasia,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome_fantasia,@cnpj,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome_fantasia", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
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

                MessageBox.Show("Fornecedor cadastrado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion


        
        #region AlterarFornecedor
        public void AlterarFornecedor(Fornecedores obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"update tb_fornecedores set nome_fantasia=@nome_fantasia,cnpj=@cnpj,email=@email,telefone=@telefone,
                             celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,
                             bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome_fantasia", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
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

                MessageBox.Show("Fornecedor alterado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion


        
        #region ListarFornecedores
        public DataTable ListarFornecedores()
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelafornecedores = new DataTable();

                string sql = "select * from tb_Fornecedores";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedores);
                conexao.Close();

                return tabelafornecedores;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion


        
        #region ExcluirFornecedor
        public void ExcluirFornecedor(Fornecedores obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"delete from tb_Fornecedores where id =@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome_fantasia", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
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

                MessageBox.Show("Fornecedor excluido com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion



        #region Buscar Fornecedor por nome
        public DataTable BuscarFornecedorPorNome(string nome)
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelafornecedores = new DataTable();

                string sql = "select * from tb_Fornecedores where nome_fantasia = @nome_fantasia";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.Parameters.AddWithValue("@nome_fantasia", nome);
                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedores);
                conexao.Close();

                return tabelafornecedores;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion
    }
}
