#region

using System;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace Agenda.Data
{
    public class Db
    {
        public static Utentes utente = new Utentes();
        public string connectionString = "Server=(localdb)\\firstdb;Integrated Security=true;";

        public void CriarUtente(Utentes utente)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText =
                    "INSERT INTO UTENTES (Nome, Idade, Sexo) VALUES (@nome_input, @age_input, @sexo_input)";
                ;
                command.Parameters.AddWithValue("@nome_input", utente.Nome);
                command.Parameters.AddWithValue("@age_input", utente.Idade);
                command.Parameters.AddWithValue("@sexo_input", utente.Sexo);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            return connection;
        }

        public SqlCommand ComandoPesquisarUtente(int id)
        {
            var connection = GetConnection();
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "Select * From UTENTES Where ID = @ID_input";
                command.Parameters.AddWithValue("@ID_input", Convert.ToInt32(id));
                return command;
            }
        }

        public SqlCommand ComandoPesquisarUtente(string nome)
        {
            var connection = GetConnection();
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                if (!string.IsNullOrEmpty(nome))
                {
                    command.CommandText = "Select * From UTENTES Where Nome LIKE @nome_input + '%'";
                    command.Parameters.AddWithValue("@nome_input", nome);
                }
                else
                {
                    // Yeah, procurar melhor maneira de fazer isto xD
                    command.CommandText = "Select * From UTENTES Where 1=0";
                }

                connection.Close();
                return command;
            }
        }

        public DataTable MostrarDadosEmGrid(string nome)
        {
            using (var dt = new DataTable("utente"))
            using (var command = ComandoPesquisarUtente(nome))
            {
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    utente.Nome = row["Nome"].ToString();
                    utente.Id = int.Parse(row["ID"].ToString());
                    utente.Sexo = char.Parse(row["Sexo"].ToString());
                    utente.Idade = int.Parse(row["Idade"].ToString());
                }

                command.Dispose();
                return dt;
            }
        }

        public DataTable MostrarDadosEmGrid(int id)
        {
            using (var dt = new DataTable("utente"))
            using (var command = ComandoPesquisarUtente(id))
            {
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    utente.Nome = row["Nome"].ToString();
                    utente.Id = int.Parse(row["ID"].ToString());
                    utente.Sexo = char.Parse(row["Sexo"].ToString());
                    utente.Idade = int.Parse(row["Idade"].ToString());
                }

                command.Dispose();
                return dt;
            }
        }
    }
}