using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheClub.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [DataType(DataType.Date, ErrorMessage ="O campo deve ter uma data válida.")]
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]

        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 dígitos.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas números.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [EmailAddress(ErrorMessage = "O formato do email é inválido.")]
        [StringLength(100, ErrorMessage = "O email não pode exceder 100 caracteres.")]
        public string Email { get; set; }
    }
}
