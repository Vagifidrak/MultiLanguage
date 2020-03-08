using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Multilang.Controllers
{
    public class MainLanguageController : Controller
    {
        // GET: MainLanguage
        public ActionResult LangSetting(string lang)
        {
            if (lang != "") {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("az");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("az");
            }
            Response.Cookies.Add(new HttpCookie("coRes")
            {
                Value = lang
            });
            return RedirectToAction("Index","Home");
        }
    }
}