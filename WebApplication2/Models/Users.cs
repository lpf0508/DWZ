using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Users
    {

        [Key]

        public int UserID { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public string UserEmail { get; set; }

        public string Details { get; set; }


    }
}