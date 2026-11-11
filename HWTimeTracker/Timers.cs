using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Names
{
    public partial class Timers : Form
    {
        private readonly HomePage loadLogs;
        private readonly Dictionary<string, Stopwatch> stopwatches = new();
        private readonly Dictionary<string, Label> timeLabels = new();
        private readonly Dictionary<string, long> timeDataIds = new();
        private System.Windows.Forms.Timer displayTimer;
        public Timers(HomePage homePage)
        {
            InitializeComponent();

            loadLogs = homePage;

            LoadClasses();

            StartPosition = FormStartPosition.Manual;
            Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(
                screenArea.Right - Width,
                screenArea.Bottom - Height
             );

            displayTimer = new System.Windows.Forms.Timer();
            displayTimer.Interval = 100;
            displayTimer.Tick += DisplayTimer_Tick;
            displayTimer.Start();
        }
        //
        //
        //
        private void Timers_Activated(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        //
        //
        //
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        //
        //
        //
        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            foreach (var kvp in stopwatches)
            {
                string className = kvp.Key;
                Stopwatch stopwatch = kvp.Value;
                if (timeLabels.TryGetValue(className, out Label timeLabel))
                {
                    TimeSpan elapsed = stopwatch.Elapsed;
                    timeLabel.Text = $"{className}: " +
                                     $"{(int)elapsed.TotalHours:00}:" +
                                     $"{elapsed.Minutes:00}:" +
                                     $"{elapsed.Seconds:00}";
                }
            }
        }
        //
        //
        //
        private void CreateClassTimer(string className)
        {
            if (!stopwatches.ContainsKey(className))
            {
                Panel classPanel = new Panel();
                classPanel.BackColor = Color.FromArgb(50, 50, 50);
                classPanel.Padding = new Padding(5);
                classPanel.Size = new Size(350, 100);
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatches[className] = stopwatch;
                Label timeLabel = new Label
                {
                    Text = $"{className}: 00:00:00",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Margin = new Padding(10)
                };
                //
                //
                //
                Button startButton = new Button
                {
                    Name = "startButton",
                    Size = new Size(75, 30),
                    Location = new Point(10, 45),
                    Text = "Start"
                };
                //
                // Start Button Starts The Stopwatch and Inserts Data Into The Database
                //
                startButton.Click += (sender, e) =>
                {
                    stopwatches[className].Start();

                    using var connection = new SqliteConnection("Data Source=TimeData.db");
                    connection.Open();

                    using var createTableCommand = connection.CreateCommand();
                    createTableCommand.CommandText = @"
                        CREATE TABLE IF NOT EXISTS TimeData 
                        (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            ClassName TEXT,
                            StartTime TEXT,
                            StopTime TEXT,
                            Duration TEXT,
                            Date TEXT
                        )";
                    createTableCommand.ExecuteNonQuery();

                    using var command = connection.CreateCommand();
                    command.CommandText = @"
                        INSERT INTO TimeData 
                            (ClassName, StartTime, Date) 
                        VALUES 
                            (@ClassName, @StartTime, @Date)";
                    command.Parameters.AddWithValue("@ClassName", className);
                    command.Parameters.AddWithValue("@StartTime", DateTime.Now);
                    command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    command.ExecuteNonQuery();

                    using var idCommand = connection.CreateCommand();
                    idCommand.CommandText = "SELECT last_insert_rowid()";

                    long id = (long)idCommand.ExecuteScalar();
                    timeDataIds[className] = id;

                    loadLogs.LoadLogs();
                    loadLogs.LoadChart();
                };
                //
                // Stop Button Stops The Stopwatch and Inserts Data Into The Database
                //
                Button stopButton = new Button
                {
                    Name = "stopbutton",
                    Size = new Size(75, 30),
                    Location = new Point(95, 45),
                    Text = "Stop"
                };
                // Stop Button Click Event Handler
                stopButton.Click += (sender, e) =>
                {
                    stopwatches[className].Stop();

                    using var connection = new SqliteConnection("Data Source=TimeData.db");
                    connection.Open();

                    using var command = connection.CreateCommand();
                    command.CommandText = @"
                        UPDATE TimeData 
                        SET StopTime = @StopTime,
                            Duration = @Duration
                        WHERE ID = @Id";
                    command.Parameters.AddWithValue("@StopTime", DateTime.Now);
                    command.Parameters.AddWithValue("@Duration", stopwatches[className].Elapsed);
                    command.Parameters.AddWithValue("@Id", timeDataIds[className]);
                    command.ExecuteNonQuery();

                    loadLogs.LoadLogs();
                    loadLogs.LoadChart();
                };
                // Add the timeLabel to the classTimersPanel and store it in the timeLabels dictionary
                timeLabels[className] = timeLabel;
                timeLabel.Location = new Point(10, 10);

                classTimersPanel.Controls.Add(classPanel);
                classPanel.Controls.Add(timeLabel);

                classPanel.Controls.Add(startButton);

                classPanel.Controls.Add(stopButton);
            }
        }
        //
        //
        //
        private void LoadClasses()
        {
            using var connection = new SqliteConnection("Data Source=Classes.db");
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Name FROM Classes";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string className = reader["Name"].ToString();
                CreateClassTimer(className);
            }
        }
    }
}