using System.ComponentModel.DataAnnotations.Schema;

namespace Mercadinho.Models
{
    [Table("TB_PRODUTO")]
    public class Item
    {
        [Column("cd_item")]
        public int Id { get; set; }

        [Column("nm_nome_item")]
        public String Nome { get; set; }

		[Column("vl_valor")]
		public double Valor { get; set; }

        [NotMapped]
        public Boolean Vegano { get; set; }

        [Column("ds_categoria")]
        public TipoCategoria Categoria { get; set; }


        [Column("ds_descrica")]
        public String Descricao { get; set; }
    }

}
