using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; } //(int, not null)
        public string Name { get; set; } //(nvarchar(50), null)
        public string Description { get; set; } //(nvarchar(150), null)
        public int Difficulty { get; set; }
        public int QuestionCount { get; set; }
        public DateTime CreatedTime { get; set; }

        public int CategoryId { get; set; }



        //public List<Question> questions { get; set; }


    }
}
