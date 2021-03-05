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
  }
}