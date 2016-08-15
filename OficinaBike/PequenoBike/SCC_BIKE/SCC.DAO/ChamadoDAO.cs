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
    public class ChamadoDAO
    {
        #region "Create"

        public int IncluirChamado(ChamadoDTO objChamadoDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "INSERT INTO Chamados ( usuarios_idUsuario, clientes_idCliente, tipoChamado_idTipoChamado, dataAtendimento, dataUltimaAtualizacao, ValorTotal, ObsAtendenteChamado, ChamadoFinalizado ) " +
                                        " VALUES ( @usuarios_idUsuario, @clientes_idCliente, @tipoChamado_idTipoChamado, @dataAtendimento, @dataUltimaAtualizacao, @ValorTotal, @ObsAtendenteChamado, @ChamadoFinalizado )";


                MCCommand.Parameters.AddWithValue("@usuarios_idUsuario", objChamadoDTO.Usuarios_idUsuario);
                MCCommand.Parameters.AddWithValue("@clientes_idCliente", objChamadoDTO.Clientes_idCliente);
                MCCommand.Parameters.AddWithValue("@tipoChamado_idTipoChamado", objChamadoDTO.TipoChamado_idTipoChamado);
                MCCommand.Parameters.AddWithValue("@dataAtendimento", objChamadoDTO.DataAtendimento);
                MCCommand.Parameters.AddWithValue("@dataUltimaAtualizacao", objChamadoDTO.DataUltimaAtualizacao);
                MCCommand.Parameters.AddWithValue("@ObsAtendenteChamado", objChamadoDTO.ObsAtendenteChamado);
                MCCommand.Parameters.AddWithValue("@ChamadoFinalizado", objChamadoDTO.ChamadoFinalizado);
                //MCCommand.Parameters.AddWithValue("@ChamadosItem_idItemChamado", objChamadoDTO.ChamadosItem_idItemChamado);
                //MCCommand.Parameters.AddWithValue("@ChamadosItem_Produtos_idProduto", objChamadoDTO.ChamadosItem_Produtos_idProduto);

                MCCommand.Parameters.AddWithValue("@ValorTotal", 0.00);


                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Inclusão

        #endregion

        #region "Read"

        //public DataTable PesquisarChamado(int idUsuario, int idCliente, int idTipoChamado)
        public int PesquisarChamado(int idUsuario, int idCliente, int idTipoChamado, DateTime DataAtendimento)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = " SELECT idChamado FROM chamados WHERE Usuarios_idUsuario = @idUsuario and  " +
                                        " Clientes_idCliente = @idCliente and  " +
                                        " TipoChamado_idTipoChamado = @idTipoChamado and " +
                                        " DataAtendimento = @DataAtendimento ";

                MCCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                MCCommand.Parameters.AddWithValue("@idCliente", idCliente);
                MCCommand.Parameters.AddWithValue("@idTipoChamado", idTipoChamado);
                MCCommand.Parameters.AddWithValue("@DataAtendimento", DataAtendimento.ToString("yyyy-MM-dd H:mm:ss"));

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamado = new DataTable();

                //Recebe dados da conexão
                dtChamado.Load(leitor);

                int CodChamado = 0;

                if (dtChamado.Rows.Count > 0)

                    if (dtChamado.Rows[0]["idChamado"].ToString() != "")
                    {
                        CodChamado = (int)Convert.ToInt32(dtChamado.Rows[0]["idChamado"].ToString());
                    }

                return CodChamado;

            }


        }  //Final PesquiarClientes(string)

        public DataTable BuscarChamadoCadastro()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT ChamadosItem.idItemChamado, Chamados.idchamado, " +
                                        "       Clientes.IdCliente, " +
                                        "       Clientes.NomeCliente, " +                                        
                                        "       Produtos.idProduto, " +
                                        "       Produtos.NomeProduto, " +
                                        "       Chamados.DataAtendimento, " +
                                        "       ChamadosItem.ObsItemChamado, " +
                                        "       ChamadosItem.ObsItemTecnico, " +
                                        "       ChamadosItem.ValorItem " +
                                        "  FROM Chamados , ChamadosItem, Produtos, Clientes " +
                                        " WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "   AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " +
                                        "   AND Produtos.idProduto = ChamadosItem.Produtos_idProduto " +
                                        "   AND ChamadosItem.ServicoAutorizado = 'N' " +
                                        " ORDER BY Chamados.idchamado DESC ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }


        }  //Final BuscarChamadoCadastro

        public DataTable BuscarChamadoApontamentoTecnico()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT ChamadosItem.idItemChamado, " +
                                        "       Chamados.idchamado, " +
                                        "       Clientes.IdCliente, " +
                                        "       Clientes.NomeCliente, " +
                                        "       Produtos.idProduto, " +
                                        "       Produtos.NomeProduto, " +
                                        "       Chamados.DataAtendimento, " +
                                        "       Chamados.ObsAtendenteChamado, ChamadosItem.PadraoMarcaModeloSerie, " +
                                        "       ChamadosItem.ObsItemChamado, " +
                                        "       ChamadosItem.ObsItemTecnico " +
                                        //"       ChamadosItem.ValorItem " +
                                        "  FROM Chamados , ChamadosItem, Produtos, Clientes " +
                                        " WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "   AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " +
                                        //"   AND Chamados.ChamadosItem_Produtos_idProduto = Chamadositem.Produtos_idProduto " +
                                        "   AND Produtos.idProduto = ChamadosItem.Produtos_idProduto " +
                                        "   AND ChamadosItem.ServicoAutorizado = 'N' " +


                                        " ORDER BY Chamados.idchamado DESC ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }


        }  //Final BuscarChamadoApontamentoTecnico

        public DataTable BuscarChamadoAutorizarServico()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT ChamadosItem.idItemChamado, Chamados.idchamado, " +
                                        "       Clientes.IdCliente, " +
                                        "       Clientes.NomeCliente, " +
                                        "       Produtos.idProduto, " +
                                        "       Produtos.NomeProduto, " +
                                        "       Chamados.DataAtendimento, " +
                                        //"       ChamadosItem.ObsItemChamado, " +
                                        "       ChamadosItem.ObsItemTecnico, " +
                                        "       ChamadosItem.ValorItem " +
                                        "  FROM Chamados , ChamadosItem, Produtos, Clientes " +
                                        " WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "   AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " +
                                        "   AND Produtos.idProduto = ChamadosItem.Produtos_idProduto " +
                                        "   AND (ChamadosItem.ServicoAutorizado = 'N') " +
                                        //Garante que somente será apresentado chamados em que todos os itens de um chamado apresentm um parecer técnco
                                        //Isso garante que somente será autorizado chamados em que o técnico tenha dado um parecer
                                        "   AND not exists (SELECT 1 " +
                                        "   			      FROM ChamadosItem CHITEM  " +
                                        "   			     WHERE Chamados.idchamado = CHITEM.Chamados_idchamado  " +
                                        "                      AND (CHITEM.ObsItemTecnico IS NULL OR CHITEM.ObsItemTecnico  = ''))  " +

                                        " ORDER BY Chamados.idchamado DESC ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }


        }  //Final BuscarChamadoAutorizarServico

        public DataTable BuscarChamadoImprimir()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "   SELECT Chamados.idchamado, " +
                                        "          Clientes.IdCliente, " +
                                        "          Clientes.NomeCliente, " +
                                        "          Chamados.DataAgendamento, " +
                                        "          Chamados.ValorTotal " +
                                        "     FROM Chamados , ChamadosItem, Clientes " +
                                        "    WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "   AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " +
                                        "      AND (ChamadosItem.ServicoAutorizado = 'S' OR ChamadosItem.ServicoAutorizado = 'N') " +
                                        "      AND Chamados.ChamadoFinalizado = 'N' " + //Somente será permitido a impressão de chamados que não tenham sido finalizados
                                        " GROUP BY Chamados.idchamado,  Clientes.IdCliente, Clientes.NomeCliente, Chamados.DataAgendamento, Chamados.ValorTotal " +
                                        " ORDER BY Chamados.idchamado DESC ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }

        }

        public DataTable BuscarChamadoBaixa()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "   SELECT Chamados.idchamado, " +
                                        "          Clientes.IdCliente, " +
                                        "          Clientes.NomeCliente, " +
                                        "          Chamados.DataAgendamento, " +
                                        "          Chamados.ValorTotal " +
                                        "     FROM Chamados , ChamadosItem, Clientes " +
                                        "    WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "      AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " + 
                                        "      AND ChamadosItem.ServicoAutorizado = 'S' " +
                                        "      AND Chamados.ChamadoFinalizado = 'N' " +
                                        " GROUP BY Chamados.idchamado,  Clientes.IdCliente, Clientes.NomeCliente, Chamados.DataAgendamento, Chamados.ValorTotal " +
                                        " ORDER BY Chamados.idchamado DESC ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }

        } //Final BuscarChamadoBaixa


        public DataTable ConsultarChamadosAtendidos(DateTime varAtendimentoDe, 
                                                    DateTime varAtendimentoAte,
                                                    DateTime varAgendamentoDe,
                                                    DateTime varAgendamentoAte)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "   SELECT Chamados.idchamado, " +
                                        "          Clientes.IdCliente, " +
                                        "          Clientes.NomeCliente, " +
                                        "          Chamados.DataAtendimento, " +
                                        "          Chamados.DataAgendamento, " +
                                        "          Count(produtos.idProduto) QtdeProdutos, " +
                                        "          Chamados.ValorTotal " +
                                        "     FROM Chamados , ChamadosItem, Clientes, Produtos " +
                                        "    WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "      AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " + 
                                        "      AND ChamadosItem.ServicoAutorizado = 'S' " +
                                        "      AND Chamadositem.Produtos_idProduto = produtos.idProduto " +
                                        "      AND Chamados.ChamadoFinalizado = 'S' " + //Status Finalizado
                                        "      AND Chamados.DataAtendimento BETWEEN (CAST(@varAtendimentoDe AS datetime)) AND (CAST(@varAtendimentoAte AS datetime)) " +
                                        "      AND Chamados.DataAgendamento BETWEEN (CAST(@varAgendamentoDe AS datetime)) AND (CAST(@varAgendamentoAte AS datetime)) " +
                                        " GROUP BY Chamados.idchamado,  Clientes.IdCliente, Clientes.NomeCliente, Chamados.DataAtendimento, Chamados.DataAgendamento, Chamados.ValorTotal " +
                                        " ORDER BY Chamados.idchamado DESC ";

                MCCommand.Parameters.AddWithValue("@varAtendimentoDe", varAtendimentoDe);
                MCCommand.Parameters.AddWithValue("@varAtendimentoAte", varAtendimentoAte);
                MCCommand.Parameters.AddWithValue("@varAgendamentoDe", varAgendamentoDe);
                MCCommand.Parameters.AddWithValue("@varAgendamentoAte", varAgendamentoAte);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }
        }

        public DataTable ConsultarChamadosNaoAtendidos(DateTime varAtendimentoDe,
                                                    DateTime varAtendimentoAte,
                                                    DateTime varAgendamentoDe,
                                                    DateTime varAgendamentoAte)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "   SELECT Chamados.idchamado, " +
                                        "          Clientes.IdCliente, " +
                                        "          Clientes.NomeCliente, " +
                                        "          Chamados.DataAtendimento, " +
                                        "          Chamados.DataAgendamento, " +
                                        "          Count(produtos.idProduto) QtdeProdutos, " +
                                        "          Chamados.ValorTotal " +
                                        "     FROM Chamados , ChamadosItem, Clientes, Produtos " +
                                        "    WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "      AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " + 
                                        "      AND ChamadosItem.ServicoAutorizado = 'S' " +
                                        "      AND Chamadositem.Produtos_idProduto = produtos.idProduto " +
                                        "      AND Chamados.ChamadoFinalizado = 'N' " +
                                        "      AND Chamados.DataAtendimento BETWEEN (CAST(@varAtendimentoDe AS datetime)) AND (CAST(@varAtendimentoAte AS datetime)) " +
                                        "      AND Chamados.DataAgendamento BETWEEN (CAST(@varAgendamentoDe AS datetime)) AND (CAST(@varAgendamentoAte AS datetime)) " +
                                        " GROUP BY Chamados.idchamado,  Clientes.IdCliente, Clientes.NomeCliente, Chamados.DataAtendimento, Chamados.DataAgendamento, Chamados.ValorTotal " +
                                        " ORDER BY Chamados.idchamado DESC ";

                MCCommand.Parameters.AddWithValue("@varAtendimentoDe", varAtendimentoDe);
                MCCommand.Parameters.AddWithValue("@varAtendimentoAte", varAtendimentoAte);
                MCCommand.Parameters.AddWithValue("@varAgendamentoDe", varAgendamentoDe);
                MCCommand.Parameters.AddWithValue("@varAgendamentoAte", varAgendamentoAte);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }
        } 


        public DataTable ConsultarChamadosNaoAutorizados(DateTime varAtendimentoDe,
                                                    DateTime varAtendimentoAte,
                                                    DateTime varAgendamentoDe,
                                                    DateTime varAgendamentoAte)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "   SELECT Chamados.idchamado, " +
                                        "          Clientes.IdCliente, " +
                                        "          Clientes.NomeCliente, " +
                                        "          Chamados.DataAtendimento, " +
                                        "          Chamados.DataAgendamento, " +
                                        "          Count(produtos.idProduto) QtdeProdutos, " +
                                        "          Chamados.ValorTotal " +
                                        "     FROM Chamados , ChamadosItem, Clientes, Produtos " +
                                        "    WHERE Chamados.Clientes_idCliente = Clientes.idCliente " +
                                        "      AND Chamados.idChamado = ChamadosItem.Chamados_idChamado " + 
                                        "      AND ChamadosItem.ServicoAutorizado = 'N' " +//Status Não Autorizados
                                        "      AND Chamadositem.Produtos_idProduto = produtos.idProduto " +
                                        "      AND Chamados.ChamadoFinalizado = 'N' " +
                                        "      AND Chamados.DataAtendimento BETWEEN (CAST(@varAtendimentoDe AS datetime)) AND (CAST(@varAtendimentoAte AS datetime)) " +
                                        "      AND Chamados.DataAgendamento BETWEEN (CAST(@varAgendamentoDe AS datetime)) AND (CAST(@varAgendamentoAte AS datetime)) " +
                                        " GROUP BY Chamados.idchamado,  Clientes.IdCliente, Clientes.NomeCliente, Chamados.DataAtendimento, Chamados.DataAgendamento, Chamados.ValorTotal " +
                                        " ORDER BY Chamados.idchamado DESC ";

                MCCommand.Parameters.AddWithValue("@varAtendimentoDe", varAtendimentoDe);
                MCCommand.Parameters.AddWithValue("@varAtendimentoAte", varAtendimentoAte);
                MCCommand.Parameters.AddWithValue("@varAgendamentoDe", varAgendamentoDe);
                MCCommand.Parameters.AddWithValue("@varAgendamentoAte", varAgendamentoAte);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtChamadosCadastro = new DataTable();

                //Recebe dados da conexão
                dtChamadosCadastro.Load(leitor);

                return dtChamadosCadastro;
            }
        }


        #endregion

        #region "Update"

        public int AgendarChmado(ChamadoDTO objChamadoDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE Chamados SET DataAgendamento = @DataAgendamento, ValorTotal = @ValorTotal " +
                                        " WHERE idChamado = @idChamado ";

                MCCommand.Parameters.AddWithValue("@ValorTotal", objChamadoDTO.ValorTotal);
                MCCommand.Parameters.AddWithValue("@DataAgendamento", objChamadoDTO.DataAgendamento);
                MCCommand.Parameters.AddWithValue("@idChamado", objChamadoDTO.Codigo);


                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }

        public int FinalizarChamado(ChamadoDTO objChamadoDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                //objChamadoDTO.Codigo = Convert.ToInt32(lblCodigo.Text);
                //objChamadoDTO.DataRetirada = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
                //objChamadoDTO.DataUltimaAtualizacao = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
                //objChamadoDTO.Usuarios_idUsuario = MainClass.IdadeUsuario;
                //objChamadoDTO.ChamadoFinalizado = "S";


                MCCommand.CommandText = "UPDATE Chamados " + 
                                        "   SET ChamadoFinalizado = @ChamadoFinalizado, " +
                                        "       DataRetirada = @DataRetirada, " +
                                        "       DataUltimaAtualizacao = @DataUltimaAtualizacao, " +
                                        "       Usuarios_idUsuario = @Usuarios_idUsuario, " +
                                        "       DataRetirada = @DataRetirada " +
                                        " WHERE idChamado = @idChamado ";

                MCCommand.Parameters.AddWithValue("@ChamadoFinalizado", objChamadoDTO.ChamadoFinalizado);
                MCCommand.Parameters.AddWithValue("@DataRetirada", objChamadoDTO.DataRetirada);
                MCCommand.Parameters.AddWithValue("@DataUltimaAtualizacao", objChamadoDTO.DataUltimaAtualizacao);
                MCCommand.Parameters.AddWithValue("@Usuarios_idUsuario", objChamadoDTO.Usuarios_idUsuario);
                MCCommand.Parameters.AddWithValue("@idChamado", objChamadoDTO.Codigo);


                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }


        }

        #endregion


    }
}
