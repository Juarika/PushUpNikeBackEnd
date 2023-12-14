namespace Domain.Entities;

public class CarritoProducto : BaseEntity
{
    public int Cantidad { get; set; }
    public int IdCarrito { get; set; }
    public Carrito? Carrito { get; set; }
    public int IdProducto { get; set; }
    public Producto? Producto { get; set; }
}