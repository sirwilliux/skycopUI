﻿using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SkycopUI
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser 

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }

        [Given(@"I Open Skycop claim page")]
        public void GivenIOpenSkycopClaimPage()
        {
            Driver.Url = "https://claim.skycop.com/?lang=en";
        }

        [When(@"I enter test airports")]
        public void WhenIEnterTestAirports()
        {
            Hooks.WaitIsDisplayed(PageObject.DeparturePort);
            PageObject.DeparturePort.SendKeys("Kaunas");
            Hooks.WaitIsDisplayed(PageObject.DepartureSelect, false, true);
            PageObject.ArrivalPort.SendKeys("Barcelona");
            Hooks.WaitIsDisplayed(PageObject.ArrivalSelect, false, true);
            PageObject.AirlinesInput.SendKeys("Ryanair");
            Hooks.WaitIsDisplayed(PageObject.AirlinesSelect, false, true);
            PageObject.FlightNoInput.SendKeys("1568");
            Hooks.WaitIsDisplayed(PageObject.FlightDateInput, click: true);
            Hooks.WaitIsDisplayed(PageObject.FlightDateToday, click: true);
            Hooks.WaitIsDisplayed(PageObject.FlightCancelled, click: true);
            Hooks.WaitIsDisplayed(PageObject.FlightMoreThan3, click: true);
            Hooks.WaitIsDisplayed(PageObject.FlightLessThan14d, click: true);
            Hooks.WaitIsDisplayed(PageObject.AirlineReasonInput, click: true);
            Hooks.WaitIsDisplayed(PageObject.AirlineReasonSelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.ReferralInput, click: true);
            Hooks.WaitIsDisplayed(PageObject.ReferralSelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.NextStep, click: true);
        }

        [When(@"I fill in flight details")]
        public void WhenIFillInDetails()
        {
            Thread.Sleep(5000);
            PageObject.CommentInput.SendKeys(Constants.Comment);
            PageObject.BookingNoInput.SendKeys(Constants.BookingNo);
            Hooks.WaitIsDisplayed(PageObject.NextStep, click: true);
        }

        [When(@"I fill in traveller details")]
        public void WhenIFillInTravellerDetails()
        {
            Thread.Sleep(5000);
            PageObject.NameInput.SendKeys(Constants.FirstName);
            PageObject.SurnameInput.SendKeys(Constants.LastName);
            PageObject.BirthdateInput.Click();
            Hooks.WaitIsDisplayed(PageObject.BirthdateYearSelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.BirthdateMonthSelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.BirthdateDaySelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.TravelingAloneInput, click: true);
            PageObject.CountryInput.SendKeys(Constants.Country);
            Hooks.WaitIsDisplayed(PageObject.CountrySelect, click: true);
            Hooks.WaitIsDisplayed(PageObject.LanguageInput, click: true);
            Hooks.WaitIsDisplayed(PageObject.LanguageSelect, click: true);
            PageObject.EmailInput.SendKeys(Constants.Email);
            PageObject.PhoneNoInput.SendKeys(Constants.PhoneNo);
            PageObject.AddressInput.SendKeys(Constants.Address);
            PageObject.CityInput.SendKeys(Constants.City);
            PageObject.PostcodeInput.SendKeys(Constants.Postcode);
            Hooks.WaitIsDisplayed(PageObject.NextStep, click: true);
        }
    }
}
