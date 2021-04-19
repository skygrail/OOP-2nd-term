using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class AddOnsForApartmentsDecorator : Flat
    {
        protected Flat flat;

        public AddOnsForApartmentsDecorator(string fl, Flat flat) : base()
        {
            this.flat = flat;
            this.addons += fl;
        }
    }

    class FlatWithRenovation : AddOnsForApartmentsDecorator
    {
        public FlatWithRenovation(Flat flat) : base(flat.addons + " Ремонт;", flat)
        { }
    }

    class FlatWithFurniture : AddOnsForApartmentsDecorator
    {
        public FlatWithFurniture(Flat flat) : base(flat.addons + " Мебель;", flat)
        { }
    }
 
    class FlatWithAlarm : AddOnsForApartmentsDecorator
    {
        public FlatWithAlarm(Flat flat) : base(flat.addons + " Сигнализация;", flat)
        { }
    }

}
