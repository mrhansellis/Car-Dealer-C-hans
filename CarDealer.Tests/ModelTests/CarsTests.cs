using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Inventory.Models;

namespace Inventory.Test
{
  [TestClass]
  public class InventoryTests
  {
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
      Assert.AreEqual(newInventory, result);
    }
    
    
    
    /* [TestMethod]
    public void CarConstructor_SetsPropertiesOfCar_Properties()
    {
      string userInput1 = "plymouth";
      string userInput2 = "voyager";
      int userInput3 = 1986;
      int userInput4 = 500;
      Car newCar = new Car(userInput1, userInput2, userInput3, userInput4);
      string result = newCar.Make;
      Assert.AreEqual(userInput, result);
    }
    [TestMethod] */
  }
}