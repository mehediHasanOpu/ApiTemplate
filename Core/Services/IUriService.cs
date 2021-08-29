using Core.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
