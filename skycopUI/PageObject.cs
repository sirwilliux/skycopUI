
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SkycopUI
{
    public class PageObject
    {
        [FindsBy(How = How.XPath, Using = "//input[@class='Select-input']")]
        public IWebElement DeparturePort;

        [FindsBy(How = How.XPath, Using = "//div[@title='Kaunas International Airport']")]
        public IWebElement DepartureSelect;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[2]")]
        public IWebElement ArrivalPort;

        [FindsBy(How = How.XPath, Using = "//div[@title='Barcelona International Airport']")]
        public IWebElement ArrivalSelect;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[3]")]
        public IWebElement AirlinesInput;

        [FindsBy(How = How.XPath, Using = "//div[@title='Ryanair']")]
        public IWebElement AirlinesSelect;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='1234']")]
        public IWebElement FlightNoInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='failedFlightDate']")]
        public IWebElement FlightDateInput;

        [FindsBy(How = How.XPath, Using = "//td[@class='rdtDay rdtToday']")]
        public IWebElement FlightDateToday;

        [FindsBy(How = How.XPath, Using = "//input[@value='can']/..//span")]
        public IWebElement FlightCancelled;

        [FindsBy(How = How.XPath, Using = "//input[@value='dg3']/..//span")]
        public IWebElement FlightMoreThan3;

        [FindsBy(How = How.XPath, Using = "//input[@value='l14']/..//span")]
        public IWebElement FlightLessThan14d;

        [FindsBy(How = How.XPath, Using = "(//div[@class='Select-control'])[5]")]
        public IWebElement AirlineReasonInput;

        [FindsBy(How = How.XPath, Using = "//div[@id='react-select-6--option-0']")]
        public IWebElement AirlineReasonSelect;

        [FindsBy(How = How.XPath, Using = "(//div[@class='Select-control'])[6]")]
        public IWebElement ReferralInput;

        [FindsBy(How = How.XPath, Using = "//div[@id='react-select-7--option-0']")]
        public IWebElement ReferralSelect;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement NextStep;

        [FindsBy(How = How.XPath, Using = "//textarea[@name='comments']")]
        public IWebElement CommentInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='bookingNumber']")]
        public IWebElement BookingNoInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='userName']")]
        public IWebElement NameInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='userSurname']")]
        public IWebElement SurnameInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='birthdate']")]
        public IWebElement BirthdateInput;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='1990']")]
        public IWebElement BirthdateYearSelect;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='2' and @class='rdtMonth']")]
        public IWebElement BirthdateMonthSelect;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='18' and @class='rdtDay']")]
        public IWebElement BirthdateDaySelect;

        [FindsBy(How = How.XPath, Using = "//input[@name='travellingAlone' and @value='false']/..")]
        public IWebElement TravelingAloneInput;

        [FindsBy(How = How.XPath, Using = "//input[@class='Select-input']")]
        public IWebElement CountryInput;

        [FindsBy(How = How.XPath, Using = "//div[text()='Lithuania']")]
        public IWebElement CountrySelect;

        [FindsBy(How = How.XPath, Using = "//div[text()='Choose language']")]
        public IWebElement LanguageInput;

        [FindsBy(How = How.XPath, Using = "//div[text()='English']")]
        public IWebElement LanguageSelect;

        [FindsBy(How = How.XPath, Using = "//input[@name='userEmail']")]
        public IWebElement EmailInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='repeatEmail']")]
        public IWebElement EmailRepeatInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='userPhoneCode']")]
        public IWebElement PhoneCodeField;

        [FindsBy(How = How.XPath, Using = "//input[@aria-expanded='true']")]
        public IWebElement PhoneCodeInput;

        [FindsBy(How = How.XPath, Using = "//div[text()='Lithuania']")]
        public IWebElement PhoneCodeSelection;

        [FindsBy(How = How.XPath, Using = "//input[@name='userPhone']")]
        public IWebElement PhoneNoInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='userAddress']")]
        public IWebElement AddressInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='userCity']")]
        public IWebElement CityInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='userPostCode']")]
        public IWebElement PostcodeInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='termsCheck']/../span[1]")]
        public IWebElement TCCheckbox;

        [FindsBy(How = How.XPath, Using = "//canvas[@id='sigCanvas']")]
        public IWebElement SignatureCanvas;

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Complete claim')]")]
        public IWebElement CompleteClaimButton;

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Congratulations!')]")]
        public IWebElement ClaimSuccess;

    }
}
