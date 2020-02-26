using System;
using System.Linq;
using System.Threading;
using CieciuraB.Todo.Web.Persist.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CieciuraB.Todo.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult LogIn(Account account)
        {
            Account result =
                Persist.ContekstDb.Accounts.FirstOrDefault(x => x.Login == account.Login && x.Haslo == account.Haslo);
            if (result == null)
            {
                if (account.Message == null && account.Login == null)
                {
                    return View();
                }
                else
                    return View(new Account() {Message = "Login lub hasło są niepoprawne"});
            }
            else
            {
                HttpContext.Session.SetString("session_user", result.Login);
                return Redirect("~/Home/List");
            }
        }


        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
           

        }
    }
}