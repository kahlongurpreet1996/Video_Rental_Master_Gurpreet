using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Master_Gurpreet
{
    public partial class Form1 : Form
    {

        MovieClass movieclass = new MovieClass();

        MemberClass memberclass = new MemberClass();

        RentalClass rentclass = new RentalClass();

        int customerGrid = 0,MovieGrid=0,RentalGrid=0;
        int Rent_ID = 0;
        public Form1()
        {
            InitializeComponent();
            txtMovieID.Text = "" + movieclass.get_ID();
            txtCustomerID.Text = "" + memberclass.get_ID();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomerID_Click(object sender, EventArgs e)
        {
            //to empty the textbox 
            txtCustomerID.Text = "";

        }

        private void txtCustomerName_Click(object sender, EventArgs e)
        {
            //to empty the textbox 
            txtCustomerName.Text = "";
        }

        private void txtCustomerContact_Click(object sender, EventArgs e)
        {
            //to empty the textbox 
            txtCustomerContact.Text = "";
        }

        private void txtCustomerAddress_Click(object sender, EventArgs e)
        {
            //to empty the textbox 
            txtCustomerAddress.Text = "";
        }

        private void txtMovieTitle_Click(object sender, EventArgs e)
        {
            //to empty the textbox 
            txtMovieTitle.Text = "";
        }

        private void txtMovieGenre_Click(object sender, EventArgs e)
        {
            //to empty the textbox 
            txtMovieGenre.Text = "";
        }

        private void TxtMovieYear_Click(object sender, EventArgs e)
        {
            //to empty the textbox 
            TxtMovieYear.Text = "";
        }

        private void txtMovieCost_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMovieCopies_Click(object sender, EventArgs e)
        {
            txtMovieCopies.Text = "";
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            try {
                if (txtMovieTitle.Text.ToString().Equals("") || txtMovieGenre.Text.ToString().Equals("") || TxtMovieYear.Text.ToString().Equals("") || Convert.ToInt32(TxtMovieYear.Text.ToString()) == 0 || Convert.ToInt32(txtMovieCopies.Text.ToString()) == 0)
                {
                    MessageBox.Show("Check all the Detail before saving the details ");
                }
                else
                {
                    movieclass.DML_Operation(txtMovieTitle.Text.ToString(), txtMovieGenre.Text.ToString(), Convert.ToInt32(TxtMovieYear.Text.ToString()), Convert.ToInt32(txtMovieCopies.Text.ToString()), "insert into Movie values('" + txtMovieTitle.Text.ToString() + "','" + txtMovieGenre.Text.ToString() + "'," + Convert.ToInt32(TxtMovieYear.Text.ToString()) + "," + Convert.ToInt32(txtMovieCost.Text.ToString()) + "," + Convert.ToInt32(txtMovieCopies.Text.ToString()) + ")");
                    MessageBox.Show("OPeration is executed ");
                    txtMovieID.Text = "" + movieclass.get_ID();
                    txtMovieTitle.Text = "Title";
                    txtMovieGenre.Text = "Genre";
                    TxtMovieYear.Text = "Year";
                    txtMovieCopies.Text = "Copies";
                    txtMovieCost.Text = "0";
                }

            }
            catch (Exception ex) {
                MessageBox.Show("check all the detail once again " + ex.Message);
            }
        }

        private void TxtMovieYear_Leave(object sender, EventArgs e)
        {

            try {
                int Currentyear = DateTime.Now.Year;

                int Year = Currentyear - Convert.ToInt32(TxtMovieYear.Text.ToString());
                // MessageBox.Show(diff.ToString());
                if (Year >= 5)
                {
                    txtMovieCost.Text = "2";
                }
                else if (Year >= 0 && Year < 5)
                {
                    txtMovieCost.Text = "5";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Check the Year once "+ex.Message);
            }
            
            
        }
        //this for updating the record
        private void btnMovieUpdate_Click(object sender, EventArgs e)
        {
            try { 
            if (txtMovieTitle.Text.ToString().Equals("") || txtMovieGenre.Text.ToString().Equals("") || TxtMovieYear.Text.ToString().Equals("") || Convert.ToInt32(TxtMovieYear.Text.ToString()) == 0 || Convert.ToInt32(txtMovieCopies.Text.ToString()) == 0)
            {
                MessageBox.Show("Check all the Detail before saving the details ");
            }
            else
            {
                    //first of all check the id is matched or not 

                    DataTable tbl_data = new DataTable();
                    tbl_data = movieclass.DML_Search("select * from Movie where ID="+Convert.ToInt32(txtMovieID.Text.ToString())+"");
                    if (tbl_data.Rows.Count>0) {
                        movieclass.DML_Operation(txtMovieTitle.Text.ToString(), txtMovieGenre.Text.ToString(), Convert.ToInt32(TxtMovieYear.Text.ToString()), Convert.ToInt32(txtMovieCopies.Text.ToString()), "Update Movie set Title='"+txtMovieTitle.Text.ToString()+"',Genre='"+txtMovieGenre.Text.ToString()+"',Year="+Convert.ToInt32(txtMovieCost.Text.ToString())+",Cost="+Convert.ToInt32(txtMovieCost.Text.ToString())+",Copies="+Convert.ToInt32(txtMovieCopies.Text.ToString())+" where ID="+Convert.ToInt32(txtMovieID.Text.ToString())+"");
                        MessageBox.Show("OPeration is executed ");

                    }
                    else {
                        MessageBox.Show("Select the Data to Updated from the Customer Grid ");
                    }
                 txtMovieID.Text = "" + movieclass.get_ID();
                txtMovieTitle.Text = "Title";
                txtMovieGenre.Text = "Genre";
                TxtMovieYear.Text = "Year";
                txtMovieCopies.Text = "Copies";
                txtMovieCost.Text = "0";
            }

        }catch (Exception ex) {
                MessageBox.Show("check all the detail once again " + ex.Message);
        }



}
        // to show the data in the grid according to the click
        private void dgvGrid_DoubleClick(object sender, EventArgs e)
        {
            if (MovieGrid==1) {
                txtMovieID.Text = dgvGrid.CurrentRow.Cells[0].Value.ToString();
                txtMovieTitle.Text= dgvGrid.CurrentRow.Cells[1].Value.ToString();
                txtMovieGenre.Text= dgvGrid.CurrentRow.Cells[2].Value.ToString();
                TxtMovieYear.Text= dgvGrid.CurrentRow.Cells[3].Value.ToString();
                txtMovieCost.Text= dgvGrid.CurrentRow.Cells[4].Value.ToString();
                txtMovieCopies.Text= dgvGrid.CurrentRow.Cells[5].Value.ToString();

                MovieGrid = 0;
            }
            if (customerGrid==1) {
                txtCustomerID.Text= dgvGrid.CurrentRow.Cells[0].Value.ToString();
                txtCustomerName.Text= dgvGrid.CurrentRow.Cells[1].Value.ToString();
                txtCustomerContact.Text= dgvGrid.CurrentRow.Cells[2].Value.ToString();
                txtCustomerAddress.Text= dgvGrid.CurrentRow.Cells[3].Value.ToString();
                customerGrid = 0;
            }
            if (RentalGrid==1) {
                Rent_ID = Convert.ToInt32(dgvGrid.CurrentRow.Cells[0].Value.ToString());
                txtCustomerID.Text = dgvGrid.CurrentRow.Cells[1].Value.ToString();
                DataTable customerTable = new DataTable();
                customerTable = memberclass.DML_Search("select * from Member where ID=" + Convert.ToInt32(txtCustomerID.Text.ToString()) + "");
                //display the customer record 
                txtCustomerName.Text = customerTable.Rows[customerTable.Rows.Count-1]["Name"].ToString();
                txtCustomerContact.Text= customerTable.Rows[customerTable.Rows.Count-1]["Contact"].ToString();
                txtCustomerAddress.Text= customerTable.Rows[customerTable.Rows.Count-1]["Address"].ToString();


                txtMovieID.Text= dgvGrid.CurrentRow.Cells[2].Value.ToString();
                DataTable MovieTable = new DataTable();
                MovieTable = movieclass.DML_Search("select * from Movie where ID=" + Convert.ToInt32(txtMovieID.Text.ToString()) + "");
                txtMovieGenre.Text = MovieTable.Rows[MovieTable.Rows.Count-1]["Genre"].ToString();
                TxtMovieYear.Text= MovieTable.Rows[MovieTable.Rows.Count-1]["Year"].ToString();
                txtMovieCost.Text= MovieTable.Rows[MovieTable.Rows.Count-1]["Cost"].ToString();
                txtMovieCopies.Text= MovieTable.Rows[MovieTable.Rows.Count-1]["Copies"].ToString();



                txtMovieTitle.Text= dgvGrid.CurrentRow.Cells[3].Value.ToString();
                dtpIssueDate.Text= dgvGrid.CurrentRow.Cells[4].Value.ToString();


                RentalGrid = 0;
            }



        }
        //working on the grid
        private void button1_Click(object sender, EventArgs e)
        {


            DataTable tbl_Grid = new DataTable();
            // get the record and pass to gridview 
            tbl_Grid = memberclass.DML_Search("select * from Member");
            dgvGrid.DataSource = tbl_Grid;
            MovieGrid=0;
            RentalGrid = 0;
            customerGrid++;


        }

        //check record of members
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.ToString().Equals("") || txtCustomerContact.Text.ToString().Equals("") || txtCustomerAddress.Text.ToString().Equals(""))
            {
                MessageBox.Show("fill all the details of the Member ");
            }
            else {
                memberclass.DML_Operation(txtCustomerName.Text.ToString(),txtCustomerContact.Text.ToString(),txtCustomerAddress.Text.ToString(),"insert into Member values('"+txtCustomerName.Text.ToString()+"','"+txtCustomerContact.Text.ToString()+"','"+txtCustomerAddress.Text.ToString()+"')");
                MessageBox.Show("OPeration is Executed ");
                txtCustomerID.Text = "" + memberclass.get_ID();
                txtCustomerName.Text = "Name";
                txtCustomerContact.Text = "COntact";
                txtCustomerAddress.Text = "Address";

            }
        }

        // to delete the record of the customer  form database
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            DataTable tbl_data = memberclass.DML_Search("select * from Member where ID="+Convert.ToInt32(txtCustomerID.Text.ToString())+"" );
            if (tbl_data.Rows.Count > 0)
            {
                memberclass.DML_Operation(txtCustomerName.Text.ToString(), txtCustomerContact.Text.ToString(), txtCustomerAddress.Text.ToString(), "Delete from Member where ID="+Convert.ToInt32(txtCustomerID.Text.ToString())+"");
                MessageBox.Show("OPeration is Executed ");
                txtCustomerID.Text = "" + memberclass.get_ID();
                txtCustomerName.Text = "Name";
                txtCustomerContact.Text = "Contact";
                txtCustomerAddress.Text = "Address";

            }
            //else blog is used if data to be deleted is in the incorrect format
            else {
                MessageBox.Show("Select the Record of the Member to update ");
            }

        }
        // to update the record of the customer in the database
        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            DataTable tbl_data = memberclass.DML_Search("select * from Member where ID=" + Convert.ToInt32(txtCustomerID.Text.ToString()) + "");
            if (tbl_data.Rows.Count > 0)
            {
                memberclass.DML_Operation(txtCustomerName.Text.ToString(), txtCustomerContact.Text.ToString(), txtCustomerAddress.Text.ToString(), "Update  Member set Name='"+txtCustomerName.Text.ToString()+"',Contact='"+txtCustomerContact.Text.ToString()+"',Address='"+txtCustomerAddress.Text.ToString()+"' where ID=" + Convert.ToInt32(txtCustomerID.Text.ToString()) + "");
                MessageBox.Show("OPeration is Executed ");
                txtCustomerID.Text = "" + memberclass.get_ID();
                txtCustomerName.Text = "Name";
                txtCustomerContact.Text = "Contact";
                txtCustomerAddress.Text = "Address";

            }
            // if something wrong with the data system will display message
            else
            {
                MessageBox.Show("Select the Record of the Member to update ");
            }

        }
        //to issue a movie on rent firstly this will check from the record about data it is inserted firlstly or not
        private void btnMovieIssue_Click(object sender, EventArgs e)
        {
            DataTable tbl_MovieID = new DataTable();
            tbl_MovieID = memberclass.DML_Search("Select * from Movie where ID="+Convert.ToInt32(txtMovieID.Text.ToString())+"");
            DataTable tbl_CustomerID = new DataTable();
            tbl_CustomerID = movieclass.DML_Search("Select * from Member where ID=" + Convert.ToInt32(txtCustomerID.Text.ToString()) + "");
            if (tbl_MovieID.Rows.Count > 0 && tbl_CustomerID.Rows.Count > 0)
            {
                // this command is used to check the cusomter may not have alrady 2 cd on rent 
                DataTable tbl_CountIssue = rentclass.DML_Search("select * from Rent where CustomerID=" + Convert.ToInt32(txtCustomerID.Text.ToString()) + " and ReturnDate='issue'");
                if (tbl_CountIssue.Rows.Count < 2) {
                    DataTable tbl_CountIssueMovie = new DataTable();
                    //count  to check how much movie is on rent 
                    tbl_CountIssueMovie = rentclass.DML_Search("select * from Rent where MovieID=" + Convert.ToInt32(txtMovieID.Text.ToString()) + " and ReturnDate='issue'");
                    if (tbl_CountIssueMovie.Rows.Count < Convert.ToInt32(txtMovieCopies.Text.ToString()))
                    {
                        //after all the verfication issued the movie on rent 
                        rentclass.DML_Operation(Convert.ToInt32(txtCustomerID.Text.ToString()), Convert.ToInt32(txtMovieID.Text.ToString()), txtMovieTitle.Text.ToString(), dtpIssueDate.Text, "insert  into Rent values(" + Convert.ToInt32(txtCustomerID.Text.ToString()) + "," + Convert.ToInt32(txtMovieID.Text.ToString()) + ",'" + txtMovieTitle.Text.ToString() + "','" + dtpIssueDate.Text.ToString() + "','issue')");
                        MessageBox.Show("Operation is Executed ");

                    }
                    else {
                        MessageBox.Show("All the Movies Copies is already issued on rent ");
                    }


                }
                else {
                    MessageBox.Show("The Issue is Customer Already have 2 movie on issue ");
                }



            
                //if the proper record is not selcted from the database
            }
            else {
                MessageBox.Show("Select the Customer and Movie Both to issue a movie on rent ");
            }
            txtCustomerID.Text = "" + memberclass.get_ID();
            txtCustomerName.Text = "Name";
            txtCustomerContact.Text = "COntact";
            txtCustomerAddress.Text = "Address";
            txtMovieID.Text = "" + movieclass.get_ID();
            txtMovieTitle.Text = "Title";
            txtMovieGenre.Text = "Genre";
            TxtMovieYear.Text = "Year";
            txtMovieCopies.Text = "Copies";
            txtMovieCost.Text = "0";


        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataTable tbl_Grid = new DataTable();
            // get the record and pass to gridview 
            tbl_Grid = movieclass.DML_Search("Select * from Rent");
            dgvGrid.DataSource = tbl_Grid;
            MovieGrid=0;
            RentalGrid++;
            customerGrid = 0;
        }

        private void btnMovieReturn_Click(object sender, EventArgs e)
        {
            if (Rent_ID > 0)
            {

                DateTime current_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime old_date = Convert.ToDateTime(dtpIssueDate.Text.ToString());


                //get the difference in the days fromat
                String Daysdiff = (current_date - old_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));



                int totalCharges = Convert.ToInt32(DaysInterval) * Convert.ToInt32(txtMovieCost.Text.ToString());



                //after all the verfication return the movie to the store 
                rentclass.DML_Operation(Convert.ToInt32(txtCustomerID.Text.ToString()), Convert.ToInt32(txtMovieID.Text.ToString()), txtMovieTitle.Text.ToString(), dtpIssueDate.Text, "update Rent set CustomerID=" + Convert.ToInt32(txtCustomerID.Text.ToString()) + ",MovieID=" + Convert.ToInt32(txtMovieID.Text.ToString()) + ",MovieTitle='" + txtMovieTitle.Text.ToString() + "',IssueDate='" + dtpIssueDate.Text.ToString() + "',ReturnDate='" + dtpReturnDate.Text.ToString() + "' where RentID=" + Rent_ID + "");
                

                MessageBox.Show("Your Total Charges of the Movie is  $" + totalCharges);
                txtCustomerID.Text = "" + memberclass.get_ID();
                txtCustomerName.Text = "Name";
                txtCustomerContact.Text = "COntact";
                txtCustomerAddress.Text = "Address";
                txtMovieID.Text = "" + movieclass.get_ID();
                txtMovieTitle.Text = "Title";
                txtMovieGenre.Text = "Genre";
                TxtMovieYear.Text = "Year";
                txtMovieCopies.Text = "Copies";
                txtMovieCost.Text = "0";



            }
            else {
                MessageBox.Show("Select the Movie To return First ");
            }



        }

        private void rbReturned_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReturned.Checked==true) {
                DataTable tblRent = new DataTable();
                tblRent = rentclass.DML_Search("Select * from Rent where ReturnDate!='issue'");
                dgvGrid.DataSource = tblRent;
                MessageBox.Show("You can only see the record can't perform any operation ");
            }
        }

        private void rbRented_CheckedChanged(object sender, EventArgs e)
        {

            if (rbReturned.Checked == true)
            {
                DataTable tblRent = new DataTable();
                tblRent = rentclass.DML_Search("Select * from Rent where ReturnDate='issue'");
                dgvGrid.DataSource = tblRent;
                MessageBox.Show("You can only see the record can't perform any operation ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //print the name of the most famous Movie of the store which on  rent 
            DataTable tblData = new DataTable();
            tblData =movieclass.DML_Search("select * from Movie");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 =rentclass.DML_Search("select * from Rent where MovieID=" + Convert.ToInt32(tblData.Rows[x]["ID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Title"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            label1.Text = Title;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //print the name of the most famous customer of the store who get the movie most on rent 
            DataTable tblData = new DataTable();
            tblData =memberclass.DML_Search("select * from Member");
            int x = 0, y = 0, cunt = 0;
            String Name = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = rentclass.DML_Search("select * from Rent where CustomerID=" + Convert.ToInt32(tblData.Rows[x]["ID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Name = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            label2.Text = Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMovieDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMovieTitle.Text.ToString().Equals("") || txtMovieGenre.Text.ToString().Equals("") || TxtMovieYear.Text.ToString().Equals("") || Convert.ToInt32(TxtMovieYear.Text.ToString()) == 0 || Convert.ToInt32(txtMovieCopies.Text.ToString()) == 0)
                {
                    MessageBox.Show("Check all the Detail before saving the details ");
                }
                else
                {
                    //first of all check the id is matched or not 

                    DataTable tbl_data = new DataTable();

                    //command to verif the id is it available or not 
                    tbl_data = movieclass.DML_Search("select * from Movie where ID=" + Convert.ToInt32(txtMovieID.Text.ToString()) + "");
                    if (tbl_data.Rows.Count > 0)
                    {

                        // command to delete the record of the movie 

                        movieclass.DML_Operation(txtMovieTitle.Text.ToString(), txtMovieGenre.Text.ToString(), Convert.ToInt32(TxtMovieYear.Text.ToString()), Convert.ToInt32(txtMovieCopies.Text.ToString()), "Delete from Movie  where ID=" + Convert.ToInt32(txtMovieID.Text.ToString()) + "");
                        MessageBox.Show("OPeration is executed ");

                    }
                    else
                    {
                        MessageBox.Show("Select the Data to Updated from the Customer Grid ");
                    }

                    //reset the variable once 
                    txtMovieID.Text = "" + movieclass.get_ID();
                    txtMovieTitle.Text = "Title";
                    txtMovieGenre.Text = "Genre";
                    TxtMovieYear.Text = "Year";
                    txtMovieCopies.Text = "Copies";
                    txtMovieCost.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("check all the detail once again " + ex.Message);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable tbl_Grid = new DataTable();
            // get the record and pass to gridview 
            tbl_Grid = movieclass.DML_Search("Select * from Movie");
            dgvGrid.DataSource = tbl_Grid;
            MovieGrid++;
            RentalGrid = 0;
            customerGrid = 0;
        }
    }
}
