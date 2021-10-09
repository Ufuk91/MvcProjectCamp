

using DateAccessLayer.Concrete;
using System.Linq;
using System.Web.Mvc;

namespace MvcKampıBaşlıyor.Controllers
{
    public class StatisticsController : Controller
    {
        private Context context = new Context();
        private bool xCategoryStatus;

        // GET: Statistics
        public ActionResult Index()
        {
            var value1 = context.Categories.Count().ToString();
            ViewBag.value1 = value1;
            var value2 = context.Headings.Count(x => x.HeadingName == "Yazılım").ToString();
            ViewBag.value2 = value2;

            var value3 = (from x in context.Writers select x.WriterName.IndexOf("a")).Distinct().Count().ToString();
            ViewBag.value3 = value3;

            var value4 = context.Categories.Where(u => u.CategoryID == context.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count())
                    .Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.value4 = value4;

            var value5 = context.Categories.Count(x => x.CategoryStatus == true) - context.Categories
                .Count(x => xCategoryStatus == false);
            ViewBag.value5 = value5;

            return View();
        }
    }
}