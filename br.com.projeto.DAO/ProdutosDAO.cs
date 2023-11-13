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

    public class ProdutosDAO
    {
        private MySqlConnection conexao;
            public ProdutosDAO()
            {
                this.conexao = new ConnectionFactory().Getconnection();
            }

        #region cadastrar Produto
            public void CadastrarProduto(Produtos obj)
            {
                try
                {       //1 passo definir o cmd sql "insert into" 
                    string sql = @"insert into tb_Produtos(descricao,preco,qtd_estoque,for_id)
                                    values (@descricao,@preco,@qtd_estoque,@for_id)";
                    //2 passo organizar o cmd sql
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                    executacmd.Parameters.AddWithValue("@preco", obj.preco);
                    executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                    executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                    //abir conexão e executar cmd
                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MessageBox.Show("Produto cadastrado com sucesso");
                    conexao.Close();

                }

                catch (Exception erro)
                {

                    MessageBox.Show("aconteceu o erro:" + erro);
                }

            }
            #endregion


        
        #region AlterarProduto
            public void AlterarProduto(Produtos obj)
            {
                try
                {       //1 passo definir o cmd sql "insert into" 
                    string sql = @"update tb_Produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque, for_id=@for_id where id=@id";

                    //2 passo organizar o cmd sql
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@id", obj.id);
                    executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                    executacmd.Parameters.AddWithValue("@preco", obj.preco);
                    executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                    executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                    //abir conexão e executar cmd
                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MessageBox.Show("Produto alterado com sucesso");
                    conexao.Close();

                }

                catch (Exception erro)
                {

                    MessageBox.Show("aconteceu o erro:" + erro);
                }

            }
        #endregion


        
        #region ListarProdutosPorNome
        public DataTable ListarProdutosPorNome(string nome)
            {
                try
                {
                    //1 passo criar data table retorno e cmd sql
                    DataTable tabelaProdutos = new DataTable();

                    string sql = @"SELECT   tb_produtos.id as 'Código', 
		                                    tb_produtos.descricao as 'Descrição',
                                            tb_produtos.preco as 'Preço', 
                                            tb_produtos.qtd_estoque as 'Qtd Estoque', 
                                            tb_fornecedores.nome_fantasia as 'Fornecedores' FROM tb_produtos
                                            join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id)
                                            where tb_produtos.descricao like @nome;";

                    //2 passo é organozar o cmd sql e executar
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome);
                    conexao.Open();

                    executacmd.ExecuteNonQuery();
                    // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelaProdutos);
                    conexao.Close();

                    return tabelaProdutos;

                }
                catch (Exception erro)
                {

                    MessageBox.Show("Erro ao executar o comando sql: " + erro);
                    return null;
                }
            }
            #endregion


        
        #region ExcluirProduto
            public void ExcluirProduto(Produtos obj)
            {
                try
                {       //1 passo definir o cmd sql "insert into" 
                    string sql = @"delete from tb_Produtos where id =@id";

                    //2 passo organizar o cmd sql
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@id", obj.id);

                    //abir conexão e executar cmd
                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MessageBox.Show("Produto excluido com sucesso");
                    conexao.Close();

                }

                catch (Exception erro)
                {

                    MessageBox.Show("aconteceu o erro:" + erro);
                }

            }
            #endregion



        #region Buscar Produto por nome
            public DataTable BuscarProdutoPorNome(string nome)
            {
                try
                {
                    //1 passo criar data table retorno e cmd sql
                    DataTable tabelaProdutos = new DataTable();

                    string sql = @"SELECT   tb_produtos.id as 'Código', 
		                                    tb_produtos.descricao as 'Descrição',
                                            tb_produtos.preco as 'Preço', 
                                            tb_produtos.qtd_estoque as 'Qtd Estoque', 
                                            tb_fornecedores.nome_fantasia as 'Fornecedores' FROM tb_produtos
                                            join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id)
                                            where descricao = @nome";

                    //2 passo é organozar o cmd sql e executar
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                    executacmd.Parameters.AddWithValue("@nome", nome);
                    conexao.Open();

                    executacmd.ExecuteNonQuery();
                    // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelaProdutos);
                    conexao.Close();

                    return tabelaProdutos;

                }
                catch (Exception erro)
                {

                    MessageBox.Show("Erro ao executar o comando sql: " + erro);
                    return null;
                }
            }
        #endregion



        #region ListarProdutos
        public DataTable ListarProdutos()
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelaProdutos = new DataTable();

                string sql = @"SELECT   tb_produtos.id as 'Código', 
		                                    tb_produtos.descricao as 'Descrição',
                                            tb_produtos.preco as 'Preço', 
                                            tb_produtos.qtd_estoque as 'Qtd Estoque', 
                                            tb_fornecedores.nome_fantasia as 'Fornecedores' FROM tb_produtos
                                            join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id);";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProdutos);
                conexao.Close();

                return tabelaProdutos;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion



        #region Metodo que retorna um produto por codigo
        public Produtos RetornaUmProdutoPorCodigo(int id)
        {
            try{
                //1 - criar o comando sql
                string sql = @"select * from tb_produtos where id = @id";

                //2 - organizar executar o comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("id", id);
                conexao.Open();

                //3 criar data reader
                MySqlDataReader rs = executacmd.ExecuteReader();

                if(rs.Read())
                {
                    Produtos p = new Produtos();

                    p.id = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");

                    conexao.Close();

                    return p;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado com esse código!");

                    conexao.Close();

                    return null;
                }
            }
            catch(Exception erro) 
            {
                MessageBox.Show("Aconteceu um erro" + erro);
                return null;
            }
        }

        #endregion



        #region Método que baixa o estoque
        public void BaixaEstoque(int id_produto,int qtd_estoque)
        {
            try
            {
                //1 passo definir o cmd sql "update" 
                string sql = @"update tb_Produtos set qtd_estoque=@qtd where id=@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id_produto);
                executacmd.Parameters.AddWithValue("@qtd", qtd_estoque);

                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        #endregion



        #region Método que aumenta o estoque caso tenha um venda excluida
        public void AumentaEstoque(int id_produto, int qtd_estoque)
        {
            try
            {
                //1 passo definir o cmd sql "update" 
                string sql = @"update tb_Produtos set qtd_estoque=@qtd where id=@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id_produto);
                executacmd.Parameters.AddWithValue("@qtd", qtd_estoque);

                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

#endregion



        #region Método que retorna o estoque atual de um produto
        public int RetornaEstoqueAtual (int id_produto)
        {
            try
            {
                int qtd_estoque = 0;

                //fazer comando sql
                string sql = @"select qtd_estoque from tb_produtos where id = @id";

                //organizar e executar o cmd 
                MySqlCommand executacmd = new MySqlCommand (sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id_produto);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();
                
                if( rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");
                    conexao.Close ();
                }

                return qtd_estoque;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return 0;
            }
        }


        #endregion
    }
}
