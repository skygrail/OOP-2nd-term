using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class FlatFactory // Лаба 4
    {
        public Address CreateAddress(Form1 ff)
        {
            return ff.GetAddress();
        }
    }
}
