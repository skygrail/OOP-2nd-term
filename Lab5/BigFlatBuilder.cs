using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class BigFlatBuilder : FlatBuilderBase
    {
        List<IObserver> observers;

        public BigFlatBuilder():base()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var obs in observers)
            {
                obs.Update(fl);
            }
        }
        public override void BuildRooms()
        {
            this.fl.numOfRooms = 6;
        }

        public override void BuildFootage()
        {
            this.fl.footage = 150;
        }

        public override void BuildYearOfConst()
        {
            this.fl.yearOfConstruction = "31 января 2021 г.";
        }

        public override void BuildFloor()
        {
            this.fl.floor = 15;
        }

        public override void BuildPrice()
        {
            this.fl.price = this.fl.footage * this.fl.numOfRooms;
        }

        public override void BuildKitchen()
        {
            this.fl.kitchen = "Кухня";
        }

        public override void BuildBathroom()
        {
            this.fl.bathroom = "Ванная";
        }

        public override void BuildBasement()
        {
            this.fl.basement = "Подвал";
        }

        public override void BuildBalcony()
        {
            this.fl.balcony = "Балкон";
        }

        public override void BuildMaterial()
        {
            this.fl.material = "Пенопласт";
        }
    }
}
