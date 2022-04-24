using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class ExerciseQuestion
    {
        [Key]
        public int ExerciseQuestionId { get; set; }
        public Exercise Exercise { get; set; }
        public Question Question { get; set; }

    }
}
