namespace Domain.Entities;

public class Estado : BaseEntity
{
    public string Descripcion { get; set; } = null!;
    public ICollection<Orden> Ordenes { get; set; } = new List<Orden>();
}