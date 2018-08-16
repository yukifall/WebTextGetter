using System;
using System.Collections.Generic;
using System.Text;

namespace WebTextGetter.Models
{
    public class Novel
    {
        public string NovelTitle { get; set; }
        public List<NovelPage> Pages { get; set; }
    }

    public class NovelPage
    {
        public int PageNo { get; set; }
        public string PageTitle { get; set; }
        public List<string> Lines { get; set; }
    }


}
