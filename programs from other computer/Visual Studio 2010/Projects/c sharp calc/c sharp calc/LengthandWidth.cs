using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class LengthandWidth
    {
        int length;
        int Width;
        int depth;
        decimal total;

        public decimal calculatePrice()
        {
            if (width > 10 && length > 10 && depth > 5)
            {
                total = 3.00;
            }
          
            else
            {
                total = 2.00;
            }

            return total;
        }

    }
}
