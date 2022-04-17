﻿using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IQuestionDal : IGenericDal<Question>
    {
        List<QuestionModelDTO> QuestionModelWhitCategory();
    }
}