using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC_BIKE.DTO
{
    class GrupoEmpresasDTO
    {
        private int codigo;
        private string nomeGrupoEmpresa;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NomeGrupoEmpresa
        {
            get { return nomeGrupoEmpresa; }
            set { nomeGrupoEmpresa = value; }
        }

    }
}
