using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EatMeUp.Model.Tests
{
    [TestClass()]
    public class DB_ConnectionTests
    {
        [TestMethod()]
        public void TestGettAllRecipesFromDBMethod()
        {
            List<Recipe> recipes = DB_Connection.GetAllRecipes();

            Assert.IsNotNull(recipes);
        }

        [TestMethod()]
        public void TestSearchingInDBRecipeByTitle()
        {
            List<Recipe> recipes = DB_Connection.GetAllRecipesContainsInThereTitleString("R");

            bool isOk = true;
            foreach (Recipe recipe in recipes)
            {
                if (!recipe.RecipeTitle.Contains("R"))
                {
                    isOk = false;
                }
            }

            Assert.IsTrue(isOk);
        }

        [TestMethod()]
        public void TestSortingRecipesByCategory()
        {
            List<Recipe> recipes = DB_Connection.GetRecipesSortedByCatagory("With meat");

            bool isOk = true;
            foreach (Recipe recipe in recipes)
            {
                if (recipe.Category != "With meat")
                {
                    isOk = false;
                }
            }

            Assert.IsTrue(isOk);
        }

        [TestMethod()]
        public void TestMethodThatRerurnUsernamesAndPasswords()
        {
            Dictionary<string, string> accounts = DB_Connection.GetCreatedAccounts();

            string actualCreatorPassword = accounts.GetValueOrDefault("Creator");
            string expectedCreatorPassword = "komatewo";

            Assert.AreEqual(actualCreatorPassword, expectedCreatorPassword);
        }
    }
}