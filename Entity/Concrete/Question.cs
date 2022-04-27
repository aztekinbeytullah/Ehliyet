using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{

    public class Question
    {
        [Key]
        public int QuestionId { get; set; } //(int, not null)
        public string Image { get; set; } //(nvarchar(500), null)
        public string Answer { get; set; } //(char(1), null)
        public DateTime DateOfUpload { get; set; } //(date, null)
        public sbyte Difficulty { get; set; } //(varbinary(10)10)
     



        //Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        List<Exercise> exercises { get; set; }

     


       
       

    }





}
