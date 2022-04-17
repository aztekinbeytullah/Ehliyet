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
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public List<ListOfCategoriesQuestionsDTO> Questions(int categoryId)
        {
            //using (MyDbContext c = new MyDbContext())
            //{
            //      var joinguery =
            //                from category in c.Categories
            //                join question in c.Questions on category.CategoryId equals question.CategoryId
            //                orderby category.Name
            //                select new ListOfCategoriesQuestionsDTO
            //                {
            //                    Category = category.Name,
            //                    CategoryDesciriptons = category.Description,
            //                    QuestionId= question.QuestionId,    
            //                    Url=question.Image,
            //                    Answer=question.Answer,
            //                    DateOfUpload=question.DateOfUpload,
            //                    Difficulty=question.Difficulty
            //                };
            //    return joinguery.ToList();
            //}
            return null;

        }


    }


}
