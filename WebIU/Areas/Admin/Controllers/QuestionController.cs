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
            var result = _questionServices.GetList();
            return View(result);
        }

        public IActionResult DeleteQuestion(int id)
        {
            var question = _questionServices.GetById(id);
            _questionServices.Remove(question);
            return RedirectToAction("Index");
        }

        public IActionResult AddQuestion()
        {
            //Mevcut Kategorilerin listesi altta bulunan bölüme gelmesi gerekiyor.
            //QuestionModelDTO nesnesindeki List<Categori> alanının include edilmesi gerekiyor.
            ViewBag.CategoryList= _categoryServices.GetList();
            return View();
        }

        [HttpPost]
        public IActionResult AddQuestion(QuestionModelDTO modelDto)
        {
            
                string path = "wwwroot/Resource/UploadedImages/QuestionImages/";
                string ImageNewName = Core.Extentions.Tools.FileUploader.UploadImage(path, modelDto.Image);

                Question question = new Question
                {
                    Answer = modelDto.Answer,
                    CategoryId=modelDto.CategoryId,
                    DateOfUpload=modelDto.DateOfUpload,
                    Difficulty=modelDto.Difficulty,
                    Image = ImageNewName,
                };
            _questionServices.Add(question);
            return RedirectToAction("Index");
    }

        public IActionResult MultiQuestionView()
        {
            var result = _questionServices.GetList();
            return View(result);
        }

         [HttpPost]
        public IActionResult AddMultiQuestion(IFormFile excelFile)
        {

            /*Bir excel dosyasından okunan question bilgileri. Her bir sorunun
             * Excel içeriğinde
             *  - her sorunun image yolu
             *  - cevabı
             *  - zorluk dzüeyi
             *  - cetagorisi
             *  - resim adı
             * olması gerkeiyor.
             * İmage yolu excel dosyasıyla aynı konum altında bulunan sorular klasöründe alınmalıdır.
             * Klasörden okunan her bir resim_adına göre eşleştirme yapılıp sisteme eklenmesi sağlanacaktır.
             */ 




            return View();
        }
       

    }
}
