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

        List<VendorFoodItemsViewModel> meals = new List<VendorFoodItemsViewModel>();

        foreach (var foodItem in HomeRepository.foodItemsList)
        {
            var vendor = VendorsRepository.vendorsList.FirstOrDefault(f => f.VendorID == foodItem.VendorID);

            if (vendor != null)
            {
                meals.Add(new VendorFoodItemsViewModel
                {
                    FoodItem = foodItem,
                    Vendor = vendor
                });
            }
        }

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

        HomeRepository.Add(new Home(
            id: 2,
            vendorID: 102,
            imageUrl: "https://flouringkitchen.com/wp-content/uploads/2023/07/BW1A4089-2.jpg",
            name: "Strawberry Cake",
            description: "A light and fluffy sponge cake layered with fresh strawberries and whipped cream, topped with juicy strawberry slices and a drizzle of sweet strawberry glaze. Perfectly sweet, fruity, and irresistible for any occasion.",
            discountPrice: 105.00m,
            originalPrice: 200.00m,
            quantityAvailable: 10,
            availableFrom: DateTime.Now,
            availableUntil: DateTime.Now.AddHours(6)
        ));

        HomeRepository.Add(new Home(
id: 3,
vendorID: 101,
imageUrl: "https://www.kikkoman.eu/fileadmin/_processed_/4/2/csm_sushi-kakkoii_2c56fe3133.webp",
name: "Sushi",
description: "Juicy beef burger with melted cheese",
discountPrice: 45.00m,
originalPrice: 60.00m,
quantityAvailable: 10,
availableFrom: DateTime.Now,
availableUntil: DateTime.Now.AddHours(6)
));


        return RedirectToAction("Index");
    }

    public ViewResult Extended(int mealID, int vendorID)
    {

        var viewModel = VendorFoodItemsViewModel.GetVendorFoodItem(mealID, vendorID);
        if (viewModel == null)
            return NotFound();

        return View(viewModel);
    }

    public ViewResult NotFound()
    {
        return View();
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
