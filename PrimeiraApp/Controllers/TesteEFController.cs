using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers {
    public class TesteEFController : Controller {

        public AppDbContext Db { get; set; }

        public TesteEFController(AppDbContext db) {
            Db = db;
        }

        public IActionResult Index() {

            var aluno = new Aluno() {
                Nome = "Henrique",
                Email = "henrique@email.com",
                DataNascimento = new DateTime(1996,11,26),
                Avaliacao = 5,
                Ativo = true
            };

            //Db.Alunos.Add(aluno);
            //Db.SaveChanges();

            var alunoChange = Db.Alunos.Where(a => a.Nome.Contains("Henrique")).FirstOrDefault();

            //alunoChange.Nome = "Henrique Santos";

            //Db.Alunos.Update(alunoChange);
            //Db.SaveChanges();

            Db.Alunos.Remove(alunoChange);
            Db.SaveChanges();

            return Content("");
        }
    }
}
