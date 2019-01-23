using KeytorcTest.PageModels;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeytorcTest.Common
{

    class WebElementHelper
    {
        public String productId { get; set; }
        public IWebElement btnSignIn
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.XPath("//*[@title='Giriş Yap']"));
            }
        }
        public IWebElement txtemail
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.Id("email"));
            }
        }
        public IWebElement txtpassword
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.Id("password"));
            }
        }
        public IWebElement btnLogin
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.Id("loginButton"));
            }
        }
        public IWebElement txtSearch
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.Id("searchData"));
            }
        }

        public IWebElement btnSearch
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.XPath("//*[@title='ARA']"));
            }
        }

        public IWebElement txtSearchResult
        {
            get
            {
                try
                {
                    return CurrentDriver.driver.FindElement(By.CssSelector(".resultText"));
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public IWebElement btnSecondPage
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.LinkText("2"));
            }
        }

        public IWebElement txtCurrentPage
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.Id("currentPage"));
            }
        }

        public IWebElement btnAddFavorite
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.CssSelector("#" + productId + " > div.proDetail > span.textImg.followBtn"));
            }
        }

        public IWebElement txtAddFavoriteName
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.XPath("//div[@id='view']/ul/li[3]/div"));
            }
        }

        public IWebElement btnWishListAndFavorite
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.XPath("//*[@id='header']/div/div/div[2]/div[2]/div[2]/div[2]/div/a[2]"));
            }
        }

        public IWebElement btnMyAccount
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.LinkText("Hesabım"));
            }
        }

        public IWebElement btnMyFavorites
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.CssSelector("h4.listItemTitle"));
            }
        }

        public IWebElement txtMyFavoriteItem
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.Id(productId));
            }

        }
        public IWebElement btnDelete
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.CssSelector("#" + productId + " > div.wishProBtns > span.deleteProFromFavorites"));
            }
        }
        public IWebElement btnDeleteFavoriteItemBlackButton
        {
            get
            {
                return CurrentDriver.driver.FindElement(By.CssSelector(".btnBlack"));
            }
        }
    }
}
