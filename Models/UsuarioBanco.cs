using MySqlConnector;
using System.Collections.Generic;
using System;
using Projeto_integrador_MVC.Models;

namespace etapa_3___Projeto_integrador_MVC.Models
{
    public class UsuarioBanco
    {
       private const string dadosConexao = "Database=loginfuturocomissario; Data Source=localhost; User Id=root";
        public void TestarConexao (){
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);
            Console.Write("Banco de dados funcionando!");
            Conexao.Open();
            Conexao.Close();
        }
 public Usuario QueryCadastro(Usuario usuario)
        {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string sql = "SELECT * FROM usuario WHERE email = @Email AND senha = @Senha";

            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            comandoQuery.Parameters.AddWithValue("@Email", usuario.Email);
            comandoQuery.Parameters.AddWithValue("@Senha", usuario.Senha);
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            Usuario novoUsuario = null;
            if (reader.Read())
            {
                novoUsuario = new Usuario();
                novoUsuario.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("Email")))
                    novoUsuario.Email = reader.GetString("Email");

                 if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    novoUsuario.Senha = reader.GetString("Senha");
            }

            conexao.Close();
            return novoUsuario;
            }
        public void Insert(Usuario novoUsuario){
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);

            Conexao.Open();

            string query = "INSERT INTO usuario(nome, sobrenome, sexo, dia, mes, ano, rua, numero, complemento, cep, estado, email, senha) VALUES (@Nome, @Sobrenome, @Sexo, @Dia, @Mes, @Ano, @Rua, @Numero, @Complemento, @Cep, @Estado, @Email, @Senha)";

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            
            comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
            comando.Parameters.AddWithValue("@Sobrenome", novoUsuario.Sobrenome);
            comando.Parameters.AddWithValue("@Sexo", novoUsuario.Sexo);
            comando.Parameters.AddWithValue("@Dia", novoUsuario.Dia);
            comando.Parameters.AddWithValue("@Mes", novoUsuario.Mes);
            comando.Parameters.AddWithValue("@Ano", novoUsuario.Ano);
            comando.Parameters.AddWithValue("@Rua", novoUsuario.Rua);
            comando.Parameters.AddWithValue("@Numero", novoUsuario.Numero);
            comando.Parameters.AddWithValue("@Complemento", novoUsuario.Complemento);
            comando.Parameters.AddWithValue("@Cep", novoUsuario.Cep);
            comando.Parameters.AddWithValue("@Estado", novoUsuario.Estado);
            comando.Parameters.AddWithValue("@Email", novoUsuario.Email);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public List<Usuario> Query (){
        
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);

            Conexao.Open();

            string query = "SELECT * FROM usuario";

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            while (reader.Read()){
                Usuario user = new Usuario();
                user.Id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome"))){
                user.Nome = reader.GetString("Nome");
                }

                if (!reader.IsDBNull(reader.GetOrdinal("Sobrenome"))){
                user.Sobrenome = reader.GetString("Sobrenome");
                }

                if (!reader.IsDBNull(reader.GetOrdinal("Sexo"))){
                user.Sexo = reader.GetString("Sexo");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Dia"))){
                user.Dia = reader.GetInt32("Dia");
                }
                
                 if (!reader.IsDBNull(reader.GetOrdinal("Mes"))){
                user.Mes = reader.GetInt32("Mes");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Ano"))){
                user.Ano = reader.GetString("Ano");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Rua"))){
                user.Rua = reader.GetString("Rua");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Numero"))){
                user.Numero = reader.GetInt32("Numero");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Complemento"))){
                user.Complemento = reader.GetString("Complemento");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Cep"))){
                user.Cep = reader.GetString("Cep");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Estado"))){
                user.Estado = reader.GetString("Estado");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Email"))){
                user.Email = reader.GetString("Email");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("Senha"))){
                user.Senha = reader.GetString("Senha");
                }


                lista.Add(user);
                }
                
                Conexao.Close();
                return lista;
                }
    }
}