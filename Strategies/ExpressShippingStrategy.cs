using TMSWebAPI.Models;

namespace TMSWebAPI.Strategies
{
    /// <summary>
    /// Express shipping strategy.
    /// </summary>
    public class ExpressShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Shipment shipment)
        {
            return shipment.Weight * 2.5m; // Example rate
        }
    }
}
