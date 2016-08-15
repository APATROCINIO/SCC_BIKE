using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DAO;
using SCC_BIKE.DTO;

namespace SCC_BIKE.Model
{
    public class UsuarioModel
    {
        public int IncluirUsuario(UsuarioDTO objUsuarioDTO)
        {
            
            return new UsuarioDAO().IncluirUsuario(objUsuarioDTO); 
        }

        public int AtualizarUsuario(UsuarioDTO objUsuarioDTO)
        {

            return new UsuarioDAO().AtualizarUsuario(objUsuarioDTO);
        }

        public UsuarioDTO AutenticarUsuarioSenha(UsuarioDTO objUsuarioDTO)
        {

            return new UsuarioDAO().AutenticarUsuarioSenha(objUsuarioDTO);
        }

        public DataTable BuscarUsuarios()
        {

            return new UsuarioDAO().BuscarUsuarios();
        }

        public DataTable PesquisarUsuarios(string NomeUsuario)
        {

            return new UsuarioDAO().PesquisarUsuarios(NomeUsuario);
        }
    }
}
