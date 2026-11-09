using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Names
{
    public partial class HomePage : UserControl
    {
        private Timers? timersWindow;
        public HomePage()
        {
            InitializeComponent();

            CreateTimeDataTable();
            LoadLogs();
        }

        private void Timers_Click(object sender, EventArgs e)
        {
            if (timersWindow == null)
            // In this case, timersWindow = nothing, so we can open a Timers form.
            {
                // Opens a Timers form.
                timersWindow = new Timers(this);
                // When the Timers form is closed, set timersWindow to null so that we can open a new Timers form.
                timersWindow.FormClosed += (s, args) =>
                {
                    timersWindow = null;
                };

                timersWindow.Show();
            }
        }
        //
        //
        //
        private void CreateTimeDataTable()
        {
            using var connection = new SqliteConnection("Data Source=TimeData.db");
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
        CREATE TABLE IF NOT EXISTS TimeData
        (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            ClassName TEXT,
            StartTime TEXT,
            StopTime TEXT,
            Duration TEXT,
            Date TEXT
        )";

            command.ExecuteNonQuery();
        }
        //
        //
        //
        public void LoadLogs()
        {
            timerLogs.Rows.Clear();

            using var connection = new SqliteConnection("Data Source=TimeData.db");
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                SELECT Classname, StartTime, StopTime, Duration, Date
                FROM TimeData
                ORDER BY ID DESC";

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string className = reader["ClassName"].ToString();
                string startTimeText = reader["StartTime"].ToString();
                string stopTimeText = reader["StopTime"].ToString();
                string durationText = reader["Duration"].ToString();
                string dateText = reader["Date"].ToString();

                string startTime = "";
                string stopTime = "";
                string duration = "";
                string date = "";

                if (DateTime.TryParse(startTimeText, out DateTime startDateTime))
                {
                    startTime = startDateTime.ToString("hh:mm:ss tt");
                }

                if (DateTime.TryParse(stopTimeText, out DateTime stopDateTime))
                {
                    stopTime = stopDateTime.ToString("hh:mm:ss tt");
                }

                if (TimeSpan.TryParse(durationText, out TimeSpan timeSpan))
                {
                    duration = timeSpan.ToString(@"hh\:mm\:ss");
                }

                if (DateTime.TryParse(dateText, out DateTime dateTime))
                {
                    date = dateTime.ToString("MM/dd/yyyy");
                }

                timerLogs.Rows.Add(
                    className,
                    startTime,
                    stopTime,
                    duration,
                    date
                );
            }
        }




        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
