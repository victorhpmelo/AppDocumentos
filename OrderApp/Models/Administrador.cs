using System.ComponentModel.DataAnnotations;

namespace OrderApp.Models
{
    public class Administrador
    {
        [Key]
        public int AdmId { get; set; }

        public string AdmNome { get; set; }

        public string Telefone { get; set; }

        public string? Email { get; set; }
    }
}
