namespace API.Dtos;

public class ProductoDto
{
    public string Titulo { get; set; }
    public string Imagen { get; set; }
    public decimal Precio { get; set; }
    public int IdCategoria { get; set; }
}