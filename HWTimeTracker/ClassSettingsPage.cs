using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace Names
{
    public partial class ClassSettingsPage : UserControl
    {
        private readonly HomePage loadLogs;
        public ClassSettingsPage(HomePage homePage)
        {
            InitializeComponent();

            using var connection = new SqliteConnection("Data Source=Classes.db");
            connection.Open();

            using var createTableCommand = connection.CreateCommand();
            createTableCommand.CommandText = "CREATE TABLE IF NOT EXISTS Classes (Name TEXT)";
            createTableCommand.ExecuteNonQuery();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Name FROM Classes";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["Name"].ToString());
            }
            connection.Close();
            // Store the reference to the HomePage instance
            loadLogs = homePage;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        


        //
        // When textbox has text and user presses enter, add to database and listbox.
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text))
            {
                using var connection = new SqliteConnection("Data Source=Classes.db");
                connection.Open();

                using var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Classes (Name) VALUES (@name)";
                command.Parameters.AddWithValue("@name", textBox1.Text);

                int writer = command.ExecuteNonQuery();
                if (writer == 1)
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                }
                connection.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                class1.PerformClick();
            }
        }


        //
        // 
        //
        private void delete1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a class to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this class?","Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Delete the data associated with the class from TimeData.db
                    string className = listBox1.SelectedItem.ToString();

                    using var dataconnection = new SqliteConnection("Data Source=Classes.db");
                    dataconnection.Open();

                    using var dataConnection = new SqliteConnection($"Data Source=TimeData.db");
                    dataConnection.Open();

                    using var deleteDataCommand = dataConnection.CreateCommand();
                    deleteDataCommand.CommandText = "DELETE FROM TimeData WHERE ClassName = @Name";
                    deleteDataCommand.Parameters.AddWithValue("@Name", className);
                    deleteDataCommand.ExecuteNonQuery();

                    // Delete the class from Classes.db

                    using var connection = new SqliteConnection("Data Source=Classes.db");
                    connection.Open();

                    using var command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM Classes WHERE Name = @name";
                    command.Parameters.AddWithValue("@name", className);
                    command.ExecuteNonQuery();

                    listBox1.Items.Remove(className);

                    loadLogs.LoadLogs();
                    loadLogs.LoadChart();
                }
            }
        }
    }
}
