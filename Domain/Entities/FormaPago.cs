namespace Domain.Entities;

public class FormaPago : BaseEntity
{
    public string Descripcion { get; set; } = null!;
    public ICollection<Pago>? Pagos { get; set; }
}