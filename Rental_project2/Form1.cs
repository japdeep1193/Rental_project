using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_project2
{
    public partial class Form1 : Form
    {
        // rentalID is declared as global var 
        // from other cs file connection is imported 
        int rentID = 0;
        sqlDatabaseConnection connection = new sqlDatabaseConnection();
        public Form1()
        {
            InitializeComponent();
        }
        // add movie function is being called from other file 
        private void newVDadd_Click(object sender, EventArgs e)
        {
            if (!Txttitle.Text.ToString().Equals("") && !TxtRatting.Text.ToString().Equals("") && !TxtYear.Text.ToString().Equals("") && !Txtcost.Text.ToString().Equals("") && !TxtCopies.Text.ToString().Equals("") && !TxtPlot.Text.ToString().Equals("") && !TxtGenre.Text.ToString().Equals("")) {
                connection.addMovie(Txttitle.Text,TxtRatting.Text,TxtYear.Text,Txtcost.Text,TxtCopies.Text,TxtPlot.Text,TxtGenre.Text);
                MessageBox.Show("record is saved ");
                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                Txtcost.Text = "";
                TxtCopies.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";
                // text boxes will be empty when admin click on add button

            }
            else {
                MessageBox.Show("must need to fill the details");
            }
        }

        private void newVDdelete_Click(object sender, EventArgs e)
        {
            // delete movie function is being called from other file 
            if (!VideoID.Text.ToString().Equals(""))
            {
                connection.deleteMovie(Convert.ToInt32(VideoID.Text));
                MessageBox.Show("record is deleted");
                VideoID.Text = "";
                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                Txtcost.Text = "";
                TxtCopies.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";
                // text boxes will be empty when admin click on delete button
            }
            else
            {
                MessageBox.Show("must need to select the details");
            }
        }

        private void newVDupdate_Click(object sender, EventArgs e)
        {
            // update movie function is being called from other file 
            if (!VideoID.Text.ToString().Equals("") && !Txttitle.Text.ToString().Equals("") && !TxtRatting.Text.ToString().Equals("") && !TxtYear.Text.ToString().Equals("") && !Txtcost.Text.ToString().Equals("") && !TxtCopies.Text.ToString().Equals("") && !TxtPlot.Text.ToString().Equals("") && !TxtGenre.Text.ToString().Equals(""))
            {
                connection.updateMovie(Convert.ToInt32(VideoID.Text),Txttitle.Text, TxtRatting.Text, TxtYear.Text, Txtcost.Text, TxtCopies.Text, TxtPlot.Text, TxtGenre.Text);
                MessageBox.Show("record is Updated ");
                VideoID.Text = "";
                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                Txtcost.Text = "";
                TxtCopies.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";
                // text boxes will be empty when admin click on update button
            }
            else
            {
                MessageBox.Show("must need to fill the details");
            }
        }
        // add customer function is being called from other file 
        private void newCSadd_Click(object sender, EventArgs e)
        {
            if (!TxtName.Text.ToString().Equals("") && !MobileNo.Text.ToString().Equals("") && !Address.Text.ToString().Equals("")) {
                connection.addUsers(TxtName.Text,MobileNo.Text,Address.Text);
                TxtName.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
                // text boxes will be empty when admin click on add button
            }
            else {
                MessageBox.Show("Must fill the Details");
            }
        }
        // delete customer function is being called from other file 
        private void newCSdel_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals(""))
            {
                connection.deleteMovie(Convert.ToInt32(CustomerID.Text));
                CustomerID.Text = "";
                TxtName.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
                // text boxes will be empty when admin click on delete button
            }
            else
            {
                MessageBox.Show("Must fill the Details");
            }
        }
        // update customer function is being called from other file 
        private void newCSupdate_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals("")  && !TxtName.Text.ToString().Equals("") && !MobileNo.Text.ToString().Equals("") && !Address.Text.ToString().Equals(""))
            {
                connection.updateUsers(Convert.ToInt32(CustomerID.Text),TxtName.Text, MobileNo.Text, Address.Text);
                TxtName.Text = "";
                CustomerID.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
                // text boxes will be empty when admin click on update button
            }
            else
            {
                MessageBox.Show("Must fill the Details");
            }
        }

        // delete rental function is being called from other file 
        private void rentalVideoDelete_Click(object sender, EventArgs e)
        {
            if (rentID > 0 )
            {
                connection.delBooking(rentID);
                MessageBox.Show("Movie is deleted from booking ");
                TxtName.Text = "";
                CustomerID.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
                VideoID.Text = "";
                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                Txtcost.Text = "";
                TxtCopies.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";
                //   // all text boxes will be empty when admin click on delete button
            }
        }

        // issue function is being called from other file 
        private void VDissue_Click(object sender, EventArgs e)
        {
            if (!CustomerID.Text.ToString().Equals("") && !VideoID.Text.ToString().Equals("")) {
                connection.MovieIssue(Convert.ToInt32(CustomerID.Text), Convert.ToInt32(VideoID.Text),IssueVideo.Text,"Issued");
                MessageBox.Show("Movie is Issued on Rent ");
                TxtName.Text = "";
                CustomerID.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
                VideoID.Text = "";
                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                Txtcost.Text = "";
                TxtCopies.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";
                // text boxes will be empty when admin click on issue button
            }
        }

        private void VDreturn_Click(object sender, EventArgs e)
        {
            if (rentID>0 &&!CustomerID.Text.ToString().Equals("") && !VideoID.Text.ToString().Equals(""))
            {
                //first we need to get the cost of the video
                DataTable tbl = new DataTable();
                tbl = connection.CmdRecord("select * from Movie where ID=" + Convert.ToInt32(VideoID.Text)+"");
                int price=Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());


                //now need to get the diffeernce between teh dates 
                DateTime current_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(IssueVideo.Text);


                //get the difference in the days fromat
                String Daysdiff = (current_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


                int bill = price * Convert.ToInt32(DaysInterval);





                connection.MovieReturn(rentID,Convert.ToInt32(CustomerID.Text), Convert.ToInt32(VideoID.Text), IssueVideo.Text,ReturnVideo.Text);
                MessageBox.Show("Movie is returned and bill is $"+ bill);
                TxtName.Text = "";
                CustomerID.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
                VideoID.Text = "";
                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                Txtcost.Text = "";
                TxtCopies.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";
                // text boxes will be empty 

            }
        }

        private void CustomerShow_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerShow.Checked == true)
            {


                DataTable tbl = new DataTable();
                tbl = connection.CmdRecord("Select * from Users");
                RecordshowingGrid.DataSource = tbl;
                // showing record on grid
            }
        }

        private void VideoShow_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoShow.Checked == true)
            {


                DataTable tbl = new DataTable();
                tbl = connection.CmdRecord("Select * from Movie");
                RecordshowingGrid.DataSource = tbl;
                //showing record on grid
            }
        }

        private void RentalShow_CheckedChanged(object sender, EventArgs e)
        {
            if (RentalShow.Checked == true)
            {
                DataTable tbl = new DataTable();
                tbl = connection.CmdRecord("Select * from Booking");
                RecordshowingGrid.DataSource = tbl;
                // showing record on grid
            }
        }

        // below are different functions that show record on grids according ti ids 
        private void RecordshowingGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerShow.Checked == true)
            {
                CustomerID.Text = RecordshowingGrid.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text = RecordshowingGrid.CurrentRow.Cells[1].Value.ToString();
                MobileNo.Text = RecordshowingGrid.CurrentRow.Cells[2].Value.ToString();
                Address.Text = RecordshowingGrid.CurrentRow.Cells[3].Value.ToString();
            }
            else if (VideoShow.Checked == true)
            {

                VideoID.Text = RecordshowingGrid.CurrentRow.Cells[0].Value.ToString();
                Txttitle.Text = RecordshowingGrid.CurrentRow.Cells[1].Value.ToString();
                TxtRatting.Text = RecordshowingGrid.CurrentRow.Cells[2].Value.ToString();
                TxtYear.Text = RecordshowingGrid.CurrentRow.Cells[3].Value.ToString();
                Txtcost.Text = RecordshowingGrid.CurrentRow.Cells[4].Value.ToString();
                TxtCopies.Text = RecordshowingGrid.CurrentRow.Cells[5].Value.ToString();
                TxtPlot.Text = RecordshowingGrid.CurrentRow.Cells[6].Value.ToString();
                TxtGenre.Text = RecordshowingGrid.CurrentRow.Cells[7].Value.ToString();
            }
            else if (RentalShow.Checked == true)
            {
                rentID = Convert.ToInt32(RecordshowingGrid.CurrentRow.Cells[0].Value.ToString());
                CustomerID.Text = RecordshowingGrid.CurrentRow.Cells[1].Value.ToString();
                VideoID.Text = RecordshowingGrid.CurrentRow.Cells[2].Value.ToString();
                IssueVideo.Text = RecordshowingGrid.CurrentRow.Cells[3].Value.ToString();
            }
            else {
                MessageBox.Show("Must need to select Option ");
            }
        }

        // price according to years
        private void TxtYear_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(TxtYear.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                Txtcost.Text = "" + cost;
            }
            catch (Exception ex)
            {

            }
        }
        // showing popular video
        private void forpopular_showVD_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            

            tblData =connection.CmdRecord("select * from Movie");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = connection.CmdRecord("select * from Booking where MovID='" + tblData.Rows[x]["ID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["title"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
        
            MessageBox.Show("Best Movie of the Store is===" + Title);

        }
        
        // showing popular customer
        private void forpopular_showCS_Click(object sender, EventArgs e)
        {

            DataTable tblData = new DataTable();


            tblData = connection.CmdRecord("select * from Users");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = connection.CmdRecord("select * from Booking where CusID='" + tblData.Rows[x]["ID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best User of the Store is===" + Title);

        }
    }
}
