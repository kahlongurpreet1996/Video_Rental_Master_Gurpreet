using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Video_Rental_Master_Gurpreet
{
    public class MovieClass
    {
        
        //object of the classes that are used to create object of the make an connection between ssm and vs
        public SqlConnection sqlconnection;


        
        public String connectionString = "Data Source=DESKTOP-LI67OBL\\SQLEXPRESS;Initial Catalog=MovieRentalStore;Integrated Security=True";

        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        public SqlCommand sqlcommand;

        // DReader is instance to read the data from the database and pass to the Class
        public SqlDataReader sqldatareader;


        public void DML_Operation(String title,String Genre,int Year,int Copies,String cmd) {
            sqlconnection= new SqlConnection(connectionString);
            sqlconnection.Open();
            sqlcommand = new SqlCommand(cmd, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();



            
        }

        public DataTable DML_Search(String Command) {

            DataTable tbl = new DataTable();

            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();


            sqlcommand = new SqlCommand(Command, sqlconnection);

            sqldatareader = sqlcommand.ExecuteReader();

            tbl.Load(sqldatareader);

            sqlconnection.Close();

            return tbl;
        }

        public int get_ID() {

            DataTable tbl = new DataTable();

            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();


            sqlcommand = new SqlCommand("select * from Movie", sqlconnection);

            sqldatareader =sqlcommand.ExecuteReader();

            tbl.Load(sqldatareader);

            sqlconnection.Close();

            if (tbl.Rows.Count == 0)
            {
                return 1;
            }
            else {
                return Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["ID"]) + 1;
            }

        }




    }
}
