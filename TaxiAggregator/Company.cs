using System;
using System.Collections.Generic;

namespace TaxiAggregator
{
    public class Company
    {
        private string name;
        private List<Taxi> taxiList;

        public Company(string name, List<Taxi> taxiList)
        {
            this.name = name;
            this.taxiList = taxiList;
        }

        public string getName()
        {
            return name;
        }

        public void addAuto(Taxi newAuto)
        {
            if (!this.taxiList.Exists(auto => auto.getNumber().Equals(newAuto.getNumber())))
            {
                this.taxiList.Add(newAuto);
            }
            else
            {
                throw new Exception("Auto with such number already exists");
            }
        }

        public void removeAuto(string number)
        {
            if (this.taxiList.Exists(auto => auto.getNumber().Equals(number)))
            {
                this.taxiList.Remove(this.taxiList.Find(auto => auto.getNumber().Equals(number)));
            }
        }
    }
}