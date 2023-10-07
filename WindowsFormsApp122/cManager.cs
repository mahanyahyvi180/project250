using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp122
{
    class cManager:cEmployee
    {

        public new int Concatinate()
        {
            return base.Concatinate().Length;
        }
    }
}
