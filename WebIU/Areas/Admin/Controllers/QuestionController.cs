using BLL.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebIU.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class QuestionController : Controller
    {
        IQuestionServices _questionServices;
        ICategoryServices _categoryServices;

        public QuestionController(IQuestionServices questionServices, ICategoryServices categoryServices)
        {
            _questionServices=questionServices;
            _categoryServices=categoryServices; 
        }

        public IActionResult Index()
        {
            return View(_questionServices.GetList());
        }

        public IActionResult DeleteQuestion(int id)
        {
            var question=_questionServices.GetById(id);
            _questionServices.Remove(question);
            return RedirectToAction("Index");
        }

        public IActionResult AddQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddQuestion(QuestionModelDTO model)
        {
            if (ModelState.IsValid)
            {
                string path= "wwwroot/Resource/UploadedImages/QuestionImages/";
                string ImageNewName =Core.Extentions.Tools.FileUploader.UploadImage(path, model.Image2);
                Question question = new Question
                {
                    Answer=model.Answer,
                    DateOfUpload=model.DateOfUpload,
                    Difficulty=model.Difficulty,
                    Image = ImageNewName

                };
                _questionServices.Add(question);
            }


            return RedirectToAction("Index");
        }

    }
}
