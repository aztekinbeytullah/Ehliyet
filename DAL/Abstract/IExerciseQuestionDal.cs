using Entity.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IExerciseQuestionDal : IGenericDal<ExerciseQuestion>
    {
        List<ExerciseQuestionsDTO> AllQuestionsOnExercise(int exerciseId);
    }
}
