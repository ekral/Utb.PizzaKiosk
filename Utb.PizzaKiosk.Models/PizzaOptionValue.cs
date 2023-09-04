namespace Utb.PizzaKiosk.Models
{
    public class PizzaOptionValue
    {
        public int Id { get; set; }
        public required int PizzaOptionId { get; set; }
        public required string PizzaOptionValueName { get; set; }
    }
}