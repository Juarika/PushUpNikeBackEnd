namespace Domain.Entities;

public class Cliente : BaseEntity
{
    public string IdCliente { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public DateTime FechaRegistro { get; set; }
    public int IdUser { get; set; }
    public User? User { get; set; }
}