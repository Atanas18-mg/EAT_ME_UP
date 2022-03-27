namespace EatMeUp.View.ChildForms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            Controller.FormsMethods.ProfileFormLogic.LoadData(this);
            Controller.FormsMethods.ProfileFormLogic.LoadThemeColor(this);
        }

        #region Buttons click events

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.ProfileFormLogic.HidePanel(this);
        }

        private void buttonDeleteRecipe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delte this recipe?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Controller.FormsMethods.ProfileFormLogic.DelteRecipe(this);
                Controller.FormsMethods.ProfileFormLogic.HidePanel(this);
                Controller.FormsMethods.ProfileFormLogic.LoadData(this);
            }
        }

        #endregion
    }
}

