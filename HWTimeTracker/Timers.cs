using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Names
{
    public partial class Timers : Form
    {
        public Timers()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(
                screenArea.Right - Width,
                screenArea.Bottom - Height
             );
        }

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

        private void Timers_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
