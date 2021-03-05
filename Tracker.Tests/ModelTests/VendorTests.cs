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

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Test vendor1";
      string description1 = "Test vendor1 Description";
      string name2 = "Test vendor2";
      string description2 = "Test vendor2 Description";
      string name3 = "Test vendor3";
      string description3 = "Test vendor3 Description";
      Vendor newVendor1 = new Vendor(name1,description1);
      Vendor newVendor2 = new Vendor(name2,description2);
      Vendor newVendor3 = new Vendor(name3,description3);
      List<Vendor> newVendorList = new List<Vendor>{newVendor1,newVendor2,newVendor3};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList,result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Test vendor1";
      string description1 = "Test vendor1 Description";
      string name2 = "Test vendor2";
      string description2 = "Test vendor2 Description";
      string name3 = "Test vendor3";
      string description3 = "Test vendor3 Description";
      Vendor newVendor1 = new Vendor(name1,description1);
      Vendor newVendor2 = new Vendor(name2,description2);
      Vendor newVendor3 = new Vendor(name3,description3);
      Vendor result = Vendor.Find(3);
      Assert.AreEqual(newVendor3,result);
    } 

  }
}