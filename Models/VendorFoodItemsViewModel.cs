namespace TimelyTastes.Models
{
    public class VendorFoodItemsViewModel
    {
        public Home FoodItem { get; set; }
        public Vendors Vendor { get; set; }


        public static VendorFoodItemsViewModel GetVendorFoodItem(int mealID, int vendorID, int dID)
        {
            Home foodItem = HomeRepository.foodItemsList.FirstOrDefault(f => f.Id == mealID);
            Home userVendorID = HomeRepository.FoodItemsList.FirstOrDefault(f => f.VendorID == dID);
            Vendors vendor = VendorsRepository.vendorsList.FirstOrDefault(f => f.VendorID == vendorID);


            if (foodItem == null || vendor == null || userVendorID == null || vendorID != dID)
                return null;


            return new VendorFoodItemsViewModel
            {
                FoodItem = foodItem,
                Vendor = vendor
            };
        }

    }
}