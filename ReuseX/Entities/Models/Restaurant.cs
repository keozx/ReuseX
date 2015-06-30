using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Restaurant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]        
        public int IdRestaurant { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Address { get; set; }        

        [StringLength(50, MinimumLength = 3)]
        public string Latitude { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Longitude { get; set; }        

        [StringLength(50, MinimumLength = 3)]
        public string Telephone { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string City { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
