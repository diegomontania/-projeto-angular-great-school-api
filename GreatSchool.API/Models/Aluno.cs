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

        public string Email { get; set; }

        public string Estado { get; set; }
    }
}
