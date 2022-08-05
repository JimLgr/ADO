using System.Data.Common;
using System.Data.SqlClient;

string connexionString = @"Data Source=DESKTOP-AP4GFC3\SQLEXPRESS;Initial Catalog=JimDB;Integrated Security=True";

SqlConnection db = new SqlConnection();
db.ConnectionString = connexionString;


//using (DbConnection connection = new SqlConnection(connexionString))
//{
//    connection.Open();
//    SqlCommand command = (SqlCommand)connection.CreateCommand();
//    command.CommandText = "SELECT * FROM Student WHERE year_result > @cote;";
//    command.Parameters.Add(new SqlParameter("cote", value:16));
//    DbDataReader reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader["login"]} | {reader["year_result"]}");
//    }
//}


string query = "SELECT last_name, first_name, section_id FROM student WHERE first_name = 'Georges'  ";
SqlCommand cmd = db.CreateCommand();
cmd.CommandText = query;

db.Open();
SqlDataReader reader = cmd.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine("{0} {1}", reader["last_name"], reader["section_id"]);
}

reader.Close();
db.Close();


