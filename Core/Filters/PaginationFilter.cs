using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Filters
{
    public class PaginationFilter
    {
        public string Sort { get; set; }
        public int Page { get; set; }
        public int Per_Page { get; set; }
        public string Search { get; set; }
        public PaginationFilter()
        {
            this.Sort = null;
            this.Page = 1;
            this.Per_Page = 12;
            this.Search = null;
        }
        public PaginationFilter(string sort, int page, int per_page, string search)
        {
            this.Sort = sort == null ? null : sort;
            this.Page = page < 1 ? 1 : page;
            this.Per_Page = per_page < 4 ? 4 : per_page;
            this.Search = search == null ? null : search;
        }
    }
}
