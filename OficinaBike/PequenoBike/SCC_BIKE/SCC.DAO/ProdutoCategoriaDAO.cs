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
    public class ProdutoCategoriaDAO
    {

        #region "Read"

        public DataTable BuscarProdutoCategorias(string codEmpresaUsuario)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "SELECT * FROM ProdutosCategoria where GrupoEmpresas_idGrupoEmpresa in (@codEmpresaUsuario)" ;

                MCCommand.Parameters.AddWithValue("@codEmpresaUsuario", Convert.ToInt32(codEmpresaUsuario));

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


        }  //Final BuscarProdutos

        public DataTable PesquisarProdutoCategorias(int codProdutoCategoria)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "SELECT * FROM ProdutosCategoria where idProdutoCategoria in (@idProdutoCategoria)";

                MCCommand.Parameters.AddWithValue("@idProdutoCategoria", codProdutoCategoria);

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


        }  //Final PesquisarProdutoCategorias

        #endregion
    }
}
