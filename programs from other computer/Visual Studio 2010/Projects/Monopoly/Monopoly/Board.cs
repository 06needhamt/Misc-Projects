using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    class Board
    {
        public Property[] propertysquares = new Property[40];

        public Board()
        {
            propertysquares[0] = new Property { name = "go",
                price = 0, 
                hotelprice = 0, 
                colour = "nonproperty", 
                canbesold = false, 
                canhavehouses = false, 
                houseprice = 0, 
                ischance = false, 
                iscommunityChest = false, 
                hashotel = false,
                issold = false, 
                numberofhouses = 0,
                rentprice = -200 };

            propertysquares[2] = new Property
            {
                name = "mayfair",
                price = 400,
                hotelprice = 250,
                colour = "Dark Blue",
                canbesold = true,
                canhavehouses = true,
                houseprice = 0,
                ischance = false,
                iscommunityChest = false,
                hashotel = false,
                issold = false,
                numberofhouses = 0,
                rentprice = 50
            };
        }
    }
}
