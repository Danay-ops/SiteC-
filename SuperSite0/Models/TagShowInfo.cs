using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSite0.Models
{
    public class TagShowInfo
    {
        List<TagInfo> Tags { get; set; }
        public List<BookInfo> Books { get; set; }
    }
}