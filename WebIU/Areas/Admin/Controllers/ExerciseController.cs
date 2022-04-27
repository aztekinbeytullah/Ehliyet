using BLL.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebIU.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ExerciseController : Controller
    {
        IExerciseServices _exerciseService;
        ICategoryServices _categoryService;
        IQuestionServices _questionService;
        IExerciseQuestionServices _exerciseQuestionService;
        public ExerciseController(  IExerciseServices exerciseService,
                                    ICategoryServices categoryServices,
                                    IQuestionServices questionServices,
                                    IExerciseQuestionServices exerciseQuestionServices)
        {
            _exerciseService=exerciseService;
            _categoryService = categoryServices;
            _questionService = questionServices;
            _exerciseQuestionService=exerciseQuestionServices;
        }

        public IActionResult Index()
        {
            var exercises=_exerciseService.GetList();
            return View(exercises);
        }

        public  IActionResult Add()
        {
            var categories=_categoryService.GetList();
            ViewBag.CategoryList = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Exercise exercise)
        {
            exercise.CreatedTime = DateTime.Now;
            _exerciseService.Add(exercise);
            AssingQuestionToExercise(exercise);

            return RedirectToAction("Index", "Exercise");
          
        }

        private void AssingQuestionToExercise(Exercise e)
        {
            var result=_questionService.GetList().Where(x => x.CategoryId ==e.CategoryId).ToList();
            Random rnd = new Random();
            List<Question> selectedQuestions = new List<Question>();
            for (int i = 0; i < e.QuestionCount-1; i++)
            {
               selectedQuestions.Add(result[rnd.Next(0, result.Count)]);
            }
            //Seçilen sorular ilgili tabloya işlenmesi gerekiyor.
            foreach (var item in selectedQuestions)
            {
                var eq = new ExerciseQuestion
                {
                    Exercise = e,
                    Question = item
                    
                };
                _exerciseQuestionService.Add(eq);
            }
           

        }

        public IActionResult Remove(int id)
        {
            var result = _exerciseService.GetById(id);
            _exerciseService.Remove(result);
            return RedirectToAction("Index", "Exercise", new { area = "Admin" });
        }
        




        public IActionResult Update(int id)
        {
           var result=_exerciseService.GetById(id);
           return View(result);
        }

        [HttpPost]
        public IActionResult Update(Exercise exercise)
        {
            if (ModelState.IsValid)
            {
                var result = _exerciseService.GetById(exercise.ExerciseId);
                
                result.Description = exercise.Description;
                result.Difficulty = exercise.Difficulty;
                result.Name = exercise.Name;
                result.QuestionCount = exercise.QuestionCount;
               


                _exerciseService.Update(result);

            }
            return RedirectToAction("Index", "Exercise", new { area = "Admin" });
            
        }





    }
}
