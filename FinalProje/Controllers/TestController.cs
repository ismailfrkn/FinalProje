using FinalProje.Models;
using FinalProje.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProje.Controllers
{
    public class TestController : Controller
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IActionResult Index()
        {
            var sorularModel = _context.Sorus.Select(x => new SoruModel()
            {
                Id = x.Id,
                Question = x.Question,
                Answer1 = x.Answer1,
                Answer2 = x.Answer2,
                Answer3 = x.Answer3,
                Answer4= x.Answer4

            }).ToList();
            return View(sorularModel);
        }
        public IActionResult Main()
        {
            var sorularModel = _context.Sorus.Select(x => new SoruModel()
            {
                Id = x.Id,
                Question = x.Question,
                Answer1 = x.Answer1,
                Answer2 = x.Answer2,
                Answer3 = x.Answer3,
                Answer4 = x.Answer4

            }).ToList();
            return View(sorularModel);
        }
        public IActionResult Detail(int id)
        {
            var soruModel = _context.Sorus.Select(x => new SoruModel()
            {
                Id = x.Id,
                Answer1 = x.Answer1,
                Answer2 = x.Answer2,
                Answer3 = x.Answer3,
                Answer4 = x.Answer4

            }).SingleOrDefault(x => x.Id == id);
            return View(soruModel);

        }
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(SoruModel model)
        {
            var soru = new Soru();
            soru.Question = model.Question;
            soru.Answer1 = model.Answer1;
            soru.Answer2 = model.Answer2;
            soru.Answer3 = model.Answer3;
            soru.Answer4 = model.Answer4;

            _context.Sorus.Add(soru);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var soruModel = _context.Sorus.Select(x => new SoruModel()
            {
                Id = x.Id,
                Question = x.Question,
                Answer1 = x.Answer1,
                Answer2 = x.Answer2,
                Answer3 = x.Answer3,
                Answer4 = x.Answer4

            }).SingleOrDefault(x => x.Id == id);
            return View(soruModel);
        }

        [HttpPost]
        public IActionResult Edit(SoruModel model)
        {
            var soru = _context.Sorus.SingleOrDefault(x => x.Id == model.Id);
            soru.Question = model.Question;
            soru.Answer1 = model.Answer1;
            soru.Answer2 = model.Answer2;
            soru.Answer3 = model.Answer3;
            soru.Answer4 = model.Answer4;

            _context.Sorus.Update(soru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var soruModel = _context.Sorus.Select(x => new SoruModel()
            {
                Id = x.Id,
                Question = x.Question,
                Answer1 = x.Answer1,
                Answer2 = x.Answer2,
                Answer3 = x.Answer3,
                Answer4 = x.Answer4

            }).SingleOrDefault(x => x.Id == id);
            return View(soruModel);
        }

        [HttpPost]
        public IActionResult Delete(SoruModel model)
        {
            var soru = _context.Sorus.SingleOrDefault(x => x.Id == model.Id);
            _context.Sorus.Remove(soru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
