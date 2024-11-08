using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Entities
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Required, MaxLength(80, ErrorMessage = "Nome não poder exceder a 80 caracteres")]
        public string? Nome { get; set; }
        [EmailAddress]
        [Required, MaxLength(120)]
        public string? Email { get; set; }
        public int Idade { get; set; }
        [MaxLength(80)]
        public string?  Curso { get; set;}
    }
}
