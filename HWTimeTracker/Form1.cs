using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Names
{
    public partial class Form1 : Form
    {
        private HomePage? home;
        private ClassSettingsPage? settings;
        private AppearanceSettingsPage? appearanceSettings;

        private void ShowPage(UserControl page)
        {
            pagePanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(page);
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            home ??= new HomePage();
            ShowPage(home);
        }

        private void classesButton_Click(object sender, EventArgs e)
        {
            settings ??= new ClassSettingsPage();
            ShowPage(settings);
        }

        private void appearanceButton_Click(object sender, EventArgs e)
        {
            appearanceSettings ??= new AppearanceSettingsPage();
            ShowPage(appearanceSettings);
        }


        public Form1()
        {
            InitializeComponent();
            home ??= new HomePage();
            ShowPage(home);
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
