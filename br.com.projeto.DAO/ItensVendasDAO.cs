using AppGASeAGUA.br.com.projeto.CONEXAO;
using AppGASeAGUA.br.com.projeto.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;

namespace AppGASeAGUA.br.com.projeto.DAO
{
    public class ItensVendasDAO
    {
        private MySqlConnection conexao;
        public ItensVendasDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();
        }

        #region método que cadastra um item de venda
        public void CadastrarItem(ItensVendas obj)
        {
            try
            {
                //1 passo definir o cmd sql "insert into" 
                string sql = @"insert into tb_itensvendas(venda_id,produto_id,qtd,subtotal)
                                    values (@venda_id,@produto_id,@qtd,@subtotal)";
                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.sub_total);

                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                conexao.Close();
            }
        }

        #endregion

        #region Método que lista todos os itens por venda
        public DataTable ListarItensPorVenda(int venda_id)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelaitens = new DataTable();

                string sql = @"SELECT  i.id as 'Código', 
	                                   p.descricao as'Descrição',
                                       i.qtd as 'Quantidade',
                                       p.preco as 'Preço',
                                       i.subtotal as 'SubTotal' 
                                       FROM tb_itensvendas as i join

                                       tb_produtos as p on(i.produto_id = p.id)
                                       where venda_id = @id;";

                //2 passo - Organizar e executar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", venda_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar My Sql Data Adpter para preencher os dados no data table
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaitens);

                //Fechar a conexao
                conexao.Close();

                return tabelaitens;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar cmd sql: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que exclui todos itemvenda de uma venda
        public void ExcluirItemVenda(ItensVendas obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"delete from tb_itensvendas where venda_id = @venda_id;";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);



                //abir conexão e executar cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

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
