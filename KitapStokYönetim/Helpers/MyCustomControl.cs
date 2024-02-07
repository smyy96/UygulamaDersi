using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapStokYönetim.Helpers
{
    public static class MyCustomControl
    {

        public static bool ControlStingToNumber(string data,out int  number)
        {

            var result =  int.TryParse(data, out number);
            return result;

        }

        
    }
}
