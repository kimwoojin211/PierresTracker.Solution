using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("a","b");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Vendor 1";
      string description = "Vendor 1 Description";
      Vendor newVendor = new Vendor(name,description);
      string result = newVendor.Name;
      Assert.AreEqual(name,result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Vendor 1";
      string description = "Vendor 1 Description";
      Vendor newVendor = new Vendor(name,description);
      string result = newVendor.Description;
      Assert.AreEqual(description,result);
    }
  }
}