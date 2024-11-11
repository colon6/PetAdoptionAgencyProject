using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetAdoptionAgencyProject.Data;
using PetAdoptionAgencyProject.Models;
using PetAdoptionAgencyProject.Models.Entities;


namespace PetAdoptionAgencyProject.Controllers
{
    public class CredentialsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CredentialsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Login()
            {
                return View();
            }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var valid = dbContext.Credentials.SingleOrDefault(u =>  u.Username == Model.Username && u.Password == Model.Password);

                if (valid != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credentials.");

                }

            }
            return View(Model);



        }

       


    }

}
