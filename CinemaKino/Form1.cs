namespace CinemaKino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LeerCSV();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void LeerCSV()
        {
            try
            {
                // string data = File.ReadAllText("Archivos\\MOCK_DATA.csv");
                //Como leer un archivo de texto

                string[] data = File.ReadAllLines("Archivos\\MOCK_DATA.csv");

                bool isHeader = true;
                List<Dato> datos = new List<Dato>();

                foreach (string line in data)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }
                    var renglon = line.Split(',');

                    /*Sintaxis anterior
                    Dato dato = new Dato();
                    dato.FirstName = renglon[1];
                    dato.LastName = renglon[2];
                    */

                    DateOnly.TryParse(renglon[8], out DateOnly date);
                    TimeOnly.TryParse(renglon[9], out TimeOnly time);
                    decimal.TryParse(renglon[10], out decimal price);
                    int.TryParse(renglon[11], out int seat);
                    int.TryParse(renglon[12], out int cinemaRoom);

                    Dato dato = new Dato
                    {
                        FirstName = renglon[1],
                        LastName = renglon[2],
                        Email = renglon[3],
                        Phone = renglon[4],
                        Gender = renglon[5],
                        MovieGenres = renglon[6],
                        MovieTitle = renglon[7],
                        Date = date,
                        Time = time,
                        Price = price,
                        Seat = seat,
                        CinemaRoom = cinemaRoom
                    };

                    datos.Add(dato);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
