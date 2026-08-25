using System.Data.SqlClient;

public static class DB
{
    // استخدمنا (localdb)\MSSQLLocalDB لأنه هو اللي اشتغل معاك
    public static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GymDB;Integrated Security=True";

    public static SqlConnection GetConnection() => new SqlConnection(connString);
}