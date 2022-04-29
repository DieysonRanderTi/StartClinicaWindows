using System;
using System.ComponentModel.DataAnnotations;

namespace StartClinica.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }
        [MaxLength(11)]
        public string CPF { get; set; }
        [Required]
        [MaxLength(14)]
        public string TelefoneContato { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string Foto { get; set; }

        //ENDEREÇO
        [MaxLength(8)]
        public string CEP { get; set; }
        [MaxLength(100)]
        public string Rua { get; set; }
        [MaxLength(20)]
        public string Numero { get; set; }
        [MaxLength(50)]
        public string Bairro { get; set; }
        [MaxLength(50)]
        public string Cidade { get; set; }
        [MaxLength(2)]
        public string EstadoUF { get; set; }
        [MaxLength(100)]
        public string Complemento { get; set; }

    }
}
