using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLibrary;
using MySql.Data.MySqlClient;

namespace Training
{
    public class DB
    {
        private static readonly string server = "localhost";
        private static readonly string Database = "Training";
        private static readonly string user = "root";
        private static readonly string password = "Sharuk@123.";

        //private static readonly string connectionString = $"server={server};Database={Database};user={user};password={password}";

        //private static MySqlConnection Connection = null;

        private static DatabaseManager manager = new MySqlHandler(server, user, password, Database);

        public static void GetConnection()
        {
            //Connection = new MySqlConnection(connectionString);
            //Connection.Open();
            manager.Connect();
        }

        public static List<Detailsvalues>  AddDetails(string n)
        {
            var res =manager.FetchData("Details",$"name='{n}'").Value;
           // var res = manager.FetchData("Details", "").Value; for all
            List<Detailsvalues> values = new List<Detailsvalues>();
            for (int i = 0; i < res["name"].Count; i++)
            {
                Detailsvalues det = new Detailsvalues();
                det.id = int.Parse(res["id"][i].ToString());
                det.name = res["name"][i].ToString();
                det.address = res["address"][i].ToString();
                det.phno = int.Parse(res["phno"][i].ToString());
                det.gender = res["gender"][i].ToString();
                values.Add(det);
            }
            return values;
        }
    }
}
