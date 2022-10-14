using System;
using System.ComponentModel.DataAnnotations;

namespace GreatSchool.API.Models
{
    public class Matricula
    {
        [Key()]
        public int Id { get; set; }

        public DateTime DataMatricula { get; set; }

        public string TurnoMatriculado { get; set; }

    }
}
