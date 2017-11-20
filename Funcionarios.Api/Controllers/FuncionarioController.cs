using Funcionarios.Service.Resources;
using Funcionarios.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Funcionarios.Api.Controllers
{
    public class FuncionarioController : ApiController
    {
        private readonly IFuncionarioService service;

        public FuncionarioController(IFuncionarioService service)
        {
            this.service = service;
        }

        [HttpPost]
        //[Authorize]
        public IHttpActionResult Add([FromBody] FuncionarioResource funcionario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Add(funcionario);

            return Ok();
        }

        [HttpPut]
        //[Authorize]
        public IHttpActionResult Update([FromBody] FuncionarioResource funcionario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Update(funcionario);

            return Ok();
        }

        [HttpDelete]
        //[Authorize]
        public IHttpActionResult DeleteFuncionario(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Delete(id);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var funcionario = service.GetById(id);

            if (funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }

        [HttpGet]
        public IHttpActionResult Get([FromUri] FuncionarioResource funcionario)
        {
            IEnumerable<FuncionarioResource> list = service.GetAll();

            if (list == null)
                return NotFound();

            return Ok(list);
        }
    }
}