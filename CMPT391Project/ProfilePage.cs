using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT391Project
{
    public partial class ProfilePage : UserControl
    {
        public ProfilePage()
        {

            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Checking:}" + Program.globalString);

            var sqlConn = ConfigurationManager.ConnectionStrings["myConnStr"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(sqlConn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("edit_user", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;



                        cmd.Parameters.AddWithValue("@username", Program.globalString);
                        cmd.Parameters.AddWithValue("@firstName", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@phone", phoneNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

                        SqlParameter returnParameter = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        cmd.ExecuteNonQuery();

                        int returnValue = (int)returnParameter.Value;

                        if (returnValue == 1)
                        {
                            Console.WriteLine("Success");
                        }
                        else if (returnValue == -1)
                        {
                            Console.WriteLine("Failure 1");
                        }
                        else
                        {
                            Console.WriteLine("Failure 2");
                        }
                    }
                }
                catch (SqlException exception)
                {
                    System.Diagnostics.Debug.WriteLine(exception.Message);
                }

            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Checking:}" + Program.globalString);

            var sqlConn = ConfigurationManager.ConnectionStrings["myConnStr"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(sqlConn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("show_user", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        Console.WriteLine("Checking:}" + Program.globalString);
                        cmd.Parameters.AddWithValue("@username", Program.globalString);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nameTextBox.Text = reader.GetString(reader.GetOrdinal("fName"));
                                lastNameTextBox.Text = reader.GetString(reader.GetOrdinal("lName"));
                                emailTextBox.Text = reader.GetString(reader.GetOrdinal("email"));
                                phoneNumberTextBox.Text = reader.GetString(reader.GetOrdinal("phone"));
                                passwordTextBox.Text = reader.GetString(reader.GetOrdinal("password"));
                            }
                        }
                    }
                }
                catch (SqlException exception)
                {
                    System.Diagnostics.Debug.WriteLine(exception.Message);
                }

            }
        }
    }
}
