using Curso.Api.Models.Cursos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Curso.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class CursoController : ControllerBase
    {
        /// <summary>
        /// Este serviço permite cadastrar curso para usuário autenticado.
        /// </summary>
        /// <returns>Retorna 201 e Dados dos Cursos do Usuário</returns>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar o curso.")]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado.")]        
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post(CursoViewModelInput cursoViewModelInput)
        {
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            return Created("", cursoViewModelInput);
        }

        /// <summary>
        /// Este serviço permite obter todos os cursos ativos do usuario.
        /// </summary>
        /// <returns>Retorna status Ok e Dados dos Cursos do Usuário</returns>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar o curso.")]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado.")]
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);

            var cursos = new List<CursoViewModelOutput>();

            cursos.Add(new CursoViewModelOutput()
            {
                Login = codigoUsuario.ToString(),
                Descricao = "Teste descrição",
                Nome = "Teste"
            });

            return Ok(cursos);
        }
    }
}
