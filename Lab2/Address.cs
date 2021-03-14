using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class Address
    {
        public string country,
            city,
            street;
        public int house,
            flat;

        public Address(string _country, string _city, string _street, int _house, int _flat)
        {
            this.country = _country;
            this.city = _city;
            this.street = _street;
            this.house = _house;
            this.flat = _flat;
        }

        public Address()
        {
            country = "";
            city = "";
            street = "";
            house = 0;
            flat = 0;
        }

    }

    
}
