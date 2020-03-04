using System;
using System.Linq;
using System.Threading.Tasks;
using CieciuraB.Todo.Web.Persist.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CieciuraB.Todo.Web.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Add()
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

            src.Kod = model.Kod;
            src.Komunikat = model.Komunikat;
            src.Przyczyna = model.Przyczyna;
            src.Rozwiazanie = model.Rozwiazanie;
            src.Uwaga = model.Uwaga;

            Persist.ContekstDb.Items.Add(src);
            return Redirect("~/Home/List");
        }

        [HttpGet]
        public IActionResult Insert(Item model)
        {
            Item newitem = new Item();
            newitem.Kod = model.Kod;
            newitem.Komunikat = model.Komunikat;
            newitem.Przyczyna = model.Przyczyna;
            newitem.Rozwiazanie = model.Rozwiazanie;
            newitem.Uwaga = model.Uwaga;

            Persist.ContekstDb.Items.Add(newitem);

            return Redirect("~/Home/List");
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Show(Guid id)
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

        [HttpGet]
        public IActionResult Search(Item item)
        {
            Item result =
                Persist.ContekstDb.Items.FirstOrDefault(x => x.Kod == item.Kod);
            if (result == null)
            {
                if (item.Kod == null)
                {
                    return View();
                }
                else

                    return View(new Item {ItemMessage = "Podany kod jest błędny"});
            }
            else
            {
                return View(result);
            }
        }
    }
}