using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DTO;
using SCC_BIKE.DAO;

namespace SCC_BIKE.Model
{
    public class ProdutoModel
    {
        public int IncluirProduto(ProdutoDTO objProdutoDTO)
        {

            return new ProdutoDAO().IncluirProduto(objProdutoDTO);
        }

        public DataTable BuscarProdutos()
        {

            return new ProdutoDAO().BuscarProdutos();
        }

        public DataTable BuscarProdutosChamado()
        {

            return new ProdutoDAO().BuscarProdutosChamado();
        }

        public DataTable PesquisarProdutos(string NomeProduto)
        {

            return new ProdutoDAO().PesquisarProdutos(NomeProduto);
        }

        public DataTable BuscarProdutoEmpresa(string codEmpresaUsuario)
        {

            return new ProdutoDAO().BuscarProdutoEmpresa(codEmpresaUsuario);
        }
        public int AtualizarProduto(ProdutoDTO objProdutoDTO)
        {
            return new ProdutoDAO().AtualizarProduto(objProdutoDTO);
        }

    }
}
