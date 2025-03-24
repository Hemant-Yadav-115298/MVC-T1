using Microsoft.AspNetCore.Mvc;
using MVC_T1.Data;
using MVC_T1.Models;

namespace MVC_T1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public CategoryController(ApplicationDbContext Db) {
            _Db = Db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _Db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create() {
            return View();

        }

    }
}
