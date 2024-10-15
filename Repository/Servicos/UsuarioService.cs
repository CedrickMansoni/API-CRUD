using api.Data;
using api.Models;
using api.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace api.Repository.Services;

public class UsuarioService : IUsuario
{
    private readonly DataContext context;
    public UsuarioService(DataContext context)
    {
        this.context = context;
    }

    public Task<bool> ApagarUsuario(string nif)
    {
        throw new NotImplementedException();
    }

    public async Task<string> CadastrarUsuario(UsuarioModel usuario)
    {
        using (var transacao = await context.Database.BeginTransactionAsync())
        {
           var u = await context.TabelaUsuario.FirstOrDefaultAsync(user => user.Nif == usuario.Nif);
           if (u is not null)
           {
                await transacao.RollbackAsync();
                return "Não foi possível cadastrar este usuário porque já existe no banco de dados";
           }
           await context.TabelaUsuario.AddAsync(usuario);
           if (await context.SaveChangesAsync() > 0)
           {
                await transacao.CommitAsync();
                return "Usuário cadastrado com sucesso";
           }
           return string.Empty;
        }
    }

    public Task<UsuarioModel> EditarUsuario(UsuarioModel usuario)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioModel> PesquisarUsuario(string nif)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UsuarioModel>> PesqusarUsuarios()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UsuarioModel>> PesqusarUsuarios(bool estado)
    {
        throw new NotImplementedException();
    }
}