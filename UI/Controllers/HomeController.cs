using BL;
using DAL;
using ENT;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using UI.Models;
using UI.Models.VM;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IActionResult result;

            try
            {
                clsListadoMisionVM listadoMisionVM = new clsListadoMisionVM();
                result = View(listadoMisionVM);
            } catch(HourException e)
            {
                ViewBag.Error = e;
                result = View("HourException");
            } catch(Exception e)
            {
                result = View("Error");
            }

            return result;
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            IActionResult result;

            try
            {
                clsMision mision = clsListadoMisionBL.buscarMisionPorId(id);

                clsListadoMisionVM listadoMisionVM = new clsListadoMisionVM(mision);

                result = View(listadoMisionVM);
            } catch(Exception ex)
            {
                result = View("Error");
            }

            return result;
        }

        public IActionResult Editar(int id)
        {
            clsMision mision = clsListadoMisionBL.buscarMisionPorId(id);
            return View(mision);
        }

        [HttpPost]
        public IActionResult Editar(clsMision mision)
        {
            clsListadoMisionBL.editarMision(mision);
            return View(mision);
        }

        public IActionResult Eliminar(int id)
        {
            clsMision mision = clsListadoMisionBL.buscarMisionPorId(id);
            return View(mision);
        }

        [HttpPost]
        public IActionResult Eliminar(clsMision mision)
        {
            clsListadoMisionBL.eliminarMision(mision.Id);
            return View(mision);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
