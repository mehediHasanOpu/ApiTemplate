using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Wrappers
{
    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int Current_page { get; set; }
        public int Per_page { get; set; }
        public int PageSize { get; set; }
        public Uri FirstPage { get; set; }
        public Uri LastPage { get; set; }
        public int Last_page { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public int Total { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public Uri Next_page_url { get; set; }
        public Uri Prev_page_url { get; set; }
        public PagedResponse(T data, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Data = data;
            this.Message = null;
            this.Succeeded = true;
            this.Errors = null;
        }
    }
}
