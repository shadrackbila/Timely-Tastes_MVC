namespace TimelyTastes.Models
{
    public static class VendorsRepository
    {

        public static List<Vendors> VendorsList = new List<Vendors>();

        public static IEnumerable<Vendors> vendorsList
        {
            get
            {
                return VendorsList;
            }
        }

        public static void Add(Vendors vendors)
        {
            VendorsList.Add(vendors);
        }
    }
}