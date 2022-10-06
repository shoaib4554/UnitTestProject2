using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject2
{
    public class commonmethod
    {
        public static IWebDriver driver;
        private object log;
    public void BaseClass(string browser)
            {
                if (browser == "chrome")
                    driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

            }
            public void myurl(string myurl)
            {
                driver.Url = myurl;
            }
            public IWebElement FindElement(By path)
            {
                return driver.FindElement(path);
            }
            public void clickable(By path)
            {
                IWebElement cliclitem = FindElement(path);
                cliclitem.Click();
            }
            public void textfield(By path, string value)
            {
                IWebElement textfieldd = FindElement(path);
                textfieldd.SendKeys(value);
            }
            public void dropdown(By path, string value)
            {
                IWebElement drop = FindElement(path);
                SelectElement mydrop = new SelectElement(drop);
                mydrop.SelectByValue(value);
            }
            public bool verifyElementIsVisible(By path)
            {
                IWebElement element = FindElement(path);
                bool result = element.Displayed || element.Enabled ? true : false;
                return result;
            }

            public void mainPage(string u)
            {
                driver.Url = u;
                Console.WriteLine(" Url has been Loaded Successfully");
            }
            public void scrollToElementClick(By path)
            {
                IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
                IWebElement element = ExplicitWaitForElement(path);
                scroller.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                clickable(path);
                Console.WriteLine("Scrolled to " + element + " and click action is performed.");
            }
            public void scrollToElement(By path)
            {
                IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
                IWebElement element = ExplicitWaitForElement(path);
                scroller.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                Console.WriteLine("Scrolled to " + element);
            }

            private IWebElement ExplicitWaitForElement(By path)
            {
                throw new NotImplementedException();
            }

            public void selectFromDropDown(By path, string obj)
            {
                IWebElement element = FindElement(path);
                SelectElement drpDownItem = new SelectElement(element);
                drpDownItem.SelectByValue(obj);
                Console.WriteLine(obj + " has been selected from " + element + " drop down.");
            }
            public void closeBrowser()
            {
                driver.Close();
                Console.WriteLine("Browser is successfully closed after completion of test Case.");
            }
        public void hovover(By path)
        {
            IWebElement first =driver.FindElement(path);
            Actions action = new Actions(driver);
            action.MoveToElement(first).Build().Perform();



        }

        }

    }


