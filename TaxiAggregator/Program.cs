namespace TaxiAggregator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Aggregator.checkDropped();
            }
        }
    }
}