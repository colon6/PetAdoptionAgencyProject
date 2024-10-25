using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetAdoptionAgencyProject.Data;
using PetAdoptionAgencyProject.Models;
using PetAdoptionAgencyProject.Models.Entities;


namespace PetAdoptionAgencyProject.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public AnimalsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AnimalViewModel animalViewModel)
        {
            var animal = new Animal
            {
                Name = animalViewModel.Name,
                Species = animalViewModel.Species,
                Breed = animalViewModel.Breed,
                Age = animalViewModel.Age,
                Weight = animalViewModel.Weight,

            };
            await dbContext.Animals.AddAsync(animal);
            await dbContext.SaveChangesAsync();

            return View();

        }

        [HttpGet]
        public async Task<IActionResult> ListAnimals()
        {
            var animals = await dbContext.Animals.ToListAsync();
            return View(animals);

        }

        [HttpGet]
        public async Task<IActionResult> editAnimal(Guid id)
        {
            var animal = await dbContext.Animals.FindAsync(id);
            return View(animal);
        }

        [HttpPost]
        public async Task<IActionResult> editAnimal(Animal viewAnimal)
        {
            var animal = await dbContext.Animals.FindAsync(viewAnimal.Id);
            if (animal is not null)
            {
                animal.Name = viewAnimal.Name;
                animal.Species = viewAnimal.Species;
                animal.Breed = viewAnimal.Breed;
                animal.Age= viewAnimal.Age;
                animal.Weight = viewAnimal.Weight;
                await dbContext.SaveChangesAsync();


            }

            return RedirectToAction("ListAnimals", "Animals");
        }

        [HttpPost]
        public async Task<IActionResult> deleteAnimal(Animal viewAnimal)
        {
            var animal = await dbContext.Animals.FindAsync(viewAnimal.Id);
            if (animal is not null)
            {
                dbContext.Animals.Remove(animal);
                await dbContext.SaveChangesAsync();

            }
            return RedirectToAction("ListAnimals", "Animals");
        }


    }
}
