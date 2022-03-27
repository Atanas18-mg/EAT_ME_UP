namespace EatMeUp.View.Classes_for_Interface
{
    public static class ThemeColor
    {
        public static Color primaryColor { get; set; }
        public static Color secondaryColor { get; set; }

        public static List<string> colorList = new List<string>()
        {
        "#3F51B5","#009688","#FF5722","#607D8B","#FF9800","#9C27B0","#2196F3","#EA676C","#E41A4A","#5978BB","#018790",
        "#0E3441","#00B0AD","#721D47","#EA4833", "#EF937E","#F37521", "#A12059", "#126881","#8BC240","#364D5B","#C7DC5B",
        "#0094BC","#E4126B", "#43B76E", "#7BCFE9", "#B71C46"
        };

        /// <summary>
        /// if correctionFactor < 0 -> color goes darker
        /// if correctionFactor > 0 -> color goes lighter
        /// </summary>
        /// <param name="color"></param>
        /// <param name="correctFactor"></param>
        /// <returns></returns>
        public static Color ChangeColorBrightness(Color color, double correctFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctFactor < 0)
            {
                correctFactor = 1 + correctFactor;
                red *= correctFactor;
                green *= correctFactor;
                blue *= correctFactor;
            }
            else
            {
                red = (255 - red) * correctFactor + red;
                green = (255 - green) * correctFactor + green;
                blue = (255 - blue) * correctFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
