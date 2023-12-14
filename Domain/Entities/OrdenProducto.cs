namespace Domain.Entities;

public class OrdenProducto : BaseEntity
{
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public int IdOrden { get; set; }
    public Orden? Orden { get; set; }
    public int IdProducto { get; set; }
    public Producto? Producto { get; set; }
}