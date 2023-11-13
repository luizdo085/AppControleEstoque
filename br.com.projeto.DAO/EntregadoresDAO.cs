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
    public class EntregadoresDAO
    {
        private MySqlConnection conexao;
        public EntregadoresDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();

        }


        #region cadastrar Entregador
        public void CadastrarEntregador(Entregadores obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"insert into tb_entregadores(nome,cpf,rg,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome,@cpf,@rg,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
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

                MessageBox.Show("Entregador cadastrado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion



        #region AlterarEntregador
        public void AlterarEntregador(Entregadores obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"update tb_entregadores set nome=@nome,cpf=@cpf,rg=@rg,email=@email,telefone=@telefone,
                             celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,
                             bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
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

                MessageBox.Show("Entregador alterado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion



        #region ListarEntregadores
        public DataTable ListarEntregadores()
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelaEntregadores = new DataTable();

                string sql = "select * from tb_entregadores";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaEntregadores);
                conexao.Close();

                return tabelaEntregadores;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion



        #region ExcluirEntregador
        public void ExcluirEntregador(Entregadores obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"delete from tb_entregadores where id =@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
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

                MessageBox.Show("Entregadores excluido com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion



        #region Buscar Entregador por nome
        public DataTable BuscarEntregadorPorNome(string nome)
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelaEntregadores = new DataTable();

                string sql = "select * from tb_entregadores where nome = @nome";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.Parameters.AddWithValue("@nome", nome);
                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaEntregadores);
                conexao.Close();

                return tabelaEntregadores;

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
