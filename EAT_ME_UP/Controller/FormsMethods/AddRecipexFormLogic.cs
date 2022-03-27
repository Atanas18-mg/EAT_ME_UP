using EatMeUp.Model;
using EatMeUp.View.Classes_for_Interface;
using System.Text.RegularExpressions;

namespace EatMeUp.Controller.FormsMethods
{
    public static class AddRecipexFormLogic
    {
        /// <summary>
        /// Using this list for storage where is mistake in the form (Using this after CheckEnteredInfo method)
        /// </summary>
        private static List<string> errorList = new List<string>();

        public static void LoadColorTheme(View.Child_Forms.AddRecipeForm addRecipeForm)
        {
            foreach (Control control in addRecipeForm.panelAllControlls.Controls)
            {
                if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJTextBox))
                {
                    RJCodeAdvance.RJControls.RJTextBox textBox = (RJCodeAdvance.RJControls.RJTextBox)control;
                    textBox.BackColor = Color.WhiteSmoke;
                    textBox.BorderColor = ThemeColor.primaryColor;
                    textBox.BorderFocusColor = ThemeColor.secondaryColor;
                    textBox.PlaceholderColor = ThemeColor.secondaryColor;
                    textBox.ForeColor = ThemeColor.secondaryColor;
                }
                if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJComboBox))
                {
                    RJCodeAdvance.RJControls.RJComboBox comboBox = (RJCodeAdvance.RJControls.RJComboBox)control;
                    comboBox.BorderColor = ThemeColor.primaryColor;
                    comboBox.IconColor = ThemeColor.secondaryColor;
                    comboBox.ForeColor = ThemeColor.secondaryColor;
                }
                if ((control.GetType() == typeof(RJCodeAdvance.RJControls.RJButton)))
                {
                    RJCodeAdvance.RJControls.RJButton button = (RJCodeAdvance.RJControls.RJButton)control;
                    button.BackColor = ThemeColor.primaryColor;
                }
                if (control.GetType() == typeof(Label))
                {
                    Label label = (Label)control;
                    label.ForeColor = ThemeColor.secondaryColor;
                }
                if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJCircularPictureBox))
                {
                    RJCodeAdvance.RJControls.RJCircularPictureBox pictureBox = (RJCodeAdvance.RJControls.RJCircularPictureBox)control;
                    pictureBox.BorderColor = ThemeColor.primaryColor;
                    pictureBox.BorderColor2 = ThemeColor.secondaryColor;
                }
            }
        }

        public static void SetFormSubcategoryComboBoxItemColectionByChoosenCategory(View.Child_Forms.AddRecipeForm addRecipeForm)
        {
            if (addRecipeForm.comboBoxCategory.Texts == "Salads and toppings")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                addRecipeForm.comboBoxSubcategory.Items.AddRange(new object[] { "With vegetables", "With meat", "With fish and seafood" });
            }
            else if (addRecipeForm.comboBoxCategory.Texts == "Starters")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                addRecipeForm.comboBoxSubcategory.Items.AddRange(new object[] { "Warm", "Cold" });
            }
            else if (addRecipeForm.comboBoxCategory.Texts == "Soups")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                addRecipeForm.comboBoxSubcategory.Items.AddRange(new object[] { "With meet", "Without meet" });
            }
            else if (addRecipeForm.comboBoxCategory.Texts == "Dish")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                addRecipeForm.comboBoxSubcategory.Items.AddRange(new object[] { "Without meet", "With meet", "With fish and seafood", "With eggs" });
            }
            else if (addRecipeForm.comboBoxCategory.Texts == "Pasta and pizza")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                addRecipeForm.comboBoxSubcategory.Items.AddRange(new object[] { "None" });
            }
            else if (addRecipeForm.comboBoxCategory.Texts == "Batter products")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                addRecipeForm.comboBoxSubcategory.Items.AddRange(new object[] { "None" });
            }
            else if (addRecipeForm.comboBoxCategory.Texts == "Desserts")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                addRecipeForm.comboBoxSubcategory.Items.AddRange(new object[] { "None" });
            }
            else if (addRecipeForm.comboBoxCategory.Texts == "Category")
            {
                addRecipeForm.comboBoxSubcategory.Items.Clear();
                MessageBox.Show("First need to add main category", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void ClearFields(View.Child_Forms.AddRecipeForm addRecipeForm)
        {
            addRecipeForm.textBoxRecipeTitle.Texts = null;
            addRecipeForm.textBoxNecessaryProducts.Texts = null;
            addRecipeForm.textBoxShortDescription.Texts = null;
            addRecipeForm.textBoxMethodOfPreparation.Texts = null;
            addRecipeForm.textBoxCookingTime.Texts = null;
            addRecipeForm.textBoxPreparationTime.Texts = null;
            addRecipeForm.textBoxPortions.Texts = null;
        }

        public static void AddPhotoButtonLogic(View.Child_Forms.AddRecipeForm addRecipeForm)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo((*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                addRecipeForm.pictureBoxRecipeImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// Check that info from custommer is valide
        /// </summary>
        /// <returns>true if there is no mistakes and false if there is mistakes</returns>
        public static bool CheckEnteredInfo(View.Child_Forms.AddRecipeForm addRecipeForm)
        {
            bool isOK = true;
            if (CountWords(addRecipeForm.textBoxRecipeTitle.Texts) > 6 || Regex.IsMatch(addRecipeForm.textBoxRecipeTitle.Texts, @"^[a-z][A-Z]+$")
                || addRecipeForm.textBoxRecipeTitle.Texts.Trim().Length == 0)
            {
                errorList.Add("textBoxRecipeTitle");
                isOK = false;
            }
            if (CountWords(addRecipeForm.textBoxShortDescription.Texts) > 25)
            {
                errorList.Add("textBoxShortDescription");
                isOK = false;
            }
            if (!Regex.IsMatch(addRecipeForm.textBoxPreparationTime.Texts, @"^[0-9]+$") || addRecipeForm.textBoxPreparationTime.Texts.Trim().Length == 0)
            {
                errorList.Add("textBoxPreparationTime");
                isOK = false;
            }
            if (!Regex.IsMatch(addRecipeForm.textBoxCookingTime.Texts, @"^[0-9]+$") || addRecipeForm.textBoxCookingTime.Texts.Trim().Length == 0)
            {
                errorList.Add("textBoxCookingTime");
                isOK = false;
            }
            if (!Regex.IsMatch(addRecipeForm.textBoxPortions.Texts, @"^[0-9]+$") || addRecipeForm.textBoxPortions.Texts.Trim().Length == 0)
            {
                errorList.Add("textBoxPortions");
                isOK = false;
            }
            if (CountWords(addRecipeForm.textBoxNecessaryProducts.Texts) > 200 || addRecipeForm.textBoxNecessaryProducts.Texts.Trim().Length == 0)
            {
                errorList.Add("textBoxNecessaryProducts");
                isOK = false;
            }
            if (CountWords(addRecipeForm.textBoxMethodOfPreparation.Texts) > 500 || addRecipeForm.textBoxMethodOfPreparation.Texts.Trim().Length == 0)
            {
                errorList.Add("textBoxMethodOfPreparation");
                isOK = false;
            }
            return isOK;
        }

        private static int CountWords(string txtToCount)
        {
            string pattern = "\\w+";
            Regex regex = new Regex(pattern);

            int countedWords = regex.Matches(txtToCount).Count;

            return countedWords;
        }

        /// <summary>
        /// Shows the customer which fields to fill in are wrong
        /// </summary>
        private static void ShowIfInputIsNotValide(View.Child_Forms.AddRecipeForm addRecipeForm)
        {
            Color changingColor = Color.Red;

            //Check if theme color is red
            if (ThemeColor.primaryColor == ColorTranslator.FromHtml("#EA676C") || ThemeColor.primaryColor == ColorTranslator.FromHtml("#EA4833") ||
                ThemeColor.primaryColor == ColorTranslator.FromHtml("#E41A4A") || ThemeColor.primaryColor == ColorTranslator.FromHtml("#B71C46")
                || ThemeColor.primaryColor == ColorTranslator.FromHtml("#721D47"))
            {
                changingColor = Color.RoyalBlue;
            }

            foreach (string error in errorList)
            {
                switch (error)
                {
                    case "textBoxRecipeTitle":
                        addRecipeForm.textBoxRecipeTitle.BorderColor = changingColor;
                        addRecipeForm.labelRecipeTitle.ForeColor = changingColor;
                        break;
                    case "textBoxShortDescription":
                        addRecipeForm.textBoxShortDescription.BorderColor = changingColor;
                        addRecipeForm.labelShortDescription.ForeColor = changingColor;
                        break;
                    case "textBoxPreparationTime":
                        addRecipeForm.labelPreparationTime.ForeColor = changingColor;
                        addRecipeForm.labelPreparationTimeCOndition.ForeColor = changingColor;
                        addRecipeForm.textBoxPreparationTime.BorderColor = changingColor;
                        break;
                    case "textBoxCookingTime":
                        addRecipeForm.labelCookingTimeCondition.ForeColor = changingColor;
                        addRecipeForm.lableCookingTime.ForeColor = changingColor;
                        addRecipeForm.textBoxCookingTime.BorderColor = changingColor;
                        break;
                    case "textBoxPortions":
                        addRecipeForm.labelPortionsCondition.ForeColor = changingColor;
                        addRecipeForm.lablePortions.ForeColor = changingColor;
                        addRecipeForm.textBoxPortions.BorderColor = changingColor;
                        break;
                    case "textBoxNecessaryProducts":
                        addRecipeForm.labelNecessaryProducts.ForeColor = changingColor;
                        addRecipeForm.textBoxNecessaryProducts.BorderColor = changingColor;
                        break;
                    case "textBoxMethodOfPreparation":
                        addRecipeForm.textBoxMethodOfPreparation.BorderColor = changingColor;
                        addRecipeForm.labelMethodOfPreparation.ForeColor = changingColor;
                        break;
                }
            }

        }

        public static void AddRecipe(View.Child_Forms.AddRecipeForm addRecipeForm)
        {
            if (Controller.FormsMethods.AddRecipexFormLogic.CheckEnteredInfo(addRecipeForm) == false)
            {
                ShowIfInputIsNotValide(addRecipeForm);
            }
            else
            {
                //get photo from picture box
                MemoryStream memoryStream = new MemoryStream();
                addRecipeForm.pictureBoxRecipeImage.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] image = memoryStream.ToArray();

                string shortDescriotion = addRecipeForm.textBoxShortDescription.Texts.Trim();
                //chek if Short Description text box is empty
                if (addRecipeForm.textBoxShortDescription.Texts.Trim().Length == 0)
                {
                    shortDescriotion = "NULL";
                }

                Recipe recipe = new Recipe(Controller.FormsMethods.LogInFormLogic.Username, addRecipeForm.textBoxRecipeTitle.Texts.Trim(), shortDescriotion,
                                           addRecipeForm.textBoxNecessaryProducts.Texts, addRecipeForm.textBoxMethodOfPreparation.Texts, addRecipeForm.comboBoxCategory.Texts,
                                           int.Parse(addRecipeForm.textBoxPreparationTime.Texts), int.Parse(addRecipeForm.textBoxCookingTime.Texts),
                                           addRecipeForm.comboBoxSubcategory.Texts, int.Parse(addRecipeForm.textBoxPortions.Texts), addRecipeForm.comboBoxDegreeOfDifficulty.Texts, image);

                DB_Connection.InsertRecipe(recipe);
            }
        }
    }
}