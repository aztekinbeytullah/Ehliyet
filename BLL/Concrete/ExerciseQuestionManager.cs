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
            _exerciseQuestionDal = exerciseQuestionDal;
        }

        public void Add(ExerciseQuestion TEntity)
        {
            _exerciseQuestionDal.Add(TEntity);
        }

        public ExerciseQuestion GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ExerciseQuestion> GetList()
        {
            throw new NotImplementedException();
        }

        public void Remove(ExerciseQuestion TEntity)
        {
            throw new NotImplementedException();
        }

        public void Update(ExerciseQuestion TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
