using System.ComponentModel.DataAnnotations;

namespace WebAutoApp1.Data.Domain
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [MaxLength(50)]
        public string Address { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
