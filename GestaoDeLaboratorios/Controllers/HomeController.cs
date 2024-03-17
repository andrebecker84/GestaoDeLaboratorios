using GestaoDeLaboratorios.DAL;
using GestaoDeLaboratorios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GestaoDeLaboratorios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InfnetDbContext _context; // DbContext

        public HomeController(ILogger<HomeController> logger, InfnetDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var listaComputadores = await _context.Computadores.ToListAsync(); // Obtém a lista de computadores do banco de dados
            return View(listaComputadores);
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