using Funcionarios.Service.Resources;
using Funcionarios.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Funcionarios.Api.Controllers
{
    [Route("api/AfastamentoFuncionario")]
    public class AfastamentoFuncionarioController : ApiController
    {
        private readonly IAfastamentoFuncionarioService service;

        public AfastamentoFuncionarioController(IAfastamentoFuncionarioService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Add([FromBody] AfastamentoFuncionarioResource afastamentoFuncionario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Add(afastamentoFuncionario);

            return Ok();
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update([FromBody] AfastamentoFuncionarioResource afastamentoFuncionario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Update(afastamentoFuncionario);

            return Ok();
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult DeleteAfastamentoFuncionario(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Delete(id);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var afastamentoFuncionario = service.GetById(id);

            if (afastamentoFuncionario == null)
                return NotFound();

            return Ok(afastamentoFuncionario);
        }

        [HttpGet]
        public IHttpActionResult Get([FromBody] AfastamentoFuncionarioResource afastamentoFuncionario)
        {
            IEnumerable<AfastamentoFuncionarioResource> list = service.GetAll();

            if (afastamentoFuncionario == null)
                return NotFound();

            return Ok(afastamentoFuncionario);
        }
    }
}