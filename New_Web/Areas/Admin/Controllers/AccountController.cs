using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datalayer;
using System.Web.Security;

namespace New_Web.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private ILoginRepository loginRepository;
        MyCmsContext db = new MyCmsContext();

        ///Get
        public AccountController()
        {
            loginRepository = new LoginRepository(db);
        }
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginViewModel login, string ReturnUrl = "/Admin/Account/Panel")
        {
            if (ModelState.IsValid)
            {
                if (loginRepository.IsExistUser(login.UserName, login.Password))
                {
                    FormsAuthentication.SetAuthCookie(login.UserName, login.RememberMe);
                    return Redirect(ReturnUrl);
                }
                else
                {
                    ModelState.AddModelError("UserName", "کاربری یافت نشد");
                }
            }
            return View(login);
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Admin/Account/Login");
        }

        public ActionResult Panel()
        {
            return View();
        }
    }
}