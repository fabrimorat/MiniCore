using Microsoft.AspNetCore.Mvc;
using MiniCore.Services;

namespace MiniCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInformeRepository _informeRepository;

        public HomeController(IInformeRepository informeRepository)
        {
            _informeRepository = informeRepository;
        }

        public IActionResult Index()
        {
            var informes = _informeRepository.ObtenerTodos();
            return View(informes);
        }

        public IActionResult ObtenerPorRangoFecha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ObtenerPorRangoFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            var informes = _informeRepository.ObtenerPorRangoFecha(fechaInicio, fechaFin);
            return View("VisualizarPorFecha", informes);
        }

    }
}
