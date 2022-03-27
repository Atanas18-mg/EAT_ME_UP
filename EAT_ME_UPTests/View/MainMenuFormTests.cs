using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EatMeUp.Tests
{
    [TestClass()]
    public class MainMenuFormTests
    {
        [TestMethod()]
        public void ChooseRandomThemeColorTest()
        {
            MainMenuForm mainForm = new MainMenuForm();

            Color firstColor = mainForm.ChooseRandomThemeColor();
            Color secondColor = mainForm.ChooseRandomThemeColor();

            Assert.AreNotEqual(firstColor, secondColor);
        }

        [TestMethod()]
        public void TestButtonActivatesion()
        {
            MainMenuForm mainForm = new MainMenuForm();

            FontAwesome.Sharp.IconButton button = mainForm.iconButtonLogIn;
            mainForm.ActivateIconButton(button);
            bool isActivated = true;

            if (button.ForeColor != Color.White)
            {
                isActivated = false;
            }
            else if (button.Font.Size != 13F)
            {
                isActivated = false;
            }

            Assert.IsTrue(isActivated);
        }

        [TestMethod()]
        public void TestButtonDeactivatesion()
        {
            MainMenuForm mainForm = new MainMenuForm();

            FontAwesome.Sharp.IconButton button = mainForm.iconButtonLogIn;
            mainForm.ActivateIconButton(button);
            mainForm.DisableIconButton();
            bool isActivated = true;

            if (button.Font.Size != 10F)
            {
                isActivated = false;
            }

            Assert.IsTrue(isActivated);
        }
    }
}