using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
   public  class Avensis : ICarBuildable
    {      
        
        public string BuildChassis()
        {
            return "Podwozie Avensis";
        }
        public string BuildEngine()
        {
            return "Silnik Avensis";
        }
        public string BuildBody()
        {
          return  "Nadwozie Avensis";
        }


    }
}
