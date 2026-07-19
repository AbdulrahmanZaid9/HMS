using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Security;
using System.Windows.Forms;
using Utilities;

namespace HMS.Login
{
    public partial class FrmLogin : Form
    {
        // Initializes the login form and its designer-generated components.
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Validates credentials, signs the user in, handles "remember me", and opens the main form on success.
        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show(
                    "Please correct the highlighted errors.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                ClsUsers user = ClsUsers.FindByUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (user != null)
                {
                    if (!user.IsActive)
                    {
                        clsLogger.LogWarning($"Inactive user login attempt. Username: {txtUsername.Text.Trim()}");

                        txtUsername.Focus();

                        MessageBox.Show(
                            "Your account is inactive. Please contact the administrator.",
                            "Account Inactive",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }


                    bool result = false;

                    if (chkRememberMe.Checked)
                        result = SecurityHelper.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                    else
                        result = SecurityHelper.RememberUsernameAndPassword("", "");


                    if (!result)
                    {
                        clsLogger.LogWarning($"Failed to save remember me credentials. Username: {txtUsername.Text.Trim()}");

                        MessageBox.Show(
                            "Failed to remember credentials. Please try again.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }


                    ClsGlobal.CurrentUser = user;

                    ClsGlobal.CurrentUser.UpdateLastLogin();

                    clsLogger.LogInformation($"User logged in successfully. Username: {user.UserName}");


                    this.Hide();

                    Mainform mainForm = new Mainform();
                    mainForm.ShowDialog();
                }
                else
                {
                    clsLogger.LogWarning($"Failed login attempt. Username: {txtUsername.Text.Trim()}");

                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error during login. Username: {txtUsername.Text.Trim()}");

                MessageBox.Show(
                    "An unexpected error occurred. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Pre-fills the username/password fields from any previously saved "remember me" credentials.
        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                string userName = "", password = "";

                if (SecurityHelper.GetStoredCredential(ref userName, ref password))
                {
                    txtUsername.Text = userName;
                    txtPassword.Text = password;

                    chkRememberMe.Checked = !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while loading stored login credentials");

                MessageBox.Show(
                    "Unable to load saved credentials.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Validates that the username field is not empty.
        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Username is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
                e.Cancel = false;
            }
        }

        // Validates that the password field is not empty.
        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
                e.Cancel = false;
            }
        }

        // Triggers the sign-in button when Enter is pressed in the username field.
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        // Toggles whether the password field displays its actual characters or masked characters.
        private void lblEye_Click(object sender, System.EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}