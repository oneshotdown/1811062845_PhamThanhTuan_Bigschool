using System.Web;
using System.Web.Mvc;

namespace _1811062845_PhamThanhTuan_Bigschooll
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
