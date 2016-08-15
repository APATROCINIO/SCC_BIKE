using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC_BIKE.DTO
{
    public class UsuarioDTO {
    
        private int codigo;
        private string nome;
        private string sobrenome;
        private string login;
        private string senha;
        private string email;
        private string cpf;
        private int perfil;
        private char status;
        private DateTime dataCadastro;


        public int Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
 
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
 
        public string Senha
        {
            get { return senha;  }
            set { senha = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
