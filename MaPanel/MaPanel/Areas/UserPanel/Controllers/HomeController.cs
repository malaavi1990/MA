using System.Web.Mvc;
using System.Web.Security;
using MA.Business.Classes;
using MA.Business.Interfaces;
using MA.Domain;
using MA.ViewModel;

namespace MaPanel.Areas.UserPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserBusiness _userBusiness = new UserBusiness();

        public ActionResult Index()
        {
            var user = _userBusiness.GetByEmail(User.Identity.Name);

            return View(user);
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordViewModel change)
        {
            if (ModelState.IsValid)
            {
                string hashOldPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(change.OldPassword, "MD5");
                var user = _userBusiness.GetByEmail(User.Identity.Name);
                if (user.Password == hashOldPassword)
                {
                    string hashNewPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(change.Password, "MD5");
                    user.Password = hashNewPassword;
                    _userBusiness.Update(user);
                    _userBusiness.Save();

                    TempData["Title"] = "تغییر کلمه عبور";
                    TempData["Message"] = "کلمه عبور شما با موفقیت تغییر کرد";
                    TempData["Class"] = "alert alert-success";
                    return View("Notification");
                }
                else
                {
                    ViewBag.Message = "کلمه عبور فعلی شما صحیح نیست";
                    ViewBag.Class = "alert alert-danger";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditProfile(string id)
        {
            var user = _userBusiness.GetById(id);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProfile(string id, User user)
        {
            if (ModelState.IsValid)
            {
                _userBusiness.Update(user);
                _userBusiness.Save();

                return RedirectToAction("Index");
            }
            return View();
        }

    }
}