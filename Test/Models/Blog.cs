using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models
{
    public class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; } 
        public string Url { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
