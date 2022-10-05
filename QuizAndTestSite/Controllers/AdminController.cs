using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizAndTestSite.Data;
using QuizAndTestSite.Models;
using System.Data;
using System.Dynamic;

namespace QuizAndTestSite.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult QuizList()
        {
            IEnumerable<QuizModel> objQuizModelList = _db.Quizes;

            return View(objQuizModelList);
        }



        [Authorize(Roles = "Admin")]
        public IActionResult CreateQuiz()
        {

            //IEnumerable<QuizModel> objQuizModelList = _db.Quizes;
            //IEnumerable<CategoryModel> objCategoryModelList = _db.Categories;

            //dynamic mymodel = new ExpandoObject();
            //mymodel.Quizes = objQuizModelList;
            //mymodel.Categories = objCategoryModelList;



            //ViewData["CategoryModelId"] = new SelectList(_db.Categories, "Id", "Id");
            //_db.Questions.Where(x => x.Id == 1).FirstOrDefault().CorrectOption;
            ViewData["CategoryModelCategoryName"] = new SelectList(_db.Categories, "CategoryName", "CategoryName");
            return View();
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateQuiz(QuizModel obj)
        {
            //obj.Id = 0;

            _db.Quizes.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Quiz created successfully";
            return RedirectToAction("QuizList");


            //if (ModelState.IsValid)
            //{
                
            //}

            //return View(obj);

        }


        
        
        [Authorize(Roles = "Admin")]
        public IActionResult EditQuiz(int? id)
        {
            ViewData["CategoryModelCategoryName"] = new SelectList(_db.Categories, "CategoryName", "CategoryName");

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var QuizModelFromDb = _db.Quizes.Find(id);

            if (QuizModelFromDb == null)
            {
                return NotFound();
            }

            return View(QuizModelFromDb);
        }


        
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditQuiz(QuizModel obj)
        {                        
            if (ModelState.IsValid)
            {
                _db.Quizes.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Quiz updated successfully";
                return RedirectToAction("QuizList");
            }

            return View(obj);
        }



        
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteQuiz(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var QuizModelFromDb = _db.Quizes.Find(id);

            if (QuizModelFromDb == null)
            {
                return NotFound();
            }

            return View(QuizModelFromDb);
        }

        

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteQuizPOST(int? id)
        {
            var obj = _db.Quizes.Find(id);
            if (obj == null)
            {
                return NotFound();
            }


            _db.Quizes.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Quiz deleted successfully";
            return RedirectToAction("QuizList");


        }




        public IActionResult CreateCategory()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategory(CategoryModel obj)
        {
            //obj.Id = 0;

            _db.Categories.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToAction("QuizList");


            //if (ModelState.IsValid)
            //{

            //}

            //return View(obj);

        }


        [Authorize(Roles = "Admin")]
        public IActionResult CreateQuestion(int? id, QuestionModel obj)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            } else
            {
                obj.QuizModelId = (int)id;
            }
            

            //ViewData["CategoryModelCategoryName"] = new SelectList(_db.Categories, "CategoryName", "CategoryName");

            //var QuestionModelFromDb = _db.Questions.Where(x => x.QuizModelId == id).FirstOrDefault();
            //var QuestionModelFromDb = new QuestionModel();


            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateQuestion(QuestionModel obj)
        {
            obj.Id = 0;

            _db.Questions.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Question created successfully";
            return RedirectToAction("QuizList");


            //if (ModelState.IsValid)
            //{

            //}

            //return View(obj);

        }


    }




}
