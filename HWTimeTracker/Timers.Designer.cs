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
            Minamize = new Button();
            classTimersPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close.BackColor = Color.Red;
            Close.Location = new Point(440, 10);
            Close.Name = "Close";
            Close.Size = new Size(50, 35);
            Close.TabIndex = 0;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Minamize
            // 
            Minamize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minamize.BackColor = Color.LightSlateGray;
            Minamize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Minamize.ForeColor = SystemColors.Desktop;
            Minamize.Location = new Point(385, 10);
            Minamize.Name = "Minamize";
            Minamize.Size = new Size(50, 35);
            Minamize.TabIndex = 1;
            Minamize.Text = "-";
            Minamize.UseVisualStyleBackColor = false;
            Minamize.Click += Timers_Activated;
            // 
            // classTimersPanel
            // 
            classTimersPanel.AutoScroll = true;
            classTimersPanel.Dock = DockStyle.Left;
            classTimersPanel.FlowDirection = FlowDirection.TopDown;
            classTimersPanel.Location = new Point(0, 0);
            classTimersPanel.Name = "classTimersPanel";
            classTimersPanel.Size = new Size(385, 350);
            classTimersPanel.TabIndex = 2;
            classTimersPanel.WrapContents = false;
            // 
            // Timers
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(500, 350);
            Controls.Add(classTimersPanel);
            Controls.Add(Minamize);
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
            //
            //
            //
        }
        #endregion

        private Button Close;
        private Button Minamize;
        private FlowLayoutPanel classTimersPanel;
    }
}