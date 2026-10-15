using System.Security.Cryptography.X509Certificates;

namespace Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) &&
        !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private Timers? timersWindow;

        private void Timers_Click(object sender, EventArgs e)
        {
            if (timersWindow == null)
                // In this case, timersWindow = nothing, so we can open a Timers form.
            {
                // Opens a Timers form.
                timersWindow = new Timers();
                // When the Timers form is closed, set timersWindow to null so that we can open a new Timers form.
                timersWindow.FormClosed += (s, args) =>
                {
                    timersWindow = null;
                };

                timersWindow.Show();
            }
        }
    }
}
