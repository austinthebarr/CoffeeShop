using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoffeeShop.Models;
using System;

namespace CoffeeShop.Controllers
{
  // public class DrinksController : Controller
  // {
  //   [HttpGet("/drinks")]
  //   public ActionResult Index()
  //   {
  //     List<Drink> all = Drink.GetAll();
  //     return View(Drink.GetAll());
  //   }
  //
  //   [HttpPost("/drinks")]
  //   public ActionResult CollectInfo(string newDrink)
  //   {
  //     Drink newDrink = new Drink(newDrink);
  //     newDrink.Save();
  //     return RedirectToAction("Index");
  //   }
  //   [HttpGet("/drinks/new")]
  //   public ActionResult CreateForm()
  //   {
  //     return View(Drink.GetAll());
  //   }
  //
  //
  // }
}
