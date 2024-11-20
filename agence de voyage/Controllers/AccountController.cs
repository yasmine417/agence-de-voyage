using agence_de_voyage.Models;
using agence_de_voyage.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace agence_de_voyage.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext context;

        public AccountController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var client = context.client.FirstOrDefault(c => c.Email == email && c.Password == password);

            if (client != null)
            {
                          return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Email ou mot de passe incorrect");
                return View();
            }
        }
        [HttpGet]
        public IActionResult Register()
        {
                     var client = new client();
            return View(client); 
        }

        [HttpPost]
        public IActionResult Register(client client)
        {
            if (ModelState.IsValid)
            {
                
                var existingClient = context.client.FirstOrDefault(c => c.Email == client.Email);
                if (existingClient != null)
                {
                             ModelState.AddModelError("Email", "L'email est déjà utilisé.");
                    return View(client);  
                }

               
                context.client.Add(client);
                context.SaveChanges();
                TempData["SuccessMessage"] = "Inscription réussie ! Vous pouvez maintenant vous connecter.";

                return RedirectToAction("Login");
            }

            return View(client);
        }
    }
}
