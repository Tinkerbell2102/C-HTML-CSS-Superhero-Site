using System.Web;
using System.Web.Mvc;

namespace FA2_IPG_6955
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
