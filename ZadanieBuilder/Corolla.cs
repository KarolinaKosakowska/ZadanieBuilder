using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    public class Corolla : ICarBuildable
    {

        public string BuildChassis()
        {
            return "Podwozie Corolla";
        }
        public string BuildEngine()
        {
            return "Silnik Corolla";
        }
        public string BuildBody()
        {
           return "Nadwozie Corolla";
        }

    }
}
