using System.ComponentModel.DataAnnotations;

namespace StartClinica.Model
{
    public class Horario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string HorarioEvento { get; set; }
    }
}
