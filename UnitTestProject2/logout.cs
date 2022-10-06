using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using UnitTestProject2;

namespace UnitTestProject2
    #region
    public class logout : commonmethod
    {
        By btn = By.XPath("//a[text()=' Signup / Login']");
        By mail = By.XPath("//input[@data-qa='login-email']");
        By password = By.XPath("//input[@name='password']");
        By logiin = By.XPath("//*[@id='form']/div/div/div[1]/div/form/button");
        By logout1 = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        #endregion
        public void llogout()
        {
            clickable(btn);
            textfield(mail, "shoaibashraf908@gmail.com");
            textfield(password, "shoaib123456");
            clickable(logiin);
            clickable(logout1);

        }

    }
}
