using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC_BIKE.DTO
{
    public class ProdutoDTO
    {
        private int codigo;
        private string nomeProduto;
        private DateTime dataCadastro;
        private DateTime dataUltimaAtualizacao;
        private int grupoEmpresas_idGrupoEmpresa;


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public DateTime DataUltimaAtualizacao
        {
            get { return dataUltimaAtualizacao; }
            set { dataUltimaAtualizacao = value; }
        }

        public int GrupoEmpresas_idGrupoEmpresa
        {
            get { return grupoEmpresas_idGrupoEmpresa; }
            set { grupoEmpresas_idGrupoEmpresa = value; }
        }

    }
}
