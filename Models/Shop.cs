using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicol_Cristian_Lab7.Models
{
    public class Shop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string Adress { get; set; }
        public string ShopDetalis { get { return ShopName + "" + Adress; } }

        [OneToMany]
        public List<ShopList> ShopLists { get; set; }


    }
}
