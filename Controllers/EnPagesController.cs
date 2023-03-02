using Microsoft.AspNetCore.Mvc;

namespace SqlCodes.Controllers
{
    public class EnPagesController : Controller
    {
        [Route("MainPage/en")]
        public IActionResult Index() { return View(); }

        [Route("sqlUsage/en")]
        public IActionResult SqlUsagePage() { return View(); }

        [Route("GeneralDataTypes/en")]
        public IActionResult GeneralDataTypesPage() { return View(); }

        [Route("DbDataTypes/en")]
        public IActionResult DbDataTypesPage() { return View(); }

        [Route("Select/en")]
        public IActionResult SelectPage() { return View(); }

        [Route("Distinct/en")]
        public IActionResult DistinctPage() { return View(); }

        [Route("Where/en")]
        public IActionResult WherePage() { return View(); }

        [Route("AndOrUse/en")]
        public IActionResult AndOrUsePage() { return View(); }

        [Route("OrderBy/en")]
        public IActionResult OrderByPage() { return View(); }

        [Route("InsertInto/en")]
        public IActionResult InsertIntoPage() { return View(); }

        [Route("Update/en")]
        public IActionResult UpdatePage() { return View(); }

        [Route("Delete/en")]
        public IActionResult DeletePage() { return View(); }

        [Route("SelectTop/en")]
        public IActionResult SelectTopPage() { return View(); }

        [Route("Like/en")]
        public IActionResult LikePage() { return View(); }

        [Route("LikeMarks/en")]
        public IActionResult LikeMarksPage() { return View(); }

        [Route("In/en")]
        public IActionResult InPage() { return View(); }

        [Route("Between/en")]
        public IActionResult BetweenPage() { return View(); }

        [Route("Aliases/en")]
        public IActionResult AliasesPage() { return View(); }

        [Route("InnerJoin/en")]
        public IActionResult InnerJoinPage() { return View(); }

        [Route("LeftJoin/en")]
        public IActionResult LeftJoinPage() { return View(); }

        [Route("RightJoin/en")]
        public IActionResult RightJoinPage() { return View(); }

        [Route("FullJoin/en")]
        public IActionResult FullJoinPage() { return View(); }

        [Route("Union/en")]
        public IActionResult UnionPage() { return View(); }

        [Route("SelectInto/en")]
        public IActionResult SelectIntoPage() { return View(); }

        [Route("InsertIntoSelect/en")]
        public IActionResult InsertIntoSelectPage() { return View(); }

        [Route("CreateDb/en")]
        public IActionResult CreateDbPage() { return View(); }

        [Route("CreateTable/en")]
        public IActionResult CreateTable() { return View(); }

        [Route("Constraints/en")]
        public IActionResult ConstraintsPage() { return View(); }

        [Route("NotNull/en")]
        public IActionResult NotNullPage() { return View(); }

        [Route("Unique/en")]
        public IActionResult UniquePage() { return View(); }

        [Route("PrimaryKey/en")]
        public IActionResult PrimaryKeyPage() { return View(); }

        [Route("ForeignKey/en")]
        public IActionResult ForeignKeyPage() { return View(); }

        [Route("Check/en")]
        public IActionResult CheckPage() { return View(); }

        [Route("Default/en")]
        public IActionResult DefaultPage() { return View(); }

        [Route("CreateIndex/en")]
        public IActionResult CreateIndexPage() { return View(); }

        [Route("Drop/en")]
        public IActionResult DropPage() { return View(); }

        [Route("Alter/en")]
        public IActionResult AlterPage() { return View(); }

        [Route("AutoIncrement/en")]
        public IActionResult AutoIncrementPage() { return View(); }

        [Route("Views/en")]
        public IActionResult ViewsPage() { return View(); }

        [Route("DateFunctions/en")]
        public IActionResult DateFunctionsPage() { return View(); }

        [Route("DateFormat/en")]
        public IActionResult DateFormatPage() { return View(); }

        [Route("Convert/en")]
        public IActionResult ConvertPage() { return View(); }

        [Route("FindNullValues/en")]
        public IActionResult FindNullValuesPage() { return View(); }

        [Route("NullFunctions/en")]
        public IActionResult NullFunctionsPage() { return View(); }

        [Route("AvgFunction/en")]
        public IActionResult AvgFunctionPage() { return View(); }

        [Route("CountFunction/en")]
        public IActionResult CountFunctionPage() { return View(); }

        [Route("FirstFunction/en")]
        public IActionResult FirstFunctionPage() { return View(); }

        [Route("LastFunction/en")]
        public IActionResult LastFunctionPage() { return View(); }

        [Route("MaxFunction/en")]
        public IActionResult MaxFunctionPage() { return View(); }

        [Route("MinFunction/en")]
        public IActionResult MinFunctionPage() { return View(); }

        [Route("SumFunction/en")]
        public IActionResult SumFunctionPage() { return View(); }

        [Route("GroupByFunction/en")]
        public IActionResult GroupByFunctionPage() { return View(); }

        [Route("Having/en")]
        public IActionResult HavingPage() { return View(); }

        [Route("UcaseUpperFunction/en")]
        public IActionResult UcaseUpperFunctionPage() { return View(); }

        [Route("LcaseLoewerFunction/en")]
        public IActionResult LcaseLoewerFunctionPage() { return View(); }

        [Route("MidFunction/en")]
        public IActionResult MidFunctionPage() { return View(); }

        [Route("LenFunction/en")]
        public IActionResult LenFunctionPage() { return View(); }

        [Route("RoundFunction/en")]
        public IActionResult RoundFunctionPage() { return View(); }

        [Route("NowFunction/en")]
        public IActionResult NowFunctionPage() { return View(); }

        [Route("FormatFunction/en")]
        public IActionResult FormatFunctionPage() { return View(); }

        [Route("ReplaceFunction/en")]
        public IActionResult ReplaceFunctionPage() { return View(); }
    }
}
