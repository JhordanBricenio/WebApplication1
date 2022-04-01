using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Persona")]
    public class User
    {

        [Column("idPersona")]
        public int id { get; set; }
        [Column("nombre")]
        public string name { get; set; }
        [Column("apellido")]
        public string lastname { get; set; }
        [Column("email")]
        public string email { get; set; }
    }
}
