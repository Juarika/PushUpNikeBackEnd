namespace API.Dtos;

public class ClienteDto
{
    public string IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaRegistro { get; set; }
    public int IdUser { get; set; }
}