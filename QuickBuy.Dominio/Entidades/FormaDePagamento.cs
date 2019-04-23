using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.Entidades
{
    public class FormaDePagamento
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }


        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool EhBCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

    }
}