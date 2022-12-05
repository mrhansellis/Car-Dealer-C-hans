using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class InventoryController : Controller
  {
    [HttpGet("/index")]
    public ActionResult Index()
    {
      List<Car> allInventory = Car.GetAll();
      return View(allInventory);
    }

    [HttpGet("/index/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/index")]
    public ActionResult NewCar(string make, string model, int year, int price)
    {
      Car newCar = new Car(make, model, year, price);
      newCar.Make = make;
      newCar.Model = model;
      newCar.Year = year;
      newCar.Price = price;
      return RedirectToAction("Index");
    }

    [HttpPost("/index/delete")]
    public ActionResult DeleteAll()
    {
      Car.ClearAll();
      return View();
    }
  }
}