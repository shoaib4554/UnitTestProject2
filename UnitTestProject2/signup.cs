using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject2
{
    public class signupp : commonmethod
    {
        #region login locator
        By btn = By.XPath("//a[text()=' Signup / Login']");
        By name = By.XPath("//input[@name='name']");
        By email = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[3]");
        By signup = By.XPath("//form//button[text()='Signup']");
        By rdbtn = By.Id("uniform-id_gender1");
        By pass = By.Id("password");
        By day = By.Id("days");
        By month = By.Id("months");
        By year = By.Id("years");
        By news = By.Id("newsletter");
        By fname = By.Id("first_name");
        By lname = By.Id("last_name");
        By copmany = By.Id("company");
        By address = By.Id("address1");
        By address2 = By.Id("address2");
        By country = By.Id("country");
        By state = By.XPath("//input[@id='state']");
        By city = By.XPath("//input[@id='city']");
        By zipcode = By.XPath("//input[@id='zipcode']");
        By mobile = By.XPath("//input[@id='mobile_number']");
        By createaccount = By.XPath("//*[@id='form']/div/div/div/div[1]/form/button");


        #endregion
        public void sigunpfunctionality()
        {
            clickable(btn);

            textfield(name, "shoaib");
            textfield(email, "shoaibashraf908@gmail.com");
            clickable(signup);
            clickable(rdbtn);
            textfield(pass, "shoaib123456");
            dropdown(day, "2");
            dropdown(month, "2");
            dropdown(year, "2017");
            clickable(news);
            textfield(fname, "SHoaib");
            textfield(lname, "Ashraf");
            textfield(copmany, "Contour");
            textfield(address, "Main bazaar Lahore");
            textfield(address2, "main bazaar Lahore");
            dropdown(country, "Canada");
            textfield(state, "washington");
            textfield(city, "lahore");
            textfield(zipcode, "54000");
            textfield(mobile, "023477383");
            clickable(createaccount);

            ;
        }
    }
}
