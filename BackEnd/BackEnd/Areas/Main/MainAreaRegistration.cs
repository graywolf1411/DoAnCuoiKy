using System.Web.Mvc;
using System.Diagnostics;

namespace BackEnd.Areas.Main
{
    public class MainAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Main";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            Trace.WriteLine("Main");
        }
    }
}
