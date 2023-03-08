using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pizza_project.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public float amount { get; set; }
        [ForeignKey("Pizza")]
        public int PizzaID { get; set; }
        public Pizza? Pizzas { get; set; }
    }
}
