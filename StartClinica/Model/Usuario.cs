using System.ComponentModel.DataAnnotations;

namespace StartClinica.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        [Required]
        [MaxLength(50)]
        public string Senha { get; set; }
        public bool EhAdministrador { get; set; }
        public bool Logado { get; set; }
    }
}
