namespace Domain.Entities;

public class Carrito : BaseEntity
{
    public string Nombre { get; set; } = null!;
    public int IdUser { get; set; }
    public User? User { get; set; }
}