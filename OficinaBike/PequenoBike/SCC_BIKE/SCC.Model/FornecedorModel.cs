using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DTO;
using SCC_BIKE.DAO;

namespace SCC_BIKE.Model
{
    public class FornecedorModel
    {
        public int IncluirFornecedor(FornecedorDTO objFornecedorDTO)
        {

            return new FornecedorDAO().IncluirFornecedor(objFornecedorDTO);
        }

        public DataTable BuscarFornecedores()
        {

            return new FornecedorDAO().BuscarFornecedores();
        }

        public DataTable PesquisarFornecedores(string NomeFornecedor)
        {

            return new FornecedorDAO().PesquisarFornecedores(NomeFornecedor);
        }

        public int AtualizarFornecedor(FornecedorDTO objFornecedorDTO)
        {
            return new FornecedorDAO().AtualizarFornecedor(objFornecedorDTO);
        }
 
    }
}
