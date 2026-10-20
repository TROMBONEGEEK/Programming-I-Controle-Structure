using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace Names
{
    partial class Timers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timers));
            Close = new Button();
            Minimize = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackColor = Color.Red;
            Close.Location = new Point(690, 10);
            Close.Name = "Close";
            Close.Size = new Size(50, 35);
            Close.TabIndex = 0;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.LightSlateGray;
            Minimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Minimize.ForeColor = SystemColors.Desktop;
            Minimize.Location = new Point(635, 10);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(50, 35);
            Minimize.TabIndex = 1;
            Minimize.Text = "-";
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Timers_Activated;
            // 
            // button1
            // 
            button1.Location = new Point(49, 55);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Timers
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(750, 125);
            Controls.Add(button1);
            Controls.Add(Minimize);
            Controls.Add(Close);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(1920, 1020);
            Name = "Timers";
            Text = "Timers";
            TopMost = true;
            Activated += Timers_Activated;
            ResumeLayout(false);
        }
        #endregion

        private Button Close;
        private Button Minimize;
        private Button button1;
    }
}