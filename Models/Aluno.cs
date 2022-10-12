using GreatSchool.API;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GreatSchool.API
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public static Collection<Aluno> TodosOsAlunos()
        {
            var alunos = new Collection<Aluno>()
            {
                new Aluno { Id = 1, Nome = "Marta", Sobrenome = "Souza", Telefone = "333232244"}, 
                new Aluno { Id = 2, Nome = "Julia", Sobrenome = "Maria", Telefone = "26754744"}, 
                new Aluno { Id = 3, Nome = "Paula", Sobrenome = "Fernande", Telefone = "332322"}, 
                new Aluno { Id = 4, Nome = "Laura", Sobrenome = "Duarte", Telefone = "365432244"}, 
                new Aluno { Id = 5, Nome = "Luiza", Sobrenome = "Caze", Telefone = "332276544"}, 
                new Aluno { Id = 6, Nome = "Lucas", Sobrenome = "Teodoro", Telefone = "33287244"}, 
                new Aluno { Id = 7, Nome = "Jose",  Sobrenome = "Casaski", Telefone = "33223444"}, 
                new Aluno { Id = 8, Nome = "Paulo", Sobrenome = "Ronaldo", Telefone = "3325543244"},
                new Aluno { Id = 8, Nome = "Paulo API", Sobrenome = "Ronaldo", Telefone = "3325543244"}
            };

            return alunos;
        }
    }
}
