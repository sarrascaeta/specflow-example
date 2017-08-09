using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace specflow_example.Steps
{
    public class Common
    {
    	public static IWebDriver driver;

    	public static IWebDriver Setup() 
    	{
            //Create a new chromedriver if needed
    		if (driver == null)
    			driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
    		return driver;
    	}
    }
}
