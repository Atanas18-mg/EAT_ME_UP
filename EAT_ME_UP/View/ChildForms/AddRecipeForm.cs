namespace EatMeUp.View.Child_Forms
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm()
        {
            InitializeComponent();
        }
        private void LoadThem()
        {
            Controller.FormsMethods.AddRecipexFormLogic.LoadColorTheme(this);
        }

        //Load Color theme
        private void AddRecipeForm_Load(object sender, EventArgs e)
        {
            LoadThem();
        }

        //Logic of Combo boxes
        private void comboBoxSubcategory_Enter(object sender, EventArgs e)
        {
            Controller.FormsMethods.AddRecipexFormLogic.SetFormSubcategoryComboBoxItemColectionByChoosenCategory(this);
        }

        #region Buttons Clicl events

        //clear all Tex Boxes
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.AddRecipexFormLogic.ClearFields(this);
        }

        //browse photo from your computer
        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.AddRecipexFormLogic.AddPhotoButtonLogic(this);
        }

        //connect to DB and add recipe
        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.AddRecipexFormLogic.AddRecipe(this);
        }

        #endregion
    }
}