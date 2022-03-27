namespace EatMeUp.Model
{
    public class Recipe
    {
        private string userName = String.Empty;
        private string recipeTitle = String.Empty;
        private string shotDescription = String.Empty;
        private string necessaryProducts = String.Empty;
        private string methodOfPreparation = String.Empty;
        private string category = String.Empty;
        private string subcategory = String.Empty;
        private int preparationTime;
        private int cookingTime;
        private int portions;
        private string degreeOfDifficulty = String.Empty;
        private byte[] image = Array.Empty<byte>();

        public Recipe(string userName, string recipeTitle, string shotDescription, string necessaryProducts, string methodOfPreparation, string category,
                     int preparationTime, int cookingTime, string subcategoty, int portions, string degreeOfDifficulty, byte[] image)
        {
            this.RecipeTitle = recipeTitle;
            this.ShotDescription = shotDescription;
            this.NecessaryProducts = necessaryProducts;
            this.MethodOfPreparation = methodOfPreparation;
            this.Category = category;
            this.PreparationTime = preparationTime;
            this.CookingTime = cookingTime;
            this.Subcategory = subcategoty;
            this.Portions = portions;
            this.DegreeOfDifficulty = degreeOfDifficulty;
            this.Image = image;
            this.UserName = userName;
        }

        public string UserName { get => userName; set => userName = value; }
        public string RecipeTitle { get => recipeTitle; set => recipeTitle = value; }
        public string ShotDescription { get => shotDescription; set => shotDescription = value; }
        public string NecessaryProducts { get => necessaryProducts; set => necessaryProducts = value; }
        public string MethodOfPreparation { get => methodOfPreparation; set => methodOfPreparation = value; }
        public string Category { get => category; set => category = value; }
        public string Subcategory { get => subcategory; set => subcategory = value; }
        public int PreparationTime { get => preparationTime; set => preparationTime = value; }
        public int CookingTime { get => cookingTime; set => cookingTime = value; }
        public int Portions { get => portions; set => portions = value; }
        public string DegreeOfDifficulty { get => degreeOfDifficulty; set => degreeOfDifficulty = value; }
        public byte[] Image { get => image; set => image = value; }
    }
}