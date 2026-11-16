namespace Names
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            Timers = new Button();
            timerLogs = new DataGridView();
            ClassnameColumn = new DataGridViewTextBoxColumn();
            StartTimeColumn = new DataGridViewTextBoxColumn();
            StopTimeColumn = new DataGridViewTextBoxColumn();
            DurationColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            cartesianChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)timerLogs).BeginInit();
            SuspendLayout();
            // 
            // Timers
            // 
            Timers.BackColor = Color.DarkOrange;
            Timers.FlatStyle = FlatStyle.Popup;
            Timers.Font = new Font("Franklin Gothic Medium Cond", 15F, FontStyle.Bold);
            Timers.ForeColor = SystemColors.ControlText;
            Timers.Location = new Point(9, 8);
            Timers.Margin = new Padding(3, 2, 3, 2);
            Timers.Name = "Timers";
            Timers.Size = new Size(88, 41);
            Timers.TabIndex = 5;
            Timers.Text = "Timers";
            Timers.UseVisualStyleBackColor = false;
            Timers.Click += Timers_Click;
            // 
            // timerLogs
            // 
            timerLogs.AllowUserToAddRows = false;
            timerLogs.AllowUserToDeleteRows = false;
            timerLogs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timerLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            timerLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            timerLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            timerLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timerLogs.Columns.AddRange(new DataGridViewColumn[] { ClassnameColumn, StartTimeColumn, StopTimeColumn, DurationColumn, DateColumn });
            timerLogs.GridColor = SystemColors.Window;
            timerLogs.Location = new Point(654, 8);
            timerLogs.Margin = new Padding(3, 2, 3, 2);
            timerLogs.Name = "timerLogs";
            timerLogs.ReadOnly = true;
            timerLogs.RowHeadersWidth = 51;
            timerLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            timerLogs.Size = new Size(788, 300);
            timerLogs.TabIndex = 6;
            // 
            // ClassnameColumn
            // 
            ClassnameColumn.HeaderText = "Class";
            ClassnameColumn.MinimumWidth = 6;
            ClassnameColumn.Name = "ClassnameColumn";
            ClassnameColumn.ReadOnly = true;
            // 
            // StartTimeColumn
            // 
            StartTimeColumn.HeaderText = "Start Time";
            StartTimeColumn.MinimumWidth = 6;
            StartTimeColumn.Name = "StartTimeColumn";
            StartTimeColumn.ReadOnly = true;
            // 
            // StopTimeColumn
            // 
            StopTimeColumn.HeaderText = "Stop Time";
            StopTimeColumn.MinimumWidth = 6;
            StopTimeColumn.Name = "StopTimeColumn";
            StopTimeColumn.ReadOnly = true;
            // 
            // DurationColumn
            // 
            DurationColumn.HeaderText = "Duration";
            DurationColumn.MinimumWidth = 6;
            DurationColumn.Name = "DurationColumn";
            DurationColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.MinimumWidth = 6;
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            // 
            // cartesianChart
            // 
            cartesianChart.AutoUpdateEnabled = true;
            cartesianChart.BackColor = Color.Silver;
            cartesianChart.BorderStyle = BorderStyle.Fixed3D;
            cartesianChart.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            cartesianChart.Legend = skDefaultLegend1;
            cartesianChart.Location = new Point(10, 60);
            cartesianChart.Margin = new Padding(3, 2, 3, 2);
            cartesianChart.MatchAxesScreenDataRatio = false;
            cartesianChart.Name = "cartesianChart";
            cartesianChart.Size = new Size(800, 248);
            cartesianChart.TabIndex = 7;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            cartesianChart.Tooltip = skDefaultTooltip1;
            cartesianChart.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(cartesianChart);
            Controls.Add(timerLogs);
            Controls.Add(Timers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            Size = new Size(1444, 773);
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)timerLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart;
        private Button Timers;
        private DataGridView timerLogs;
        private DataGridViewTextBoxColumn ClassnameColumn;
        private DataGridViewTextBoxColumn StartTimeColumn;
        private DataGridViewTextBoxColumn StopTimeColumn;
        private DataGridViewTextBoxColumn DurationColumn;
        private DataGridViewTextBoxColumn DateColumn;
    }
}
