using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class FlatBuilderBase
    {
        protected Flat fl;

        protected FlatBuilderBase()
        {
            fl = new Flat();
        }

        public abstract void BuildRooms();
        public abstract void BuildFootage();
        public abstract void BuildYearOfConst();
        public abstract void BuildFloor();
        public abstract void BuildMaterial();
        public abstract void BuildPrice();
        public abstract void BuildKitchen();
        public abstract void BuildBathroom();
        public abstract void BuildBasement();
        public abstract void BuildBalcony();

        public Flat GetFlat()
        {
            return fl;
        }

    }
}
