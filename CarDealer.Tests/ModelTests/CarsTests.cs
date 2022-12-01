using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Inventory.Models;

namespace Inventory.Test
{
  [TestClass]
  public class InventoryTests : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }

    [TestMethod]
    public void CarConstrutor_CreatesInstanceOfCar_Car()
    {
      Car newCar = new Car("plymouth", "voyager", 1986, 500);
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarList()
    {
      List<Car> newInventory = new List<Car> { };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newInventory, result);
    }
  }
}