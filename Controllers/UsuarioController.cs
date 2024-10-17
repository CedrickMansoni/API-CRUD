using api.Models;
using api.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;


[ApiController]
[Route("api/v1/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuario usuario;
    public UsuarioController(IUsuario usuario)
    {
        this.usuario = usuario;
    }


    [HttpPost]
    [Route("/cadastrar/usuario")]
    public async Task<IActionResult> CadastrarUsuario(UsuarioModel usuario)
    {
        var response = await this.usuario.CadastrarUsuario(usuario);
        if(response.Contains("Não") || response == string.Empty)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    [HttpPut]
    [Route("/editar/usuario")]
    public async Task<IActionResult> EditarUsuario([FromBody] UsuarioModel usuario)
    {
        var response = await this.usuario.EditarUsuario(usuario);
        if (response is not null)
        if (response.Mensagem.Contains("Erro"))
        {
            BadRequest(response);
        }
        return Ok(response);
    }
}