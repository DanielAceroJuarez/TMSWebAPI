using TMSWebAPI.Models;
using TMSWebAPI.Repositories;

namespace TMSWebAPI.Services
{
    /// <summary>
    /// Singleton class for managing shipments.
    /// </summary>
    public sealed class ShipmentManager
    {
        private static readonly ShipmentManager _instance = new ShipmentManager();
        private ShipmentManager() { }
        public static ShipmentManager Instance => _instance;

        public IRepository<Shipment> ShipmentRepository { get; set; } = new ShipmentRepository();
    }
}
