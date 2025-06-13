namespace Eltemplo.Models;

public class HorarioPedido
{
    public int HorarioPedidoID { get; set; }
    public int PedidoID { get; set; }
    public DateTime FechaPedido { get; set; }
    public int CupoMaximo { get; set; }
  

}