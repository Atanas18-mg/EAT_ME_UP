using System.ComponentModel;

namespace EatMeUp.View.CustomControl
{
    public partial class RecipeItem : UserControl
    {
        public RecipeItem()
        {
            InitializeComponent();
        }

        #region Properties

        private Image _image;
        private string _title;
        private string _description;
        private string _preparationTime;
        private string _cookingTime;
        private string _difficulty;
        private string _portions;
        private Color _themeColor;
        private string _Products;
        private string _MethodOfPreparation;

        [Category("Properties(custom)")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBoxCustommerImage.Image = value; }
        }

        [Category("Properties(custom)")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelTItle.Text = value; }
        }

        [Category("Properties(custom)")]
        public string Description
        {
            get { return _description; }
            set { _description = value; labelShortDiscription.Text = value; }
        }

        [Category("Properties(custom)")]
        public string PreparationTime
        {
            get { return _preparationTime; }
            set { _preparationTime = value; labelPreparationTime.Text = value; }
        }

        [Category("Properties(custom)")]
        public string CookingTime
        {
            get { return _cookingTime; }
            set { _cookingTime = value; labelCookingTime.Text = value; }
        }

        [Category("Properties(custom)")]
        public string Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; labelDifficulty.Text = value; }
        }

        [Category("Properties(custom)")]
        public string Portions
        {
            get { return _portions; }
            set { _portions = value; labelPortions.Text = value; }
        }

        [Category("Properties(custom)")]
        public Color ThemeColor
        {
            get { return _themeColor; }
            set
            {
                _themeColor = value;
                panelImage.BackColor = value;

                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(Label))
                    {
                        Label label = (Label)control;
                        label.ForeColor = value;
                    }
                    if (control.GetType() == typeof(FontAwesome.Sharp.IconPictureBox))
                    {
                        FontAwesome.Sharp.IconPictureBox pictureBox = (FontAwesome.Sharp.IconPictureBox)control;
                        pictureBox.IconColor = value;
                    }
                }
            }
        }

        [Category("Properties(custom)")]
        public string Products
        {
            get { return _Products; }
            set { _Products = value; }
        }

        [Category("Properties(custom)")]
        public string MethodOfPreparation
        {
            get { return _MethodOfPreparation; }
            set { _MethodOfPreparation = value; }
        }

        #endregion

        #region Hover Effect

        #region Mouse Hover Evvents

        private void RecipeItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelShortDiscription_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelTItle_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelPreparationTime_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelDifficulty_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelPortions_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelCookingTime_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void iconPictureBoxCLock_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void iconPictureBoxInfo_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void pictureBoxCustommerImage_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void panelImage_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        #endregion

        #region Mouse leave events

        private void RecipeItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void labelTItle_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void labelShortDiscription_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void labelPreparationTime_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void labelDifficulty_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void labelPortions_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void labelCookingTime_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void iconPictureBoxCLock_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void iconPictureBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxCustommerImage_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }

        private void panelImage_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxCLock.BackColor = Color.WhiteSmoke;
            this.iconPictureBoxInfo.BackColor = Color.WhiteSmoke;
        }
        #endregion

        #region Mouse Enter Events

        private void RecipeItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelTItle_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelShortDiscription_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelPreparationTime_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelDifficulty_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelPortions_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void iconPictureBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void labelCookingTime_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void iconPictureBoxCLock_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void pictureBoxCustommerImage_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        private void panelImage_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.iconPictureBoxCLock.BackColor = Color.LightGray;
            this.iconPictureBoxInfo.BackColor = Color.LightGray;
        }

        #endregion

        #endregion
    }
}
