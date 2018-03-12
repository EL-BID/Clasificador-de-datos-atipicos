using System.Web;
using System.Web.Mvc;

namespace Sisben.WebApps.QAML
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
