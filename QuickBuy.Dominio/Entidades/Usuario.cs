using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Nome { get; set; }
        public string Sobrenome { get; set; }


        //usuario pode ter nenhum ou vários pedidos
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
