using BLL.Abstract;
using DAL.Abstract;
using DAL.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class ExerciseQuestionManager : IExerciseQuestionServices
    {
        IExerciseQuestionDal _exerciseQuestionDal;
    
        public ExerciseQuestionManager(IExerciseQuestionDal exerciseQuestionDal)
        {
            _exerciseQuestionDal=exerciseQuestionDal;
        }

        public void Add(ExerciseQuestion exerciseQuestion)
        {
            _exerciseQuestionDal.Add(exerciseQuestion);
        }

        public ExerciseQuestion GetById(int id)
        {
            return _exerciseQuestionDal.GetById(id);
        }

        public List<ExerciseQuestion> GetList()
        {
            return _exerciseQuestionDal.GetList();
        }

        public void Remove(ExerciseQuestion exerciseQuestion)
        {
            _exerciseQuestionDal.Remove(exerciseQuestion);
        }

        public void Update(ExerciseQuestion exerciseQuestion)
        {
            _exerciseQuestionDal.Update(exerciseQuestion);
        }
    }
}
