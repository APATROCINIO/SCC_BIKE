using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC_BIKE.DTO
{
    public class ProdutoCategoriaDTO
    {
        private int codigo;
        private string nomeProdutoCategoria;
        private int GrupoEmpresas_idGrupoEmpresa;
        
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NomeProdutoCategoria
        {
            get { return nomeProdutoCategoria; }
            set { nomeProdutoCategoria = value; }
        }

        public int GrupoEmpresas_idGrupoEmpresa1
        {
            get { return GrupoEmpresas_idGrupoEmpresa; }
            set { GrupoEmpresas_idGrupoEmpresa = value; }
        }

    }
}
