using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfQuestionRepository : GenericRepository<Question>, IQuestionDal
    {

        public List<QuestionModelDTO> QuestionModelWhitCategory()
        {
            //using (MyDbContext c = new MyDbContext())
            //{
            //    var result = from que in c.Questions
            //                 join cat in c.Categories on que.CategoryId equals cat.CategoryId
            //                 select new QuestionModelDTO
            //                 {
                                 
            //                     //CategoryName=cat.Name,
            //                     //CategoryId=que.CategoryId,
            //                     Categorys=cat,
            //                     Answer=que.Answer,
            //                     Difficulty=que.Difficulty,
            //                     DateOfUpload=que.DateOfUpload,
            //                     QuestionId=que.QuestionId,
            //                 };
            //    return result.ToList();
            //}
            return null;
            
        }
    }


}
