using System.Linq;
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
            Account result= Persist.ContekstDb.Accounts.FirstOrDefault(x => x.Login == account.Login && x.Haslo == account.Haslo);
            if (result == null)
            {
                if(account.Message == null)
                {
                    
                    return View();
                }
                else
                    return View(new Account(){Message = "Widomosc"});
                
            }
            else
            {
                HttpContext.Session.SetString("session_user", result.Login);
                return Redirect("~/Home/List");
            }
        }
        

        
        
        
        
        
        
        

        public IActionResult LogOut()
        {
            return null;
        }
    }
}