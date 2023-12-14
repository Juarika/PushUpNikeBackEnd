namespace API.Dtos;

public class PagoDto
{
    public string IdTransacion { get; set; }
    public DateOnly FechaPago { get; set; }
    public int IdOrden { get; set; }
    public int IdFormaPago { get; set; }
}