using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Treinamento_WebApi.Dockers;

namespace Treinamento_WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        private FaculdadeContext _context;
        public AlunoController(FaculdadeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _context.Alunos.ToList();
        }

        public Aluno Get(int id)
        {
            return _context.Alunos.Where(x => x.Id == id).SingleOrDefault();
        }

        [HttpPost]
        public Aluno Post([FromBody]Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return aluno;
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Aluno aluno)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
