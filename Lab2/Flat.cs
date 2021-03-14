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
    public class Flat
    {
        public int footage;
        public int numOfRooms;
        public string yearOfConstruction;
        public int floor;

        public string kitchen;
        public string bathroom;
        public string basement;
        public string balcony;

        public string material;

        public Address address;

        public Flat (int _footage, int _numOfRooms, string _yearOfConstruction,
            int _floor, string _kitchen, string _bathroom, string _basement,
            string _balcony, string _material, Address _address)
        {
            this.footage = _footage;
            this.numOfRooms = _numOfRooms;
            this.yearOfConstruction = _yearOfConstruction;
            this.floor = _floor;
            this.kitchen = _kitchen;
            this.bathroom = _bathroom;
            this.basement = _basement;
            this.balcony = _balcony;
            this.material = _material;
            this.address = _address;
        }

        public Flat()
        {
            footage = 0;
            numOfRooms = 0;
            yearOfConstruction = "";
            floor = 0;
            kitchen = "";
            bathroom = "";
            basement = "";
            balcony = "";
            material = "";
        }

        //public override string ToString()
        //{
        //    return footage + " " + numOfRooms + " " + yearOfConstruction + " " + floor +
        //        " " + kitchen + " " + bathroom + " " + basement + " " + balcony +
        //        " " + material + " " + address.country + " " + address.city + " " +
        //        address.street + " " + address.house + " " + address.flat;
        //}

        public override string ToString()
        {
            return "Метраж:" + footage + " Кол-во комнат:" + numOfRooms + " Год постройки:" + yearOfConstruction + " Этаж:" + floor +
                " Опции:" + kitchen + ", " + bathroom + ", " + basement + ", " + balcony +
                " Материал:" + material + " Адрес:" + address.country + ", " + address.city + ", " +
                address.street + ", " + address.house + "/" + address.flat;
        }
    }
}
