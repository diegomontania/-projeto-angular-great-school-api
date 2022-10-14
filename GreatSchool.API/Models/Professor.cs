using System.ComponentModel.DataAnnotations;

namespace GreatSchool.API.Models
{
    public class Professor
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Disciplina { get; set; }
    }
}
