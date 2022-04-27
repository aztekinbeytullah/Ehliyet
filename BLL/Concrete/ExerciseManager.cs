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
    public class ExerciseManager : IExerciseServices
    {
        IExerciseDal _exerciseDal;
    
        public ExerciseManager(IExerciseDal exerciseDal)
        {
            _exerciseDal=exerciseDal;
        }

        public void Add(Exercise exercise)
        {
            _exerciseDal.Add(exercise);
        }

        public void AddQuestionOnExercise(List<Question> questions)
        {
        }

        public Exercise GetById(int id)
        {
            return _exerciseDal.GetById(id);
        }

        public List<Exercise> GetList()
        {
            return _exerciseDal.GetList();
        }

        public void Remove(Exercise exercise)
        {
            _exerciseDal.Remove(exercise);
        }

        public void Update(Exercise exercise)
        {
            _exerciseDal.Update(exercise);
        }
    }
}
