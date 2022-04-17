using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public  class ListOfCategoriesQuestionsDTO
    {
                            public string Category {get;set;}
                            public string CategoryDesciriptons {get;set;}
                            public int QuestionId {get;set;}
                            public string Url {get;set;}
                            public string Answer {get;set;}
                            public DateTime DateOfUpload {get;set;}
                            public byte[] Difficulty { get; set; }
    }
}
