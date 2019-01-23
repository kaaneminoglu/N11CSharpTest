using KeytorcTest.PageModels;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KeytorcTest.Tests
{
    [TestFixture]
    [Parallelizable]
    [Binding, Scope(Tag = "N11TestScenario")]

    class N11Test
    {
        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();
        SearchResultPage searchPage = new SearchResultPage();

        [StepDefinition(@"'(.*)' driver seçilir.")]
        public void OpenDriver(string driverName)
        {
            CurrentDriver.SelectDriver(driverName);
        }

        [StepDefinition(@"'(.*)' adresi açılır.")]
        public void OpenWebSite(string webSite)
        {
            CurrentDriver.OpenWebSite(webSite);
        }

        [StepDefinition(@"Login ekranı açılır.")]
        public void OpenLoginPage()
        {
            homePage.ClickLoginPage();
        }

        [StepDefinition(@"Email bilgisi '(.*)' girilir.")]
        public void SetEmail(string email)
        {
            loginPage.SetEmail(email);
        }

        [StepDefinition(@"Şifre bilgisi '(.*)' girilir.")]
        public void SetPassword(string password)
        {
            loginPage.SetPassword(password);
        }

        [StepDefinition(@"Giriş Yap butonuna basılır.")]
        public void ClickLogin()
        {
            loginPage.ClickLoginButton();
        }

        [StepDefinition(@"Arama alanına '(.*)' yazılır.")]
        public void SetSearchText(string searchText)
        {
            homePage.SetSearchText(searchText);
        }

        [StepDefinition(@"Sonuçların listelendiği görüntülenir.")]
        public void CheckSearchResult()
        {
            Assert.True(searchPage.CheckSearchResult(), "Sonuç bulunamadı.");            
        }

        [StepDefinition(@"2. sayfa açılır.")]
        public void ClickSecondPage()
        {
            searchPage.ClickSecondPage();
        }

        [StepDefinition(@"'(.*)' nolu sayfanın açıldığı kontrol edilir.")]
        public void CheckCurrentPage(string currentPage)
        {
            Assert.True(searchPage.CheckCurrentPage(currentPage), "Sayfa açılmadı.");
        }

        [StepDefinition(@"Favorilerime ekle butonuna tıklanır.")]
        public void AddFavorite()
        {
            searchPage.AddFavorite();
        }

        [StepDefinition(@"İstek Listem / Favorilerim butonuna tıklanır.")]
        public void ClickWishListAndFavorite()
        {
            homePage.ClickWishListAndFavorite();
        }

        [StepDefinition(@"Doğru ürün favorilerime eklendiği kontrol edilir.")]
        public void CheckTrueFavoriteProduct()
        {
            Assert.True(searchPage.CheckTrueFavoriteProduct(), "Ürün favorilere eklenmedi.");
        }

        [StepDefinition(@"Ürün favori listesinden çıkartılır.")]
        public void DeleteFavoriteProduct()
        {
            searchPage.DeleteFavoriteProduct();
        }

        [StepDefinition(@"Ürünün favori listesinde olmadığı kontrol edilir.")]
        public void CheckDeleteFavoriteProduct()
        {
            Assert.False(searchPage.CheckTrueFavoriteProduct(), "Ürün favorilerimden kaldırılamadı.");
            CurrentDriver.QuitDriver();
        }
    }
}
