using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DAO;
using SCC_BIKE.DTO;

namespace SCC_BIKE.Model
{
    public class ChamadoTipoModel
    {
        public int PesquisarCodigoChamadoTipo(string DeSCC_BIKEhamadoTipo)
        {

            return new ChamadoTipoDAO().PesquisarCodigoChamadoTipo(DeSCC_BIKEhamadoTipo);
        }

        public int IncluirItemTipoChamado(ChamadoTipoDTO objChamadoTipoDTO)
        {

            return new ChamadoTipoDAO().IncluirItemTipoChamado(objChamadoTipoDTO);
        }



    }
}
