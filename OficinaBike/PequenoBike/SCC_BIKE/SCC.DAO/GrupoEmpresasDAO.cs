using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC_BIKE.DTO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SCC_BIKE.DAO
{
    public class GrupoEmpresasDAO
    {
        #region "Read"
        
        public DataTable BuscarGrupoEmpresas(int codProdutoCategoria)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "SELECT GE.idGrupoEmpresa, GE.NomeGrupoEmpresa " +
                                        "  FROM produtoscategoria PC, grupoempresas GE " +
                                        " WHERE GE.idGrupoEmpresa = PC.GrupoEmpresas_idGrupoEmpresa and " +
                                        "       PC.idProdutoCategoria = @codProdutoCategoria " +
                                        " GROUP BY GE.idGrupoEmpresa, GE.NomeGrupoEmpresa";

                MCCommand.Parameters.AddWithValue("@codProdutoCategoria", codProdutoCategoria);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtProdutoCategoria = new DataTable();

                //Recebe dados da conexão
                dtProdutoCategoria.Load(leitor);

                return dtProdutoCategoria;
            }

        }

        #endregion
    }
}
