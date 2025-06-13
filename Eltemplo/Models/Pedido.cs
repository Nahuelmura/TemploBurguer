namespace Eltemplo.Models;

public class Pedido
{
    public int PedidoID { get; set; }
    public int ClienteID { get; set; }
    public int VentaID { get; set; }
     public int ProductoID { get; set; }
    public Estado Estado { get; set; }


}

public enum Estado
{
    En_Espera = 1,
    Preparando,
    Finalizado,
    Enviado
}