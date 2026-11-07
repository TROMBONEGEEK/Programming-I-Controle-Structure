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
            Timers = new Button();
            timerLogs = new DataGridView();
            ClassnameColumn = new DataGridViewTextBoxColumn();
            StartTimeColumn = new DataGridViewTextBoxColumn();
            StopTimeColumn = new DataGridViewTextBoxColumn();
            DurationColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)timerLogs).BeginInit();
            SuspendLayout();
            // 
            // Timers
            // 
            Timers.Font = new Font("Franklin Gothic Medium Cond", 15F, FontStyle.Bold);
            Timers.ForeColor = SystemColors.ControlText;
            Timers.Location = new Point(10, 10);
            Timers.Name = "Timers";
            Timers.Size = new Size(100, 55);
            Timers.TabIndex = 5;
            Timers.Text = "Timers";
            Timers.UseVisualStyleBackColor = true;
            Timers.Click += Timers_Click;
            // 
            // timerLogs
            // 
            timerLogs.AllowUserToAddRows = false;
            timerLogs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timerLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            timerLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timerLogs.Columns.AddRange(new DataGridViewColumn[] { ClassnameColumn, StartTimeColumn, StopTimeColumn, DurationColumn, DateColumn });
            timerLogs.Location = new Point(742, 10);
            timerLogs.Name = "timerLogs";
            timerLogs.ReadOnly = true;
            timerLogs.RowHeadersWidth = 51;
            timerLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            timerLogs.Size = new Size(900, 400);
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
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(timerLogs);
            Controls.Add(Timers);
            Name = "HomePage";
            Size = new Size(1652, 1033);
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)timerLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Timers;
        private DataGridView timerLogs;
        private DataGridViewTextBoxColumn ClassnameColumn;
        private DataGridViewTextBoxColumn StartTimeColumn;
        private DataGridViewTextBoxColumn StopTimeColumn;
        private DataGridViewTextBoxColumn DurationColumn;
        private DataGridViewTextBoxColumn DateColumn;
    }
}
