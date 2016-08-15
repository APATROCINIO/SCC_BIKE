using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC_BIKE.DTO
{
    public class ChamadoItemDTO
    {
        private int codigo;
        private int produtos_idProduto;
        private int chamados_idChamado;
        private string externoPagtoCartao;
        private string externoPagtoDinheiro;
        private string externoPagtoCheque;
        private string internoPossuiDocumento;
        private string internoMarcaModeloSerie;
        private string servicoAutorizado;
        private decimal valorItem;
        private string obsItemChamado;
        private string obsItemTecnico;
        private DateTime dataInclusao;
        private int idUsuarioCadastro;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Produtos_idProduto
        {
            get { return produtos_idProduto; }
            set { produtos_idProduto = value; }
        }

        public int Chamados_idChamado
        {
            get { return chamados_idChamado; }
            set { chamados_idChamado = value; }
        }

        public string ExternoPagtoCartao
        {
            get { return externoPagtoCartao; }
            set { externoPagtoCartao = value; }
        }

        public string ExternoPagtoDinheiro
        {
            get { return externoPagtoDinheiro; }
            set { externoPagtoDinheiro = value; }
        }

        public string ExternoPagtoCheque
        {
            get { return externoPagtoCheque; }
            set { externoPagtoCheque = value; }
        }

        public string InternoPossuiDocumento
        {
            get { return internoPossuiDocumento; }
            set { internoPossuiDocumento = value; }
        }

        public string InternoMarcaModeloSerie
        {
            get { return internoMarcaModeloSerie; }
            set { internoMarcaModeloSerie = value; }
        }

        public decimal ValorItem
        {
            get { return valorItem; }
            set { valorItem = value; }
        }

        public string ServicoAutorizado
        {
            get { return servicoAutorizado; }
            set { servicoAutorizado = value; }
        }

        public string ObsItemChamado
        {
            get { return obsItemChamado; }
            set { obsItemChamado = value; }
        }

        public string ObsItemTecnico
        {
            get { return obsItemTecnico; }
            set { obsItemTecnico = value; }
        }

        public DateTime DataInclusao
        {
            get { return dataInclusao; }
            set { dataInclusao = value; }
        }

        public int IdUsuarioCadastro
        {
            get { return idUsuarioCadastro; }
            set { idUsuarioCadastro = value; }
        }

    }
}
