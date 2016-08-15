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
    public class ChamadoTipoDAO
    {

        #region "Create"

        public int IncluirItemTipoChamado(ChamadoTipoDTO objChamadoTipoDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                //ATENÇÃO, NUNCA DEIXAR UM INDICE NESTA TABELA QUAND O RELACIONAMENTO ESTIVER DIRECIONADO AO ID DO Chamado E IDictionary DO PRODUTO
                MCCommand.CommandText = "INSERT INTO ChamadosTipo ( Produtos_idProduto, Chamados_idChamado, Obs, ValorAtendimento ) " +
                " VALUES ( @Produtos_idProduto, @Chamados_idChamado, @Obs, @ValorAtendimento )";


                //MCCommand.Parameters.AddWithValue("@Produtos_idProduto", objChamadoTipoDTO.Produtos_idProduto);
                //MCCommand.Parameters.AddWithValue("@Chamados_idChamado", objChamadoItemDTO.Chamados_idChamado);
                //MCCommand.Parameters.AddWithValue("@Obs", objChamadoItemDTO.Obs);
                //MCCommand.Parameters.AddWithValue("@ValorAtendimento", 0.00);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Inclusão

        #endregion

        #region "Read"

        public int PesquisarCodigoChamadoTipo(string DeSCC_BIKEhamadoTipo)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idTipoChamado FROM ChamadosTipo WHERE DescricaoTipoChamado LIKE @ChamadoTipo";

                MCCommand.Parameters.AddWithValue("@ChamadoTipo", DeSCC_BIKEhamadoTipo);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;
                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtTipoChamado = new DataTable();

                //Recebe dados da conexão
                dtTipoChamado.Load(leitor);
                
                int CodTipoChamado = 0;

                if (dtTipoChamado.Rows[0]["idTipoChamado"].ToString() != "")
                {
                    CodTipoChamado = (int)Convert.ToInt32(dtTipoChamado.Rows[0]["idTipoChamado"].ToString());
                }

                return CodTipoChamado;
            }

        }  //Final PesquiarTipoChamado(string)

        #endregion

     
    }
}
