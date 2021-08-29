using Core.Filters;
using Core.Services;
using Core.Wrappers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public class PaginationHelper
    {
        public static PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationFilter validFilter, int totalRecords, IUriService uriService, string route)
        {
            var totalPages = ((double)totalRecords / (double)validFilter.Per_Page);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            var respose = new PagedResponse<List<T>>(pagedData, validFilter.Page, validFilter.Per_Page)
            {
                Next_page_url = validFilter.Page >= 1 && validFilter.Page < roundedTotalPages
                ? uriService.GetPageUri(new PaginationFilter(validFilter.Sort, validFilter.Page + 1, validFilter.Per_Page, validFilter.Search), route)
                : null,
                Prev_page_url = validFilter.Page - 1 >= 1 && validFilter.Page <= roundedTotalPages
                ? uriService.GetPageUri(new PaginationFilter(validFilter.Sort, validFilter.Page - 1, validFilter.Per_Page, validFilter.Search), route)
                : null,
                FirstPage = uriService.GetPageUri(new PaginationFilter(validFilter.Sort, 1, validFilter.Per_Page, validFilter.Search), route),
                LastPage = uriService.GetPageUri(new PaginationFilter(validFilter.Sort, roundedTotalPages, validFilter.Per_Page, validFilter.Search), route),
                TotalPages = roundedTotalPages,
                TotalRecords = totalRecords,
                Total = totalRecords,
                Current_page = validFilter.Page,
                Per_page = validFilter.Per_Page,
                Last_page = roundedTotalPages,
                From = validFilter.Page == 1 ? 1 : ((validFilter.Page - 1) * validFilter.Per_Page) + 1,
                To = validFilter.Page == roundedTotalPages ? totalRecords : ((validFilter.Page - 1) * validFilter.Per_Page) + validFilter.Per_Page
            };
          
            return respose;
        }
    }
}
