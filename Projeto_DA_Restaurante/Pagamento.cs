//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_DA_Restaurante
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagamento
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public int MetodoPagamentoId { get; set; }
        public int PedidoId { get; set; }
        public System.DateTime Data { get; set; }
        public int PromocaoIdPromocao { get; set; }
    
        public virtual MetodoPagamento MetodoPagamento { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Promocao Promocao { get; set; }
    }
}
