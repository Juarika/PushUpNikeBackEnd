namespace Domain.Entities;

public class Pago : BaseEntity
{
    public string IdTransacion { get; set; } = null!;
    public DateOnly FechaPago { get; set; }
    public int IdOrden { get; set; }
    public Orden Orden { get; set; } = null!;
    public int IdFormaPago { get; set; }
    public FormaPago FormaPago { get; set; } = null!;
}