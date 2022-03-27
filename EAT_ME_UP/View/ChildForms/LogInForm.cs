namespace EatMeUp.View.Child_Forms
{
    public partial class LogIn_Register_Form : Form
    {
        public LogIn_Register_Form()
        {
            InitializeComponent();
        }

        private void LogIn_Register_Form_Load(object sender, EventArgs e)
        {
            Controller.FormsMethods.LogInFormLogic.LoadTheme(this);
        }

        private void checkBoxShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = false;
            }
            else
            {
                textBoxPassword.PasswordChar = true;
            }
        }

        #region Buttons Click Events

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.LogInFormLogic.Clear(this);
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Controller.FormsMethods.LogInFormLogic.LogIn(this);

        }

        #endregion
    }
}