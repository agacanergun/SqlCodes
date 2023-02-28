using Microsoft.AspNetCore.Mvc;

namespace SqlCodes.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [Route("sqlUsage/tr")]
        public IActionResult SqlUsagePage() { return View(); }

        [Route("GeneralDataTypes/tr")]
        public IActionResult GeneralDataTypesPage() { return View(); }

        [Route("DbDataTypes/tr")]
        public IActionResult DbDataTypesPage() { return View(); }

        [Route("Select/tr")]
        public IActionResult SelectPage() { return View(); }

        [Route("Distinct/tr")]
        public IActionResult DistinctPage() { return View(); }

        [Route("Where/tr")]
        public IActionResult WherePage() { return View(); }

        [Route("AndOrUse/tr")]
        public IActionResult AndOrUsePage() { return View(); }

        [Route("OrderBy/tr")]
        public IActionResult OrderByPage() { return View(); }

        [Route("InsertInto/tr")]
        public IActionResult InsertIntoPage() { return View(); }

        [Route("Update/tr")]
        public IActionResult UpdatePage() { return View(); }

        [Route("Delete/tr")]
        public IActionResult DeletePage() { return View(); }

        [Route("SelectTop/tr")]
        public IActionResult SelectTopPage() { return View(); }

        [Route("Like/tr")]
        public IActionResult LikePage() { return View(); }

        [Route("LikeMarks/tr")]
        public IActionResult LikeMarksPage() { return View(); }

        [Route("In/tr")]
        public IActionResult InPage() { return View(); }

        [Route("Between/tr")]
        public IActionResult BetweenPage() { return View(); }

        [Route("Aliases/tr")]
        public IActionResult AliasesPage() { return View(); }

        [Route("InnerJoin/tr")]
        public IActionResult InnerJoinPage() { return View(); }

        [Route("LeftJoin/tr")]
        public IActionResult LeftJoinPage() { return View(); }

        [Route("RightJoin/tr")]
        public IActionResult RightJoinPage() { return View(); }

        [Route("FullJoin/tr")]
        public IActionResult FullJoinPage() { return View(); }

        [Route("Union/tr")]
        public IActionResult UnionPage() { return View(); }

        [Route("SelectInto/tr")]
        public IActionResult SelectIntoPage() { return View(); }

        [Route("InsertIntoSelect/tr")]
        public IActionResult InsertIntoSelectPage() { return View(); }

        [Route("CreateDb/tr")]
        public IActionResult CreateDbPage() { return View(); }

        [Route("CreateTable/tr")]
        public IActionResult CreateTable() { return View(); }

        [Route("Constraints/tr")]
        public IActionResult ConstraintsPage() { return View(); }

        [Route("NotNull/tr")]
        public IActionResult NotNullPage() { return View(); }

        [Route("Unique/tr")]
        public IActionResult UniquePage() { return View(); }

        //burdan devam

        [Route("PrimaryKey/tr")]
        public IActionResult PrimaryKeyPage() { return View(); }

        [Route("ForeignKey/tr")]
        public IActionResult ForeignKeyPage() { return View(); }

        [Route("Check/tr")]
        public IActionResult CheckPage() { return View(); }

        [Route("Default/tr")]
        public IActionResult DefaultPage() { return View(); }

        [Route("CreateIndex/tr")]
        public IActionResult CreateIndexPage() { return View(); }

        [Route("Drop/tr")]
        public IActionResult DropPage() { return View(); }

        [Route("Alter/tr")]
        public IActionResult AlterPage() { return View(); }

        [Route("AutoIncrement/tr")]
        public IActionResult AutoIncrementPage() { return View(); }

        [Route("Views/tr")]
        public IActionResult ViewsPage() { return View(); }

        [Route("DateFunctions/tr")]
        public IActionResult DateFunctionsPage() { return View(); }

        [Route("DateFormat/tr")]
        public IActionResult DateFormatPage() { return View(); }

        [Route("Convert/tr")]
        public IActionResult ConvertPage() { return View(); }

        [Route("FindNullValues/tr")]
        public IActionResult FindNullValuesPage() { return View(); }

        [Route("NullFunctions/tr")]
        public IActionResult NullFunctionsPage() { return View(); }

        [Route("AvgFunction/tr")]
        public IActionResult AvgFunctionPage() { return View(); }

        [Route("CountFunction/tr")]
        public IActionResult CountFunctionPage() { return View(); }

        [Route("FirstFunction/tr")]
        public IActionResult FirstFunctionPage() { return View(); }

        [Route("LastFunction/tr")]
        public IActionResult LastFunctionPage() { return View(); }

        [Route("MaxFunction/tr")]
        public IActionResult MaxFunctionPage() { return View(); }

        [Route("MinFunction/tr")]
        public IActionResult MinFunctionPage() { return View(); }

        [Route("SumFunction/tr")]
        public IActionResult SumFunctionPage() { return View(); }

        [Route("GroupByFunction/tr")]
        public IActionResult GroupByFunctionPage() { return View(); }

        [Route("Having/tr")]
        public IActionResult HavingPage() { return View(); }

        [Route("UcaseUpperFunction/tr")]
        public IActionResult UcaseUpperFunctionPage() { return View(); }

        [Route("LcaseLoewerFunction/tr")]
        public IActionResult LcaseLoewerFunctionPage() { return View(); }

        [Route("MidFunction/tr")]
        public IActionResult MidFunctionPage() { return View(); }

        [Route("LenFunction/tr")]
        public IActionResult LenFunctionPage() { return View(); }

        [Route("RoundFunction/tr")]
        public IActionResult RoundFunctionPage() { return View(); }

        [Route("NowFunction/tr")]
        public IActionResult NowFunctionPage() { return View(); }

        [Route("FormatFunction/tr")]
        public IActionResult FormatFunctionPage() { return View(); }

        [Route("ReplaceFunction/tr")]
        public IActionResult ReplaceFunctionPage() { return View(); }
    }
}
