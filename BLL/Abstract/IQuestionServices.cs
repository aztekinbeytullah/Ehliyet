using BLL.Concrete;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IQuestionServices : IGenericServices<Question>
    {
        public List<QuestionModelDTO> QuestionModelWhitCategory();
    }
}
