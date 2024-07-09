using System.Collections.Generic;
using System.Linq;
using TMSWebAPI.Models;

namespace TMSWebAPI.Repositories
{
    /// <summary>
    /// Repository for managing shipments.
    /// </summary>
    public class ShipmentRepository : IRepository<Shipment>
    {
        private readonly List<Shipment> _shipments = new List<Shipment>();

        public void Add(Shipment shipment)
        {
            _shipments.Add(shipment);
        }

        public Shipment Get(int id)
        {
            return _shipments.FirstOrDefault(s => s.ShipmentId == id);
        }

        public IEnumerable<Shipment> GetAll()
        {
            return _shipments;
        }

        public void Update(Shipment shipment)
        {
            var existingShipment = Get(shipment.ShipmentId);
            if (existingShipment != null)
            {
                existingShipment.Origin = shipment.Origin;
                existingShipment.Destination = shipment.Destination;
                existingShipment.ShipmentDate = shipment.ShipmentDate;
                existingShipment.Weight = shipment.Weight;
            }
        }

        public void Delete(int id)
        {
            var shipment = Get(id);
            if (shipment != null)
            {
                _shipments.Remove(shipment);
            }
        }
    }
}
