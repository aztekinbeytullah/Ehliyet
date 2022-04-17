using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } //(int, not null)
        public string Name { get; set; } //(nvarchar(50), null)
        public string Description { get; set; } //(nvarchar(150), null)
        public string Image { get; set; }

        public List<Question> Questions { get; set; }
    }

}
