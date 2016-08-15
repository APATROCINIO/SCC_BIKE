using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DAO;
using SCC_BIKE.DTO;

namespace SCC_BIKE.Model
{
    public class ChamadoModel
    {
        public int IncluirChamado(ChamadoDTO objChamadoDTO)
        {

            return new ChamadoDAO(). IncluirChamado(objChamadoDTO);
        }

        public int PesquisarChamado(int idUsuario, int idCliente, int idTipoChamado, DateTime DataAtendimento)
        {

            return new ChamadoDAO().PesquisarChamado(idUsuario, idCliente, idTipoChamado, DataAtendimento);
        }

        public DataTable BuscarChamadoCadastro()
        {

            return new ChamadoDAO().BuscarChamadoCadastro();
        }

        public DataTable BuscarChamadoApontamentoTecnico()
        {

            return new ChamadoDAO().BuscarChamadoApontamentoTecnico();
        }

        public DataTable BuscarChamadoAutorizarServico()
        {

            return new ChamadoDAO().BuscarChamadoAutorizarServico();
        }

        public int AgendarChmado(ChamadoDTO objChamadoDTO)
        {
            return new ChamadoDAO().AgendarChmado(objChamadoDTO);
        }

        public DataTable BuscarChamadoImprimir()
        {

            return new ChamadoDAO().BuscarChamadoImprimir();
        }

        public DataTable BuscarChamadoBaixa()
        {

            return new ChamadoDAO().BuscarChamadoBaixa();
        }

        public int FinalizarChamado(ChamadoDTO objChamadoDTO)
        {

            return new ChamadoDAO().FinalizarChamado(objChamadoDTO);
        }

        public DataTable ConsultarChamadosAtendidos(DateTime varAtendimentoDe, DateTime varAtendimentoAte, DateTime varAgendamentoDe, DateTime varAgendamentoAte)
        {

            return new ChamadoDAO().ConsultarChamadosAtendidos(varAtendimentoDe, varAtendimentoAte, varAgendamentoDe, varAgendamentoAte);
        }


        public DataTable ConsultarChamadosNaoAutorizados(DateTime varAtendimentoDe, DateTime varAtendimentoAte, DateTime varAgendamentoDe, DateTime varAgendamentoAte)
        {

            return new ChamadoDAO().ConsultarChamadosNaoAutorizados(varAtendimentoDe, varAtendimentoAte, varAgendamentoDe, varAgendamentoAte);
        }

        public DataTable ConsultarChamadosPendentes(DateTime varAtendimentoDe, DateTime varAtendimentoAte, DateTime varAgendamentoDe, DateTime varAgendamentoAte)
        {

            return new ChamadoDAO().ConsultarChamadosNaoAtendidos(varAtendimentoDe, varAtendimentoAte, varAgendamentoDe, varAgendamentoAte);
        }    
    }
}
