namespace Domain.Entities;

public class Producto : BaseEntity
{
    public string Titulo { get; set; } = null!;
    public string Imagen { get; set; } = null!;
    public decimal Precio { get; set; }
    public int IdCategoria { get; set; }
    public Categoria? Categoria { get; set; }
    public ICollection<OrdenProducto> OrdenProductos { get; set; } = new List<OrdenProducto>();
}