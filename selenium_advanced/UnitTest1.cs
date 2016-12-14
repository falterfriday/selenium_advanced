﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace selenium_advanced
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string chromeDriverPath = @"C:\testing\chrome\";
            //using (IWebDriver driver = new ChromeDriver(chromeDriverPath))
            //{
            //    driver.Navigate().GoToUrl("file:///C:/Users/Patrick.Todd/Documents/Visual%20Studio%202013/Projects/03_selenium_webdriver/selenium_advanced/selenium_advanced/TestPage1.html");
            //    var radioButtons = driver.FindElements(By.Name("color"));
            //    radioButtons.
            //}

            string chromeDriverPath = @"C:\testing\chrome\";
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            driver.Url = "file:///C:/Users/Patrick.Todd/Documents/Visual%20Studio%202013/Projects/03_selenium_webdriver/selenium_advanced/selenium_advanced/TestPage1.html";
            
            var radioButtons = driver.FindElements(By.Name("color"));

            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Selected)
                    Console.Write("The " + radioButton.GetAttribute("value") + " one is selected");
            }

            var check = driver.FindElement(By.Id("check1"));
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            check.Click();
            //is it checked now or not?

            //this is hard way
            var select = driver.FindElement(By.Id("select1"));
            var timSelect = select.FindElements(By.TagName("option"))[2];
            timSelect.Click();

            //the easy way
            //make sure to install selenium support classes
            var selectElement = new SelectElement(select);
            selectElement.SelectByText("Steve");
            selectElement.SelectByText("Bob");
            selectElement.SelectByText("Steve");
            selectElement.SelectByText("Allen");
        }
    }
}
