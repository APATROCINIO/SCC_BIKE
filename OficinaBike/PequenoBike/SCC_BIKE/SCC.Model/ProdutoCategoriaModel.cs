using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DTO;
using SCC_BIKE.DAO;

namespace SCC_BIKE.Model
{
    public class ProdutoCategoriaModel
    {

        public DataTable BuscarProdutoCategorias(string codEmpresaUsuario)
        {

            return new ProdutoCategoriaDAO().BuscarProdutoCategorias(codEmpresaUsuario);
        }

        public DataTable PesquisarProdutoCategorias(int codProdutoCategoria)
        {

            return new ProdutoCategoriaDAO().PesquisarProdutoCategorias(codProdutoCategoria);
        }
    }
}
