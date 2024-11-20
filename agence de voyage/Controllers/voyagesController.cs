using agence_de_voyage.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace agence_de_voyage.Controllers
{
    public class voyagesController: Controller
    {
        private readonly ApplicationDbContext context;

        public voyagesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var voyages = context.voyages.ToList();

            // Vérifiez si voyages est vide avant de le passer à la vue
            if (voyages == null || !voyages.Any())
            {
                // Vous pouvez aussi logguer l'absence de données ici si nécessaire
                Console.WriteLine("Aucun voyage trouvé.");
            }

            // Passer la collection de voyages à la vue
            return View(voyages);
        }
    }
}
