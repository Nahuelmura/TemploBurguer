namespace Eltemplo.Models;

public class Venta
{
    public int VentaID { get; set; }
    public int ClienteID { get; set; }
    public DateTime? Fecha { get; set; }
    public decimal? Total { get; set; }
    public bool? FormaDePago { get; set; }


}
