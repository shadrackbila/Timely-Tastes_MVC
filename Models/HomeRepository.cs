namespace TimelyTastes.Models
{
    public static class HomeRepository
    {

        public static List<Home> FoodItemsList = new List<Home>();

        public static IEnumerable<Home> foodItemsList
        {
            get
            {
                return FoodItemsList;
            }
        }

        public static void Add(Home foodItem)
        {
            FoodItemsList.Add(foodItem);
        }
    }
}