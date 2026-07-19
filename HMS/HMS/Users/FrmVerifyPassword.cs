using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Windows.Forms;

namespace HMS.Users
{
    public partial class FrmVerifyPassword : Form
    {
        private int _userId;
        private string _userName;

        // Initializes the form and displays the given user's ID and username.
        public FrmVerifyPassword(int userId, string userName)
        {
            InitializeComponent();
            lblUserId.Text = $"User ID {userId}";
            lblUsername.Text = $"Username {userName}";

            _userId = userId;
            _userName = userName;

        }

        // Verifies the entered current password, then opens the change password form if correct.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClsUsers.IsPasswordCorrect(_userId, txtCurrentPassword.Text))
                {
                    MessageBox.Show(
                        "The current password you entered is incorrect. Please try again.",
                        "Incorrect Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCurrentPassword.Focus();
                    return;
                }

                FrmChangePassword changePasswordForm =
                    new FrmChangePassword(_userId, _userName);

                changePasswordForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while verifying the current password.");

                MessageBox.Show(
                    "An unexpected error occurred while verifying your password.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Closes the form without verifying.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}