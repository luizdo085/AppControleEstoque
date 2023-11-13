using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGASeAGUA.br.com.projeto.CONEXAO
{
    public class ConnectionFactory
    {
        public MySqlConnection Getconnection()
        {
            try
            {
                string conexao = ConfigurationManager.ConnectionStrings["gaseagua"].ConnectionString;
                return new MySqlConnection(conexao);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar: " + erro);
                return null;
            }
        }
    }
}
