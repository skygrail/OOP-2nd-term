using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    public class Flat
    {
        [IndexNumber]
        public int footage { get; }
        [Required]
        public int numOfRooms;
        [Required]
        public string yearOfConstruction;
        [Required]
        public int floor;
        [Required]
        public int price;

        [Required]
        public string kitchen;
        [Required]
        public string bathroom;
        [Required]
        public string basement;
        [Required]
        public string balcony;

        [Required]
        public string material;

        public Address address;

        public Flat(int _footage, int _numOfRooms, string _yearOfConstruction,
            int _floor, int _price, string _kitchen, string _bathroom, string _basement,
            string _balcony, string _material, Address _address)
        {
            this.footage = _footage;
            this.numOfRooms = _numOfRooms;
            this.yearOfConstruction = _yearOfConstruction;
            this.floor = _floor;
            this.price = _price;
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
            price = 0;
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
