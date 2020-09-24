namespace TaxiAggregator
{
    public class Location
    {
        private double lat;
        private double lon;

        public Location(double lat, double lon)
        {
            setLocation(lat, lon);
        }

        public void setLocation(double lattittude, double longtittude)
        {
            this.lat = lattittude;
            this.lon = longtittude;
        }

        public double getLattitude()
        {
            return this.lat;
        }

        public double getLongtittude()
        {
            return this.lon;
        }
    }
}