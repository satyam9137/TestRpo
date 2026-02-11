using Microsoft.AspNetCore.Mvc;
using Registration_Page.Models;

namespace Registration_Page.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save data to database or any other processing here

                ViewBag.Message = "Registration successful!";
                return View();
            }

            // If validation fails, show form again with errors
            return View(model);
        }
    }
}
