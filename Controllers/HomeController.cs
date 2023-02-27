using Microsoft.AspNetCore.Mvc;

namespace SqlCodes.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [Route("TR/SqlUsage")]
        public IActionResult SqlUsagePage() { return View(); }

        [Route("TR/GeneralDataTypes")]
        public IActionResult GeneralDataTypesPage() { return View(); }

        [Route("TR/DbDataTypes")]
        public IActionResult DbDataTypesPage() { return View(); }

        [Route("TR/Select")]
        public IActionResult SelectPage() { return View(); }

        [Route("TR/Distinct")]
        public IActionResult DistinctPage() { return View(); }

        [Route("TR/Where")]
        public IActionResult WherePage() { return View(); }

        [Route("TR/AndOrUse")]
        public IActionResult AndOrUsePage() { return View(); }

        [Route("TR/OrderBy")]
        public IActionResult OrderByPage() { return View(); }

        [Route("TR/InsertInto")]
        public IActionResult InsertIntoPage() { return View(); }

        [Route("TR/Update")]
        public IActionResult UpdatePage() { return View(); }

        [Route("TR/Delete")]
        public IActionResult DeletePage() { return View(); }

        [Route("TR/SelectTop")]
        public IActionResult SelectTopPage() { return View(); }

        [Route("TR/Like")]
        public IActionResult LikePage() { return View(); }

        [Route("TR/LikeMarks")]
        public IActionResult LikeMarksPage() { return View(); }

        [Route("TR/In")]
        public IActionResult InPage() { return View(); }

        [Route("TR/Between")]
        public IActionResult BetweenPage() { return View(); }

        [Route("TR/Aliases")]
        public IActionResult AliasesPage() { return View(); }


    }
}
