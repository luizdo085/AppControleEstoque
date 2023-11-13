using AppGASeAGUA.br.com.projeto.DAO;
using AppGASeAGUA.br.com.projeto.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGASeAGUA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            //botão entrar
            string email = txtemail.Text;
            string senha = txtsenha.Text;

            FuncionariosDAO dao = new FuncionariosDAO();

            if (dao.EfetuarLogin(email, senha) == true)
            {

                this.Hide();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtsenha_Click(object sender, EventArgs e)
        {
            txtsenha.Text = "";
            txtsenha.PasswordChar = '*';
        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
        }
    }
}
