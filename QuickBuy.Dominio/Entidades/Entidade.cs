using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        //classe pai eh essa aqui
        public List<string> _mensagemValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get
            {
                return _mensagemValidacao ?? (_mensagemValidacao = new List<string>());
            }
        }
        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }
        public abstract void Validadte();
        protected bool EhValidado
        {//senao tiver nenhuma mensagem de validacao, esntao ehValidado=true
            get { return !(MensagemValidacao.Any()); }            }
        }
    }
}
