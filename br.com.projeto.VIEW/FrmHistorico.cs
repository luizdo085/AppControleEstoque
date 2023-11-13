using AppGASeAGUA.br.com.projeto.DAO;
using MySqlX.XDevAPI;
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
    public partial class FrmHistorico : Form
    {
        int venda_id;
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));


            VendasDAO vdao = new VendasDAO();
            tabelahistorico.DataSource = vdao.ListarVendasPorPeriodo(datainicio, datafim);
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendasDAO dAO = new VendasDAO();

            tabelahistorico.DataSource = dAO.ListarVendas();
            tabelahistorico.DefaultCellStyle.ForeColor = Color.Black;

        }



        private void tabelahistorico_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //1 passo chamar a outro formulario e passando o valor do id da venda
            venda_id = int.Parse(tabelahistorico.CurrentRow.Cells[0].Value.ToString());
            FrmDetalhes tela = new FrmDetalhes(venda_id);

            //2 passo passando as informações pra outra tela
            tela.txtdata.Text = tabelahistorico.CurrentRow.Cells[1].Value.ToString();
            tela.txtcliente.Text = tabelahistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txttotalvenda.Text = tabelahistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtentrega_retirada.Text = tabelahistorico.CurrentRow.Cells[4].Value.ToString();
            tela.txtforma_pagamento.Text = tabelahistorico.CurrentRow.Cells[5].Value.ToString();
            tela.txtfuncionario.Text = tabelahistorico.CurrentRow.Cells[6].Value.ToString();
            tela.txtobs.Text = tabelahistorico.CurrentRow.Cells[7].Value.ToString();


            //passando id da venda


            //3 passo  abrindo o outro formulario
            tela.ShowDialog();
        }
    }
}
