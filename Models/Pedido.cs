using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PadariaDoceAroma.Models
{
    [Table("TB_PEDIDO")]
    public class Pedido
    {

        [Column("cd_pedido"), Key()]
        public int IdPedido { get; set; }


        [Column("dt_pedido")]
        public DateTime DataPedido { get; set; }

        [Column("nm_cliente")]
        public string NomeCliente{ get; set; }

        [Column("vl_produto")]
        public double valorPedido { get; set; }

        
        public int FkItemId { get; set; }

        public Item Item { get; set; }

    }
}
