using GreatSchool.API.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.ConstrainedExecution;

namespace GreatSchool.API.Models
{
    public class Aluno
    {
        [Required]
        [Key()]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50)]
        public string Sobrenome { get; set; }

        [Required]
        [RegularExpression("\\([1-9]\\d\\)\\s9?\\d{4}-\\d{4}", ErrorMessage = "N�mero de telefone inv�lido")]
        public string Telefone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        [Required]
        public DateTime DataMatricula { get; set; }

        //1 aluno est� associado a 1 turma - ForeignKey
        //possui um nullable na propriedade ID e na propriedade de navegacao, significa que o relacionamento � opcional. Um aluno pode ter ou n�o uma turma.
        //porem o Id da turma nem o objeto de navegacao sao necessarios para criacao de um aluno
        public int? TurmaId { get; set; }

        public Turma? Turma { get; set; } //propriedade de navegacao https://stackoverflow.com/a/11508155/13156642
    }
}
