using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.Dominio.Entidades
{
    public class Admin
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        public string  Nome { get; set; } = default!;

        [Required]
        public string  Email { get; set; } = default!;

        public string Senha { get; set; } = default!;

        public string Perfil { get; set; } = default!;

    }
}
