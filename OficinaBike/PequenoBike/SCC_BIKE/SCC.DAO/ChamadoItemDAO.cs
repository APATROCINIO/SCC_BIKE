using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCC_BIKE.DTO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace SCC_BIKE.DAO
{
    public class ChamadoItemDAO
    {

        #region "Create"

        public int IncluirChamadoItem(ChamadoItemDTO objChamadoItemDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                //ATENÇÃO, NUNCA DEIXAR UM INDICE NESTA TABELA QUAND O RELACIONAMENTO ESTIVER DIRECIONADO AO ID DO Chamado E IDictionary DO PRODUTO
                MCCommand.CommandText = "INSERT INTO ChamadosItem ( Chamados_idChamado, DataInclusao, IdUsuarioCadastro, Produtos_idProduto, " +
                                        " CelularPossuiCarregador, CelularPossuiCartaoMemoria, CelularPossuiChip, PadraoPossuiCarregador, " +
                                        " PadraoMarcaModeloSerie, ValorItem, ServicoAutorizado ) " +
                                        " VALUES ( @Chamados_idChamado, @DataInclusao, @IdUsuarioCadastro, @Produtos_idProduto, " +
                                        " @CelularPossuiCarregador, @CelularPossuiCartaoMemoria, @CelularPossuiChip, @PadraoPossuiCarregador, " +
                                        " @PadraoMarcaModeloSerie, @ValorItem, @ServicoAutorizado )";

                MCCommand.Parameters.AddWithValue("@Chamados_idChamado", objChamadoItemDTO.Chamados_idChamado);
                MCCommand.Parameters.AddWithValue("@DataInclusao", objChamadoItemDTO.DataInclusao);
                MCCommand.Parameters.AddWithValue("@IdUsuarioCadastro", objChamadoItemDTO.IdUsuarioCadastro);                
                MCCommand.Parameters.AddWithValue("@Produtos_idProduto", objChamadoItemDTO.Produtos_idProduto);
                MCCommand.Parameters.AddWithValue("@CelularPossuiCarregador", objChamadoItemDTO.ExternoPagtoCartao);
                MCCommand.Parameters.AddWithValue("@CelularPossuiCartaoMemoria", objChamadoItemDTO.ExternoPagtoDinheiro);
                MCCommand.Parameters.AddWithValue("@CelularPossuiChip", objChamadoItemDTO.ExternoPagtoCheque);
                MCCommand.Parameters.AddWithValue("@PadraoPossuiCarregador", objChamadoItemDTO.InternoPossuiDocumento);
                MCCommand.Parameters.AddWithValue("@PadraoMarcaModeloSerie", objChamadoItemDTO.InternoMarcaModeloSerie);
                MCCommand.Parameters.AddWithValue("@ValorItem", objChamadoItemDTO.ValorItem);
                MCCommand.Parameters.AddWithValue("@ServicoAutorizado", objChamadoItemDTO.ServicoAutorizado);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Inclusão

        #endregion

        #region "Read"

        public int PesquisarCodigoChamadoItem(int idUsuario, int idProduto, DateTime dataInclusao)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idItemChamado FROM ChamadosItem WHERE idUsuarioCadastro = @idUsuario " +
                                        " AND Produtos_idProduto = @idProduto "+
                                        " AND dataInclusao = @dataInclusao ";

                MCCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                MCCommand.Parameters.AddWithValue("@idProduto", idProduto);
                MCCommand.Parameters.AddWithValue("@dataInclusao", dataInclusao);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;
                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtItemChamado = new DataTable();

                //Recebe dados da conexão
                dtItemChamado.Load(leitor);

                int CodItemChamado = 0;

                if (dtItemChamado.Rows[0]["idItemChamado"].ToString() != "")
                {
                    CodItemChamado = (int)Convert.ToInt32(dtItemChamado.Rows[0]["idItemChamado"].ToString());
                }

                return CodItemChamado;
            }

        }

        public DataTable BuscarChamadoAutorizado(int idChamado)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idItemChamado, Produtos.NomeProduto, ChamadosItem.ValorItem  " +
                                        "  FROM ChamadosItem, Produtos " +
                                        " WHERE ChamadosItem.Produtos_idProduto = Produtos.idProduto " +
                                        "   AND ChamadosItem.Chamados_idChamado = @idChamado ";


                MCCommand.Parameters.AddWithValue("@idChamado", idChamado);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;
                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtItemChamado = new DataTable();

                //Recebe dados da conexão
                dtItemChamado.Load(leitor);

                return dtItemChamado;
            }

        }

        public int PesquisarChamado(int idUsuario, int idCliente, int idTipoChamado, DateTime DataAtendimento)
        {

            return new ChamadoDAO().PesquisarChamado(idUsuario, idCliente, idTipoChamado, DataAtendimento);
        }

        #endregion

        #region "Update"


        public int AtualizarStatusItemChmado(ChamadoItemDTO objChamadoItemDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE ChamadosItem SET ServicoAutorizado = @ServicoAutorizado" +
                                        " WHERE Chamados_idChamado = @Chamados_idChamado ";

                MCCommand.Parameters.AddWithValue("@ServicoAutorizado", objChamadoItemDTO.ServicoAutorizado);
                MCCommand.Parameters.AddWithValue("@Chamados_idChamado", objChamadoItemDTO.Chamados_idChamado);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }
        }// Fim Atualização

        public int AtualizarValorItemChmado(ChamadoItemDTO objChamadoItemDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE ChamadosItem SET ValorItem = @ValorItem " +
                                        " WHERE idItemChamado = @idItemChamado ";

                MCCommand.Parameters.AddWithValue("@ValorItem", objChamadoItemDTO.ValorItem);
                MCCommand.Parameters.AddWithValue("@idItemChamado", objChamadoItemDTO.Codigo);


                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }
        }// Fim Atualização

        public int AtualizarItemChmado(ChamadoItemDTO objChamadoItemDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE ChamadosItem SET ObsItemTecnico = @ObsItemTecnico " +
                                        " WHERE idItemChamado = @idItemChamado ";

                MCCommand.Parameters.AddWithValue("@ObsItemTecnico", objChamadoItemDTO.ObsItemTecnico);
                MCCommand.Parameters.AddWithValue("@idItemChamado", objChamadoItemDTO.Codigo);


                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }
        }// Fim Atualização

        #endregion



    }
}
