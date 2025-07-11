namespace OrderApp.Models
{
    public enum PedidoStatus
    {
        Pendente,
        EmTransito,
        Entregue
    }
    public enum Sigilo 
    {
        Baixo,
        Medio,
        Alto
    }
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public PedidoStatus PedidoStatus { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public double Preco {  get; set; }
        public Sigilo Sigilo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
    }
}
