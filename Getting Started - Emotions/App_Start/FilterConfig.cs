﻿using System.Web;
using System.Web.Mvc;

namespace Getting_Started___Emotions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
