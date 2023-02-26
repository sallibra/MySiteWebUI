using Data;
using Microsoft.AspNetCore.Mvc;
using MySiteWebUI.Models;

namespace MySiteWebUI.Controllers
{
    public class ModuleController : Controller
    {
        public IActionResult Index()
        {
            int a = 10;
            var ville = new ToutesLesVillesViewModel();
            ville.Nom_ville = "Labé";
            ville.Nombre_Quartier = 25;

            return View(ville);
        }

        public IActionResult TousLesModules() 
        {
            ModuleMemoryRepository repository = new ModuleMemoryRepository();
            List<LesModules> listModule = repository.GetAllModules();
            return View(listModule);
        }

    }
}
