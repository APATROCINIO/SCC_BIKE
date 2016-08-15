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
    public class UsuarioDAO
    {

        #region "USUÁRIOS"

        public int IncluirUsuario(UsuarioDTO objUsuarioDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                //INSTRUÇÃO PARA INSERT NO SQLSERVER
                //MCCommand.CommandText = "INSERT INTO usuarios (idUsuario, Nome, Sobrenome, " +
                //                        "Login, Senha, Perfil, Cpf, Email, DataCadastro, Status) " +
                //                        " VALUES (4, @Nome, @Sobrenome, @Login, @Senha, @Perfil, @Cpf, @Email, @DataCadastro, @Status)";
                //
                //
                //MCCommand.Parameters.AddWithValue("Nome", MySqlDbType.VarChar).Value = objUsuarioDTO.Nome;
                //MCCommand.Parameters.AddWithValue("Sobrenome", MySqlDbType.VarChar).Value = objUsuarioDTO.Sobrenome;
                //MCCommand.Parameters.AddWithValue("Login", MySqlDbType.VarChar).Value = objUsuarioDTO.Login;
                //MCCommand.Parameters.AddWithValue("Senha", MySqlDbType.VarChar).Value = objUsuarioDTO.Senha;
                //MCCommand.Parameters.AddWithValue("Perfil", MySqlDbType.UInt32).Value = objUsuarioDTO.Perfil;
                //MCCommand.Parameters.AddWithValue("Cpf", MySqlDbType.VarChar).Value = objUsuarioDTO.Cpf;
                //MCCommand.Parameters.AddWithValue("Email", MySqlDbType.VarChar).Value = objUsuarioDTO.Email;
                //MCCommand.Parameters.AddWithValue("DataCadastro", MySqlDbType.DateTime).Value = objUsuarioDTO.DataCadastro;
                //MCCommand.Parameters.AddWithValue("Status", MySqlDbType.VarChar).Value = objUsuarioDTO.Status;


                MCCommand.CommandText = "INSERT INTO usuarios ( Nome, Sobrenome, Login, Senha, Perfil, Email, DataCadastro, Status, Cpf ) " +
                                        " VALUES ( @Nome, @Sobrenome, @Login, @Senha, @Perfil, @Email, @DataCadastro, @Status, @Cpf)";

                
                MCCommand.Parameters.AddWithValue("@Nome", objUsuarioDTO.Nome);
                MCCommand.Parameters.AddWithValue("@Sobrenome", objUsuarioDTO.Sobrenome);
                MCCommand.Parameters.AddWithValue("@Login",  objUsuarioDTO.Login);
                MCCommand.Parameters.AddWithValue("@Senha",  validCryptographyPass(objUsuarioDTO.Senha));
                MCCommand.Parameters.AddWithValue("@Perfil", objUsuarioDTO.Perfil);
                MCCommand.Parameters.AddWithValue("@Cpf", objUsuarioDTO.Cpf);
                MCCommand.Parameters.AddWithValue("@Email", objUsuarioDTO.Email);
                MCCommand.Parameters.AddWithValue("@DataCadastro", objUsuarioDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@Status", objUsuarioDTO.Status);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Inclusão

        public int AtualizarUsuario(UsuarioDTO objUsuarioDTO)
        {
            using (MySqlConnection mysqlCON = new MySqlConnection())
            {

                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();


                MCCommand.CommandText = "UPDATE usuarios SET Nome = @Nome, Sobrenome = @Sobrenome, Login = @Login, Perfil = @Perfil " +
                                        ", Email = @Email, DataCadastro = @DataCadastro, Status= @Status, Cpf = @Cpf " +
                                        " WHERE idUsuario = @idUsuario ";

                MCCommand.Parameters.AddWithValue("@Nome", objUsuarioDTO.Nome);
                MCCommand.Parameters.AddWithValue("@Sobrenome", objUsuarioDTO.Sobrenome);
                MCCommand.Parameters.AddWithValue("@Login", objUsuarioDTO.Login);
                MCCommand.Parameters.AddWithValue("@Perfil", objUsuarioDTO.Perfil);
                MCCommand.Parameters.AddWithValue("@Cpf", objUsuarioDTO.Cpf);
                MCCommand.Parameters.AddWithValue("@Email", objUsuarioDTO.Email);
                MCCommand.Parameters.AddWithValue("@DataCadastro", objUsuarioDTO.DataCadastro);
                MCCommand.Parameters.AddWithValue("@Status", objUsuarioDTO.Status);
                MCCommand.Parameters.AddWithValue("@idUsuario", objUsuarioDTO.Codigo);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                int qtd = MCCommand.ExecuteNonQuery();

                return qtd;

            }

        }// Fim Atualização

        public UsuarioDTO AutenticarUsuarioSenha(UsuarioDTO objUsuario)
        {
            string varLogin = objUsuario.Login;
            string varSenha = validCryptographyPass(objUsuario.Senha);

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT * FROM usuarios WHERE Login = @login and Senha = @Senha";

                MCCommand.Parameters.AddWithValue("@Login", varLogin);
                MCCommand.Parameters.AddWithValue("@Senha", varSenha);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                MySqlDataReader ER;

                ER = MCCommand.ExecuteReader();

                if (ER.HasRows)  // encontrou algum registro com usuario e senha informados!
                {

                    while(ER.Read())
                    {


                        objUsuario.Codigo = Convert.ToInt32(ER["idUsuario"]);
                        objUsuario.Nome = Convert.ToString(ER["Nome"]);
                        objUsuario.Sobrenome = Convert.ToString(ER["SobreNome"]);
                        objUsuario.Login = Convert.ToString(ER["Login"]);
                        objUsuario.Senha = Convert.ToString(ER["Senha"]);
                        objUsuario.Login = Convert.ToString(ER["Email"]);
                        objUsuario.Login = Convert.ToString(ER["Cpf"]);
                        objUsuario.Perfil = Convert.ToInt32(ER["Perfil"]);
                        objUsuario.Status = Convert.ToChar(ER["Status"]);
                        objUsuario.Login = Convert.ToString(ER["DataCadastro"]);

                    }

                }
                else
                {
                       objUsuario.Login = null;
                       objUsuario.Senha = null;
                }

                return objUsuario;
            }


        }  //Final AutenticarUsuarioSenha

        public string validCryptographyPass(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        } //Final validCryptographyPass

        public DataTable BuscarUsuarios()
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT idUsuario, " +
                                        "       Nome, " +
                                        "       Sobrenome, " +
                                        "       Login, " +
                                        "       Senha, " +
                                        "       Perfil, " +
                                        "       Email, " +
                                        "       DataCadastro, " +
                                        "       Status, " +
                                        "       Cpf " +
                                        "  FROM usuarios ";

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader(); 

                //Cria um objeto datatable
                DataTable dtUsuarios = new DataTable();

                //Recebe dados da conexão
                dtUsuarios.Load(leitor);
                
                return dtUsuarios;
            }


        }  //Final BuscarUsuarios

        public DataTable PesquisarUsuarios(string NomeUsuario)
        {

            using (MySqlConnection mysqlCON = new MySqlConnection())
            {
                //conexão csSCC_BIKE criada manualmente nas propriedades da Classe DAO
                mysqlCON.ConnectionString = Properties.Settings.Default.csSCC_BIKE;
                MySqlCommand MCCommand = new MySqlCommand();

                MCCommand.CommandText = "SELECT * FROM usuarios WHERE Nome LIKE @Nome";

                MCCommand.Parameters.AddWithValue("@Nome", NomeUsuario);

                mysqlCON.Open();
                MCCommand.Connection = mysqlCON;

                //Executando o leitor ou melhor, executando o comando MySql no banco
                MySqlDataReader leitor = MCCommand.ExecuteReader();

                //Cria um objeto datatable
                DataTable dtUsuarios = new DataTable();

                //Recebe dados da conexão
                dtUsuarios.Load(leitor);

                return dtUsuarios;
            }


        }  //Final ConsultarUsuarios(string)

        #endregion

    }
}
