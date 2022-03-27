using EatMeUp.View.Classes_for_Interface;
using EatMeUp.Model;

namespace EatMeUp.Controller.FormsMethods
{
    public static class LogInFormLogic
    {
        /// <summary>
        /// This field stay null until someone log in
        /// </summary>
        public static string Username { get; set; }

        public static void LoadTheme(View.Child_Forms.LogIn_Register_Form logInForm)
        {
            logInForm.tableLayoutPanelMain.BackColor = ThemeColor.secondaryColor;

            foreach (Control control in logInForm.panelControls.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label label = (Label)control;
                    label.ForeColor = ThemeColor.primaryColor;
                }

                if (control.GetType() == typeof(FontAwesome.Sharp.IconPictureBox))
                {
                    FontAwesome.Sharp.IconPictureBox pictureBox = (FontAwesome.Sharp.IconPictureBox)control;
                    pictureBox.ForeColor = ThemeColor.primaryColor;
                }

                if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJTextBox))
                {
                    RJCodeAdvance.RJControls.RJTextBox textBox = (RJCodeAdvance.RJControls.RJTextBox)control;
                    textBox.PlaceholderColor = ThemeColor.primaryColor;
                    textBox.ForeColor = ThemeColor.primaryColor;
                }
            }

            logInForm.buttonLogIn.BackColor = ThemeColor.primaryColor;
            logInForm.buttonClear.BorderColor = ThemeColor.primaryColor;
            logInForm.buttonClear.ForeColor = ThemeColor.primaryColor;

            logInForm.checkBoxShowPassword.ForeColor = ThemeColor.primaryColor;
        }

        /// <summary>
        /// Clear Fields
        /// </summary>
        /// <param name="logInForm"></param>
        public static void Clear(View.Child_Forms.LogIn_Register_Form logInForm)
        {
            logInForm.textBoxUsername.Texts = null;
            logInForm.textBoxPassword.Texts = null;
        }

        /// <summary>
        /// This is the logic of Log In button
        /// </summary>
        /// <param name="logInForm"></param>
        public static void LogIn(View.Child_Forms.LogIn_Register_Form logInForm)
        {
            Dictionary<string, string> accounts = DB_Connection.GetCreatedAccounts();

            if (accounts.ContainsKey(logInForm.textBoxUsername.Texts))
            {
                //get password of specific username
                string password = accounts[logInForm.textBoxUsername.Texts];

                if (password == logInForm.textBoxPassword.Texts)
                {
                    Username = logInForm.textBoxUsername.Texts;

                    MessageBox.Show("You signed in successfully! Now you have access to PROFILE tab in the menu and option to add recipes", "Info..",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorect password!", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username is incorect!", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}