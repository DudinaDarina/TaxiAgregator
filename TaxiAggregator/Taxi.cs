using System;

namespace TaxiAggregator
{
    public class Taxi
    {
        private string number;
        private GLONASS glonass;

        public Taxi(string number, GLONASS glonass)
        {
            this.number = number;
            this.glonass = glonass;
        }

        public string getNumber()
        {
            return this.number;
        }

        public Location getLocation()
        {
            return this.glonass.getLocation();
        }
    }
}