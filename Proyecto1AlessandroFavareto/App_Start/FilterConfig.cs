using System.Web;
using System.Web.Mvc;

namespace Proyecto1AlessandroFavareto
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
