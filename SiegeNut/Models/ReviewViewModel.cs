using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace SiegeNut.Models
{
    public class ReviewViewModel
    {
        public IPagedList<Review> Reviews { get; set; }
        public string CurrentUser { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsAuthenticated { get; set; }

        public string SortBy { get; set; }
        public string SortOrder { get; set; }
        
        public string SearchString { get; set; }
        public string SearchField { get; set; }
        public int? SearchRating { get; set; }

        public int page { get; set; }
    }
}