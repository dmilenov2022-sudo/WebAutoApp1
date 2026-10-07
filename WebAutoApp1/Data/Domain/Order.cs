using System.ComponentModel.DataAnnotations;

namespace WebAutoApp1.Data.Domain
{
    public class Order
    {
       
            public int Id { get; set; }

            [Required]
            public int CarId { get; set; }

            public virtual Car Car { get; set; } = null!;

            [Required]
            public int ClientId { get; set; }

            public virtual Client Client { get; set; } = null!;

            [Required]
            public DateTime OrderDate { get; set; }
        }
    }
