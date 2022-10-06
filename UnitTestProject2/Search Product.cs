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
{
    internal class Search_Product : commonmethod
    {

        #region 
        By product = By.XPath("//a[contains(text(),'products')]");
        By searchproduct = By.XPath("//input[@id='search_product']");
        By clicksearch = By.XPath("//button[@id='submit_search']");
        #endregion
        public void searchproductt()
        {
            clickable(product);
            textfield(searchproduct, "shirts");
            clickable(clicksearch);

        }


    }
}
