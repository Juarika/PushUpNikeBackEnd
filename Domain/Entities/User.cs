namespace Domain.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; } = null!;
    public string IdenNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<UserRol>? UsersRols { get; set; }
    public ICollection<Carrito>? Carritos { get; set; } 
    public ICollection<Orden> Ordenes { get; set; } = new List<Orden>();
}