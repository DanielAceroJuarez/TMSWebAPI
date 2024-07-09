using NUnit.Framework;
using System;
using TMSWebAPI.Models;
using TMSWebAPI.Repositories;
using FluentAssertions;

namespace TMSWebAPI.Tests
{
    [TestFixture]
    public class ShipmentRepositoryTests
    {
        private IRepository<Shipment> _repository;

        [SetUp]
        public void Setup()
        {
            _repository = new ShipmentRepository();
        }

        [Test]
        public void AddShipment_ShouldAddShipment()
        {
            var shipment = new Shipment(1, "New York", "Los Angeles", DateTime.Now, 100);
            _repository.Add(shipment);
            var retrievedShipment = _repository.Get(1);

            shipment.Should().Be(retrievedShipment);
        }

        [Test]
        public void GetShipment_ShouldReturnShipment()
        {
            var shipment = new Shipment(2, "Chicago", "Houston", DateTime.Now, 200);
            _repository.Add(shipment);
            var retrievedShipment = _repository.Get(2);

            shipment.Should().Be(retrievedShipment);
        }

        // Additional tests for Update and Delete...
    }
}
