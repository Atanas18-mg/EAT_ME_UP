using EatMeUp.View.Classes_for_Interface;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace EatMeUp
{
    public partial class MainMenuForm : Form
    {
        //Fields
        private IconButton currentIconButton;
        private Random random;
        private int themeIndex;
        private Form activeForm;

        public MainMenuForm()
        {
            InitializeComponent();
            random = new Random();

            //remove borders of the form
            this.Text = string.Empty;
            this.ControlBox = false;

            //
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoadTheme()
        {
            this.labelInfo.ForeColor = ThemeColor.secondaryColor;
            this.labelInfoCreator.BackColor = ThemeColor.secondaryColor;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        #region Methods
        public Color ChooseRandomThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);

            while (themeIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            themeIndex = index;
            string color = ThemeColor.colorList[themeIndex];

            return ColorTranslator.FromHtml(color);
        }

        public void ActivateIconButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentIconButton != (IconButton)btnSender)
                {
                    DisableIconButton();
                    Color color = ChooseRandomThemeColor();
                    currentIconButton = (IconButton)btnSender;
                    currentIconButton.BackColor = color;
                    currentIconButton.ForeColor = Color.White;
                    currentIconButton.Font = new System.Drawing.Font("Segoe UI", 13F,
                                             System.Drawing.FontStyle.Regular,
                                             System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogoBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.primaryColor = color;
                    ThemeColor.secondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        public void DisableIconButton()
        {
            foreach (Control previousButton in panelMenuBar.Controls)
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

        public void OpenChildForm(Form childForm, object btnSender, string textForTitle)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateIconButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDekstop.Controls.Add(childForm);
            this.panelDekstop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = textForTitle;
        }

        #endregion

        #region Controls click events

        private void iconButtonHomePage_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                ActivateIconButton(sender);
                panelDekstop.BringToFront();
                panelDekstop.Show();
                LoadTheme();
            }
        }

        private void iconButtonRecipes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Child_Forms.RecipesForm(), sender, "RECIPES");
        }

        private void iconButtonAddRecipe_Click(object sender, EventArgs e)
        {
            if (Controller.FormsMethods.LogInFormLogic.Username == null)
            {
                MessageBox.Show("Trump first to log in to access this page", "Info..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else OpenChildForm(new View.Child_Forms.AddRecipeForm(), sender, "ADD RECIPE");
        }

        private void iconButtonRegister_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new View.ChildForms.RegisterForm(), sender, "REGISTER");
        }

        private void iconButtonLogIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Child_Forms.LogIn_Register_Form(), sender, "LOG IN");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconPictureBoxMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void iconPictureBoxProfile_Click(object sender, EventArgs e)
        {
            if (Controller.FormsMethods.LogInFormLogic.Username == null)
            {
                MessageBox.Show("Trump first to log in to access this page", "Info..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DisableIconButton();
                Form childForm = new View.ChildForms.ProfileForm();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDekstop.Controls.Add(childForm);
                this.panelDekstop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                labelTitle.Text = "PROFILE";
            }
        }

        private void iconPictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region Controls mouse events

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBoxMinimize_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void iconPictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void iconPictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void iconPictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void iconPictureBoxProfile_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void iconPictureBoxProfile_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        #endregion
    }
}
