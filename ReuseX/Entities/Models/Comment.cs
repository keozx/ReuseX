using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommentId { get; set; }
        
        public int CustomerID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Description { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Image { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
