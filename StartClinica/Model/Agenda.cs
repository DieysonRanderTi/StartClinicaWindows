using System;
using System.ComponentModel.DataAnnotations;

namespace StartClinica.Model
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        [Required]
        [Display(Name ="Data de Agendamento")]
        public DateTime DataAgendamento { get; set; }
        [Required]
        [Display(Name = "Horário")]
        public string Horario { get; set; }
        [Required]
        [MaxLength(200)]
        public string Motivo { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }

    }
}
