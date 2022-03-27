using EatMeUp.Model;

namespace EatMeUp.View.ChildForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.LoadRegisterFormTheme(this);
        }

        #region Click events

        private void iconButtonFastFood_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void iconButtonSalad_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void iconButtonMeet_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void iconButtonSoup_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void iconButtonSeafood_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void iconButtonFruits_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void iconButtonDesserts_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void iconButtonOther_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.MarkFavouriteFood(this, sender);
        }

        private void buttonAddFhoto_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.CoosePhotoFromPC(this);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.RegisterFormLogic.ClearAllData(this);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.FormsMethods.RegisterFormLogic.CheckAllData(this);
                Custommer custommer = Controller.FormsMethods.RegisterFormLogic.CreateCustommerAccount(this);
                DB_Connection.AddCustommer(custommer);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("You have empty fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Toggle buttons events

        private void toggleButtonMale_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonMale.Checked)
            {
                this.toggleButtonFemale.Checked = false;
            }
            else this.toggleButtonFemale.Checked = true;
        }

        private void toggleButtonFemale_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonFemale.Checked)
            {
                this.toggleButtonMale.Checked = false;
            }
            else this.toggleButtonMale.Checked = true;
        }

        #endregion
    }
}
