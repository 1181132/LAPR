using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using DDDSample1.Domain.Shared;
using DDDSample1.Domain.Entregas;

namespace DDDSample1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregasController : ControllerBase
    {
        private readonly IEntregaService _service;

        public EntregasController(IEntregaService service)
        {
            _service = service;
        }

        // GET: api/Entregas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntregaDto>>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        // GET: api/Entregas/6
        [HttpGet("{id}")]
        public async Task<ActionResult<EntregaDto>> GetGetById(String id)
        {
            var entrega = await _service.GetByIdAsync(new EntregaId(id));

            if (entrega == null)
            {
                return NotFound();
            }

            return entrega;
        }

        // POST: api/Entregas
        [HttpPost]
        public async Task<ActionResult<EntregaDto>> Create(CreatingEntregaDto dto)
        {
            var entrega = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetGetById), new { id = entrega.Id }, entrega);
        }

        
        // PUT: api/Entregas/6
        [HttpPut("{id}")]
        public async Task<ActionResult<EntregaDto>> Update(String id, EntregaDto dto)
        {
            if (id != dto.Id)
            {
                return BadRequest();
            }

            try
            {
                var entrega = await _service.UpdateAsync(dto);
                
                if (entrega == null)
                {
                    return NotFound();
                }
                return Ok(entrega);
            }
            catch(BusinessRuleValidationException ex)
            {
                return BadRequest(new {Message = ex.Message});
            }
        }

        // Inactivate: api/Entregas/6
        [HttpDelete("{id}")]
        public async Task<ActionResult<EntregaDto>> SoftDelete(String id)
        {
            var entrega = await _service.InactivateAsync(new EntregaId(id));

            if (entrega == null)
            {
                return NotFound();
            }

            return Ok(entrega);
        }
        
        // DELETE: api/Entregas/6
        [HttpDelete("{id}/hard")]
        public async Task<ActionResult<EntregaDto>> HardDelete(String id)
        {
            try
            {
                var entrega = await _service.DeleteAsync(new EntregaId(id));

                if (entrega == null)
                {
                    return NotFound();
                }

                return Ok(entrega);
            }
            catch(BusinessRuleValidationException ex)
            {
               return BadRequest(new {Message = ex.Message});
            }
        }
    }
}