﻿using AppGASeAGUA.br.com.projeto.CONEXAO;
using AppGASeAGUA.br.com.projeto.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGASeAGUA.br.com.projeto.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().Getconnection();

        }


        #region cadastrar cliente
        public void CadastrarCliente(Cliente obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"insert into tb_clientes(nome,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente cadastrado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion


        
        #region AlterarCliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"update tb_clientes set nome=@nome,cpf=@cpf,email=@email,telefone=@telefone,
                             celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,
                             bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente alterado com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion


        
        #region ListarClientes
        public DataTable ListarClientes()
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
                conexao.Close();

                return tabelacliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion


         
        #region ExcluirCliente
        public void ExcluirCliente(Cliente obj)
        {
            try
            {       //1 passo definir o cmd sql "insert into" 
                string sql = @"delete from tb_clientes where id =@id";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente excluido com sucesso");
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro:" + erro);
            }

        }
        #endregion



        #region Buscar cliente por nome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //1 passo criar data table retorno e cmd sql
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes where nome = @nome";

                //2 passo é organozar o cmd sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                executacmd.Parameters.AddWithValue("@nome", nome);
                executacmd.ExecuteNonQuery();
                // 3 passo criar MySqlDataAdapter para prencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
                conexao.Close();

                return tabelacliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion



        #region Método que retorna dados do cliente por cpf
        public Cliente RetornaDadosClientePorCpf(string cpf)
        {
            try
            {
                //1 passo criar o comando sql e o obj cliente
                Cliente obj = new Cliente();
                string sql = @"select * from tb_clientes where cpf=@cpf";

                //2 passo organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                //abir conexão, pegar as informações da tabela cliente e  executar cmd
                conexao.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();
                if (rs.Read())
                {
                    obj.id = rs.GetInt32("id");
                    obj.nome = rs.GetString("nome");
                    obj.endereco = rs.GetString("endereco");
                    obj.numero = rs.GetInt32("numero");
                    obj.bairro = rs.GetString("bairro");
                    obj.cidade = rs.GetString("cidade");
                    obj.estado = rs.GetString("estado");

                    conexao.Close();
                    return obj;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");

                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }


        #endregion

    }
}
