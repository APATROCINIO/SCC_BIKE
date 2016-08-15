using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC_BIKE.DTO
{
    public class ChamadoDTO
    {

        private int codigo;
        private int idItemChamado;
        private string obsAtendenteChamado;
        private Decimal valorTotal;
        private DateTime dataAtendimento;
        private DateTime dataAgendamento;
        private string horaAgendamento;
        private DateTime dataRetirada;
        private string horaRetirada;
        private string clienteRetirada;
        private DateTime dataUltimaAtualizacao;
        private int usuarios_idUsuario;
        private int clientes_idCliente;
        private int tipoChamado_idTipoChamado;
        private int clientes_Usuarios_idUsuario;
        private string chamadoFinalizado;
        //private int chamadosItem_idItemChamado;
        //private int chamadosItem_Produtos_idProduto;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int IdItemChamado
        {
            get { return idItemChamado; }
            set { idItemChamado = value; }
        }

        public string ObsAtendenteChamado
        {
            get { return obsAtendenteChamado; }
            set { obsAtendenteChamado = value; }
        }

        public Decimal ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public DateTime DataAtendimento
        {
            get { return dataAtendimento; }
            set { dataAtendimento = value; }
        }

        public DateTime DataAgendamento
        {
            get { return dataAgendamento; }
            set { dataAgendamento = value; }
        }

        public string HoraAgendamento
        {
            get { return horaAgendamento; }
            set { horaAgendamento = value; }
        }

        public DateTime DataRetirada
        {
            get { return dataRetirada; }
            set { dataRetirada = value; }
        }

        public string HoraRetirada
        {
            get { return horaRetirada; }
            set { horaRetirada = value; }
        }

        public string ClienteRetirada
        {
            get { return clienteRetirada; }
            set { clienteRetirada = value; }
        }

        public DateTime DataUltimaAtualizacao
        {
            get { return dataUltimaAtualizacao; }
            set { dataUltimaAtualizacao = value; }
        }

        public int Usuarios_idUsuario
        {
            get { return usuarios_idUsuario; }
            set { usuarios_idUsuario = value; }
        }

        public int Clientes_idCliente
        {
            get { return clientes_idCliente; }
            set { clientes_idCliente = value; }
        }

        public int TipoChamado_idTipoChamado
        {
            get { return tipoChamado_idTipoChamado; }
            set { tipoChamado_idTipoChamado = value; }
        }

        public int Clientes_Usuarios_idUsuario
        {
            get { return clientes_Usuarios_idUsuario; }
            set { clientes_Usuarios_idUsuario = value; }
        }

        public string ChamadoFinalizado
        {
            get { return chamadoFinalizado; }
            set { chamadoFinalizado = value; }
        }

        //public int ChamadosItem_idItemChamado
        //{
        //    get { return chamadosItem_idItemChamado; }
        //    set { chamadosItem_idItemChamado = value; }
        //}

        //public int ChamadosItem_Produtos_idProduto
        //{
        //    get { return chamadosItem_Produtos_idProduto; }
        //    set { chamadosItem_Produtos_idProduto = value; }
        //}

    }
}
