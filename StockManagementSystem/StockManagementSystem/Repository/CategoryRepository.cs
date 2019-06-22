using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;

namespace StockManagementSystem.Repository
{
    public class CategoryRepository
    {
        public string connectionString = @"Server=PROSHAHADAT; Database=StockManagementSystemDb; Integrated Security= True;";
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;

        public void InsertCategory(Category category)
        {
           sqlConnection = new SqlConnection(connectionString);
           string commandString = @"INSERT INTO Category VALUES ('" + category.Name + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public DataTable ShowCategory()
        {
            string commandString = @"SELECT * FROM Category";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);            
            sqlConnection.Close();
            return dataTable;
        }

    }
}
