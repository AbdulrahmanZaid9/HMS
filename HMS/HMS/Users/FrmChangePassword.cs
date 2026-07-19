using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HMS.Users
{
    public partial class FrmChangePassword : Form
    {
        private int _userId;
        private string _userName;

        // Initializes the form and displays the given user's ID and username.
        public FrmChangePassword(int userId, string userName)
        {
            InitializeComponent();
            lblUserId.Text = $"User ID {userId}";
            lblUsername.Text = $"Username {userName}";

            _userId = userId;
            _userName = userName;
        }

        // Validates that a new password has been entered.
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "Password is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, null);

            }
        }

        // Validates that a confirmation password has been entered.
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);

            }
        }

        // Closes the form without saving.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Verifies the new and confirmation passwords match, then updates the user's password and closes the form on success.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "The new password and confirmation password do not match. Please enter the same password in both fields.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                if (ClsUsers.UpdatePassword(_userId, txtConfirmPassword.Text))
                {
                    MessageBox.Show(
                        "Your password has been changed successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "An error occurred while changing your password. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, "Error while updating user password.");

                MessageBox.Show(
                    "An unexpected error occurred while changing the password.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}