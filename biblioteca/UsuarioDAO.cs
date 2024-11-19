using System;
using System.Data.SqlClient;
using Dapper;
using MySqlConnector;


namespace biblioteca
{
    public class UsuarioDAO
    {
        private string connectionString = "Server=127.0.0.1;Port=3307;Database=usuariosDB;User Id=root;Password=root1234;";

        public UsuarioDAO() { }
        public UsuarioDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Usuario> GetAll()
        {
            string query = "select * from usuarios";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var usuarios = connection.Query<Usuario>(query);
                return usuarios;
            }
        }

        public Usuario GetById(int id)
        {
            string query = "select * from usuarios where id = @id";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var usuario = connection.QueryFirstOrDefault<Usuario>(query, new { id });
                return usuario;
            }

        }


        public int Create(Usuario usuario)
        {

            string query = "insert into usuarios (nombre, edad) values (@nombre, @edad)";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(query, new { nombre = usuario.Nombre, edad = usuario.Edad });
                return affectedRows;
            }
        }


        public int Update(Usuario usuario)
        {
            string query = "update usuarios set nombre = @nombre, edad = @edad WHERE id = @id";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                return connection.Execute(query, new { nombre = usuario.Nombre, edad = usuario.Edad, id = usuario.Id });
            }
        }


        public int DeleteById(int id)
        {
            string query = "update usuarios set activo = @active WHERE id = @id";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                return connection.Execute(query, new { id = id, active = false });
            }
        }




    }
}
