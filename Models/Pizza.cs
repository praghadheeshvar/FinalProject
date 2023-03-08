using System.ComponentModel.DataAnnotations;

namespace Pizza_project.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        public string? PizzaName { get; set; }
        public string? Type { get; set; }
        public string? Speciality { get; set; }
        public string? Crust { get; set; }
        public int Price { get; set; }
        public string? No_Of_Slices { get; set; }
        ICollection<Order> orders { get; set; }
    }
}
