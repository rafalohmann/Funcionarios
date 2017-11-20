using Funcionarios.Service.Resources;
using Funcionarios.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Funcionarios.Api.Controllers
{
    public class SexoController : ApiController
    {
        private readonly ISexoService service;

        public SexoController(ISexoService service)
        {
            this.service = service;
        }

        [HttpPost]
        //[Authorize]
        public IHttpActionResult Add([FromBody] SexoResource sexo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Add(sexo);

            return Ok();
        }

        [HttpPut]
        //[Authorize]
        public IHttpActionResult Update([FromBody] SexoResource sexo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Update(sexo);

            return Ok();
        }

        [HttpDelete]
        //[Authorize]
        public IHttpActionResult DeleteSexo(string id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Delete(id);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var sexo = service.GetById(id);

            if (sexo == null)
                return NotFound();

            return Ok(sexo);
        }

        [HttpGet]
        public IHttpActionResult Get([FromUri] SexoResource sexo)
        {
            IEnumerable<SexoResource> list = service.GetAll();

            if (list == null)
                return NotFound();

            return Ok(list);
        }
    }
}