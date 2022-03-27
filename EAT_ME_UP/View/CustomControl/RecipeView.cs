namespace EatMeUp.View.CustomList
{
    public partial class RecipeView : Form
    {
        public RecipeView(string title, string necessaryProducts, string methodOfPreparation, Color themeColor)
        {
            InitializeComponent();

            //set data
            this.labelTitle.Text = title;
            this.richTextBoxProducts.Text = necessaryProducts;
            this.richTextBoxMethod.Text = methodOfPreparation;

            //upload color theme
            this.panelTitleBar.BackColor = themeColor;
            this.labelInfoMethod.ForeColor = themeColor;
            this.labelInfoProducts.ForeColor = themeColor;
            this.richTextBoxMethod.ForeColor = themeColor;
            this.richTextBoxProducts.ForeColor = themeColor;
        }
    }
}