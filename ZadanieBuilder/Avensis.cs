using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
   public  class Avensis : ICarBuildable
    {
        public string CarModel { get; set; } = "Avensis";

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
            return  "Nadwozie";
        }
    }
}
