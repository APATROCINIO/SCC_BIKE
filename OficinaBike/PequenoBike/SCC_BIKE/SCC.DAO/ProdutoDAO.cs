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
    public class ProdutoDAO
    {

        #region "PRODUTOS"

        public int IncluirProduto(ProdutoDTO objProdutoDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "INSERT INTO Produtos ( NomeProduto,DataCadastro, DataUltimaAtualizacao,GrupoEmpresas_idGrupoEmpresa) " +
                                        " VALUES ( @NomeProduto,@DataCadastro, @DataUltimaAtualizacao,@GrupoEmpresas_idGrupoEmpresa)";


                MCCommand.Parameters.AddWithValue("@NomeProduto", objProdutoDTO.NomeProduto);
                MCCommand.Parameters.AddWithValue("@DataCadastro", objProdutoDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@DataUltimaAtualizacao", objProdutoDTO.DataUltimaAtualizacao);
                MCCommand.Parameters.AddWithValue("@GrupoEmpresas_idGrupoEmpresa", objProdutoDTO.GrupoEmpresas_idGrupoEmpresa);
                //MCCommand.Parameters.AddWithValue("@ProdutosCategoria_idProdutoCategoria", objProdutoDTO.ProdutosCategoria_idProdutoCategoria);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Inclusão

        public DataTable BuscarProdutos()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idProduto, " +
                                        "       NomeProduto, " +
                                        "       DataCadastro, " +
                                        "       DataUltimaAtualizacao " +
                                        "  FROM Produtos ";

                //MCCommand.CommandText = "SELECT * FROM Produtos";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtProdutos = new DataTable();

                //Recebe dados da conexão
                dtProdutos.Load(leitor);

                return dtProdutos;
            }

        }  //Final BuscarProdutos

        public DataTable BuscarProdutoEmpresa(string codEmpresaUsuario)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idProduto, " +
                                        "       NomeProduto, " +
                                        "       DataCadastro, " +
                                        "       DataUltimaAtualizacao " +
                                        "  FROM Produtos " +
                                        " WHERE GrupoEmpresas_idGrupoEmpresa in (@codEmpresaUsuario)";

                MCCommand.Parameters.AddWithValue("@codEmpresaUsuario", Convert.ToInt32(codEmpresaUsuario));

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtProdutos = new DataTable();

                //Recebe dados da conexão
                dtProdutos.Load(leitor);

                return dtProdutos;
            }

        }  //Final BuscarProdutos

        public int AtualizarProduto(ProdutoDTO objProdutoDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE Produtos SET NomeProduto = @NomeProduto, DataUltimaAtualizacao = @DataUltimaAtualizacao " +
                                        ", GrupoEmpresas_idGrupoEmpresa = @GrupoEmpresas_idGrupoEmpresa, ProdutosCategoria_idProdutoCategoria = @ProdutosCategoria_idProdutoCategoria  " +
                                        " WHERE idProduto = @idProduto ";

                MCCommand.Parameters.AddWithValue("@idProduto", objProdutoDTO.Codigo);
                MCCommand.Parameters.AddWithValue("@NomeProduto", objProdutoDTO.NomeProduto);
                //MCCommand.Parameters.AddWithValue("@DataCadastro", objProdutoDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@DataUltimaAtualizacao", objProdutoDTO.DataUltimaAtualizacao);
                MCCommand.Parameters.AddWithValue("@GrupoEmpresas_idGrupoEmpresa", objProdutoDTO.GrupoEmpresas_idGrupoEmpresa);
                //MCCommand.Parameters.AddWithValue("@ProdutosCategoria_idProdutoCategoria", objProdutoDTO.ProdutosCategoria_idProdutoCategoria);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }
        }// Fim Atualização

        public DataTable PesquisarProdutos(string NomeProduto)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                //ATENÇÃO  ATENÇÃO ATENÇÃO ATENÇÃO ATENÇÃO ATENÇÃO ATENÇÃO ATENÇÃO ATENÇÃO
                //
                //SERÁ NECESSÁRIO INCLUIR O RELACIONAMENTO COM A TABELA DE produtoscategoria
                //
                if (NomeProduto == "INTERNO")
                {
                    MCCommand.CommandText = "SELECT * FROM Produtos WHERE NomeProduto <> 'PEÇAS (EXTERNO)'";
                }
                else
                {
                    MCCommand.CommandText = "SELECT * FROM Produtos WHERE NomeProduto LIKE @NomeProduto";
                    NomeProduto = "PEÇAS (EXTERNO)";
                }
                

                

                MCCommand.Parameters.AddWithValue("@NomeProduto", NomeProduto);
               

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtProdutos = new DataTable();

                //Recebe dados da conexão
                dtProdutos.Load(leitor);

                return dtProdutos;
            }

        }  //Final PesquiarProdutos(string)

        #endregion



        #region "PRODUTOS CHAMADOS"

        public DataTable BuscarProdutosChamado()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idProduto 'Código', NomeProduto Produto FROM Produtos order by NomeProduto ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtProdutos = new DataTable();

                //Recebe dados da conexão
                dtProdutos.Load(leitor);

                return dtProdutos;
            }

        }  //Final BuscarProdutosChamado

#endregion

    }
}
