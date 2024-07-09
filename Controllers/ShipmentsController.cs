using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TMSWebAPI.Models;
using TMSWebAPI.Repositories;

namespace TMSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentsController : ControllerBase
    {
        private readonly IRepository<Shipment> _repository;

        public ShipmentsController(IRepository<Shipment> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Shipment>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Shipment> Get(int id)
        {
            var shipment = _repository.Get(id);
            if (shipment == null)
            {
                return NotFound();
            }
            return Ok(shipment);
        }

        [HttpPost]
        public ActionResult<Shipment> Create([FromBody] Shipment shipment)
        {
            _repository.Add(shipment);
            return CreatedAtAction(nameof(Get), new { id = shipment.ShipmentId }, shipment);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Shipment shipment)
        {
            if (_repository.Get(id) == null)
            {
                return NotFound();
            }
            _repository.Update(shipment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_repository.Get(id) == null)
            {
                return NotFound();
            }
            _repository.Delete(id);
            return NoContent();
        }
    }
}
