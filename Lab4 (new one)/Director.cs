using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public  class Director
    {
        private FlatBuilderBase builderBase;

        public FlatBuilderBase BuilderBase
        {
            set { builderBase = value; }
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
