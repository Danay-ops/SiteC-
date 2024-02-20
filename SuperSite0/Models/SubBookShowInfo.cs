using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSite0.Models
{
    public class SubBookShowInfo
    {
        BookInfo Book { get; set; }
        List<TagInfo> Tags { get; set; }
    }
}