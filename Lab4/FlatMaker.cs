using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class FlatMaker // Лаба 4
    {
        public Flat Make(FlatBuider flatBuilder, Form1 ff1)
        {
            flatBuilder.CreateFlat(new FlatFactory(), ff1);
            flatBuilder.SetFootage();
            flatBuilder.SetNumOfRooms();
            flatBuilder.SetYearOfContr();
            flatBuilder.SetFloor();
            flatBuilder.SetPrice();
            flatBuilder.SetKitchen();
            flatBuilder.SetBathroom();
            flatBuilder.SetBasement();
            flatBuilder.SetBalcony();
            flatBuilder.SetMaterial();

            return flatBuilder.Flat;
        }
    }
}
