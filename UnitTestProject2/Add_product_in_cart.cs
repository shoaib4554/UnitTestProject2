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
    #region
    public class Add_product_in_cart : commonmethod
    {
        By product = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[2]/a/i");
        By select = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/img");
        By btn = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[1]/div[2]/div/a");
        By btn2 = By.XPath("//*[@id=\"cartModal\"]/div/div/div[3]/button");
        By second_product=By.XPath("/html/body/section[2]/div/div/div[2]/div/div[3]/div/div[1]/div[2]");
        By btn3 = By.XPath("//a[@class=\"btn btn-default add-to-cart\"]");
        By viewcard = By.XPath("//*[@id=\"cartModal\"]/div/div/div[2]/p[2]/a");
        #endregion
        public void AddProduct()
        {
            clickable(product);
            hovover(select);
            clickable(btn);
            clickable(btn2);
            hovover(second_product);
            clickable(btn3);
            clickable(viewcard);    
        }





            
    }
}
