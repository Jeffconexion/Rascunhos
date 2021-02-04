using BookStore.Domain;
using BookStore.Repositories;
using BookStore.Repositories.Contracts;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class AutorController : Controller
    {
        private IAuthorRepository _repository;

        public AutorController(AuthorRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var autores = _repository.Get();
            return View(autores);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Autor autor)
        {
            return View(_repository.Create(autor));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            var autor = _repository.Get(id);
            return View(autor);
        }

        [HttpPost]
        public ActionResult Edit(Autor autor)
        {
            return View(_repository.Update(autor));
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var autor = _repository.Get(id);
            return View(autor);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}