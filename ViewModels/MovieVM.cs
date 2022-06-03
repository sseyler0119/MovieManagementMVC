using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManagementMVC.ViewModels
{
    public class MovieVM // Movie view model to limit the number of variables sent to the Admin Index page
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
    }
}