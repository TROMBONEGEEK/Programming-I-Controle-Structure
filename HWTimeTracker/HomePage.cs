using LiveChartsCore;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Data.Sqlite;
using SkiaSharp;
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

            LoadChart();
        }
        //
        //
        //
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
        //
        //
        //
        public void LoadChart()
        { 
            using var connection = new SqliteConnection("Data Source=TimeData.db");
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                SELECT Classname, Duration
                FROM TimeData";

            var totals = new Dictionary<string, TimeSpan>();

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string className = reader["ClassName"].ToString();
                string durationText = reader["Duration"].ToString();

                if (TimeSpan.TryParse(durationText, out TimeSpan duration))
                {
                    if (totals.ContainsKey(className))
                    {
                        totals[className] += duration;
                    }
                    else
                    {
                        totals[className] = duration;
                    }
                }
            }
            //
            var values = new List<double>();
            foreach (var total in totals.Values)
            {
                values.Add(total.TotalSeconds);
            }
            //
            var classNames = totals.Keys.ToArray();
            //
            var columnSeries = new ColumnSeries<double>
            {
                Values = values
            };
            //
            columnSeries.PointMeasured += OnPointMeasured;
            cartesianChart.Series = [columnSeries];
            cartesianChart.XAxes = new[]
            {
                new Axis
                {
                    Labels = classNames
                }
            };

            cartesianChart.YAxes = new[]
            {
                new Axis
                {
                    Labeler = value =>
                    {
                        TimeSpan time = TimeSpan.FromSeconds(value);
                        return time.ToString(@"hh\:mm\:ss");
                    }
                }
            };
        }
        //
        private void OnPointMeasured(ChartPoint point)
        {
            if (point.Context.Visual is null) return;
            point.Context.Visual.Fill = GetPaint(point.Index);
        }
        //
        private SolidColorPaint GetPaint(int index)
        {
            var paints = new SolidColorPaint[]
            {
                new(SKColors.Red),
                new(SKColors.Green),
                new(SKColors.Blue),
                new(SKColors.Yellow)
            };
            return paints[index % paints.Length];
        }
        //
        //
        //
        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
