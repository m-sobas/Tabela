using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tabela.Models.Domains;
using Tabela.Models.ViewModels;

namespace Tabela.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var vm = new TemplateViewModel
        {
            Id = 1,
            Name = "Szablon Nr 1",
            DateTime = DateTime.Now,
            Queries = new List<Query>
            {
                new Query
                {
                    Id = 11,
                    Radio = true,
                    Counter = null,
                    File = null
                },
                new Query
                {
                    Id = 12,
                    Radio = false,
                    Counter = 10,
                    File = null
                },
                new Query
                {
                    Id = 13,
                    Radio = true,
                    Counter = 20,
                    File = null
                }
            }
        };

        return View(vm);
    }

    [HttpPost]
    public IActionResult SendForm(TemplateViewModel template)
    {
        return Json(new { success = true, message = "Dane zosta³y zapisane", data = template });
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
