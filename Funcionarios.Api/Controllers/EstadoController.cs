using Funcionarios.Service.Resources;
using Funcionarios.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Funcionarios.Api.Controllers
{
    public class EstadoController : ApiController
    {
        private readonly IEstadoService service;

        public EstadoController(IEstadoService service)
        {
            this.service = service;
        }

        [HttpPost]
        //[Authorize]
        public IHttpActionResult Add([FromBody] EstadoResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Add(resource);

            return Ok();
        }

        [HttpPut]
        //[Authorize]
        public IHttpActionResult Update([FromBody] EstadoResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Update(resource);

            return Ok();
        }

        [HttpDelete]
        //[Authorize]
        public IHttpActionResult Delete(string id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Delete(id);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var entity = service.Get(id);

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpGet]
        public IHttpActionResult GetMany([FromUri] EstadoResource entity)
        {
            IEnumerable<EstadoResource> list = service.GetMany(entity);

            if (list == null)
                return NotFound();

            return Ok(list);
        }
    }
}