using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project_62133508.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Nhập tên tài khoản!")]
        public string username { set; get; }
        [Required(ErrorMessage = "Nhập mật khẩu!")]
        public string password { set; get; }
        public bool remember { set; get; }
    }
}