using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        
        public decimal Price { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
