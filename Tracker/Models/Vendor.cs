using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor>{};
    
    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      Id = _instances.Count;
      _instances.Add(this);
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}