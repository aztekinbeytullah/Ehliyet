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

        public ExerciseController(IExerciseServices exerciseService)
        {
            _exerciseService=exerciseService;
        }

        public IActionResult Index()
        {
            var exercises=_exerciseService.GetList();
            return View(exercises);
        }

        public  IActionResult AddExercise()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddExercise(Exercise exercise)
        {

            return View();
        }






    }
}
