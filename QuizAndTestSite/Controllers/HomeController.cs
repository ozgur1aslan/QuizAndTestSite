using Microsoft.AspNetCore.Mvc;
using QuizAndTestSite.Data;
using QuizAndTestSite.Models;
using System.Diagnostics;
using System.Dynamic;
using System.Security.Claims;

namespace QuizAndTestSite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }





        //public IActionResult Quiz(int? id)
        //{

        //    IEnumerable<QuestionModel> objQuestionModelList = _db.Questions.Where(x => x.QuizModelId == id);

        //    //List objects to be used on dynamic model
        //    //IEnumerable<QuizModel> objQuizModelList = _db.Quizes;
        //    //IEnumerable<QuestionModel> objQuestionModelList = _db.Questions;
        //    //IEnumerable<OptionModel> objOptionModelList = _db.Options;
        //    //IEnumerable<ResultModel> objResultModelList = _db.Results;



        //    //Dynamic model which contains other models
        //    //dynamic mymodel = new ExpandoObject();
        //    //mymodel.Quizes = objQuizModelList;
        //    //mymodel.Questions = objQuestionModelList;
        //    //mymodel.Options = objOptionModelList;
        //    //mymodel.Results = objResultModelList;


        //    //ViewdData for question records
        //    //ViewData["questions"] = objQuestionModelList;



        //    return View(objQuestionModelList);
        //}




        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Quiz(ChosenOptionsModel obj)
        //{
        //    //if (obj.ChosenOption_1 == _db.Questions.Where(x => x.Id == 1).FirstOrDefault().CorrectOption && obj.ChosenOption_2 == _db.Questions.Where(x => x.Id == 2).FirstOrDefault().CorrectOption)
        //    //{
        //    //    return Json("hll");
        //    //}
        //    //else
        //    //{
        //    //    return Json("yanlis cevap");

        //    //}

        //    ResultModel Result = new ResultModel();

        //    foreach (var question in _db.Questions.Where(x => x.QuizModelId == obj.Id))
        //    {

        //        if (question.CorrectOption == obj.ChosenOption_1)
        //        {
        //            Result.Score = Result.Score + 1;
        //        }

        //        if (question.CorrectOption == obj.ChosenOption_2)
        //        {
        //            Result.Score = Result.Score + 1;
        //        }

        //        if (question.CorrectOption == obj.ChosenOption_3)
        //        {
        //            Result.Score = Result.Score + 1;
        //        }

        //        if (question.CorrectOption == obj.ChosenOption_4)
        //        {
        //            Result.Score = Result.Score + 1;
        //        }

        //        if (question.CorrectOption == obj.ChosenOption_5)
        //        {
        //            Result.Score = Result.Score + 1;
        //        }







        //    }
        //    int question_count = _db.Questions.Where(x => x.QuizModelId == obj.Id).Count();

        //    Result.Score = (100 / question_count) * Result.Score;
        //    Result.QuizModelId = obj.Id;
        //    Result.AspNetUsersId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    Result.Date = DateTime.UtcNow;

        //    _db.Results.Add(Result);
        //    _db.SaveChanges();







        //    return RedirectToAction("Result", Result);

        //}



        //public IActionResult Result(ResultModel Result)
        //{


        //    return View(Result);
        //}




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}