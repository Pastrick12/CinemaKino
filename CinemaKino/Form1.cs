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

                var renglon = data[0].Split(',');

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
