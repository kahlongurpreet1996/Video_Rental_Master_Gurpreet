using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Master_Gurpreet
{
   public class RentalClass
    {


        //object of the classes that are used to create object of the make an connection between ssm and vs
        public SqlConnection sqlconnection;



        public String connectionString = "Data Source=DESKTOP-LI67OBL\\SQLEXPRESS;Initial Catalog=MovieRentalStore;Integrated Security=True";

        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        public SqlCommand sqlcommand;

        // DReader is instance to read the data from the database and pass to the Class
        public SqlDataReader sqldatareader;


        public void DML_Operation(int CustomerID, int MovieID, String Title,String IssueDate , String cmd)
        {
            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            sqlcommand = new SqlCommand(cmd, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();




        }

        public DataTable DML_Search(String cmd)
        {

            DataTable tbl = new DataTable();

            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();


            sqlcommand = new SqlCommand(cmd, sqlconnection);

            sqldatareader = sqlcommand.ExecuteReader();

            tbl.Load(sqldatareader);

            sqlconnection.Close();

            return tbl;
        }

        public int get_ID()
        {

            DataTable tbl = new DataTable();

            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();


            sqlcommand = new SqlCommand("select * from Rent", sqlconnection);

            sqldatareader = sqlcommand.ExecuteReader();

            tbl.Load(sqldatareader);

            sqlconnection.Close();

            if (tbl.Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["ID"]) + 1;
            }

        }

    }
}
