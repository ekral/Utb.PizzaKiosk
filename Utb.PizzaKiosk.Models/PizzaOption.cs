namespace Utb.PizzaKiosk.Models
{

    public class PizzaOption
    {
        public int Id { get; set; }

        public required PizzaOptionType PizzaOptionType { get; set; }
        public required string PizzaOptionName { get; set; }
        public required string PizzaOptionDescription { get; set; }
    }
}