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
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 55);
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
            Names.Location = new Point(12, 9);
            Names.Name = "Names";
            Names.Size = new Size(55, 20);
            Names.TabIndex = 1;
            Names.Text = "Names";
            Names.Click += Label1_Click;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.Location = new Point(12, 27);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(120, 84);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 27);
            txtName.TabIndex = 3;
            // 
            // Timers
            // 
            Timers.Location = new Point(138, 103);
            Timers.Name = "Timers";
            Timers.Size = new Size(94, 29);
            Timers.TabIndex = 4;
            Timers.Text = "Timers";
            Timers.UseVisualStyleBackColor = true;
            Timers.Click += Timers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            WindowState = FormWindowState.Maximized;
            Controls.Add(Timers);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(Names);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Homework Time Tracker";
            Activated += Form1_Activated;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Label Names;
        private ListBox lstNames;
        private TextBox txtName;
        private Button Timers;
    }
}
