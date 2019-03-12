using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    public class Director
    {
        ICarBuildable builder;

        public Director(ICarBuildable builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildChassis();
            builder.BuildEngine();
            builder.BuildBody();
        }

        public string GetBuildedParts()
        {
            string CompletedParts = $"{builder.BuildChassis()} {builder.CarModel}  {builder.BuildEngine()} {builder.CarModel}  {builder.BuildBody()} {builder.CarModel} ";
            return CompletedParts;
        }
    }
}
