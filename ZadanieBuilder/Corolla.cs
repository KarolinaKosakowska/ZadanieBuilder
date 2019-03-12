using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    public class Corolla : ICarBuildable
    {
        public string CarModel { get; set; } = "Corolla";
      
        public string BuildChassis()
        {
            return "Podwozie";
        }
        public string BuildEngine()
        {
            return "Silnik";
        }
        public string BuildBody()
        {
           return "Nadwozie";
        }
    }
}
