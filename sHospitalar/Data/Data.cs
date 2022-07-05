using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Data
{
    public class db
    {
        public string connectionString = "Server=(localdb)\\firstdb;Integrated Security=true;";

        public void CriarUtente(string nome, int age, string sexo)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
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
                connection.Close();
            }
        }

        public DataTable PesquisarUtentePorNome(DataGridView grid_result, string nome)
        {
            using (DataTable dt = new DataTable("Utentes"))
            using (SqlConnection connection = new SqlConnection(this.connectionString))
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
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable PesquisarUtentePorID(DataGridView grid_result, string ID)
        {
            using (DataTable dt = new DataTable("Utentes"))
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * From Utentes Where ID = @ID_input";
                command.Parameters.AddWithValue("@ID_input", Convert.ToInt32(ID));
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}