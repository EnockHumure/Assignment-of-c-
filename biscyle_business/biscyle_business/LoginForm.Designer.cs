namespace biscyle_business
{
    partial class LoginForm
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
            this.Text            = "Login";
            this.ClientSize      = new Size(420, 380);
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
            lblTitle.Text      = "Welcome";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font      = new Font("Segoe UI", 18f, FontStyle.Bold);
            lblTitle.Dock      = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            pnlHeader.Controls.Add(lblTitle);

            // Username
            lblUsername           = new Label();
            lblUsername.Text      = "Username";
            lblUsername.Font      = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(60, 60, 80);
            lblUsername.Location  = new Point(40, 100);
            lblUsername.AutoSize  = true;

            txtUsername             = new TextBox();
            txtUsername.Location    = new Point(40, 124);
            txtUsername.Size        = new Size(340, 35);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font        = new Font("Segoe UI", 10.5f);
            txtUsername.BackColor   = Color.FromArgb(245, 247, 250);

            // Password
            lblPassword           = new Label();
            lblPassword.Text      = "Password";
            lblPassword.Font      = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(60, 60, 80);
            lblPassword.Location  = new Point(40, 174);
            lblPassword.AutoSize  = true;

            txtPassword               = new TextBox();
            txtPassword.Location      = new Point(40, 198);
            txtPassword.Size          = new Size(340, 35);
            txtPassword.BorderStyle   = BorderStyle.FixedSingle;
            txtPassword.Font          = new Font("Segoe UI", 10.5f);
            txtPassword.BackColor     = Color.FromArgb(245, 247, 250);
            txtPassword.PasswordChar  = '●';

            // Error
            lblError           = new Label();
            lblError.ForeColor = Color.FromArgb(200, 50, 50);
            lblError.Font      = new Font("Segoe UI", 8.5f);
            lblError.Location  = new Point(40, 242);
            lblError.AutoSize  = true;
            lblError.Text      = "";

            // Login button
            btnLogin                          = new Button();
            btnLogin.Text                     = "Login";
            btnLogin.Location                 = new Point(40, 270);
            btnLogin.Size                     = new Size(340, 46);
            btnLogin.BackColor                = Color.FromArgb(0, 140, 186);
            btnLogin.ForeColor                = Color.White;
            btnLogin.FlatStyle                = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font                     = new Font("Segoe UI", 11f, FontStyle.Bold);
            btnLogin.Cursor                   = Cursors.Hand;
            btnLogin.Click                   += BtnLogin_Click;

            this.Controls.AddRange(new Control[] { pnlHeader, lblUsername, txtUsername, lblPassword, txtPassword, lblError, btnLogin });
        }

        private Panel   pnlHeader   = null!;
        private Label   lblTitle    = null!;
        private Label   lblUsername = null!;
        private Label   lblPassword = null!;
        private TextBox txtUsername = null!;
        private TextBox txtPassword = null!;
        private Label   lblError    = null!;
        private Button  btnLogin    = null!;
    }
}
