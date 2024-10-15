using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheClub.Models
{
    public class Entrada
    {
        [Key]
        public int IdEntrada { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo deve ter uma data e hora válidas.")]
        [DisplayName("Data e Hora da Entrada")]
        public DateTime DataHoraEntrada { get; set; }
    }
}
