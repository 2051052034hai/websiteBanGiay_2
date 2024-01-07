using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.EF;

namespace Project_62133508.Models
{

        [Serializable]
        public class CartItem
        {
            public SANPHAM Product { get; set; }
            public int CoGiay { get; set; }
            public int Quantity { get; set; }
    }
}