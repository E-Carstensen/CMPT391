using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace CMPT391Project
{
    public partial class LogIn : Form
    {

        
        public LogIn()
        {
            InitializeComponent();

            passwordLabel.Show();
            usernameLabel.Show();

            password.Show();
            userName.Show();

            flowLayoutPanel1.Hide();
            panel2.Hide();
            cartPage1.Hide();
            profilePage1.Hide();
            classSearch1.Hide();
            enrolledClasses1.Hide();

            LoginLabel.Show();


            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            int returnedValue = -1; // Initilize sql response outside of try
            //loads the connection string into sqlConn from the .config file
            var sqlConn = ConfigurationManager.ConnectionStrings["myConnStr"].ConnectionString;

            // Default local host database with name CMPT391Database
            using (SqlConnection conn = new SqlConnection(sqlConn)) 
            {
                try
                {
                    conn.Open();
                    // Using the check login procedure
                    using (SqlCommand cmd = new SqlCommand("check_login", conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        // Get inputted username/password
                        cmd.Parameters.AddWithValue("@username", userName.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);

                        // Parameter for retrieving return value
                        SqlParameter returnedParam = new SqlParameter("@ReturnValue", SqlDbType.Int);
                        returnedParam.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;


                        cmd.ExecuteNonQuery();


                        returnedValue = (int)cmd.Parameters["@ReturnValue"].Value;
                    }
                }
                catch(SqlException exception)
                {
                    System.Diagnostics.Debug.WriteLine(returnedValue.ToString());
                    System.Diagnostics.Debug.WriteLine(exception.Message);
                }
            }

            // -1 represents bad login/connection
            if (returnedValue > 0)
            {
                enrolledClasses1.getUser = userName.Text;
                passwordLabel.Hide();
                usernameLabel.Hide();

                Program.globalString = userName.Text;

            password.Hide();
            userName.Hide();
            flowLayoutPanel1.Show();
            panel2.Show();
            cartPage1.Show();
            profilePage1.Show();
            classSearch1.Show();
            enrolledClasses1.Show();


                flowLayoutPanel1.Show();
                profilePage1.Show();
                profilePage1.BringToFront();

                
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profilePage1.BringToFront();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
           
            cartPage1.BringToFront();

        }

        private void classSearchButton_Click(object sender, EventArgs e)
        {
           
            classSearch1.BringToFront();
        }

        private void cartPage1_Load(object sender, EventArgs e)
        {
             
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enrolledClassesButton_Click(object sender, EventArgs e)
        {
            enrolledClasses1.BringToFront();
        }

        private void enrolledClasses1_Load(object sender, EventArgs e)
        {
            int returnedValue = -1; // Initilize sql response outside of try


            // Default local host database with name CMPT391Database
            using (SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=CMPT391Database;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    // Using the check login procedure
                    using (SqlCommand cmd = new SqlCommand("class_search", conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        // Get inputted username/password
                        cmd.Parameters.AddWithValue("@username", userName.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);

                        // Parameter for retrieving return value
                        SqlParameter returnedParam = new SqlParameter("@ReturnValue", SqlDbType.Int);
                        returnedParam.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;


                        cmd.ExecuteNonQuery();


                        returnedValue = (int)cmd.Parameters["@ReturnValue"].Value;
                    }
                }
                catch (SqlException exception)
                {
                    System.Diagnostics.Debug.WriteLine(returnedValue.ToString());
                    System.Diagnostics.Debug.WriteLine(exception.Message);
                }
            }

            // -1 represents bad login/connection
            if (returnedValue > 0)
            {
                logInProcedure();
            }
        }
    }
}
