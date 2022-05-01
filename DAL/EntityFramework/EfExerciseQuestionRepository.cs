using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using Entity.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfExerciseQuestionRepository : GenericRepository<ExerciseQuestion>, IExerciseQuestionDal
    {
        public List<ExerciseQuestionsDTO> AllQuestionsOnExercise(int exerciseId)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var queryResult = from eq in context.ExerciseQuestions
                            join q in context.Questions on eq.QuestionId equals q.QuestionId
                            join e in context.Exercises on eq.ExerciseId equals e.ExerciseId
                            join c in context.Categories on q.CategoryId equals c.CategoryId
                            where eq.ExerciseId==exerciseId
                            //orderby (h.Baslik)
                            select new ExerciseQuestionsDTO
                            {
                                ExerciseId = eq.ExerciseId,
                                QuestionId=eq.QuestionId,
                                ExerciseQuestionsId=eq.ExerciseQuestionsId,
                                CategoryId=q.CategoryId,
                                CategoryName=c.Name,
                                Answer=q.Answer,
                                Difficulty=q.Difficulty,
                                Image=q.Image
                            };

                return queryResult.ToList();
            }
        }
    }
}
