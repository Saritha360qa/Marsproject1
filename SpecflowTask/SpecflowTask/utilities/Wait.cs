using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.utilities
{
    public class Wait
    {
        public static void WaitTobeClickable(IWebDriver Driver, string locatortype, string locatorvalue, int seconds)
        {
            var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));

            if (locatortype == "XPath")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if (locatortype == "Id")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }
            if (locatortype == "Cssselector")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
        }
        public static void WaitForELementToExist(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locatorType == "XPath")
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(ExpectedConditions.ElementExists(By.Name(locatorValue)));
            }


        }
    }
}

