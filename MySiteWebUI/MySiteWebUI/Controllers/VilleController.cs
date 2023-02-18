using Microsoft.AspNetCore.Mvc;
using MySiteWebUI.Models;

namespace MySiteWebUI.Controllers
{
    public class VilleController : Controller
    {
        public IActionResult Index()
        {
            int a = 10;
            var ville = new ToutesLesVillesViewModel();
            ville.Nom_ville = "Labé";
            ville.Nombre_Quartier = 25;

            return View(ville);
        }
    }
}
