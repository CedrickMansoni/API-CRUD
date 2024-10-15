using api.Models;

namespace api.Repository.Interfaces;

public interface IUsuario
{
    Task<string> CadastrarUsuario(UsuarioModel usuario); 
    Task<UsuarioModel> PesquisarUsuario(string nif);
    Task<IEnumerable<UsuarioModel>> PesqusarUsuarios();
    Task<IEnumerable<UsuarioModel>> PesqusarUsuarios(bool estado);
    Task<UsuarioModel> EditarUsuario(UsuarioModel usuario);
    Task<bool> ApagarUsuario(string nif);
}