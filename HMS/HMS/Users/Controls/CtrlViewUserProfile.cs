using HMS.Global_Classes;
using HMS_Buisness;
using System;
using System.Windows.Forms;

namespace HMS.Users.Controls
{


    public partial class CtrlViewUserProfile : UserControl
    {
        private int _userId;

        // Initializes the control and its designer-generated components.
        public CtrlViewUserProfile()
        {
            InitializeComponent();
        }

        // Sets the status badge's text and colors based on whether the user is active.
        private void SetStatusBadge(bool isActive)
        {
            if (isActive)
            {
                lblStatusBadge.Text = "Active";
                lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(22, 101, 52);
                lblStatusBadge.ForeColor = System.Drawing.Color.FromArgb(187, 247, 208);
            }
            else
            {
                lblStatusBadge.Text = "Inactive";
                lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(127, 29, 29);
                lblStatusBadge.ForeColor = System.Drawing.Color.FromArgb(254, 202, 202);
            }
        }

        // Loads a user (and their person details) by ID and populates all profile sections: header, contact, personal, account, notes, and footer.
        public void LoadData(int userId)
        {
            try
            {
                ClsUsers user = ClsUsers.FindUserByUserId(userId);

                if (user == null)
                {
                    MessageBox.Show(
                        "User not found.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (user.Person == null)
                {
                    MessageBox.Show(
                        "Person details not found.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                _userId = user.UserId;

                // Header
                lblName.Text = string.IsNullOrWhiteSpace(user.Person.FullName)
                    ? "—"
                    : user.Person.FullName;

                lblUserIdBadge.Text = "USER #" + user.UserId;
                lblPersonIdBadge.Text = "PERSON #" + user.Person.PersonId;

                SetStatusBadge(user.IsActive);


                // Contact
                lblEmail.Text = string.IsNullOrWhiteSpace(user.Person.Email)
                    ? "—"
                    : user.Person.Email;

                lblPhone.Text = string.IsNullOrWhiteSpace(user.Person.Phone)
                    ? "—"
                    : user.Person.Phone;

                lblAddress.Text = string.IsNullOrWhiteSpace(user.Person.Address)
                    ? "—"
                    : user.Person.Address;


                // Personal
                lblDOB.Text = user.Person.DateOfBirth.ToString("yyyy-MM-dd");

                lblGender.Text = user.Person.Gender == false
                    ? "Male"
                    : "Female";

                lblNationality.Text =
                    user.Person.Nationality == null ||
                    string.IsNullOrWhiteSpace(user.Person.Nationality.CountryName)
                    ? "—"
                    : user.Person.Nationality.CountryName;

                lblPassport.Text = string.IsNullOrWhiteSpace(user.Person.PassportNumber)
                    ? "—"
                    : user.Person.PassportNumber;


                // Account
                lblUsername.Text = string.IsNullOrWhiteSpace(user.UserName)
                    ? "—"
                    : user.UserName;

                lblLastLogin.Text = user.LastLogin.HasValue
                    ? user.LastLogin.Value.ToString("yyyy-MM-dd HH:mm")
                    : "—";


                // Notes
                lblNotes.Text = string.IsNullOrWhiteSpace(user.Person.Notes)
                    ? "—"
                    : user.Person.Notes;


                // Footer
                lblTimestamps.Text =
                    $"Created {user.Person.CreatedAt:yyyy-MM-dd}  ·  Last updated {user.Person.UpdatedAt:yyyy-MM-dd}";
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while loading user profile. User ID: {userId}");

                MessageBox.Show(
                    "An unexpected error occurred while retrieving the user.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Closes the parent form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        // Opens the add/update user form for editing this user, then closes the parent form.
        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUpdateUser addUpdateUserForm = new FrmAddUpdateUser(_userId);

                addUpdateUserForm.ShowDialog();

                this.FindForm().Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex, $"Error while opening edit user form. User ID: {_userId}");

                MessageBox.Show(
                    "An unexpected error occurred while opening the edit user form.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}