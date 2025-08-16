using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TimelyTastes.Models;

namespace TimelyTastes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var meals = HomeRepository.foodItemsList;
        return View(meals);
    }

    public IActionResult AddListing()
    {
        HomeRepository.Add(new Home(
    id: 1,
    vendorID: 101,
    imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT88ezWEuW-R3QYwijNkm16d1odtnIn3zubTw&s",
    name: "Cheese Burger",
    description: "Juicy beef burger with melted cheese",
    discountPrice: 45.00m,
    originalPrice: 60.00m,
    quantityAvailable: 10,
    availableFrom: DateTime.Now,
    availableUntil: DateTime.Now.AddHours(6)
));

        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
