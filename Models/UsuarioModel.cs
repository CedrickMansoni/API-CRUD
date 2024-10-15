using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("tabela_usuario")]
public class UsuarioModel
{
    [Key]
    [Column("nif")]
    public string Nif {get; set;} = string.Empty;
    [Column("nome")]
    public string Nome {get; set;} = string.Empty;
    [Column("estado")]
    public bool Estado {get; set;}
}