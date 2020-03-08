using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multilang
{
    public static class MultiExtension
    {
        public static string Language(this HttpCookieCollection cookie)
        {
            return cookie["coRes"]?.Value;
        }
    }
}