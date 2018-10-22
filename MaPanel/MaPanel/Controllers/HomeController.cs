using System.Web.Mvc;

namespace MaPanel.Controllers
{
    public class HomeController : Controller
    {
        //private readonly UnitOfWork _uow = new UnitOfWork();

        //public HomeController(UnitOfWork uow)
        //{
        //    _uow = uow;
        //}
        public ActionResult Index()
        {
            //Role role = new Role()
            //{
            //    RoleId = 1,
            //    RoleName = "Admin"
            //};

            //_uow.RoleDal.Insert(role);

            return View();
        }
    }
}