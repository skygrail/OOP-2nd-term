using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public  class Director : IObserver
    {
        private FlatBuilderBase builderBase;

        public bool approval { get; set; }

        public FlatBuilderBase BuilderBase
        {
            set { builderBase = value; }
        }

        public void Update(object obj)
        {
            Flat flat = (Flat)obj;
            if (flat.footage > 0)
                approval = true;
            else
                approval = false;
        }

        public void BuildWithoutOptions()
        {
            this.builderBase.BuildRooms();
            this.builderBase.BuildFootage();
            this.builderBase.BuildYearOfConst();
            this.builderBase.BuildMaterial();
            this.builderBase.BuildFloor();
            this.builderBase.BuildPrice();
        }

        public void BuildWithOptions()
        {
            this.builderBase.BuildRooms();
            this.builderBase.BuildFootage();
            this.builderBase.BuildYearOfConst();
            this.builderBase.BuildMaterial();
            this.builderBase.BuildFloor();
            this.builderBase.BuildPrice();
            this.builderBase.BuildKitchen();
            this.builderBase.BuildBathroom();
            this.builderBase.BuildBasement();
            this.builderBase.BuildBalcony();
    }
    }
}
