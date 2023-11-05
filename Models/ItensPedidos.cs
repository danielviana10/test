/*using AspNetCore;*/
using System.ComponentModel.DataAnnotations.Schema;

namespace PadariaDoceAroma.Models
{

    [Table("TB_ITEN_PEDIDO")]
    public class ItensPedidos
    {

        // Tabela associativa 
        [Column("cd_item_pedido")]
        public int IdItemPedido { get; set; }


        // FAZER O ESQUEMA DE MANY TO ONE
        
        public int FK_Pedido { get; set; }



        public int FK_Produto { get; set; }


    }
}
