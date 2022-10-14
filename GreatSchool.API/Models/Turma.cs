using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GreatSchool.API.Models
{
    public class Turma
    {
        [Key()]
        public int Id { get; set; }

        public string Turno { get; set; }

        //uma turma tem um professor
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        //propriedade de navegacao https://stackoverflow.com/a/11508155/13156642
        //1 turma pode ter N alunos, logo a turma tem uma lista de alunos associados a essa turma
        public ICollection<Aluno> Alunos { get; set; }
    }
}
