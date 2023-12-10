using Microsoft.AspNetCore.Mvc;
using WebApplication1__ctceTrainingPlural.Models;
using WebApplication1__ctceTrainingPlural.ViewModel;

namespace WebApplication1__ctceTrainingPlural.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        //'IPieRepository' & 'ICategoryRepository' injected by the Dependency Injection (no need for 'new')
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        // GET: /<controller>/
        public IActionResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
			piesListViewModel.Pies = _pieRepository.AllPies;
			piesListViewModel.CurrentCategory = "Cheese cakes";
			return View(piesListViewModel);
		}
    }
}
