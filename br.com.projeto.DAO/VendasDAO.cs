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
    public class VendasDAO
    {
        private MySqlConnection conexao;
        public VendasDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();
        }

        #region método que cadastra uma venda
        public void CadastrarVenda(Vendas obj)
        {
            try
            {
                //1 passo definir o cmd sql "insert into" 
                string sql = @"insert into tb_vendas(cliente_id,data_venda,total_venda,observacoes,entrega_retirada,forma_pagamento,funcionarios_id)
                                    values (@cliente_id,@data_venda,@total_venda,@observacoes,@entrega_retirada,@forma_pagamento,@funcionario_id)";
                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@observacoes", obj.observacao);
                executacmd.Parameters.AddWithValue("@entrega_retirada", obj.entrega_retirada);
                executacmd.Parameters.AddWithValue("@forma_pagamento", obj.forma_pagamento);
                executacmd.Parameters.AddWithValue("@funcionario_id", obj.funcionario_id);


                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion



        #region método que pega o id da ultima venda
        public int RetornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                // 1 passo criar comando sql
                string sql = @"select max(id) id from tb_vendas";

                //organizar o cmd
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //abir conexão e executar cmd
                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if(rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                }
                conexao.Close();
                return idvenda;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
                conexao.Close();
                return 0;
            }
        }

        #endregion



        #region Método que exibe historico de vendas
        public DataTable ListarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelahistorico = new DataTable();

                string sql = @"SELECT  v.id as 'Código',
	                                   v.data_venda as 'Data da venda',
                                       c.nome as 'Cliente',
                                       v.total_venda as 'Total',
                                       v.entrega_retirada as 'Entrega/Retirada',
                                       v.forma_pagamento as 'Forma de Pagamento',
                                       f.nome as 'Funcionario',
                                       v.observacoes as 'Observações'
                                       
       
                                       FROM tb_vendas as v  join tb_clientes as c on (v.cliente_id = c.id)
									   join tb_funcionarios as f on (v.funcionarios_id = f.id)
                                       where v.data_venda between @datainicio and @datafim";

                //2 passo - Organizar e executar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@datainicio", datainicio);
                executacmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar My Sql Data Adpter para preencher os dados no data table
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelahistorico);

                //Fechar a conexao
                conexao.Close();

                return tabelahistorico;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar cmd sql: " + erro);
                return null;
            }
        }
        
            
        #endregion



        #region Método que lista todas vendas
        public DataTable ListarVendas()
        {
            try
            {
                //1 passo criar cmd sql e data table
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT  v.id as 'Código',
	                                   v.data_venda as 'Data da venda',
                                       c.nome as 'Cliente',
                                       v.total_venda as 'Total',
                                       v.entrega_retirada as 'Entrega/Retirada',
                                       v.forma_pagamento as 'Forma de Pagamento',
                                       f.nome as 'Funcionario',
                                       v.observacoes as 'Observações'
                                       
       
                                       FROM tb_vendas as v  join tb_clientes as c on (v.cliente_id = c.id)
									   join tb_funcionarios as f on (v.funcionarios_id = f.id);";


                //2 passo é organizar e executar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo criar o mysqlDataAdpter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);

                //4 passo fechar conexão
                conexao.Close();
                return tabelaHistorico;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }
        #endregion



        #region Método que exclui(da um update e exclui valor e deixa uma observação) venda e deixa uma observação
        public void ExcluirVenda(Vendas obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"update tb_vendas set total_venda=""0.00"",
                               observacoes=@observacoes where id=@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@observacoes", obj.observacao);



                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Venda excluida com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion
    }
}
