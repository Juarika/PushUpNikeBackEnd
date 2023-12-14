namespace API.Dtos;

public class OrdenProductoDto
{
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public int IdOrden { get; set; }
    public int IdProducto { get; set; }
}