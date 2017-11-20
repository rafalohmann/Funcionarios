using Funcionarios.Service.Resources;
using Funcionarios.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Funcionarios.Api.Controllers
{
    [RoutePrefix("api/cidade")]
    public class CidadeController : ApiController
    {
        private readonly ICidadeService service;

        public CidadeController(ICidadeService service)
        {
            this.service = service;
        }

        [HttpPost]
        //[Authorize]
        public IHttpActionResult Add([FromBody] CidadeResource entityResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Add(entityResource);

            return Ok();
        }

        [HttpPut]
        //[Authorize]
        public IHttpActionResult Update([FromBody] CidadeResource entityResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Update(entityResource);

            return Ok();
        }

        [HttpDelete]
        //[Authorize]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Delete(id);

            return Ok();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var entity = service.Get(id);

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpGet]
        [Route("{estadoId}")]
        public IHttpActionResult Get(string estadoId, [FromUri] CidadeResource entityResource)
        {
            IEnumerable<CidadeResource> list = service.GetMany(estadoId, entityResource);

            if (list == null)
                return NotFound();

            return Ok(list);
        }
    }
}