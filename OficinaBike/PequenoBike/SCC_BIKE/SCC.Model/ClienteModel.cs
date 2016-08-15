using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DAO;
using SCC_BIKE.DTO;

namespace SCC_BIKE.Model
{
    public class ClienteModel
    {

        public int IncluirCliente(ClienteDTO objClienteDTO)
        {

            return new ClienteDAO().IncluirCliente(objClienteDTO);
        }

        public DataTable BuscarClientes()
        {

            return new ClienteDAO().BuscarClientes();
        }

        public DataTable BuscarClientesChamado()
        {

            return new ClienteDAO().BuscarClientesChamado();
        }

        public DataTable PesquisarClientes(string NomeCliente)
        {

            return new ClienteDAO().PesquisarClientes(NomeCliente);
        }

        public int AtualizarCliente(ClienteDTO objClienteDTO)
        {
            return new ClienteDAO().AtualizarCliente(objClienteDTO);
        }

    }
}
