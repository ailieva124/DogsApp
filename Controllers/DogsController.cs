using DogsApp.Data;
using DogsApp.Domain;
using DogsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DogsApp.Controllers
{
    public class DogsController : Controller
    {
        private readonly ApplicationDbContext context;

        public DogsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return this.View();
        }

        public IActionResult All()
        {
            List<DogAllViewModel> dogs = context.Dogs
                .Select(dogFromDb => new DogAllViewModel
                {
                    Name = dogFromDb.Name,
                    Age = dogFromDb.Age,
                    Breed = dogFromDb.Breed,
                    Picture = dogFromDb.Picture
                }).ToList();

            return this.View(dogs);
        }

        [HttpPost]
        public IActionResult Create(DogCreateViewModel bindingModel)
        {
            if(ModelState.IsValid)
            {
                Dog dogFromDb = new Dog
                {
                    Name = bindingModel.Name,
                    Age = bindingModel.Age,
                    Breed = bindingModel.Breed,
                    Picture = bindingModel.Picture
                };

                context.Dogs.Add(dogFromDb);
                context.SaveChanges();

                return this.RedirectToAction("Success");
            }

            return this.View();
        }

        public IActionResult Success()
        {
            return this.View();
        }
    }
}
