using MongoDB.Driver;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CinemaKino.Usuario;
namespace CinemaKino.UserMigracion;

public class Migracion
{
    public readonly IMongoCollection<User> mongoCollection;
    public readonly SqlConnection sqlConnection;

    public Migracion(IMongoCollection<User> mongoCollection, SqlConnection sqlConnection)
    {
        this.mongoCollection = mongoCollection;
        this.sqlConnection = sqlConnection;
    }

    public async Task MigrateUsersAsync()
    {
        var users = await mongoCollection.Find(Builders<User>.Filter.Empty).ToListAsync(); // Asegúrate de usar Builders<User>.Filter.Empty

        using (var sqlConnection = this.sqlConnection)
        {

            foreach (var user in users)
            {
                var command = new SqlCommand("INSERT INTO users (ID, firstname, lastname, email, phone, gender) VALUES (@Id, @firstname, @lastname, @email, @phone, @gender)", sqlConnection);

                command.Parameters.AddWithValue("@Id", user.Id.ToString());
                command.Parameters.AddWithValue("@firstname", user.firstname);
                command.Parameters.AddWithValue("@lastname", user.lastname);
                command.Parameters.AddWithValue("@email", user.email);
                command.Parameters.AddWithValue("@phone", user.phone);
                command.Parameters.AddWithValue("@gender", user.gender);


                var command1 = new SqlCommand("INSERT INTO funcion (movietitle, moviegenres, seat, price, cinemaroom, userID) VALUES (@movietitle, @moviegenres, @seat, @price, @cinemaroom, @userId)", sqlConnection);

                command1.Parameters.AddWithValue("@movietitle", user.movietitle);
                command1.Parameters.AddWithValue("@userId", user.Id.ToString());
                command1.Parameters.AddWithValue("@moviegenres", user.moviegenres);
                command1.Parameters.AddWithValue("@seat", user.seat);
                command1.Parameters.AddWithValue("@price", user.price);
                command1.Parameters.AddWithValue("@cinemaroom", user.cinemaroom);

                var command2 = new SqlCommand("INSERT INTO date (Year, Month, Day, Hour, Minute) VALUES (@Year, @Month, @Day, @Hour, @Minute)", sqlConnection);

                command2.Parameters.AddWithValue("@Year", user.date.Year);
                command2.Parameters.AddWithValue("@Month", user.date.Month);
                command2.Parameters.AddWithValue("@Day", user.date.Day);
                command2.Parameters.AddWithValue("@Hour", user.time.Hour);
                command2.Parameters.AddWithValue("@Minute", user.time.Minute);


                await command.ExecuteNonQueryAsync();
                await command1.ExecuteNonQueryAsync();
                await command2.ExecuteNonQueryAsync();


            }
            sqlConnection.Close();
            

        }
    }
}
