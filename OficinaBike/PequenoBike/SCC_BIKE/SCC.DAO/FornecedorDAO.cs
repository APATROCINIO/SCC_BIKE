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
    public class FornecedorDAO
    {

        #region "Create"

        public int IncluirFornecedor(FornecedorDTO objFornecedorDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "INSERT INTO Fornecedores ( NomeFornecedor,Empresa,CPF_CNPJ,Email,Rua,Numero,Bairro,Cidade,Celular1,TelFixo1,Celular2,TelFixo2,DataCadastro,DataUltimaAtualizacao,Usuarios_idUsuario ) " +
                                        " VALUES ( @NomeFornecedor,@Empresa,@CPF_CNPJ,@Email,@Rua,@Numero,@Bairro,@Cidade,@Celular1,@TelFixo1,@Celular2,@TelFixo2,@DataCadastro,@DataUltimaAtualizacao,@Usuarios_idUsuario )";


                MCCommand.Parameters.AddWithValue("@NomeFornecedor", objFornecedorDTO.NomeFornecedor);
                MCCommand.Parameters.AddWithValue("@Empresa", objFornecedorDTO. Empresa);
                MCCommand.Parameters.AddWithValue("@CPF_CNPJ", objFornecedorDTO.Cpf_cnpj);
                MCCommand.Parameters.AddWithValue("@Email", objFornecedorDTO.Email);
                MCCommand.Parameters.AddWithValue("@Rua", objFornecedorDTO.Rua);
                MCCommand.Parameters.AddWithValue("@Numero", objFornecedorDTO.Numero);
                MCCommand.Parameters.AddWithValue("@Bairro", objFornecedorDTO.Bairro);
                MCCommand.Parameters.AddWithValue("@Cidade", objFornecedorDTO.Cidade);
                MCCommand.Parameters.AddWithValue("@Celular1", objFornecedorDTO.Celular1);
                MCCommand.Parameters.AddWithValue("@TelFixo1", objFornecedorDTO.TelFixo1);
                MCCommand.Parameters.AddWithValue("@Celular2", objFornecedorDTO.Celular2);
                MCCommand.Parameters.AddWithValue("@TelFixo2", objFornecedorDTO.TelFixo2);
                MCCommand.Parameters.AddWithValue("@DataCadastro", objFornecedorDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@DataUltimaAtualizacao", objFornecedorDTO.DataUltimaAtualizacao);
                MCCommand.Parameters.AddWithValue("@Usuarios_idUsuario", objFornecedorDTO.Usuarios_idUsuario);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Inclusão

        #endregion


        #region "Read"

        public DataTable BuscarFornecedores()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idFornecedor, " +
                                        "       NomeFornecedor,Empresa, " +
                                        "       CPF_CNPJ, " +
                                        "       Email, " +
                                        "       Rua, " +
                                        "       Numero, " +
                                        "       Bairro, " +
                                        "       Cidade, " +
                                        "       Uf, " +
                                        "       Celular1, " + 
                                        "       TelFixo1, " +
                                        "       Celular2, " +
                                        "       TelFixo2, " +
                                        "       Whatsapp, " +
                                        "       DataCadastro, " +
                                        "       DataUltimaAtualizacao, " +
                                        "       Usuarios_idUsuario " +
                                        "       FROM Fornecedores ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtFornecedores = new DataTable();

                //Recebe dados da conexão
                dtFornecedores.Load(leitor);

                return dtFornecedores;
            }


        }  //Final BuscarUsuarios

        public DataTable PesquisarFornecedores(string NomeFornecedor)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT * FROM Fornecedors WHERE NomeFornecedor LIKE @NomeFornecedor";

                MCCommand.Parameters.AddWithValue("@NomeFornecedor", NomeFornecedor);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtFornecedores = new DataTable();

                //Recebe dados da conexão
                dtFornecedores.Load(leitor);

                return dtFornecedores;
            }


        }  //Final PesquiarFornecedors(string)

        #endregion


        #region "Update"

        public int AtualizarFornecedor(FornecedorDTO objFornecedorDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE Fornecedores SET NomeFornecedor = @NomeFornecedor, Empresa = @Empresa, Cpf_cnpj = @Cpf_cnpj, Rua = @Rua " +
                                        ", Numero = @Numero, Bairro = @Bairro, Uf = @Uf,  Cidade= @Cidade, Celular1 = @Celular1 " +
                                        ", TelFixo1 = @TelFixo1, Celular1 = @Celular1, Celular2 = @Celular2, TelFixo2= @TelFixo2, Email = @Email, DataCadastro = @DataCadastro " +
                                        ", Usuarios_idUsuario = @Usuarios_idUsuario, DataUltimaAtualizacao = @DataUltimaAtualizacao  " +
                                        " WHERE idFornecedor = @idFornecedor ";

                MCCommand.Parameters.AddWithValue("@idFornecedor", objFornecedorDTO.Codigo);
                MCCommand.Parameters.AddWithValue("@NomeFornecedor", objFornecedorDTO.NomeFornecedor);
                MCCommand.Parameters.AddWithValue("@Empresa", objFornecedorDTO.Empresa);
                MCCommand.Parameters.AddWithValue("@Cpf_cnpj", objFornecedorDTO.Cpf_cnpj);
                MCCommand.Parameters.AddWithValue("@Rua", objFornecedorDTO.Rua);
                MCCommand.Parameters.AddWithValue("@Numero", objFornecedorDTO.Numero);
                MCCommand.Parameters.AddWithValue("@Bairro", objFornecedorDTO.Bairro);
                MCCommand.Parameters.AddWithValue("@Uf", objFornecedorDTO.Uf);
                MCCommand.Parameters.AddWithValue("@Cidade", objFornecedorDTO.Cidade);
                MCCommand.Parameters.AddWithValue("@Celular1", objFornecedorDTO.Celular1);
                MCCommand.Parameters.AddWithValue("@Celular2", objFornecedorDTO.Celular2);
                MCCommand.Parameters.AddWithValue("@TelFixo1", objFornecedorDTO.TelFixo1);
                MCCommand.Parameters.AddWithValue("@TelFixo2", objFornecedorDTO.TelFixo2);
                MCCommand.Parameters.AddWithValue("@Email", objFornecedorDTO.Email);
                MCCommand.Parameters.AddWithValue("@DataCadastro", objFornecedorDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@Usuarios_idUsuario", objFornecedorDTO.Usuarios_idUsuario);
                MCCommand.Parameters.AddWithValue("@DataUltimaAtualizacao", objFornecedorDTO.DataUltimaAtualizacao);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }
        }// Fim Atualização

        #endregion


        #region "Delete"

        #endregion
        

    }
}
