using System;
using System.ComponentModel.DataAnnotations;

namespace CieciuraB.Todo.Web.Persist.Domain
{
    public class Account
    {
        [Display(Name = "Login")]   
        public string Login { get; set; }
        
        [Display(Name = "Hasło")]   
        public string Haslo { get; set; }

        public string Message { get; set; }
    }
}