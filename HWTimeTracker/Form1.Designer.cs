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
            navigationPanel = new Panel();
            homeButton = new Button();
            classesButton = new Button();
            appearanceButton = new Button();
            pagePanel = new Panel();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = SystemColors.ActiveCaption;
            navigationPanel.BorderStyle = BorderStyle.FixedSingle;
            navigationPanel.Controls.Add(homeButton);
            navigationPanel.Controls.Add(classesButton);
            navigationPanel.Controls.Add(appearanceButton);
            navigationPanel.Dock = DockStyle.Left;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(250, 1033);
            navigationPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.DarkOrange;
            homeButton.Location = new Point(-2, -2);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(250, 40);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // classesButton
            // 
            classesButton.BackColor = Color.DarkOrange;
            classesButton.Location = new Point(-2, 44);
            classesButton.Name = "classesButton";
            classesButton.Size = new Size(250, 40);
            classesButton.TabIndex = 1;
            classesButton.Text = "Class Settings";
            classesButton.UseVisualStyleBackColor = false;
            classesButton.Click += classesButton_Click;
            // 
            // appearanceButton
            // 
            appearanceButton.BackColor = Color.DarkOrange;
            appearanceButton.Location = new Point(-2, 90);
            appearanceButton.Name = "appearanceButton";
            appearanceButton.Size = new Size(250, 40);
            appearanceButton.TabIndex = 2;
            appearanceButton.Text = "Appearance";
            appearanceButton.UseVisualStyleBackColor = false;
            appearanceButton.Click += appearanceButton_Click;
            // 
            // pagePanel
            // 
            pagePanel.BackColor = SystemColors.Control;
            pagePanel.Dock = DockStyle.Fill;
            pagePanel.Location = new Point(250, 0);
            pagePanel.Name = "pagePanel";
            pagePanel.Size = new Size(1652, 1033);
            pagePanel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pagePanel);
            Controls.Add(navigationPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Homework Time Tracker";
            WindowState = FormWindowState.Maximized;
            navigationPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private Panel navigationPanel;
        private Button appearanceButton;
        private Button classesButton;
        private Button homeButton;
        private Panel pagePanel;
    }
}
