using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizAndTestSite.Data;
using QuizAndTestSite.Models;
using System.Security.Claims;

namespace QuizAndTestSite.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ResultList()
        {
            IEnumerable<ResultModel> objResultModelList = _db.Results.Where(x => x.AspNetUsersId == User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(objResultModelList);
        }
    }
}
