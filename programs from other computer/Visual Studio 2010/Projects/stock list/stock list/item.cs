using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace stock_list
{
    class item
    {
        public long stallnumber { get; set; }
        public long stocknumber { get; set; }
        public string itemdescription { get; set; }
        public decimal boughtprice { get; set; }
        public decimal soldprice { get; set; }
        public decimal profitorloss { get; set; }

    }
}
