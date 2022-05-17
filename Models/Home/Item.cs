using E_Shopping.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Shopping.Models.Home
{
    public class Item
    {
        public Tbl_Product Product { get; set; }
        public int Quantity { get; set; }
    }
}