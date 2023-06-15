namespace RestaurantManagementSystem
{
    public class Menu
    {
        public string Name { get; set; }
        public decimal Price  { get; set; }
        public string Ingredients { get; set; }
        public Category Category { get; set; }

    }
    public enum Category
    {
        Meat,
        Beverage,
        Dessert

    }
}