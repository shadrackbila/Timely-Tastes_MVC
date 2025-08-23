namespace TimelyTastes.Models
{
    public class VendorFoodItemsViewModel
    {
        public Home FoodItem { get; set; }
        public Vendors Vendor { get; set; }


        public static VendorFoodItemsViewModel GetVendorFoodItem(int mealID, int vendorID)
        {
            Home foodItem = HomeRepository.foodItemsList.FirstOrDefault(f => f.Id == mealID);
            Vendors vendor = VendorsRepository.vendorsList.FirstOrDefault(f => f.VendorID == vendorID);


            if (foodItem == null || vendor == null)
                return null;


            return new VendorFoodItemsViewModel
            {
                FoodItem = foodItem,
                Vendor = vendor
            };
        }

    }
}