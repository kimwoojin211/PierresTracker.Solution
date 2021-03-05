using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order("a","b","c","d");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    
    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    
    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string newTitle = "Sike. New title.";
      newOrder.Title = newTitle;
      string result = newOrder.Title;
      Assert.AreEqual(newTitle, result);
    }
    
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string newDescription = "Sike. New description.";
      newOrder.Description = newDescription;
      string result = newOrder.Description;
      Assert.AreEqual(newDescription, result);
    }
        
    [TestMethod]
    public void SetPrice_SetPrice_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string newPrice = "Sike. New price.";
      newOrder.Price = newPrice;
      string result = newOrder.Price;
      Assert.AreEqual(newPrice, result);
    }
            
    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string title = "Test title";
      string description = "Test description";
      string price = "Test price";
      string date = "Test date";
      Order newOrder = new Order(title,description,price,date);
      string newDate = "Sike. New date.";
      newOrder.Date = newDate;
      string result = newOrder.Date;
      Assert.AreEqual(newDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order>{};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList,result);
    }

  }
}