using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheClub.Models
{
    public class Produto
    {
        [Key]
        public int iDProduto { get; set; }

        [Required(ErrorMessage = " Você precisa preencher este campo.")]
        [MaxLength(100)]
        [Display(Name = "Nome")]
        public string iDNome { get; set; }
       

        [Required(ErrorMessage = " Você precisa preencher este campo.")]
        [MaxLength(1000)]
        [Display(Name = "Descrição")]

        public string Descricao { get; set; }


        [Required(ErrorMessage = " Você precisa preencher este campo.")]
        [Column(TypeName = "Decimal (18,2)")]
        [Display(Name = "Preço")]
        public decimal preco { get; set; }

        [Required(ErrorMessage = " Você precisa preencher este campo.")]
        [Display(Name = "Estoque")]
        public int estoque { get; set; }
    }
}
