using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBHDTDD.Models
{
    public class AccountModel
    {
        [Key]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Roleid { get; set; }

    }
}