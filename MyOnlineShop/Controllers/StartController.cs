using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyOnlineShop.Controllers
{
    public class StartController : Controller
    {
        //mymethod hello
        public string Hello()
        {
            int time = DateTime.Now.Hour;
            string result= "Добрый вечер";
            if (time >= 0 && time < 6) result = "Доброй ночи";
            if (time >= 6 && time < 12) result = "Доброе утро";
            if (time >= 12 && time < 18) result = "Добрый день";
            return result;
        }


        // GET: HelloController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
