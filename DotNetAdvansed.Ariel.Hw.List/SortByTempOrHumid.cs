using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvansed.Ariel.Hw.List
{
    class SortByTempOrHumid : IComparer<TemperatureMeasurement>
    {
        public int Compare(TemperatureMeasurement x, TemperatureMeasurement y)
        {
            if (x.Humidity.CompareTo(y.Humidity) == 0)
            {
                if (x.Temperature.CompareTo(y.Temperature) == 0)
                {
                    return x.City.CompareTo(y.City);
                }
            return (x.Temperature.CompareTo(y.Temperature)) * -1;
            }
         return ((x.Humidity.CompareTo(y.Humidity)) *-1);
        }
    }
}
