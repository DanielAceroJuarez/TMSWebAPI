using TMSWebAPI.Models;

namespace TMSWebAPI.Strategies
{
    /// <summary>
    /// Interface for different shipping strategies.
    /// </summary>
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(Shipment shipment);
    }
}
