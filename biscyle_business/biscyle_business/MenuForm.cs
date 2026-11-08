using System.Diagnostics;

namespace biscyle_business
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BtnBicycle_Click(object sender, EventArgs e)
        {
            new Form1(this).Show();
            this.Hide();
        }

        private void BtnMushroom_Click(object sender, EventArgs e)
        {
            string mushroomExe = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "..",
                "Mushuroom-type", "Mushuroom-type", "bin", "Debug", "net8.0-windows", "Mushuroom-type.exe"
            );

            mushroomExe = Path.GetFullPath(mushroomExe);

            if (File.Exists(mushroomExe))
                Process.Start(mushroomExe);
            else
                MessageBox.Show("Build the Mushroom project first in Visual Studio.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
