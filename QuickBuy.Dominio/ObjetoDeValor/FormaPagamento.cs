using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }

        public bool ehBoleto 
        {
            get {return Id == (int)TipoFormaPagamentoEnum.Boleto;}
        }
        public bool ehCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool ehDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }

        }
        public bool ehNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

    }
}
    

