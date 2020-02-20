using System;
using System.Linq;
using System.Threading.Tasks;
using CieciuraB.Todo.Web.Persist.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CieciuraB.Todo.Web.Controllers
{
    public class ListController : Controller
    {
        // GET
        public IActionResult New()
        {
            return View();
        }

        public IActionResult Edit(Guid id)
        {
            Item model = Persist.ContekstDb.Items.FirstOrDefault(x => x.Id == id);
            if (model == null)
            {
                throw new Exception("Nie ma takiego Id");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Delete(Guid id)
        {
            Item model = Persist.ContekstDb.Items.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        public IActionResult Remove(Guid id)
        {
            Item model = Persist.ContekstDb.Items.FirstOrDefault(x => x.Id == id);
            Persist.ContekstDb.Items.Remove(model);
            return Redirect("~/Home/List");
        }


        [HttpGet]
        public IActionResult Update(Item model)
        {
            Item src = Persist.ContekstDb.Items.FirstOrDefault(x => x.Id == model.Id);
            Persist.ContekstDb.Items.Remove(src);

            src.Name = model.Name;
            src.Description = model.Description;
            src.Priorytet = model.Priorytet;

            Persist.ContekstDb.Items.Add(src);
            return Redirect("~/Home/List");
        }
    }
}