using System;
using NUnit.Framework;
using OpenQA.Selenium;
using specflow_example.Pages;
using TechTalk.SpecFlow;

namespace specflow_example.Steps
{
    [Binding]
    public class GoogleSearchSteps
    {
        public IWebDriver driver;

        public GoogleSearchSteps() 
        {
            driver = Common.Setup();
        }

        [Given(@"I am at '(.*)'")]
        public void GivenIAmAt(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        
        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string searchTerm)
        {
            GooglePage google = new GooglePage();
            google.SearchBox.SendKeys(searchTerm);
            google.SearchButton.Click();
        }
        
        [Then(@"I should see '(.*)' results containing '(.*)'")]
        public void ThenIShouldSeeResultsContaining(int resultsCount, string termToCheckfor)
        {
            GooglePage google = new GooglePage();

            //Verify total count of search results
            Assert.IsTrue(google.SearchResultsList.Count == resultsCount);

            //Verify each search result contains the search term
            foreach(var result in google.SearchResultsList)
            {
                string resultText = result.Text.ToLower();
                Assert.IsTrue(resultText.Contains(termToCheckfor));
            }
        }
    }
}
