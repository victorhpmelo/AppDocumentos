using System.ComponentModel.DataAnnotations;

namespace OrderApp.Models
{
    public class Administrador
    {
        [Key]
        public int AdmId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome pode ter no máximo 100 caracteres.")]

        public string? AdmNome { get; set; }

        [Phone(ErrorMessage = "Número de telefone inválido.")]

        public string? Telefone { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string? Email { get; set; }
    }
}

