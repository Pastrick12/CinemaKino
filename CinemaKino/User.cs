using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CinemaKino.Usuario;

public class Fecha
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
}

public class Ticks
{
    public long numberLong{ get; set; }

}

public class Hora
{
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }
    public int Millisecond { get; set; }

    public int Microsecond { get; set; }

    public long Ticks { get; set; }

}
public class User
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string gender { get; set; }

    public string moviegenres { get; set; }

    public string  movietitle  { get; set; } 

    public Fecha date { get; set; }

    public Hora time { get; set; }
        
    public string price { get; set; }

    public int seat { get; set; }

    public int cinemaroom { get; set; }


}


