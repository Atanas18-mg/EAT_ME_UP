using EatMeUp.Model;
using EatMeUp.View.Classes_for_Interface;
using EatMeUp.View.CustomList;

namespace EatMeUp.View.Child_Forms
{
    public partial class RecipesForm : Form
    {
        public RecipesForm()
        {
            InitializeComponent();
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            List<Recipe> recipes = DB_Connection.GetAllRecipes();
            Controller.FormsMethods.RecipeFormLogic.LoadRecipes(this, recipes);
            Controller.FormsMethods.RecipeFormLogic.LoadTheme(this);
        }

        #region Category buttons click events

        private void iconButtonSalads_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.ActivateButton(this, sender);
            Controller.FormsMethods.RecipeFormLogic.ShowSubMenu(this, panelSaladsSubcategory);
        }

        private void iconButtonStarters_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.ActivateButton(this, sender);
            Controller.FormsMethods.RecipeFormLogic.ShowSubMenu(this, panelStartersSubcategory);
        }

        private void iconButtonSoups_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.ActivateButton(this, sender);
            Controller.FormsMethods.RecipeFormLogic.ShowSubMenu(this, panelSoupsSubcategory);
        }

        private void iconButtonDish_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.ActivateButton(this, sender);
            Controller.FormsMethods.RecipeFormLogic.ShowSubMenu(this, panelDishSubcategory);
        }

        private void iconButtonPastaAndPizza_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.ActivateButton(this, sender);
        }

        private void iconButtonBatterProducts_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.ActivateButton(this, sender);
        }

        private void iconButtonDessetrs_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.ActivateButton(this, sender);
        }

        #endregion

        #region Category toggle buttons events
        //toggle buttons Salads
        private void toggleButtonSaladsWithVegetables_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonSaladsWithVegetables.Checked)
            {
                this.toggleButtonSaladsWithMeat.Checked = false;
                this.toggleButtonSaladsWithFishAndSeafood.Checked = false;
            }
        }

        private void toggleButtonSaladsWithMeat_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonSaladsWithMeat.Checked)
            {
                this.toggleButtonSaladsWithVegetables.Checked = false;
                this.toggleButtonSaladsWithFishAndSeafood.Checked = false;
            }
        }

        private void toggleButtonSaladsWithFishAndSeafood_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonSaladsWithFishAndSeafood.Checked)
            {
                this.toggleButtonSaladsWithVegetables.Checked = false;
                this.toggleButtonSaladsWithMeat.Checked = false;
            }
        }

        //toggle buttons Starters
        private void toggleButtonStartersWarm_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonStartersWarm.Checked)
            {
                this.toggleButtonStartersCold.Checked = false;
            }
        }

        private void toggleButtonStartersCold_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonStartersCold.Checked)
            {
                this.toggleButtonStartersWarm.Checked = false;
            }
        }

        //toggle buttons Soups
        private void toggleButtonSoupsWithMeat_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonSoupsWithMeat.Checked)
            {
                this.toggleButtonSoupsWithoutMeat.Checked = false;
            }
        }

        private void toggleButtonSoupsWithoutMeat_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonSoupsWithoutMeat.Checked)
            {
                this.toggleButtonSoupsWithMeat.Checked = false;
            }
        }

        //toggle buttons Dishes
        private void toggleButtonDishWithMeat_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonDishWithMeat.Checked)
            {
                this.toggleButtonDishWithoutMeat.Checked = false;
                this.toggleButtonDishWhitEggs.Checked = false;
                this.toggleButtonDishWithFish.Checked = false;
            }
        }

        private void toggleButtonDishWithoutMeat_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonDishWithoutMeat.Checked)
            {
                this.toggleButtonDishWithMeat.Checked = false;
                this.toggleButtonDishWhitEggs.Checked = false;
                this.toggleButtonDishWithFish.Checked = false;
            }
        }

        private void toggleButtonDishWithFish_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonDishWithFish.Checked)
            {
                this.toggleButtonDishWithMeat.Checked = false;
                this.toggleButtonDishWhitEggs.Checked = false;
                this.toggleButtonDishWithoutMeat.Checked = false;
            }
        }

        private void toggleButtonDishWhitEggs_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonDishWhitEggs.Checked)
            {
                this.toggleButtonDishWithMeat.Checked = false;
                this.toggleButtonDishWithFish.Checked = false;
                this.toggleButtonDishWithoutMeat.Checked = false;
            }
        }

        #endregion

        #region Buttons click events

        private void IconButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxSearchString.Texts))
            {
                flowLayoutPanelRecipes.Controls.Clear();
                List<Recipe> recipes = DB_Connection.GetAllRecipesContainsInThereTitleString(this.textBoxSearchString.Texts.Trim());
                Controller.FormsMethods.RecipeFormLogic.LoadRecipes(this, recipes);
            }
        }

        private void buttonApply_Click_1(object sender, EventArgs e)
        {
            if (Controller.FormsMethods.RecipeFormLogic.currentButton != null)
            {
                string category = Controller.FormsMethods.RecipeFormLogic.currentButton.Text;
                if (Controller.FormsMethods.RecipeFormLogic.TakeSubcategorySetByrUser(this, category) == String.Empty)
                {
                    flowLayoutPanelRecipes.Controls.Clear();
                    List<Recipe> recipes = DB_Connection.GetRecipesSortedByCatagory(category);
                    Controller.FormsMethods.RecipeFormLogic.LoadRecipes(this, recipes);
                }
                else
                {
                    flowLayoutPanelRecipes.Controls.Clear();
                    string subcategory = Controller.FormsMethods.RecipeFormLogic.TakeSubcategorySetByrUser(this, category);
                    List<Recipe> recipes = DB_Connection.GetRecipesSortedByCatagoryAndSubcategory(category, subcategory);
                    Controller.FormsMethods.RecipeFormLogic.LoadRecipes(this, recipes);
                }

            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RecipeFormLogic.HidePanel(this);
        }

        private void buttonOpenWindow_Click(object sender, EventArgs e)
        {
            RecipeView recipeView = new RecipeView(this.labelRecipeTitle.Text, richTextBoxProducts.Text, richTextBoxMethod.Text, ThemeColor.secondaryColor);
            recipeView.Show();
        }

        #endregion
    }
}