using ProfQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProfQuiz.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> TestStart()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> TestStart(TestViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Session.Add("TestState", viewModel);

                // TODO: Заменить на переход на стриницу теста, когда она будет добавлена
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(viewModel);
            }
        }
    }
}