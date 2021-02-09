using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_project2
{
   public class sqlDatabaseConnection
    {



        
        SqlConnection conn;

        //write the connection sstring to asses the data from database
        String conStr = "Data Source=DESKTOP-F2POPJP\\SQLEXPRESS;Initial Catalog=Rental_Project;Integrated Security=True";

        // for isnert , delete , update commands
        SqlCommand cmd;

        // this var will read data that comes from database
        SqlDataReader DReader;

        public void addUsers(String Name,String Phone,String Address) {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "insert into Users(Name,Phone,Address)values(@Name,@Phone,@Address)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void MovieIssue(int CusID,int MovID,String IssDate,String ReturnDate)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "insert into Booking(CusID,MovID,Bookingdate,ReturnDate)values(@CusID,@MovID,@IssDate,@ReturnDate)";
            cmd = new SqlCommand(query, conn);
            // parametres passing values
            cmd.Parameters.AddWithValue("@CusID", CusID);
            cmd.Parameters.AddWithValue("@MovID", MovID);
            cmd.Parameters.AddWithValue("@IssDate", IssDate);
            cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void MovieReturn(int RentID,int CusID, int MovID, String IssDate, String ReturnDate)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "update Booking set CusID=@CusID,MovID=@MovID,Bookingdate=@IssDate,ReturnDate=@ReturnDate where ID=@RentID";
            cmd = new SqlCommand(query, conn);
            // parametres passing values
            cmd.Parameters.AddWithValue("@RentID", RentID);
            cmd.Parameters.AddWithValue("@CusID", CusID);
            cmd.Parameters.AddWithValue("@MovID", MovID);
            cmd.Parameters.AddWithValue("@IssDate", IssDate);
            cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void delBooking(int RentID)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "delete Booking  where ID=@RentID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@RentID", RentID);
             cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void updateUsers(int upID,String Name, String Phone, String Address)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "update Users set Name=@Name,Phone=@Phone,Address=@Address where ID=@upID";
            cmd = new SqlCommand(query, conn);
            // parametres passing values
            cmd.Parameters.AddWithValue("@upID", upID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteUsers(int delID)
        {
            // firstly checking connection 
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "delete from Users where ID=@DelID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DelID", delID);
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }




        public void addMovie(String title,String Ratting,String year,String cost,String copies,String plot,String genre)
        {
            // firstly checking connection 
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "insert into Movie(title,ratting,year,cost,copies,plot,genre)values(@title,@ratting,@year,@cost,@copies,@plot,@genre)";
            cmd = new SqlCommand(query, conn);
            // parametres passing with daabase and form variable for insertation
            cmd.Parameters.AddWithValue("@title",title);
            cmd.Parameters.AddWithValue("@ratting",Ratting);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@copies", copies);
            cmd.Parameters.AddWithValue("@plot", plot);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.ExecuteNonQuery();
            
            conn.Close();
        }

        public void updateMovie(int upID,String title, String Ratting, String year, String cost, String copies, String plot, String genre)
        {
            // firstly checking connection 
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "update  Movie set title=@title,ratting=@ratting,year=@year,cost=@cost,copies=@copies,plot=@plot,genre=@plot where ID=@upID";
            cmd = new SqlCommand(query, conn);
            // parametres passing with daabase and form variable for updation
            cmd.Parameters.AddWithValue("@upID", upID);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@ratting", Ratting);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@copies", copies);
            cmd.Parameters.AddWithValue("@plot", plot);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void deleteMovie(int DelID)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "delete from Movie where ID=@delID";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@delID", DelID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable CmdRecord(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(conStr);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }


    }
}
