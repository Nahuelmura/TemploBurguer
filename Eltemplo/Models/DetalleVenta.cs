namespace Eltemplo.Models;

public class DetalleVenta
{
    public int DetalleVentaID { get; set; }
    public int VentaID { get; set; }
    public int ProductoID { get; set; }
    public int Cantidad { get; set; }
    public decimal? PrecioUnitario { get; set; }

}
