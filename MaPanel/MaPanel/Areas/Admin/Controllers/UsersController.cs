using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using MA.Business.Classes;
using MA.Business.Interfaces;
using MA.Domain;

namespace MaPanel.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private IUserBusiness _userBusiness = new UserBusiness();
        private IRoleBusiness _roleBusiness = new RoleBusiness();

        public ActionResult Index()
        {
            var users = _userBusiness.Get(0);
            return View(users.ToList());
        }

        public ActionResult Details(string id)
        {
            User user = _userBusiness.GetById(id);
            return View(user);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.RoleId = new SelectList(_roleBusiness.Get(), "RoleId", "RoleName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email,Password,MobileNumber,IsActive,ImageName,NationalCode,FirstName,LastName,Country,State,City,Address,PostalCode,BirthDate,RoleId")] User user)
        {
            // Add ModelState.IsValid To Validation
            var checkEmail = _userBusiness.GetByEmail(user.Email.Trim().ToLower());
            if (checkEmail == null)
            {
                user.UserId = Guid.NewGuid().ToString();
                user.ActiveCode = Guid.NewGuid().ToString();
                user.JoinDate = DateTime.Now;
                user.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "MD5");
                _userBusiness.Insert(user);
                _userBusiness.Save();
            }
            else
            {
                ViewBag.Message = "ایمیل تکراری است";
                ViewBag.Class = "alert alert-danger";
                ViewBag.RoleId = new SelectList(_roleBusiness.Get(), "RoleId", "RoleName", user.RoleId);
                return View(user);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            User user = _userBusiness.GetById(id);
            ViewBag.RoleId = new SelectList(_roleBusiness.Get(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Email,Password,MobileNumber,ActiveCode,IsActive,ImageName,NationalCode,FirstName,LastName,Country,State,City,Address,PostalCode,BirthDate,JoinDate,RoleId")] User user)
        {
            if (ModelState.IsValid)
            {
                bool checkEmail = _userBusiness.CheckEmail(user.Email.Trim().ToLower());
                if (checkEmail == false)
                {
                    _userBusiness.Update(user);
                    _userBusiness.Save();
                    return RedirectToAction("Index");
                }

                ViewBag.Message = "ایمیل تکراری است";
                ViewBag.Class = "alert alert-danger";
                ViewBag.RoleId = new SelectList(_roleBusiness.Get(), "RoleId", "RoleName", user.RoleId);
                return View(user);
            }
            ViewBag.RoleId = new SelectList(_roleBusiness.Get(), "RoleId", "RoleName", user.RoleId);
            return View(user);
        }

        public ActionResult Delete(string id)
        {
            User user = _userBusiness.GetById(id);
            _userBusiness.Delete(user);
            _userBusiness.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _userBusiness.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}