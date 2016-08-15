using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DAO;
using SCC_BIKE.DTO;

namespace SCC_BIKE.Model
{
    public class ChamadoItemModel
    {
        public int IncluirChamadoItem(ChamadoItemDTO objChamadoItemDTO)
        {

            return new ChamadoItemDAO().IncluirChamadoItem(objChamadoItemDTO);
        }

        public int PesquisarCodigoChamadoItem(int idUsuario, int idProduto, DateTime dataInclusao)
        {

            return new ChamadoItemDAO().PesquisarCodigoChamadoItem(idUsuario, idProduto, dataInclusao);
        }

        public int AtualizarItemChmado(ChamadoItemDTO objChamadoItemDTO)
        {
            return new ChamadoItemDAO().AtualizarItemChmado(objChamadoItemDTO);
        }

        public int AtualizarStatusItemChmado(ChamadoItemDTO objChamadoItemDTO)
        {
            return new ChamadoItemDAO().AtualizarStatusItemChmado(objChamadoItemDTO);
        }

        public int AtualizarValorItemChmado(ChamadoItemDTO objChamadoItemDTO)
        {
            return new ChamadoItemDAO().AtualizarValorItemChmado(objChamadoItemDTO);
        }

        public DataTable BuscarChamadoAutorizado(int parIdChamado)
        {
            return new ChamadoItemDAO().BuscarChamadoAutorizado(parIdChamado);
        }
    }
}
