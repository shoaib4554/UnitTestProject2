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
        public class DownloadInvoiceClass : commonmethod
        {
            #region search_product
            By selectProduct1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
            By selectProduct2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[4]");
            By selectProduct3 = By.XPath("(//i[@class='fa fa-shopping-cart'])[12]");
            By selectProduct4 = By.XPath("(//i[@class='fa fa-shopping-cart'])[22]");
            By continueShoppingButton = By.XPath("//button[contains(text(),'Continue Shopping')]");
            By cartButton = By.XPath("//a[contains(text(),' Cart')]");
            By checkOutButton = By.XPath("//a[text()='Proceed To Checkout']");
            By loginAsUserButton = By.XPath("//u[text()='Register / Login']");
            By commentBox = By.XPath("//textarea[@name='message']");
            By placeOrderButton = By.XPath("//a[contains(text(),'Place Order')]");
            By cardNameInput = By.Name("name_on_card");
            By cardNumberInput = By.Name("card_number");
            By cvcInput = By.XPath("//input[@name='cvc']");
            By expiryMonthInput = By.Name("expiry_month");
            By expiryYearInput = By.Name("expiry_year");
            By confirmOrderButton = By.XPath("//button[@id='submit']");
            By downloadInvoiceButton = By.XPath("//a[text()='Download Invoice']");
            By continueAfterCheckOutButton = By.XPath("//a[text()='Continue']");


            #endregion

            public void addProductsToCart()
            {
                scrollToElementClick(selectProduct1);
                scrollToElementClick(selectProduct1);
                clickable(continueShoppingButton);
                scrollToElement(selectProduct2);
                scrollToElementClick(selectProduct2);
                clickable(continueShoppingButton);
                scrollToElement(selectProduct3);
                scrollToElementClick(selectProduct3);
                clickable(continueShoppingButton);
                scrollToElement(selectProduct4);
                scrollToElementClick(selectProduct4);
                clickable(continueShoppingButton);
            }
            public void cartPage()
            {
                scrollToElementClick(cartButton);
            }
            public void proceedToCheckOut()
            {
                clickable(checkOutButton);
                clickable(loginAsUserButton);
            }
            public void proceedToCheckOutAfterLogin()
            {
                clickable(checkOutButton);
            }

            //SignUp Functionality
            #region UserRegisterationElements
            By signUp = By.XPath("//a[@href='/login']");
            By nameField = By.XPath("//input[@placeholder='Name']");
            By emailField = By.XPath("//form[@action='/signup']/input[@placeholder='Email Address']");
            By signUpButton = By.XPath("//button[contains(text(),'Signup')]");
            By radioTitle = By.XPath("//label[@for='id_gender1']");
            By passwordField = By.XPath("//input[@name='password']");
            By dateDrpDown = By.XPath("//select[@name='days']");
            By monthDrpDown = By.XPath("//select[@name='months']");
            By yearDrpDown = By.XPath("//select[@name='years']");
            By newsLetterCheck = By.XPath("//input[@name='newsletter']");
            By specialOffersCheck = By.XPath("//input[@name='optin']");
            By firstNameField = By.XPath("//input[@name='first_name']");
            By lastNameField = By.XPath("//input[@name='last_name']");
            By companyField = By.XPath("//input[@name='company']");
            By addressField1 = By.XPath("//input[@name='address1']");
            By addressField2 = By.XPath("//input[@name='address2']");
            By countryDrpDown = By.XPath("//select[@name='country']");
            By stateField = By.XPath("//input[@name='state']");
            By cityField = By.XPath("//input[@name='city']");
            By zipCodeField = By.XPath("//input[@name='zipcode']");
            By contactField = By.XPath("//input[@name='mobile_number']");
            By completeSignUpButton = By.XPath("//button[contains(text(),'Create Account')]");
            By continueButton = By.XPath("//a[contains(text(),'Continue')]");
            #endregion

            public void RegisterNewUser()
            {

                textfield(nameField, "shoaib");
                textfield(emailField, "shoaibashraf90@gmail.com");
                clickable(signUpButton);
                clickable(radioTitle);
                textfield(passwordField, "shoaib99987");
                dropdown(dateDrpDown, "1");
                dropdown(monthDrpDown, "3");
                dropdown(yearDrpDown, "2019");
                clickable(newsLetterCheck);
                clickable(specialOffersCheck);
                textfield(firstNameField, "shoaib");
                textfield(lastNameField, "Ashraf");
                textfield(companyField, "contour");
                textfield(addressField1, "lahore");
                textfield(addressField2, "lahore");
                dropdown(countryDrpDown, "canada");
                textfield(stateField, "pakistan");
                textfield(cityField, "lahore");
                textfield(zipCodeField, "5400");
                textfield(contactField, "0344473838");
                clickable(completeSignUpButton);
            }
            public void confirmRegisteration()
            {
                clickable(continueButton);
            }
            public void placeOrder()
            {
                textfield(commentBox, "Just Comments");
                clickable(placeOrderButton);
            }
            #endregion
            public void cardDetails()
            {
                textfield(cardNameInput, "shoaib");
                textfield(cardNumberInput, "87673828638");
                textfield(cvcInput, "311");
                textfield(expiryMonthInput, "januraty");
                textfield(expiryYearInput, "2019");
                clickable(confirmOrderButton);
                clickable(downloadInvoiceButton);
                clickable(continueAfterCheckOutButton);

            }

        }
    }
}
