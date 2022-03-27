using EatMeUp.Model;
using EatMeUp.View.Classes_for_Interface;
using System.Text.RegularExpressions;

namespace EatMeUp.Controller.FormsMethods
{
    public static class RegisterFormLogic
    {
        public static void LoadRegisterFormTheme(View.ChildForms.RegisterForm registerForm)
        {
            registerForm.panelControls.BackColor = ThemeColor.secondaryColor;

            foreach (Control control in registerForm.panelControls.Controls)
            {
                if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJTextBox))
                {
                    RJCodeAdvance.RJControls.RJTextBox textBox = (RJCodeAdvance.RJControls.RJTextBox)control;
                    textBox.BackColor = ThemeColor.secondaryColor;
                    textBox.ForeColor = Color.WhiteSmoke;
                    textBox.BorderColor = Color.WhiteSmoke;
                    textBox.PlaceholderColor = Color.WhiteSmoke;
                    textBox.BorderFocusColor = ThemeColor.primaryColor;
                }

                if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJButton))
                {
                    RJCodeAdvance.RJControls.RJButton button = (RJCodeAdvance.RJControls.RJButton)control;
                    button.BackColor = ThemeColor.secondaryColor;
                    button.ForeColor = Color.WhiteSmoke;
                    button.BorderColor = Color.WhiteSmoke;
                }
            }
            //Favourite foods
            registerForm.groupBoxFavFood.BackColor = ThemeColor.secondaryColor;
            registerForm.groupBoxGender.BackColor = ThemeColor.secondaryColor;
        }

        /// <summary>
        /// This should be called in click events of icon buttons in Favourite food Group box 
        /// </summary>
        /// <param name="registerForm"></param>
        /// <param name="sender"></param>
        public static void MarkFavouriteFood(View.ChildForms.RegisterForm registerForm, object sender)
        {
            foreach (Control button in registerForm.groupBoxFavFood.Controls)
            {
                FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)button;
                btn.BackColor = ThemeColor.secondaryColor;
                btn.ForeColor = Color.WhiteSmoke;
                btn.IconColor = Color.WhiteSmoke;
            }

            FontAwesome.Sharp.IconButton iconButton = (FontAwesome.Sharp.IconButton)sender;
            iconButton.BackColor = Color.WhiteSmoke;
            iconButton.ForeColor = ThemeColor.secondaryColor;
            iconButton.IconColor = ThemeColor.secondaryColor;
        }

        public static void CoosePhotoFromPC(View.ChildForms.RegisterForm registerForm)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo((*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                registerForm.pictureBoxCustommerImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        public static void ClearAllData(View.ChildForms.RegisterForm registerForm)
        {
            foreach (Control control in registerForm.panelControls.Controls)
            {
                if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJTextBox))
                {
                    RJCodeAdvance.RJControls.RJTextBox textBox = (RJCodeAdvance.RJControls.RJTextBox)control;
                    textBox.Texts = null;
                }
            }

            foreach (Control button in registerForm.groupBoxFavFood.Controls)
            {
                FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)button;
                btn.BackColor = ThemeColor.secondaryColor;
                btn.ForeColor = Color.WhiteSmoke;
                btn.IconColor = Color.WhiteSmoke;
            }

            registerForm.toggleButtonFemale.Checked = false;
            registerForm.toggleButtonMale.Checked = false;

            registerForm.pictureBoxCustommerImage.Image = null;
        }

        /// <summary>
        /// Check all data entered by user and throw exeptions for every kind of them
        /// </summary>
        /// <param name="registerForm"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="Exception"></exception>
        public static void CheckAllData(View.ChildForms.RegisterForm registerForm)
        {
            List<string> usernames = DB_Connection.GetCustommersUsernames();

            if (string.IsNullOrEmpty(registerForm.textBoxFirstName.Texts) || string.IsNullOrEmpty(registerForm.textBoxPassword.Texts) ||
                string.IsNullOrEmpty(registerForm.textBoxRepeadPassword.Texts) || string.IsNullOrEmpty(registerForm.textBoxSurname.Texts)
                || string.IsNullOrEmpty(registerForm.textBoxUsername.Texts))
            {
                throw new ArgumentNullException(nameof(registerForm));
            }
            else if (registerForm.textBoxFirstName.Texts.Trim().Length > 20 || registerForm.textBoxSurname.Texts.Trim().Length > 30 ||
                     registerForm.textBoxPassword.Texts.Trim().Length > 20 || registerForm.textBoxUsername.Texts.Trim().Length > 15)
            {
                throw new FormatException("You have fields longer than permissible ave fields longer tan alloued");
            }
            else if (registerForm.textBoxPassword.Texts == registerForm.textBoxUsername.Texts)
            {
                throw new FormatException("Username and password must be deferent");
            }
            else if (Regex.IsMatch(registerForm.textBoxFirstName.Texts, @"^[a-z][A-Z]+$") || Regex.IsMatch(registerForm.textBoxSurname.Texts, @"^[a-z][A-Z]+$"))
            {
                throw new FormatException("You must only use letters for names");
            }
            else if (usernames.Contains(registerForm.textBoxUsername.Texts))
            {
                throw new Exception("Username already used");
            }
            else if (registerForm.textBoxPassword.Texts != registerForm.textBoxRepeadPassword.Texts)
            {
                throw new Exception("Password fields are not the same");
            }
        }

        /// <summary>
        /// Creat instance of Creator class with data in register form
        /// </summary>
        /// <param name="registerForm"></param>
        /// <returns></returns>
        public static Custommer CreateCustommerAccount(View.ChildForms.RegisterForm registerForm)
        {
            //get custommer gender
            string gender = "Male";
            if (registerForm.toggleButtonFemale.Checked)
            {
                gender = "Female";
            }

            //get photo from picture box
            MemoryStream memoryStream = new MemoryStream();
            registerForm.pictureBoxCustommerImage.Image.Save(memoryStream, registerForm.pictureBoxCustommerImage.Image.RawFormat);
            byte[] image = memoryStream.ToArray();

            //get favourite food
            string favouriteFood = string.Empty;
            foreach (FontAwesome.Sharp.IconButton button in registerForm.groupBoxFavFood.Controls)
            {
                if (button.BackColor == Color.WhiteSmoke)
                {
                    favouriteFood = button.Text;
                    break;
                }
            }

            Custommer custommer = new Custommer(registerForm.textBoxUsername.Texts.Trim(), registerForm.textBoxPassword.Texts.Trim(),
                                                registerForm.textBoxFirstName.Texts.Trim(), registerForm.textBoxSurname.Texts.Trim(),
                                                gender, image, favouriteFood);

            return custommer;
        }
    }
}
