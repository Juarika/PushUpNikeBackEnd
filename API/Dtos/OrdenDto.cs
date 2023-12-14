namespace API.Dtos;

public class OrdenDto
{
    public string Direccion { get; set; }
    public decimal Total { get; set; }
    public int IdUser { get; set; }
    public int IdEstado { get; set; }
}