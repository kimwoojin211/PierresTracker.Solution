using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test","Test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test vendor";
      string description = "Test vendor description";
      Vendor newVendor = new Vendor(name,description);
      string result = newVendor.Name;
      Assert.AreEqual(name,result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Test vendor";
      string description = "Test vendor description";
      Vendor newVendor = new Vendor(name,description);
      string result = newVendor.Description;
      Assert.AreEqual(description,result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test vendor";
      string description = "Test vendor Description";
      Vendor newVendor = new Vendor(name,description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

  }
}