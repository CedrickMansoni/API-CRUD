using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace API_CRUD.Models
{
    public class UsuarioDTO
    {
        public UsuarioModel? Dados {get; set;} = new UsuarioModel();
        public string Mensagem {get; set;} = string.Empty;
    }
}