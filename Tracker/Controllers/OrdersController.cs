using Microsoft.AspNetCore.Mvc;
using Tracker.Models;

namespace Tracker.Controllers
{
  public class OrdersController: Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor newVendor = Vendor.Find(vendorId);
      return View(newVendor);
    }
  }
}