using GreatSchool.API;
using GreatSchool.API.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace GreatSchool.API
{
    public class Aluno
    {
        [Key()]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Estado { get; set; }

        //propriedade de navegacao https://stackoverflow.com/a/11508155/13156642
        //1 aluno tem apenas 1 matricula
        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }

        //propriedade de navegacao https://stackoverflow.com/a/11508155/13156642
        //1 aluno está associado a 1 turma
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}
