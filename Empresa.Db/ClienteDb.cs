using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Models;
using System.Data.SqlClient;

namespace Empresa.Db
{
    public class ClienteDb
    {

        public void Incluir(Cliente cliente)
        {
            string comandoSql = @"INSERT INTO Cliente(Id, Nome, Email, Telefone) VALUES(@Id, @Nome, @Email, @Telefone)";

            var con = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(comandoSql, con);

            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Alterar(Cliente cliente)
        {
            string comandoSql = @"UPDATE Cliente SET Nome = @Nome, Email = @Email, Telefone = @Telefone WHERE Id = @Id";

            var con = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(comandoSql, con);

            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Excluir(int id)
        {
            string comandoSql = @"DELETE from Cliente WHERE Id = @Id";

            var con = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(comandoSql, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public Cliente ObterPorId(int id)
        {
            string comandoSql = @"SELECT Id, Nome, Email, Telefone 
                                    FROM Cliente
                                    WHERE Id=@Id";

            var con = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(comandoSql, con);
            
            cmd.Parameters.AddWithValue("@Id", id);

            Cliente cliente = null;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                //instancio um cliente
                cliente = new Cliente();

                //pego os dados do cliente
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

            }

            reader.Close();
            con.Close();

            return cliente;
        }

        public List<Cliente> Listar()
        {
            string comandoSql = @"SELECT Id, Nome, Email, Telefone from Cliente";

            var con = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(comandoSql, con);

            List<Cliente> lista = new List<Cliente>();

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //instancio um cliente
                var cliente = new Cliente();

                //pego os dados do cliente
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

                //jogo na lista
                lista.Add(cliente);
            }

            reader.Close();
            con.Close();

            return lista;
        }
    }
}
