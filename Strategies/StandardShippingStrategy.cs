using TMSWebAPI.Models;

namespace TMSWebAPI.Strategies
{
    /// <summary>
    /// Standard shipping strategy.
    /// </summary>
    public class StandardShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Shipment shipment)
        {
            return shipment.Weight * 1.5m; // Example rate
        }
    }
}
