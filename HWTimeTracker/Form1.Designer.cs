namespace Names
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            Names = new Label();
            lstNames = new ListBox();
            txtName = new TextBox();
            Timers = new Button();
            pagePanel = new Panel();
            navigationPanel = new Panel();
            appearanceButton = new Button();
            classesButton = new Button();
            homeButton = new Button();
            pagePanel.SuspendLayout();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(540, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // Names
            // 
            Names.AutoSize = true;
            Names.Location = new Point(434, 0);
            Names.Name = "Names";
            Names.Size = new Size(55, 20);
            Names.TabIndex = 1;
            Names.Text = "Names";
            Names.Click += Label1_Click;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.Location = new Point(414, 26);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(120, 24);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(308, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 27);
            txtName.TabIndex = 3;
            // 
            // Timers
            // 
            Timers.Location = new Point(576, 124);
            Timers.Name = "Timers";
            Timers.Size = new Size(94, 29);
            Timers.TabIndex = 4;
            Timers.Text = "Timers";
            Timers.UseVisualStyleBackColor = true;
            Timers.Click += Timers_Click;
            // 
            // pagePanel
            // 
            pagePanel.AutoScroll = true;
            pagePanel.Controls.Add(Timers);
            pagePanel.Dock = DockStyle.Fill;
            pagePanel.Location = new Point(0, 0);
            pagePanel.Name = "pagePanel";
            pagePanel.Size = new Size(977, 469);
            pagePanel.TabIndex = 5;
            // 
            // navigationPanel
            // 
            navigationPanel.BorderStyle = BorderStyle.Fixed3D;
            navigationPanel.Controls.Add(appearanceButton);
            navigationPanel.Controls.Add(classesButton);
            navigationPanel.Controls.Add(homeButton);
            navigationPanel.Dock = DockStyle.Left;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(150, 469);
            navigationPanel.TabIndex = 0;
            // 
            // appearanceButton
            // 
            appearanceButton.Location = new Point(0, 70);
            appearanceButton.Name = "appearanceButton";
            appearanceButton.Size = new Size(150, 40);
            appearanceButton.TabIndex = 2;
            appearanceButton.Text = "Appearance";
            appearanceButton.UseVisualStyleBackColor = true;
            // 
            // classesButton
            // 
            classesButton.Location = new Point(0, 35);
            classesButton.Name = "classesButton";
            classesButton.Size = new Size(150, 40);
            classesButton.TabIndex = 1;
            classesButton.Text = "Class Settings";
            classesButton.UseVisualStyleBackColor = true;
            classesButton.Click += classesButton_Click;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(0, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(150, 40);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 469);
            Controls.Add(btnAdd);
            Controls.Add(Names);
            Controls.Add(lstNames);
            Controls.Add(txtName);
            Controls.Add(navigationPanel);
            Controls.Add(pagePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Homework Time Tracker";
            WindowState = FormWindowState.Maximized;
            Activated += Form1_Activated;
            pagePanel.ResumeLayout(false);
            navigationPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Label Names;
        private ListBox lstNames;
        private TextBox txtName;
        private Button Timers;
        private Panel pagePanel;
        private Panel navigationPanel;
        private Button appearanceButton;
        private Button classesButton;
        private Button homeButton;
    }
}
