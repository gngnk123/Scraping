using Car_Details.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car_Details.Controllers
{
    public class CarBrandsController : Controller
    {
        public IActionResult EnterModels()
        {
            CarBrandsModel model = new CarBrandsModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Details(CarBrandsModel model)
        {
            //string Details = model.Br_Name +"   "+ model.Model + "   " + model.year;
            string details = model.Br_Name;
   
            return PartialView("Details", details);
        }
    }
}
