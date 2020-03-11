using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public int UsuarioId { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string  EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
        //regra de validacao
        public override void Validadte()
        {
            LimparMensagemValidacao();
            if (!ItensPedido.Any())
                MensagemValidacao.Add("Crítica - Favor informa item de pedido!");
            if (string.IsNullOrEmpty(CEP))
                MensagemValidacao.Add("Critca - Favor informar o CEP!");
        }
    }
}
