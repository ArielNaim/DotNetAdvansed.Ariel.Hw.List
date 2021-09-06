using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvansed.Ariel.Hw.List
{
    class TemperatureMeasurement : IComparable<TemperatureMeasurement>
    {
        public string City { get; set; }
        public double Date { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }

        public TemperatureMeasurement(string city, double date, double temperature, int humidity)
        {
            City = city;
            Date = date;
            Temperature = temperature;
            Humidity = humidity;
        }

        public int CompareTo(TemperatureMeasurement other)
        {
            if (this.City.CompareTo(other.City) == 0)
            {
                if (this.Date.CompareTo(other.Date) == 0)
                {
                    return this.Date.CompareTo(other.Date);
                }
            }
                return this.City.CompareTo(other.City);
        }
    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}, {3}", City, Date, Temperature, Humidity);
    }


    }

    
    }


