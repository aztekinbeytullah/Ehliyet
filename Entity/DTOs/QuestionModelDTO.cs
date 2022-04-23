using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public  class QuestionModelDTO
    {
        public int QuestionId { get; set; } 
        public IFormFile Image { get; set; }
        public string Answer { get; set; } 
        public DateTime DateOfUpload { get; set; } 
        public sbyte Difficulty { get; set; } 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
