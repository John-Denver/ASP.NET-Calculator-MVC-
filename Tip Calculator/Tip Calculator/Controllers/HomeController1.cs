using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class TipCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new TipCalculatorModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (model.MealCost <= 0)
            {
                model.ErrorMessage = "Please enter a valid meal cost greater than $0.00.";
                return View(model);
            }

            return View(model);
        }

        public IActionResult Clear()
        {
            var model = new TipCalculatorModel();
            return RedirectToAction("Index");
        }
    }
}
