using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_62133508.Common
{
    [Serializable]
    public class UserInfoPublic
    {
        public long UserID { set; get; }
        public string Username { set; get; }
        public int? Permision { set; get; }

    }
}