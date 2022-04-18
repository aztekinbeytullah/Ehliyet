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
        public int QuestionId { get; set; } //(int, not null)
        public string Image { get; set; } //(nvarchar(500), null)
        public string Answer { get; set; } //(char(1), null)
        public DateTime DateOfUpload { get; set; } //(date, null)
        public sbyte Difficulty { get; set; } //(varbinary(10)10)
        public IFormFile Image2{ get; set; }



        //Relations
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
