﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NJekyll.Engine
{
    public class Filters
    {
        public static Paginator Paginate(List<Page> collection, int perPage)
        {
            return new Paginator(collection, perPage);
        }

        public static string AddPage(string url, int pageNumber)
        {
            return pageNumber > 1 ? url + "/page/" + pageNumber.ToString() : url;
        }
    }
}