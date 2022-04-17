using BLL.Abstract;
using Core.Extentions.Tools;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebIU.Models;


namespace WebIU.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices=categoryServices;
        }

        public IActionResult Index()
        {
            return View(_categoryServices.GetList());
        }


        public IActionResult AddCategory()
        {
            return View(new CategoryModelDTO());
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryModelDTO categoryModel)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();

                if (categoryModel.Image!=null)
                {
                    category.Image= FileUploader.UploadImage("wwwroot/Resource/UploadedImages/CategoryImages/", categoryModel.Image);
                }
                category.Description=categoryModel.Description;
                category.Name=categoryModel.Name;

                _categoryServices.Add(category);
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }
            return View(categoryModel);
        }


        public IActionResult UpdateCategory(int id)
        {
            var category = _categoryServices.GetById(id);

            CategoryModelDTO model = new CategoryModelDTO
            {
                Name= category.Name,
                Description = category.Description,
                CategoryId=category.CategoryId

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateCategory(CategoryModelDTO categoryModel)
        {
            if (ModelState.IsValid)
            {
                var category = _categoryServices.GetById(categoryModel.CategoryId);
                if (categoryModel.Image!=null)
                {
                    category.Image=FileUploader.UploadImage("wwwroot/Resource/UploadedImages/CategoryImages/", categoryModel.Image);   
                }
                category.Description=categoryModel.Description;
                category.Name=categoryModel.Name;

                _categoryServices.Update(category);
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }
            return View(categoryModel);
        }


        public IActionResult DeleteCategory(int id)
        {
            Category category = _categoryServices.GetById(id);
            _categoryServices.Remove(category);
            return RedirectToAction("Index");
        }


       

    }
}
