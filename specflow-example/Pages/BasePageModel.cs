using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace specflow_example.Steps
{
    /// <summary>
    /// Simple base page to be used by all page models.
    /// </summary>
    public class BasePageModel
    {
        public IWebDriver driver => Common.driver;

        public BasePageModel()
        {
            //This needs to be executed for page models to work
            PageFactory.InitElements(driver, this);
        }
    }
}
