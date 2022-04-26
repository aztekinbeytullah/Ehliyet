using BLL.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebIU.Areas.Admin.Controllers
{
    //Deneme2
    [Area("Admin")]
    [Authorize]
    public class ExerciseController : Controller
    {
        IExerciseServices _exerciseService;
        public ExerciseController(IExerciseServices exerciseService)
        {
            _exerciseService=exerciseService;
        }

        public IActionResult Index()
        {
            var exercises=_exerciseService.GetList();
            return View(exercises);
        }

        public  IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Exercise exercise)
        {
            exercise.CreatedTime = DateTime.Now;
            _exerciseService.Add(exercise);
            return View("Index");
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
