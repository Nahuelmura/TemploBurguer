namespace Eltemplo.Models;

public class Producto
{

    public int ProductoID { get; set; }
    public string? Descripcion { get; set; }
    public decimal PrecioCosto { get; set; }
    public decimal PrecioVenta { get; set; }

    public int Stock { get; set; }

    public bool Disponible { get; set; }



}
