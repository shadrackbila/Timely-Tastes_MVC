namespace TimelyTastes.Models
{
    public class Home
    {


        public Home(int id, int vendorID, string imageUrl, string name, string description,
                          decimal discountPrice, decimal originalPrice, int quantityAvailable,
                          DateTime availableFrom, DateTime availableUntil)
        {
            Id = id;
            VendorID = vendorID;
            ImageUrl = imageUrl;
            Name = name;
            Description = description;
            DiscountPrice = discountPrice;
            OriginalPrice = originalPrice;
            QuantityAvailable = quantityAvailable;
            AvailableFrom = availableFrom;
            AvailableUntil = availableUntil;
        }




        public int Id { get; set; }

        public int VendorID { get; set; }

        public string ImageUrl { get; set; } = "";

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal DiscountPrice { get; set; }

        public decimal OriginalPrice { get; set; }

        public int QuantityAvailable { get; set; }

        public DateTime AvailableFrom { get; set; }

        public DateTime AvailableUntil { get; set; }


    }
}