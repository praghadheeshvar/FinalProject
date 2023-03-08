using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pizza_project.Models
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusUpdate { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        ICollection<Order> orders { get; set; }
    }
}
