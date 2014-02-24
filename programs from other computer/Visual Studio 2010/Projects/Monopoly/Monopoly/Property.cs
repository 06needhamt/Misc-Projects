using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    class Property
    {
        public string name { get; set; }
        public string colour { get; set; }
        public int price { get; set; }
        public int rentprice { get; set; }
        public int houseprice { get; set; }
        public int hotelprice { get; set; }
        public int numberofhouses { get; set; }
        public bool canbesold { get; set; }
        public bool canhavehouses { get; set; }
        public bool ischance { get; set; }
        public bool iscommunityChest { get; set; }
        public bool hashotel { get; set; }
        public bool issold { get; set; }

        public void buy(Property property)
        {
            property.issold = true;
            Console.WriteLine(property.name + " is now sold" );
        }
    }
}
