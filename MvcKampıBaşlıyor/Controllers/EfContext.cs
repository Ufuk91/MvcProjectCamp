using System.Web.Mvc;

namespace MvcKampıBaşlıyor.Controllers
{
    internal class EfContext : ExceptionContext
    {
        public object Categories { get; internal set; }
        public object Writers { get; internal set; }
    }
}