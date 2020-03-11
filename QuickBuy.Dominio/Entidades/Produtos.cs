using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produtos : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validadte()
        {
            throw new NotImplementedException();
        }
    }
}
