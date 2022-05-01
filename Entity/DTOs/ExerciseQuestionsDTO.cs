using Microsoft.AspNetCore.Http;

namespace Entity.DTOs
{
    public class ExerciseQuestionsDTO
    {
        public int ExerciseQuestionsId { get; set; }
        public int ExerciseId { get; set; } //(int, not null)
        public int QuestionId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }

    }
}