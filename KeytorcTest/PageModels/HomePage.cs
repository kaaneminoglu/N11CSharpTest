using KeytorcTest.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeytorcTest.PageModels
{
    class HomePage
    {
        WebElementHelper webElement = new WebElementHelper();

        public void ClickLoginPage()
        {
            webElement.btnSignIn.Click();
        }

        public void SetSearchText(string searchText)
        {
            webElement.txtSearch.SendKeys(searchText);
            webElement.btnSearch.Click();
        }

        public void ClickWishListAndFavorite()
        {
            Actions action = new Actions(CurrentDriver.driver);
            action.MoveToElement(webElement.btnMyAccount).Perform();           
            webElement.btnWishListAndFavorite.Click();
            webElement.btnMyFavorites.Click();
        }
    }
}
