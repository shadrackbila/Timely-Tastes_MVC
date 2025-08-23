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

    [HttpPost]
    public IActionResult PayWithPayFast(decimal amount, string itemName)
    {

        string site = "https://sandbox.payfast.co.za/eng/process";


        var model = new Dictionary<string, string>
    {
        { "merchant_id", "10041413" },
        { "merchant_key", "sc4ufc371j03p" },
   { "return_url", "https://c5e3728f58a6.ngrok-free.app/payment/success" },
    { "cancel_url", "https://c5e3728f58a6.ngrok-free.app/payment/cancel" },
    { "notify_url", "https://c5e3728f58a6.ngrok-free.app/payment/notify" },
        { "amount", amount.ToString("F2") },
        { "item_name", itemName }
    };

        var query = string.Join("&", model.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
        var redirectUrl = $"{site}?{query}";

        return Redirect(redirectUrl);
    }

    [Route("payment/success")]
    public IActionResult Success()
    {
        // Payment successful
        return View();
    }

    public IActionResult Cancel()
    {
        // Payment cancelled
        return View();
    }

    [HttpPost]
    public IActionResult Notify()
    {
        // PayFast sends server-to-server notifications here
        return Ok();
    }


}