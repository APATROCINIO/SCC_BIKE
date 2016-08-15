using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DTO;
using SCC_BIKE.DAO;

namespace SCC_BIKE.Model
{
    public class GrupoEmpresasModel
    {

        public DataTable BuscarGrupoEmpresas(int codProdutoCategoria)
        {

            return new GrupoEmpresasDAO().BuscarGrupoEmpresas(codProdutoCategoria);
        }
    
    }
}
