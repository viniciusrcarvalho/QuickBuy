using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {

        public int id { get; set; }
        public DateTime Datapedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataprevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaDePagamentoId { get; set; }

        public FormaDePagamento FormaDePagamento { get; set; }

        //pedido deve ter pelo menos um pedido
        //ou muitos pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; } 
    }
}
