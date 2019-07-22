/// 
///  HomeController presents the information.
///
///  It hosts the repo concrete implementation (exposed through DI), 
///  which can be anything, memory or DB, it's irrelevant for the web app
///  where the info is coming from, so the controller is not tied to specifics
///

using System.Diagnostics;
using System.Threading.Tasks;
using bhccsolution.Interface;
using bhccsolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace bhccsolution.Controllers
{
    public class HomeController : Controller
     {
        private readonly IRepo _repoService;                                                        //repo service
            
        public HomeController(IRepo repo)
        {
            _repoService = repo;                                                                    //inject & assign the registered concrete implementation
        }

        public async Task<IActionResult> Index()
        {
            return View(await _repoService.GetAll());                                                 //get the entries & present
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Details(uint id)
        {
            ReasonViewModel reason = await _repoService.GetById(id);                                //get the requested reason & present
            return View(reason);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
