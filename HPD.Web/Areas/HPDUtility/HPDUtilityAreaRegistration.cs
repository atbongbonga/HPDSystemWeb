using System.Web.Mvc;

namespace HPD.Web.Areas.HPDUtility
{
    public class HPDUtilityAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HPDUtility";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HPDUtility_default",
                "HPDUtility/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}