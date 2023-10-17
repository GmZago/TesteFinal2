using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TesteFinal.Models
{
    [Table("Bimestre")]
    public class Bimestre
    {
        [Column("BimestreId")]
        [Display(Name = "Código Bimestre")]
        public int Id { get; set; }

        [Column("BimestreDescricao")]
        [Display(Name = "Descricao do Bimestre")]
        public string BimestreDescricao { get; set; } = string.Empty;

    }
}
