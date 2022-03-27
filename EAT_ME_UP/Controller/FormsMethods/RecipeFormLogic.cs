using EatMeUp.View.Classes_for_Interface;
using FontAwesome.Sharp;
using EatMeUp.Model;
using EatMeUp.View.CustomControl;

namespace EatMeUp.Controller.FormsMethods
{
    public static class RecipeFormLogic
    {
        /// <summary>
        /// Hold info of button that is marked
        /// </summary>
        public static IconButton currentButton { get; set; }

        public static void HideSubMenu(View.Child_Forms.RecipesForm recipesForm)
        {
            if (recipesForm.panelDishSubcategory.Visible == true)
            {
                recipesForm.panelDishSubcategory.Visible = false;
            }

            if (recipesForm.panelSaladsSubcategory.Visible == true)
            {
                recipesForm.panelSaladsSubcategory.Visible = false;
            }

            if (recipesForm.panelSoupsSubcategory.Visible == true)
            {
                recipesForm.panelSoupsSubcategory.Visible = false;
            }

            if (recipesForm.panelStartersSubcategory.Visible == true)
            {
                recipesForm.panelStartersSubcategory.Visible = false;
            }

            UncheckAllToggleButtons(recipesForm);
        }

        public static void UncheckAllToggleButtons(View.Child_Forms.RecipesForm recipesForm)
        {
            foreach (Panel panel in recipesForm.panelSaladsSubcategory.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJToggleButton))
                    {
                        RJCodeAdvance.RJControls.RJToggleButton toggleButton = (RJCodeAdvance.RJControls.RJToggleButton)control;
                        toggleButton.Checked = false;
                    }
                }
            }

            foreach (Panel panel in recipesForm.panelDishSubcategory.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJToggleButton))
                    {
                        RJCodeAdvance.RJControls.RJToggleButton toggleButton = (RJCodeAdvance.RJControls.RJToggleButton)control;
                        toggleButton.Checked = false;
                    }
                }
            }

            foreach (Panel panel in recipesForm.panelSoupsSubcategory.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJToggleButton))
                    {
                        RJCodeAdvance.RJControls.RJToggleButton toggleButton = (RJCodeAdvance.RJControls.RJToggleButton)control;
                        toggleButton.Checked = false;
                    }
                }
            }

            foreach (Panel panel in recipesForm.panelStartersSubcategory.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control.GetType() == typeof(RJCodeAdvance.RJControls.RJToggleButton))
                    {
                        RJCodeAdvance.RJControls.RJToggleButton toggleButton = (RJCodeAdvance.RJControls.RJToggleButton)control;
                        toggleButton.Checked = false;
                    }
                }
            }
        }

        public static void ShowSubMenu(View.Child_Forms.RecipesForm recipesForm, Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(recipesForm);
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        /// <summary>
        /// Mark button of Category list
        /// </summary>
        /// <param name="recipesForm"></param>
        /// <param name="btnSender"></param>
        public static void ActivateButton(View.Child_Forms.RecipesForm recipesForm, object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableIconButton(recipesForm);
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = ThemeColor.primaryColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13F,
                                             System.Drawing.FontStyle.Regular,
                                             System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        /// <summary>
        /// Unmark button of Category list
        /// </summary>
        /// <param name="recipesForm"></param>
        public static void DisableIconButton(View.Child_Forms.RecipesForm recipesForm)
        {
            foreach (Control previousButton in recipesForm.panelCategoryBar.Controls)
            {
                if (previousButton.GetType() == typeof(IconButton))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 10F,
                                             System.Drawing.FontStyle.Regular,
                                             System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        public static void LoadRecipes(View.Child_Forms.RecipesForm recipesForm, List<Recipe> recipes)
        {
            RecipeItem[] ListItems = new RecipeItem[recipes.Count];

            for (int i = 0; i < recipes.Count; i++)
            {
                //Upload date to custom control
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

                recipesForm.flowLayoutPanelRecipes.Controls.Add(ListItems[i]);

                //Assign this UserControl click event
                ListItems[i].Click += new System.EventHandler(UserControlClick);
            }

            //Code custom control click event
            void UserControlClick(object sender, EventArgs e)
            {
                RecipeItem recipeItem = (RecipeItem)sender;

                //Set data
                recipesForm.richTextBoxMethod.Text = recipeItem.MethodOfPreparation;
                recipesForm.richTextBoxProducts.Text = recipeItem.Products;
                recipesForm.labelRecipeTitle.Text = recipeItem.Title;

                ShowPanel(recipesForm);
            }
        }

        public static void ShowPanel(View.Child_Forms.RecipesForm recipesForm)
        {
            recipesForm.panelRecipeInfo.Visible = true;

            //Set colors
            recipesForm.buttonOK.BackColor = ThemeColor.primaryColor;
            recipesForm.buttonOpenWindow.BackColor = ThemeColor.primaryColor;
            recipesForm.labelRecipeTitle.ForeColor = ThemeColor.secondaryColor;
            recipesForm.labelProducts.ForeColor = ThemeColor.secondaryColor;
            recipesForm.labelMethodOfPreparation.ForeColor = ThemeColor.secondaryColor;
            recipesForm.richTextBoxMethod.ForeColor = ThemeColor.secondaryColor;
            recipesForm.richTextBoxProducts.ForeColor = ThemeColor.secondaryColor;
        }

        public static void HidePanel(View.Child_Forms.RecipesForm recipesForm)
        {
            recipesForm.panelRecipeInfo.Visible = false;
        }

        /// <summary>
        /// Check if user has selected subcategoty
        /// </summary>
        /// <param name="recipesForm"></param>
        /// <param name="category">shows the category in which the method will search for</param>
        /// <returns>if user did not select subcategory returns empty string else return string with subcategory</returns>
        public static string TakeSubcategorySetByrUser(View.Child_Forms.RecipesForm recipesForm, string category)
        {
            switch (category)
            {
                case "Salads and toppings":
                    if (recipesForm.toggleButtonSaladsWithVegetables.Checked) return recipesForm.labelSaladsWithVegetables.Text;
                    if (recipesForm.toggleButtonSaladsWithMeat.Checked) return recipesForm.labelSaladsWithMeat.Text;
                    if (recipesForm.toggleButtonSaladsWithFishAndSeafood.Checked) return recipesForm.labelSaladsFish.Text;
                    return String.Empty;
                case "Starters":
                    if (recipesForm.toggleButtonStartersCold.Checked) return recipesForm.labelStartersCold.Text;
                    if (recipesForm.toggleButtonStartersWarm.Checked) return recipesForm.labelStartersWarm.Text;
                    return String.Empty;
                case "Soups":
                    if (recipesForm.toggleButtonSoupsWithMeat.Checked) return recipesForm.labelSoupsWithMeat.Text;
                    if (recipesForm.toggleButtonSoupsWithoutMeat.Checked) return recipesForm.labelSoupsWithoutMeat.Text;
                    return String.Empty;
                case "Dish":
                    if (recipesForm.toggleButtonDishWhitEggs.Checked) return recipesForm.labelDishEggs.Text;
                    if (recipesForm.toggleButtonDishWithFish.Checked) return recipesForm.labelDishFish.Text;
                    if (recipesForm.toggleButtonDishWithMeat.Checked) return recipesForm.labelDishWithMeet.Text;
                    if (recipesForm.toggleButtonDishWithoutMeat.Checked) return recipesForm.labelDishWithoutMeet.Text;
                    return String.Empty;
            }
            return String.Empty;
        }

        public static void LoadTheme(View.Child_Forms.RecipesForm recipesForm)
        {
            recipesForm.textBoxSearchString.BorderColor = ThemeColor.secondaryColor;
            recipesForm.labelSearchInfo.ForeColor = ThemeColor.secondaryColor;
            recipesForm.IconButtonSearch.BackColor = ThemeColor.secondaryColor;
        }
    }
}