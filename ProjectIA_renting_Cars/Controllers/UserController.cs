using ProjectIA_renting_Cars.Models;
using ProjectIA_renting_Cars.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectIA_renting_Cars.Controllers
{
    public class UserController : Controller
    {
        public static User user_Data;
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: User
        public ActionResult Index(){
            return RedirectToAction("Index", "Home");
        }
        
        [HttpGet]
        public ActionResult Regester(){
            var Categories = db.Categories.ToList();
            UserCategoryViewModel User_C_VM = new UserCategoryViewModel {
                categories = Categories
            };

            return View(User_C_VM);
        }

        [HttpPost]
        public ActionResult Regester(UserCategoryViewModel User_C_VM) {
            if (!ModelState.IsValid) {
                var Categories = db.Categories.ToList();
                User_C_VM.categories = Categories;

                return View("Regester", User_C_VM);
            }

            User_C_VM.User.IsAdmin = false;
            User_C_VM.User.IsBlocked = false;

            db.users.Add(User_C_VM.User); 
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login(){
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user){

            var userData = db.Categories.SingleOrDefault(u => u.category_Name == "A");
            if (userData != null){
                //if (userData.Password == user.Password) {
                    return RedirectToAction("Index", "Home");
                //}
            }
            return View("Login", user);
        }
    }
}