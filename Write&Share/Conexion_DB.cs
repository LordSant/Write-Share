using MySql.Data.MySqlClient;
namespace Write_Share
{
    public class Conexion_DB
    {
        private MySqlConnection conn;

        public Conexion_DB()
        {
            conn = new MySqlConnection("Server = localhost; Port=3306; User Id = root; password = santiago007; Database = write&share");

        }

        public MySqlConnection AbrirConexion()
        {
            try
            {
                conn.Open();
                return conn;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void cerrar_conexion()
        {
            conn.Close();
        }

        /*public  static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string data_base = "write&share";
            string usuario = "root";
            string password = "santiago007";

            string cadena_conexion = "Database=" + data_base + "; Data source=" + servidor + "; user Id=" + usuario + "; password=" + password + "";

            try
            {
                MySqlConnection conexion_based = new MySqlConnection(cadena_conexion);

                return conexion_based;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error:" + ex.Message);

                return null;
            }

        }*/

    }
}
