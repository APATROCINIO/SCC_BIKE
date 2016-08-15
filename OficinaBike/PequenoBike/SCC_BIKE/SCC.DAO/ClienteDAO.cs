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
    public class ClienteDAO
    {

        #region "Create"

        public int IncluirCliente(ClienteDTO objClienteDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "INSERT INTO clientes ( NomeCliente,Empresa,CPF_CNPJ,Email,Rua,Numero,Bairro,Cidade,Celular1,TelFixo1,Celular2,TelFixo2,DataCadastro,DataUltimaAtualizacao,Usuarios_idUsuario ) " +
                                        " VALUES ( @NomeCliente,@Empresa,@CPF_CNPJ,@Email,@Rua,@Numero,@Bairro,@Cidade,@Celular1,@TelFixo1,@Celular2,@TelFixo2,@DataCadastro,@DataUltimaAtualizacao,@Usuarios_idUsuario )";


                MCCommand.Parameters.AddWithValue("@NomeCliente", objClienteDTO.NomeCliente);
                MCCommand.Parameters.AddWithValue("@Empresa", objClienteDTO.Empresa);
                MCCommand.Parameters.AddWithValue("@CPF_CNPJ", objClienteDTO.Cpf_cnpj);
                MCCommand.Parameters.AddWithValue("@Email", objClienteDTO.Email);
                MCCommand.Parameters.AddWithValue("@Rua", objClienteDTO.Rua);
                MCCommand.Parameters.AddWithValue("@Numero", objClienteDTO.Numero);
                MCCommand.Parameters.AddWithValue("@Bairro", objClienteDTO.Bairro);
                MCCommand.Parameters.AddWithValue("@Cidade", objClienteDTO.Cidade);
                MCCommand.Parameters.AddWithValue("@Celular1", objClienteDTO.Celular1);
                MCCommand.Parameters.AddWithValue("@TelFixo1", objClienteDTO.TelFixo1);
                MCCommand.Parameters.AddWithValue("@Celular2", objClienteDTO.Celular2);
                MCCommand.Parameters.AddWithValue("@TelFixo2", objClienteDTO.TelFixo2);
                MCCommand.Parameters.AddWithValue("@DataCadastro", objClienteDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@DataUltimaAtualizacao", objClienteDTO.DataUltimaAtualizacao);
                MCCommand.Parameters.AddWithValue("@Usuarios_idUsuario", objClienteDTO.Usuarios_idUsuario);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Inclusão

        #endregion

        #region "Read"
        
        public DataTable BuscarClientes()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idCliente, " +
		                                "       NomeCliente, " +
		                                "       Empresa, " +
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
                                        "  FROM clientes ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtClientes = new DataTable();

                //Recebe dados da conexão
                dtClientes.Load(leitor);

                return dtClientes;
            }


        }  //Final BuscarUsuarios

        public DataTable BuscarClientesChamado()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idCliente 'Código', NomeCliente Cliente FROM dbSCC_BIKE.Clientes order by NomeCliente";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtClientes = new DataTable();

                //Recebe dados da conexão
                dtClientes.Load(leitor);

                return dtClientes;
            }


        }  //Final BuscarUsuarios

        public DataTable PesquisarClientes(string NomeCliente)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT * FROM clientes WHERE NomeCliente LIKE @NomeCliente";

                MCCommand.Parameters.AddWithValue("@NomeCliente", NomeCliente);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtClientes = new DataTable();

                //Recebe dados da conexão
                dtClientes.Load(leitor);

                return dtClientes;
            }


        }  //Final PesquiarClientes(string)

        #endregion

        #region "Update"

        public int AtualizarCliente(ClienteDTO objClienteDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE clientes SET NomeCliente = @NomeCliente, Empresa = @Empresa, Cpf_cnpj = @Cpf_cnpj, Rua = @Rua " +
                                        ", Numero = @Numero, Bairro = @Bairro, Cidade= @Cidade, Uf = @Uf, Celular1 = @Celular1 " +
                                        ", TelFixo1 = @TelFixo1, Celular1 = @Celular1, Celular2 = @Celular2, TelFixo2= @TelFixo2, Email = @Email, DataCadastro = @DataCadastro " +
                                        ", Usuarios_idUsuario = @Usuarios_idUsuario, DataUltimaAtualizacao = @DataUltimaAtualizacao  " +
                                        " WHERE idCliente = @idCliente ";

                MCCommand.Parameters.AddWithValue("@idCliente", objClienteDTO.Codigo);
                MCCommand.Parameters.AddWithValue("@NomeCliente", objClienteDTO.NomeCliente);
                MCCommand.Parameters.AddWithValue("@Empresa", objClienteDTO.Empresa);
                MCCommand.Parameters.AddWithValue("@Cpf_cnpj", objClienteDTO.Cpf_cnpj);
                MCCommand.Parameters.AddWithValue("@Rua", objClienteDTO.Rua);
                MCCommand.Parameters.AddWithValue("@Numero", objClienteDTO.Numero);
                MCCommand.Parameters.AddWithValue("@Bairro", objClienteDTO.Bairro);
                MCCommand.Parameters.AddWithValue("@Cidade", objClienteDTO.Cidade);
                MCCommand.Parameters.AddWithValue("@Uf", objClienteDTO.Uf);
                MCCommand.Parameters.AddWithValue("@Celular1", objClienteDTO.Celular1);
                MCCommand.Parameters.AddWithValue("@Celular2", objClienteDTO.Celular2);
                MCCommand.Parameters.AddWithValue("@TelFixo1", objClienteDTO.TelFixo1);
                MCCommand.Parameters.AddWithValue("@TelFixo2", objClienteDTO.TelFixo2);
                MCCommand.Parameters.AddWithValue("@Email", objClienteDTO.Email);
                MCCommand.Parameters.AddWithValue("@DataCadastro", objClienteDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@Usuarios_idUsuario", objClienteDTO.Usuarios_idUsuario);
                MCCommand.Parameters.AddWithValue("@DataUltimaAtualizacao", objClienteDTO.DataUltimaAtualizacao);

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
