namespace Rental_project2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txtcost = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.newVDdelete = new System.Windows.Forms.Button();
            this.newVDupdate = new System.Windows.Forms.Button();
            this.newVDadd = new System.Windows.Forms.Button();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.TxtPlot = new System.Windows.Forms.TextBox();
            this.TxtCopies = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtRatting = new System.Windows.Forms.TextBox();
            this.Txttitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newCSdel = new System.Windows.Forms.Button();
            this.newCSupdate = new System.Windows.Forms.Button();
            this.newCSadd = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.VideoID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.ReturnVideo = new System.Windows.Forms.DateTimePicker();
            this.IssueVideo = new System.Windows.Forms.DateTimePicker();
            this.rentalVideoDelete = new System.Windows.Forms.Button();
            this.VDreturn = new System.Windows.Forms.Button();
            this.VDissue = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.forpopular_showCS = new System.Windows.Forms.Button();
            this.forpopular_showVD = new System.Windows.Forms.Button();
            this.RentalShow = new System.Windows.Forms.RadioButton();
            this.VideoShow = new System.Windows.Forms.RadioButton();
            this.CustomerShow = new System.Windows.Forms.RadioButton();
            this.RecordshowingGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecordshowingGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txtcost
            // 
            this.Txtcost.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Txtcost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcost.Location = new System.Drawing.Point(839, 172);
            this.Txtcost.Name = "Txtcost";
            this.Txtcost.Size = new System.Drawing.Size(154, 32);
            this.Txtcost.TabIndex = 181;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Red;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(789, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 24);
            this.label18.TabIndex = 180;
            this.label18.Text = "Video Zone";
            // 
            // newVDdelete
            // 
            this.newVDdelete.BackColor = System.Drawing.Color.Red;
            this.newVDdelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVDdelete.Location = new System.Drawing.Point(903, 339);
            this.newVDdelete.Name = "newVDdelete";
            this.newVDdelete.Size = new System.Drawing.Size(85, 32);
            this.newVDdelete.TabIndex = 179;
            this.newVDdelete.Text = "Delete";
            this.newVDdelete.UseVisualStyleBackColor = false;
            this.newVDdelete.Click += new System.EventHandler(this.newVDdelete_Click);
            // 
            // newVDupdate
            // 
            this.newVDupdate.BackColor = System.Drawing.Color.Red;
            this.newVDupdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVDupdate.Location = new System.Drawing.Point(812, 339);
            this.newVDupdate.Name = "newVDupdate";
            this.newVDupdate.Size = new System.Drawing.Size(85, 32);
            this.newVDupdate.TabIndex = 178;
            this.newVDupdate.Text = "Update";
            this.newVDupdate.UseVisualStyleBackColor = false;
            this.newVDupdate.Click += new System.EventHandler(this.newVDupdate_Click);
            // 
            // newVDadd
            // 
            this.newVDadd.BackColor = System.Drawing.Color.Red;
            this.newVDadd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVDadd.Location = new System.Drawing.Point(721, 339);
            this.newVDadd.Name = "newVDadd";
            this.newVDadd.Size = new System.Drawing.Size(85, 32);
            this.newVDadd.TabIndex = 177;
            this.newVDadd.Text = "Add";
            this.newVDadd.UseVisualStyleBackColor = false;
            this.newVDadd.Click += new System.EventHandler(this.newVDadd_Click);
            // 
            // TxtGenre
            // 
            this.TxtGenre.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenre.Location = new System.Drawing.Point(839, 283);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(154, 32);
            this.TxtGenre.TabIndex = 176;
            // 
            // TxtPlot
            // 
            this.TxtPlot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlot.Location = new System.Drawing.Point(839, 247);
            this.TxtPlot.Name = "TxtPlot";
            this.TxtPlot.Size = new System.Drawing.Size(154, 32);
            this.TxtPlot.TabIndex = 175;
            // 
            // TxtCopies
            // 
            this.TxtCopies.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtCopies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCopies.Location = new System.Drawing.Point(839, 209);
            this.TxtCopies.Name = "TxtCopies";
            this.TxtCopies.Size = new System.Drawing.Size(154, 32);
            this.TxtCopies.TabIndex = 174;
            // 
            // TxtYear
            // 
            this.TxtYear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYear.Location = new System.Drawing.Point(839, 135);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(154, 32);
            this.TxtYear.TabIndex = 173;
            this.TxtYear.TextChanged += new System.EventHandler(this.TxtYear_TextChanged);
            // 
            // TxtRatting
            // 
            this.TxtRatting.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRatting.Location = new System.Drawing.Point(839, 97);
            this.TxtRatting.Name = "TxtRatting";
            this.TxtRatting.Size = new System.Drawing.Size(154, 32);
            this.TxtRatting.TabIndex = 172;
            // 
            // Txttitle
            // 
            this.Txttitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Txttitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttitle.Location = new System.Drawing.Point(839, 59);
            this.Txttitle.Name = "Txttitle";
            this.Txttitle.Size = new System.Drawing.Size(154, 32);
            this.Txttitle.TabIndex = 171;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(738, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 170;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(738, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 169;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(739, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 168;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(738, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 167;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(738, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 166;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(738, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 165;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(738, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 164;
            this.label16.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 163;
            this.label1.Text = "Customer Zone";
            // 
            // newCSdel
            // 
            this.newCSdel.BackColor = System.Drawing.Color.Red;
            this.newCSdel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCSdel.Location = new System.Drawing.Point(427, 209);
            this.newCSdel.Name = "newCSdel";
            this.newCSdel.Size = new System.Drawing.Size(274, 37);
            this.newCSdel.TabIndex = 162;
            this.newCSdel.Text = "Delete";
            this.newCSdel.UseVisualStyleBackColor = false;
            this.newCSdel.Click += new System.EventHandler(this.newCSdel_Click);
            // 
            // newCSupdate
            // 
            this.newCSupdate.BackColor = System.Drawing.Color.Red;
            this.newCSupdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCSupdate.Location = new System.Drawing.Point(547, 171);
            this.newCSupdate.Name = "newCSupdate";
            this.newCSupdate.Size = new System.Drawing.Size(154, 32);
            this.newCSupdate.TabIndex = 161;
            this.newCSupdate.Text = "Update";
            this.newCSupdate.UseVisualStyleBackColor = false;
            this.newCSupdate.Click += new System.EventHandler(this.newCSupdate_Click);
            // 
            // newCSadd
            // 
            this.newCSadd.BackColor = System.Drawing.Color.Red;
            this.newCSadd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCSadd.Location = new System.Drawing.Point(425, 171);
            this.newCSadd.Name = "newCSadd";
            this.newCSadd.Size = new System.Drawing.Size(101, 32);
            this.newCSadd.TabIndex = 158;
            this.newCSadd.Text = "Add";
            this.newCSadd.UseVisualStyleBackColor = false;
            this.newCSadd.Click += new System.EventHandler(this.newCSadd_Click);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(547, 127);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(154, 32);
            this.Address.TabIndex = 160;
            // 
            // MobileNo
            // 
            this.MobileNo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MobileNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(547, 88);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(154, 32);
            this.MobileNo.TabIndex = 159;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(547, 50);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(154, 32);
            this.TxtName.TabIndex = 157;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(421, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 156;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(421, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 155;
            this.label9.Text = "Phone No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(421, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 154;
            this.label11.Text = " Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(454, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 24);
            this.label17.TabIndex = 193;
            this.label17.Text = "Rental Zone";
            // 
            // VideoID
            // 
            this.VideoID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.VideoID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoID.Location = new System.Drawing.Point(546, 328);
            this.VideoID.Name = "VideoID";
            this.VideoID.Size = new System.Drawing.Size(154, 32);
            this.VideoID.TabIndex = 192;
            // 
            // CustomerID
            // 
            this.CustomerID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(546, 282);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(154, 32);
            this.CustomerID.TabIndex = 191;
            // 
            // ReturnVideo
            // 
            this.ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnVideo.Location = new System.Drawing.Point(546, 408);
            this.ReturnVideo.Name = "ReturnVideo";
            this.ReturnVideo.Size = new System.Drawing.Size(154, 32);
            this.ReturnVideo.TabIndex = 190;
            // 
            // IssueVideo
            // 
            this.IssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueVideo.Location = new System.Drawing.Point(546, 371);
            this.IssueVideo.Name = "IssueVideo";
            this.IssueVideo.Size = new System.Drawing.Size(154, 32);
            this.IssueVideo.TabIndex = 189;
            // 
            // rentalVideoDelete
            // 
            this.rentalVideoDelete.BackColor = System.Drawing.Color.Red;
            this.rentalVideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalVideoDelete.Location = new System.Drawing.Point(413, 486);
            this.rentalVideoDelete.Name = "rentalVideoDelete";
            this.rentalVideoDelete.Size = new System.Drawing.Size(274, 37);
            this.rentalVideoDelete.TabIndex = 188;
            this.rentalVideoDelete.Text = "Delete";
            this.rentalVideoDelete.UseVisualStyleBackColor = false;
            this.rentalVideoDelete.Click += new System.EventHandler(this.rentalVideoDelete_Click);
            // 
            // VDreturn
            // 
            this.VDreturn.BackColor = System.Drawing.Color.Red;
            this.VDreturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VDreturn.Location = new System.Drawing.Point(533, 448);
            this.VDreturn.Name = "VDreturn";
            this.VDreturn.Size = new System.Drawing.Size(154, 32);
            this.VDreturn.TabIndex = 187;
            this.VDreturn.Text = "Return";
            this.VDreturn.UseVisualStyleBackColor = false;
            this.VDreturn.Click += new System.EventHandler(this.VDreturn_Click);
            // 
            // VDissue
            // 
            this.VDissue.BackColor = System.Drawing.Color.Red;
            this.VDissue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VDissue.Location = new System.Drawing.Point(411, 448);
            this.VDissue.Name = "VDissue";
            this.VDissue.Size = new System.Drawing.Size(101, 32);
            this.VDissue.TabIndex = 186;
            this.VDissue.Text = "Issue";
            this.VDissue.UseVisualStyleBackColor = false;
            this.VDissue.Click += new System.EventHandler(this.VDissue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(398, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 185;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(398, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 184;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(407, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 183;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(407, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 182;
            this.label15.Text = "Customer ID";
            // 
            // forpopular_showCS
            // 
            this.forpopular_showCS.BackColor = System.Drawing.Color.Red;
            this.forpopular_showCS.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forpopular_showCS.Location = new System.Drawing.Point(191, 393);
            this.forpopular_showCS.Name = "forpopular_showCS";
            this.forpopular_showCS.Size = new System.Drawing.Size(201, 37);
            this.forpopular_showCS.TabIndex = 199;
            this.forpopular_showCS.Text = "Customer Popular";
            this.forpopular_showCS.UseVisualStyleBackColor = false;
            this.forpopular_showCS.Click += new System.EventHandler(this.forpopular_showCS_Click);
            // 
            // forpopular_showVD
            // 
            this.forpopular_showVD.BackColor = System.Drawing.Color.Red;
            this.forpopular_showVD.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forpopular_showVD.Location = new System.Drawing.Point(3, 393);
            this.forpopular_showVD.Name = "forpopular_showVD";
            this.forpopular_showVD.Size = new System.Drawing.Size(181, 37);
            this.forpopular_showVD.TabIndex = 198;
            this.forpopular_showVD.Text = "Video Popular";
            this.forpopular_showVD.UseVisualStyleBackColor = false;
            this.forpopular_showVD.Click += new System.EventHandler(this.forpopular_showVD_Click);
            // 
            // RentalShow
            // 
            this.RentalShow.AutoSize = true;
            this.RentalShow.BackColor = System.Drawing.Color.Red;
            this.RentalShow.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalShow.ForeColor = System.Drawing.Color.White;
            this.RentalShow.Location = new System.Drawing.Point(206, 33);
            this.RentalShow.Name = "RentalShow";
            this.RentalShow.Size = new System.Drawing.Size(82, 27);
            this.RentalShow.TabIndex = 197;
            this.RentalShow.TabStop = true;
            this.RentalShow.Text = "Rental";
            this.RentalShow.UseVisualStyleBackColor = false;
            this.RentalShow.CheckedChanged += new System.EventHandler(this.RentalShow_CheckedChanged);
            // 
            // VideoShow
            // 
            this.VideoShow.AutoSize = true;
            this.VideoShow.BackColor = System.Drawing.Color.Red;
            this.VideoShow.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoShow.ForeColor = System.Drawing.Color.White;
            this.VideoShow.Location = new System.Drawing.Point(122, 33);
            this.VideoShow.Name = "VideoShow";
            this.VideoShow.Size = new System.Drawing.Size(78, 27);
            this.VideoShow.TabIndex = 196;
            this.VideoShow.TabStop = true;
            this.VideoShow.Text = "Video";
            this.VideoShow.UseVisualStyleBackColor = false;
            this.VideoShow.CheckedChanged += new System.EventHandler(this.VideoShow_CheckedChanged);
            // 
            // CustomerShow
            // 
            this.CustomerShow.AutoSize = true;
            this.CustomerShow.BackColor = System.Drawing.Color.Red;
            this.CustomerShow.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerShow.ForeColor = System.Drawing.Color.White;
            this.CustomerShow.Location = new System.Drawing.Point(6, 33);
            this.CustomerShow.Name = "CustomerShow";
            this.CustomerShow.Size = new System.Drawing.Size(110, 27);
            this.CustomerShow.TabIndex = 195;
            this.CustomerShow.TabStop = true;
            this.CustomerShow.Text = "Customer";
            this.CustomerShow.UseVisualStyleBackColor = false;
            this.CustomerShow.CheckedChanged += new System.EventHandler(this.CustomerShow_CheckedChanged);
            // 
            // RecordshowingGrid
            // 
            this.RecordshowingGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.RecordshowingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordshowingGrid.Location = new System.Drawing.Point(2, 96);
            this.RecordshowingGrid.Name = "RecordshowingGrid";
            this.RecordshowingGrid.Size = new System.Drawing.Size(399, 255);
            this.RecordshowingGrid.TabIndex = 194;
            this.RecordshowingGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordshowingGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomerShow);
            this.groupBox1.Controls.Add(this.VideoShow);
            this.groupBox1.Controls.Add(this.RentalShow);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 79);
            this.groupBox1.TabIndex = 200;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1014, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.forpopular_showCS);
            this.Controls.Add(this.forpopular_showVD);
            this.Controls.Add(this.RecordshowingGrid);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.VideoID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.ReturnVideo);
            this.Controls.Add(this.IssueVideo);
            this.Controls.Add(this.rentalVideoDelete);
            this.Controls.Add(this.VDreturn);
            this.Controls.Add(this.VDissue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Txtcost);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.newVDdelete);
            this.Controls.Add(this.newVDupdate);
            this.Controls.Add(this.newVDadd);
            this.Controls.Add(this.TxtGenre);
            this.Controls.Add(this.TxtPlot);
            this.Controls.Add(this.TxtCopies);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtRatting);
            this.Controls.Add(this.Txttitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newCSdel);
            this.Controls.Add(this.newCSupdate);
            this.Controls.Add(this.newCSadd);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RecordshowingGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtcost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button newVDdelete;
        private System.Windows.Forms.Button newVDupdate;
        private System.Windows.Forms.Button newVDadd;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.TextBox TxtPlot;
        private System.Windows.Forms.TextBox TxtCopies;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtRatting;
        private System.Windows.Forms.TextBox Txttitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newCSdel;
        private System.Windows.Forms.Button newCSupdate;
        private System.Windows.Forms.Button newCSadd;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox VideoID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.DateTimePicker ReturnVideo;
        private System.Windows.Forms.DateTimePicker IssueVideo;
        private System.Windows.Forms.Button rentalVideoDelete;
        private System.Windows.Forms.Button VDreturn;
        private System.Windows.Forms.Button VDissue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button forpopular_showCS;
        private System.Windows.Forms.Button forpopular_showVD;
        private System.Windows.Forms.RadioButton RentalShow;
        private System.Windows.Forms.RadioButton VideoShow;
        private System.Windows.Forms.RadioButton CustomerShow;
        private System.Windows.Forms.DataGridView RecordshowingGrid;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

