using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using specflow_example.Steps;

namespace specflow_example.Pages
{
    public class GooglePage : BasePageModel
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.rc")]
        public IList<IWebElement> SearchResultsList { get; set; }
    }
}
