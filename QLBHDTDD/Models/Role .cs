using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class Role
    {
        public string Roleid { get; set; }
        public string Rolename { get; set; }
        public virtual Role Roles { get; set; }

    }
}