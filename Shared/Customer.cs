using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Shared
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Street is required")]
        [StringLength(50)]
        public string Street { get; set; }
        [Required(ErrorMessage = "City is required")]
        [StringLength(20)]
        public string City { get; set; }
    }
}
