using System.Security.Cryptography.X509Certificates;

namespace OrderApp.Models
{
    public class Cliente
    {

        public int ClienteId { get; set; }

        public string ClienteNome { get; set; }

        public string Telefone { get; set; }

        public string? Email { get; set; }

        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
