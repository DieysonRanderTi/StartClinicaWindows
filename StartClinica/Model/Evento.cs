using System;
using System.ComponentModel.DataAnnotations;

namespace StartClinica.Model
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        [Required]
        public string DataEvento { get; set; }
        [Required]
        public string Horario { get; set; }
        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
