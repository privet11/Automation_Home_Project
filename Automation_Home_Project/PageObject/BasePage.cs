﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Home_Project.PageObject
{
    class BasePage
    {
        readonly IWebDriver driver;

        [Obsolete]
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //[FindsBy(How = How.CssSelector, Using = ".fusion-main-menu a[href*='about']")]
        //private IWebElement about;

        //[FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        //private IWebElement searchIcon;

        //public void goToPage()
        //{
        //    driver.Navigate().GoToUrl("http://www.swtestacademy.com");
        //}

        //public AboutPage goToAboutPage()
        //{
        //    about.Click();
        //    return new AboutPage(driver);
        //}


    }
}
