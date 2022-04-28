using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    /// <summary>
    /// Deneme Sınavlarına ilişkin Sorular
    /// </summary>
    public class ExerciseQuestion
    {
        [Key]
        public int ExerciseQuestionsId { get; set; }
        public int ExerciseId { get; set; }
        public int QuestionId { get; set; }
    }
}
