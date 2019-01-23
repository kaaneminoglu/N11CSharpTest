using KeytorcTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeytorcTest.PageModels
{
    class LoginPage
    {
        WebElementHelper webElement = new WebElementHelper();

        public void SetEmail(string email)
        {
            webElement.txtemail.SendKeys(email);
        }

        public void SetPassword(string password)
        {
            webElement.txtpassword.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            webElement.btnLogin.Click();
        }
    }
}
