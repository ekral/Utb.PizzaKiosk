namespace Utb.PizzaKiosk.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public required string Name { get; init; }
        public required string Description { get; init; }
    }

    class Skupina
    {
        public string Nazev { get; set; }
        public int Id { get; set; }
    }

    class Student
    {
        public Skupina Skupina { get; set; }
    }
}