using EatMeUp.Model;
using EatMeUp.View.Classes_for_Interface;
using EatMeUp.View.CustomControl;

namespace EatMeUp.Controller.FormsMethods
{
    public static class ProfileFormLogic
    {
        public static void LoadData(View.ChildForms.ProfileForm profileForm)
        {
            //Load Item list
            List<Recipe> recipes = DB_Connection.GetAllRecipiesFromAccount(LogInFormLogic.Username);

            RecipeItem[] ListItems = new RecipeItem[recipes.Count];

            for (int i = 0; i < recipes.Count; i++)
            {
                //Set data
                ListItems[i] = new RecipeItem();
                ListItems[i].Title = recipes[i].RecipeTitle;
                if (recipes[i].ShotDescription == String.Empty)
                {
                    ListItems[i].Description = "There is no description";
                }
                else ListItems[i].Description = recipes[i].ShotDescription;
                ListItems[i].PreparationTime = $"Preparation time: {recipes[i].PreparationTime}";
                ListItems[i].CookingTime = $"Cooking time: {recipes[i].CookingTime}";
                ListItems[i].Difficulty = $"Difficulty: {recipes[i].DegreeOfDifficulty}";
                ListItems[i].Portions = $"Portions {recipes[i].Portions}";

                ListItems[i].Products = recipes[i].NecessaryProducts;
                ListItems[i].MethodOfPreparation = recipes[i].MethodOfPreparation;

                if (recipes[i].Image.Length != 0)
                {
                    string image64 = Convert.ToBase64String(recipes[i].Image);
                    ListItems[i].Image = DB_Connection.ConvertBase64ToImage(image64);
                }

                //Set Color Theme
                ListItems[i].ThemeColor = ThemeColor.secondaryColor;

                profileForm.flowLayoutPanelList.Controls.Add(ListItems[i]);

                //Assign this UserControl click event
                ListItems[i].Click += new System.EventHandler(UserControlClick);
            }

            void UserControlClick(object sender, EventArgs e)
            {
                RecipeItem recipeItem = (RecipeItem)sender;

                profileForm.richTextBoxProducts.Text = recipeItem.Products;
                profileForm.richTextBoxMethodPreparation.Text = recipeItem.MethodOfPreparation;
                ShowPanel(profileForm);
            }

            //Load text
            if (recipes.Count > 0)
            {
                profileForm.labelInfoForRecipes.Text = "These are all your recipes:";
            }

            //Load custommer data
            Custommer custommer = DB_Connection.GetCustommerInfo(LogInFormLogic.Username);

            if (custommer.Image.Length != 0)
            {
                string image64 = Convert.ToBase64String(custommer.Image);
                profileForm.pictureBoxCustommerImage.Image = DB_Connection.ConvertBase64ToImage(image64);
            }
            profileForm.labelWelcome.Text = $"Welcome, {custommer.Username}";
            profileForm.labelUsername.Text = custommer.Username;
            profileForm.labelFirstName.Text = $"First name: {custommer.FirstName}";
            profileForm.labelLastName.Text = $"Last name: {custommer.LastName}";
        }

        public static void ShowPanel(View.ChildForms.ProfileForm profileForm)
        {
            profileForm.panelRecipeInfo.Visible = true;
            profileForm.buttonOK.BackColor = ThemeColor.secondaryColor;
            profileForm.buttonDeleteRecipe.BackColor = ThemeColor.secondaryColor;
        }

        public static void HidePanel(View.ChildForms.ProfileForm profileForm)
        {
            profileForm.panelRecipeInfo.Visible = false;
        }

        public static void LoadThemeColor(View.ChildForms.ProfileForm profileForm)
        {
            foreach (Control control in profileForm.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label label = (Label)control;
                    label.ForeColor = ThemeColor.secondaryColor;
                }
            }

            profileForm.tableLayoutPanelRecipeInfo.BackColor = ThemeColor.secondaryColor;
            profileForm.richTextBoxMethodPreparation.ForeColor = ThemeColor.secondaryColor;
            profileForm.richTextBoxProducts.ForeColor = ThemeColor.secondaryColor;
            profileForm.pictureBoxCustommerImage.BorderColor = ThemeColor.secondaryColor;
            profileForm.pictureBoxCustommerImage.BorderColor2 = ThemeColor.secondaryColor;
        }

        public static void DelteRecipe(View.ChildForms.ProfileForm profileForm)
        {
            DB_Connection.DeleteRecipe(profileForm.richTextBoxProducts.Text);
            DB_Connection.ResetTabelAutoIncrementId("recipe_info");
        }
    }
}
