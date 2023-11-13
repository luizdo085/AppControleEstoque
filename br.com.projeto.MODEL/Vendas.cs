using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGASeAGUA.br.com.projeto.MODEL
{
    public class Vendas
    {
        //atributos e get e set
        public int id { get; set; }
        public int cliente_id { get; set; }
        public int funcionario_id { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total_venda { get; set; }
        public string observacao { get; set; }
        public string entrega_retirada { get; set; }
        public string forma_pagamento { get; set; }
    }
}
