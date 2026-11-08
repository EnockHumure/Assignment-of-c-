namespace biscyle_business
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Form
            this.Text            = "Main Menu";
            this.ClientSize      = new Size(480, 420);
            this.BackColor       = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.ShowIcon        = false;
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.Font            = new Font("Segoe UI", 10f);

            // Header
            pnlHeader           = new Panel();
            pnlHeader.BackColor = Color.FromArgb(30, 90, 160);
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Height    = 70;

            lblTitle           = new Label();
            lblTitle.Text      = "Select an Application";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font      = new Font("Segoe UI", 16f, FontStyle.Bold);
            lblTitle.Dock      = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            pnlHeader.Controls.Add(lblTitle);

            // Bicycle button
            btnBicycle                          = new Button();
            btnBicycle.Text                     = "Bicycle Rental Calculator";
            btnBicycle.Location                 = new Point(60, 120);
            btnBicycle.Size                     = new Size(360, 70);
            btnBicycle.BackColor                = Color.FromArgb(0, 140, 186);
            btnBicycle.ForeColor                = Color.White;
            btnBicycle.FlatStyle                = FlatStyle.Flat;
            btnBicycle.FlatAppearance.BorderSize = 0;
            btnBicycle.Font                     = new Font("Segoe UI", 12f, FontStyle.Bold);
            btnBicycle.Cursor                   = Cursors.Hand;
            btnBicycle.Click                   += BtnBicycle_Click;

            // Mushroom button
            btnMushroom                          = new Button();
            btnMushroom.Text                     = "Mushroom Type Identifier";
            btnMushroom.Location                 = new Point(60, 220);
            btnMushroom.Size                     = new Size(360, 70);
            btnMushroom.BackColor                = Color.FromArgb(34, 139, 34);
            btnMushroom.ForeColor                = Color.White;
            btnMushroom.FlatStyle                = FlatStyle.Flat;
            btnMushroom.FlatAppearance.BorderSize = 0;
            btnMushroom.Font                     = new Font("Segoe UI", 12f, FontStyle.Bold);
            btnMushroom.Cursor                   = Cursors.Hand;
            btnMushroom.Click                   += BtnMushroom_Click;

            // Logout button
            btnLogout                          = new Button();
            btnLogout.Text                     = "Logout";
            btnLogout.Location                 = new Point(60, 330);
            btnLogout.Size                     = new Size(360, 46);
            btnLogout.BackColor                = Color.FromArgb(180, 50, 50);
            btnLogout.ForeColor                = Color.White;
            btnLogout.FlatStyle                = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font                     = new Font("Segoe UI", 11f, FontStyle.Bold);
            btnLogout.Cursor                   = Cursors.Hand;
            btnLogout.Click                   += BtnLogout_Click;

            this.Controls.AddRange(new Control[] { pnlHeader, btnBicycle, btnMushroom, btnLogout });
        }

        private Panel  pnlHeader   = null!;
        private Label  lblTitle    = null!;
        private Button btnBicycle  = null!;
        private Button btnMushroom = null!;
        private Button btnLogout   = null!;
    }
}
