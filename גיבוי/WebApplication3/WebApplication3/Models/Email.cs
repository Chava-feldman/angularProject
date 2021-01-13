using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Email
    {
        public string email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Email(string m, string s, string b)
        {
            email = m;
            Subject = s;
            Body = b;
        }

    }
}