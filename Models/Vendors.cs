namespace TimelyTastes.Models
{
    public class Vendors
    {
        public Vendors(int shopId, int vendorID, string logo, string name, string bio, string adress, string shopOwnerName)
        {
            ShopId = shopId;
            VendorID = vendorID;
            Logo = logo;
            Name = name;
            Bio = bio;
            Adress = adress;
            ShopOwnerName = shopOwnerName;
        }

        public int ShopId { get; set; } = 0;

        public int VendorID { get; set; } = 0;

        public string Logo { get; set; } = "";

        public string Name { get; set; } = "";

        public string Bio { get; set; } = "";

        public string Adress { get; set; } = "";

        public string ShopOwnerName { get; set; } = "";

        public int FoodQuality { get; set; } = 0;

        public int FoodQuantity { get; set; } = 0;

        public int FoodVariety { get; set; } = 0;

        public int CollectionExperience { get; set; } = 0;

        public double Rating { get; set; } = 0;

        public int SavedMeals { get; set; } = 0;

        public int TotalReviews { get; set; } = 0;

    }
}