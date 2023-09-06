namespace Utb.PizzaKiosk.Models
{

    public abstract class PizzaOption
    {
        public int Id { get; set; }

        public required string Description { get; set; }
    }
}