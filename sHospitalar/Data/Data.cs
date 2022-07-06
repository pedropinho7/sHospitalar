using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sHospitalar.Data
{
    public class Db
    {
        public string connectionString = "Server=(localdb)\\firstdb;Integrated Security=true;";

        public void CriarUtente(string nome, int age, string sexo)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Utentes (Nome, Idade, Sexo) VALUES (@nome_input, @age_input, @sexo_input)";
                ;
                command.Parameters.AddWithValue("@nome_input", nome);
                command.Parameters.AddWithValue("@age_input", age);
                command.Parameters.AddWithValue("@sexo_input", sexo);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
        }

        public DataTable PesquisarUtentePorNome(DataGridView grid_result, string nome)
        {
            using (var dt = new DataTable("Utentes"))
            using (var connection = new SqlConnection(this.connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                if (!string.IsNullOrEmpty(nome))
                {
                    command.CommandText = "Select * From Utentes Where Nome LIKE @nome_input + '%'";
                    command.Parameters.AddWithValue("@nome_input", nome);

                }
                else
                { // Yeah, procurar melhor maneira de fazer isto xD
                    command.CommandText = "Select * From Utentes Where 1=0";
                }
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                //ADICIONEI ISTO RECENTEMENTE, SE HOUVER PROBLEMAS YEAH
                command.Dispose();
                return dt;
            }
        }

        public DataTable PesquisarUtentePorId(DataGridView gridResult, string id)
        {
            using (var dt = new DataTable("Utentes"))
            using (var connection = new SqlConnection(this.connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * From Utentes Where ID = @ID_input";
                command.Parameters.AddWithValue("@ID_input", Convert.ToInt32(id));
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                //ADICIONEI ISTO RECENTEMENTE, SE HOUVER PROBLEMAS YEAH
                command.Dispose();
                return dt;
            }
        }
    }
}