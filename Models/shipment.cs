using System;

namespace TMSWebAPI.Models
{
    /// <summary>
    /// Represents a shipment in the TMS.
    /// </summary>
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime ShipmentDate { get; set; }
        public decimal Weight { get; set; }

        public Shipment(int shipmentId, string origin, string destination, DateTime shipmentDate, decimal weight)
        {
            ShipmentId = shipmentId;
            Origin = origin;
            Destination = destination;
            ShipmentDate = shipmentDate;
            Weight = weight;
        }
    }
}
