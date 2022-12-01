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
  }
}