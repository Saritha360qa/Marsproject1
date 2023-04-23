using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTask.utilities
{ 
    public class Commondriver
    {
        public static IWebDriver driver { get; set; }
        public Commondriver() 
        { 
            driver = new ChromeDriver();
        }
    }
}

