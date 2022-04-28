using DAL.Abstract;
using DAL.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfExerciseQuestionRepository :GenericRepository<ExerciseQuestion>,IExerciseQuestionDal
    { 
      
    }
}
