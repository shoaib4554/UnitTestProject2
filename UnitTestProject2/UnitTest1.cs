using Microsoft.VisualStudio.TestTools.UnitTesting;
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
using System.Threading;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            signupp si = new signupp();
            si.BaseClass("chrome");
            si.myurl("https://www.automationexercise.com/");
            Assert.IsTrue(true);
            si.sigunpfunctionality();

        }
        [TestMethod]
        public void loginn()
        {
            login log = new login();
            log.BaseClass("chrome");
            log.myurl("https://www.automationexercise.com/");
            log.loginnn();
        }
        [TestMethod]
        public void logouttt()
        {
            logout logt = new logout();
            login log = new login();
            log.BaseClass("chrome");
            log.myurl("https://www.automationexercise.com/");
            log.loginnn();
            Thread.Sleep(1000);
            logt.llogout();
        }
        [TestMethod]
        public void TC_Searchproduct()
        {
            By search_product = By.XPath("//h2[contains(text(),'All products')]");
            By verifying_product = By.XPath("//h2[contains(text(),'searc')]");
            By home = By.XPath("//a[text()='Home']");
            Search_Product search = new Search_Product();
            search.BaseClass("chrome");
            search.mainPage("u");
            Assert.IsTrue(search.verifyElementIsVisible(home));
            Assert.IsTrue(search.verifyElementIsVisible(search_product));
            search.searchproductt();
            Assert.IsTrue(search.verifyElementIsVisible(verifying_product));
            search.closeBrowser();
        }
        [TestMethod]
        public void TC_5_DownloadInvoiceAfterPurchaseOrder()
        {
            By verifyHome = By.XPath("//a[text()=' Home']");
            By VerifyCartPage = By.XPath("//li[text()='Shopping Cart']");

            DownloadInvoiceClass obj = new DownloadInvoiceClass();
            obj.BaseClass("chrome");
            obj.mainPage("u");
            Assert.IsTrue(obj.verifyElementIsVisible(verifyHome));
            obj.addProductsToCart();
            obj.cartPage();
            Assert.IsTrue(obj.verifyElementIsVisible(VerifyCartPage));
            obj.proceedToCheckOut();
            obj.RegisterNewUser();
            obj.confirmRegisteration();
            obj.cartPage();
            obj.proceedToCheckOutAfterLogin();
            obj.placeOrder();
            obj.cardDetails();
            obj.closeBrowser();
        }
        [TestMethod]
        public void add_to_card_()
        {
            Add_product_in_cart adct = new Add_product_in_cart();
            adct.BaseClass("chrome");
            adct.myurl("https://www.automationexercise.com/");
            By Home = By.XPath("//a[text()=' Home']");
            By CartPage = By.XPath("//li[text()='Shopping Cart']");
            adct.BaseClass("chrome");
            adct.mainPage("u");
            Assert.IsTrue(adct.verifyElementIsVisible(Home));
            adct.AddProduct();
            Assert.IsTrue(adct.verifyElementIsVisible(CartPage));
            adct.closeBrowser();



        }

    }


}

