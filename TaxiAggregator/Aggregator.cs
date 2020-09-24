using System.Collections.Generic;

namespace TaxiAggregator
{
    public abstract class Aggregator
    {
        private List<Company> companies;
        
        //Find closest
        //Send through API
        
        public static void dropOrder(Location orderLocation, Taxi refusedDriver)
        {
            
        }

        public static void findClosest()
        {
            
        }

        public static void checkDropped()
        {
            //if db !empty => dropOrder(getFirstOrderLocationFromDB(), getFirstRefusedDriverFromDB())
        }
    }
}