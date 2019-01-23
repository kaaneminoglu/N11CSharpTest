using KeytorcTest.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeytorcTest.PageModels
{
    class SearchResultPage
    {
        WebElementHelper webElement = new WebElementHelper();
        string favoriteItemId;

        public bool CheckSearchResult()
        {
            if (webElement.txtSearchResult == null)
            {
                return false;
            }
            return webElement.txtSearchResult.Displayed;
        }

        public void ClickSecondPage()
        {
            WebDriverWait wait = new WebDriverWait(CurrentDriver.driver, TimeSpan.FromSeconds(10));
            wait.Until(x => webElement.btnSecondPage);
            webElement.btnSecondPage.Click();
        }

        public bool CheckCurrentPage(string currentPage)
        {
            WebDriverWait wait = new WebDriverWait(CurrentDriver.driver, TimeSpan.FromSeconds(10));
            wait.Until(x => webElement.txtCurrentPage);
            if (string.Equals(currentPage, webElement.txtCurrentPage.GetAttribute("value")))
            {
                return true;
            }
            else
            {
                ClickSecondPage();
            }
            return string.Equals(currentPage, webElement.txtCurrentPage.GetAttribute("value"));
        }

        public void AddFavorite()
        {
            WebDriverWait wait = new WebDriverWait(CurrentDriver.driver, TimeSpan.FromSeconds(10));
            wait.Until(x => webElement.txtAddFavoriteName);
            favoriteItemId = webElement.txtAddFavoriteName.GetAttribute("id");
            webElement.productId = favoriteItemId;
            webElement.btnAddFavorite.Click();
        }

        public bool CheckTrueFavoriteProduct()
        {
            Thread.Sleep(3000);
            try
            {
                return webElement.txtMyFavoriteItem.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void DeleteFavoriteProduct()
        {
            webElement.btnDelete.Click();
            Thread.Sleep(3000);
            webElement.btnDeleteFavoriteItemBlackButton.Click();
        }
    }
}
