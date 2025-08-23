using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TimelyTastes.Models;

namespace TimelyTastes.Controllers;

public class OrderController : Controller
{

    public IActionResult Index(int mealID, int vendorID, int dID)
    {

        var viewModel = VendorFoodItemsViewModel.GetVendorFoodItem(mealID, vendorID, dID);
        if (viewModel == null)
            return RedirectToAction("NotFound", "Home");


        return View(viewModel);
    }


}