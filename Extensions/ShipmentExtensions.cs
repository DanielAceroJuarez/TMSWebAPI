using TMSWebAPI.Models;

namespace TMSWebAPI.Extensions
{
    /// <summary>
    /// Extension methods for Shipment class.
    /// </summary>
    public static class ShipmentExtensions
    {
        public static decimal CalculateShippingCost(this Shipment shipment, decimal ratePerKg)
        {
            return shipment.Weight * ratePerKg;
        }
    }
}
