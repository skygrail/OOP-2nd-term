using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class FlatBuider // Лаба 4
    {
        public Flat Flat { get; private set; }

        protected Form1 ff { get; set; }

        public void CreateFlat(FlatFactory ff, Form1 ff1)
        {
            Flat = new Flat();
            this.ff = ff1;
            Flat.address = ff.CreateAddress(ff1);
        }

        public abstract void SetFootage();

        public abstract void SetNumOfRooms();

        public abstract void SetYearOfContr();

        public abstract void SetFloor();

        public abstract void SetPrice();

        public abstract void SetKitchen();

        public abstract void SetBathroom();

        public abstract void SetBasement();

        public abstract void SetBalcony();

        public abstract void SetMaterial();
    }
}
