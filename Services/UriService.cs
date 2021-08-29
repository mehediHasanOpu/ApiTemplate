using Core.Filters;
using Core.Services;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }
        public Uri GetPageUri(PaginationFilter filter, string route)
        {
            var _enpointUri = new Uri(string.Concat(_baseUri, route));
            var modifiedUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "page", filter.Page.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "per_page", filter.Per_Page.ToString());
            return new Uri(modifiedUri);
        }
    }
}
