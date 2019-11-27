using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;
namespace DojoSurveyWithModel.Controllers
{
    public class DojoSurveyWithModelController : Controller
    {

        [HttpPost]
        [Route("Survey")]
        public IActionResult Survey(Result resultFromForm)
        {
            return RedirectToAction("Result", resultFromForm);
        }

        [HttpGet]
        [Route("/result")]
        public ViewResult Result(Result resultFromForm)
        {
            return View("Result", resultFromForm);
        }
    }
}