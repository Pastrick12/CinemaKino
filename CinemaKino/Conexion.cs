using MongoDB.Driver;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CinemaKino.UserMigracion;
using CinemaKino.Usuario;
public class Conexion
{
    private readonly string mongoConnectionString = "mongodb://localhost:27017";
    private readonly string sqlConnectionString = "Server=localhost;Database=cinemakino;Trusted_Connection=True;TrustServerCertificate=True;";

    public IMongoCollection<User> GetMongoCollection()
    {
        var mongoClient = new MongoClient(mongoConnectionString);
        var mongoDatabase = mongoClient.GetDatabase("cinemakino");
        return mongoDatabase.GetCollection<User>("datos");
    }

    public async Task<SqlConnection> GetSqlConnectionAsync()
    {
        SqlConnection connection = new SqlConnection(sqlConnectionString);
        try
        {
            await connection.OpenAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al conectar a SQL Server: {ex.Message}");
            throw; // Re-lanzar la excepción si es necesario
        }
        return connection;
    }
}
