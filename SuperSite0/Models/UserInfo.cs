using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSite0.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public int SubId { get; set; }
        public int Count { get; set; }

    }
}