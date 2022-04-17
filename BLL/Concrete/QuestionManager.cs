using BLL.Abstract;
using DAL.Abstract;
using DAL.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class QuestionManager : IQuestionServices
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal=questionDal;
        }

        public void Add(Question question)
        {
            _questionDal.Add(question);
        }

        public Question GetById(int id)
        {
            return _questionDal.GetById(id);
        }

        public List<Question> GetList()
        {
            return _questionDal.GetList();
        }

        /// <summary>
        /// Kategorilerin ve Soruların "Join Model" Operasyonu
        /// </summary>
        /// <returns></returns>
        public List<QuestionModelDTO> QuestionModelWhitCategory()
        {
            return _questionDal.QuestionModelWhitCategory();
        }

        public void Remove(Question question)
        {
            _questionDal.Remove(question);
        }

        public void Update(Question question)
        {
            _questionDal.Update(question);
        }
    }
}
