namespace Domain.Entities;

public class Orden : BaseEntity
{
    public string Direccion { get; set; } = null!;
    public decimal Total { get; set; }
    public int IdUser { get; set; }
    public User? User { get; set; }
    public int IdEstado { get; set; }
    public Estado? Estado { get; set; }
    public ICollection<OrdenProducto> OrdenProductos { get; set; } = new List<OrdenProducto>();
}