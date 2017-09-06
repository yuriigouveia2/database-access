using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Treinamento_WebApi.Dockers
{
    public class FaculdadeContext : DbContext
    {
        public FaculdadeContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }

    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Matricula { get; set; }

        public string Email { get; set; }
    }
}
