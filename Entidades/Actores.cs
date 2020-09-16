using System.ComponentModel.DataAnnotations;

namespace RegistroEje.Entidades{

public class Actores{
    [Key]
    public int ActorId { get; set; }

    public string Nombres { get; set; }

    public int Salario { get; set; }
}

}
