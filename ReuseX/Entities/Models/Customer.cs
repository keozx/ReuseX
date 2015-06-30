using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]        
        public int CustomerId { get; set; }

        [StringLength(50, MinimumLength = 3)]        
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [StringLength(12)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Address { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Latitude { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Longitude { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string City { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string IdFb { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string IdTwitter { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}
