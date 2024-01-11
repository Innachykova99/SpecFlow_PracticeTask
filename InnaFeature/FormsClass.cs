using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Forms.StepDefinitions
{
    public class DriverHelper
    {
        private IWebDriver driver;

        public DriverHelper()
        {
            driver = GetDriver();
        }

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://demoqa.com/");
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public void Teardown()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }


        public void NavigateToTheCategoryNamedFormsAndPracticeFormSection(string forms, string p1)
        {
            var FormsCategory = driver.FindElement(By.XPath("//*[@class='card-body']/h5[contains(text(), 'Forms')]"));
            FormsCategory.Click();
            var PracticeFormSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Practice Form')]"));
            PracticeFormSection.Click();
        }
        public void FillOutTheTextFieldsWithDataFromTheTableExamples(Table table)
        {
            var firstName = table.Rows[0]["First Name"];
            var lastName = table.Rows[0]["Last Name"];
            var email = table.Rows[0]["Email"];
            var mobile = table.Rows[0]["Mobile"];
            var currentAddress = table.Rows[0]["Current Address"];

            var FirstNameInput = driver.FindElement(By.XPath("//*[@id=\"firstName\"]"));
            FirstNameInput.SendKeys(firstName);

            var LastNameInput = driver.FindElement(By.XPath("//*[@id=\"lastName\"]"));
            LastNameInput.SendKeys(lastName);

            var EmailInput = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            EmailInput.SendKeys(email);

            var MobileInput = driver.FindElement(By.XPath("//*[@id=\"userNumber\"]"));
            MobileInput.SendKeys(mobile);

            var CurrentAddressInput = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            CurrentAddressInput.SendKeys(currentAddress);
        }

        public void SelectFemaleForGender(string female, string gender)
        {
            var FemaleRadioButton = driver.FindElement(By.XPath("//*[@name='gender' and contains(@value, 'Female')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", FemaleRadioButton);
        }
        public void FillOutTheDateOfBirthFormWithNewDate(string p0, string p1)
        {
            var DateOfBirthForm = driver.FindElement(By.XPath("//*[@id=\"dateOfBirthInput\"]"));
            DateOfBirthForm.Click();
            var Month = driver.FindElement(By.XPath("//*[@class = 'react-datepicker__month-select']"));
            Month.Click();
            var MonthOption = driver.FindElement(By.XPath("//*[@class='react-datepicker__month-select']//option[contains(@value, '9')]"));
            MonthOption.Click();
            var Year = driver.FindElement(By.XPath("//*[@class = 'react-datepicker__year-select']"));
            Year.Click();
            var YearOption = driver.FindElement(By.XPath("//*[@class = 'react-datepicker__year-select']//option[contains(@value, '2000')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", YearOption);
            YearOption.Click();
            var DateOption = driver.FindElement(By.XPath("//*[@class = 'react-datepicker__day react-datepicker__day--026']"));
            DateOption.Click();
        }

        public void EnterPhysicsAndMathInSubjectsField(string physics, string math, string subjects)
        {
            var SubjectsInput = driver.FindElement(By.XPath("//*[@id=\"subjectsContainer\"]"));
            SubjectsInput.Click();


           var actions = new Actions(driver);
            actions.SendKeys(physics).Perform();
            Thread.Sleep(500); 

            actions.SendKeys(Keys.Enter).Perform(); 
            Thread.Sleep(500); 

            actions.SendKeys(math).Perform();
            Thread.Sleep(500); 

            actions.SendKeys(Keys.Enter).Perform();

        }

        public void SelectReadingAndMusicCheckboxesForHobbies(string reading, string music, string hobbies)
        {
            var ReadingCheckbox = driver.FindElement(By.XPath("//*[@type='checkbox']/following-sibling::label[text()='Reading']"));
            var actions = new Actions(driver);
            actions.Click(ReadingCheckbox).Perform();
            var MusicCheckbox = driver.FindElement(By.XPath("//*[@type='checkbox']/following-sibling::label[text()='Music']"));
            actions.Click(MusicCheckbox).Perform();
        }
        public void SelectForDropdownAndForDropdown(string p0, string state, string merrut, string city)
        {
            var StateDropdown = driver.FindElement(By.XPath("//*[@id=\"state\"]"));
            StateDropdown.Click(); // blocked as the AD is shown in browser that blocks the view of element, managed the browser site settings, performed the antivirus check, no issues
            var StateOption = driver.FindElement(By.XPath("//*[contains(@class, 'css-11unzgr')]//*[contains(@class, 'css-yt9ioa-option') and contains(text(), 'Uttar Pradesh')]"));
            StateOption.Click();

            var CityDropdown = driver.FindElement(By.XPath("//*[@id='city']"));
            CityDropdown.Click();
            var CityOption = driver.FindElement(By.XPath("//*[contains(@class, 'css-11unzgr')]//*[contains(@class, 'css-yt9ioa-option') and contains(text(), 'Merrut')]"));
            CityOption.Click();
        }
        public void WhenISubmitTheForm()
        {
            var SubmitButton = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            SubmitButton.Click();
        }

        public void VerifyDataInModal(string fieldName, string expectedValue)
        {
            string DataInModal = $"//*[@class = 'table-responsive']//td[contains(text(), '{fieldName}')]/following-sibling::td[contains(text(), '{expectedValue}')]";
            var ElementData = driver.FindElement(By.XPath(DataInModal));

        }
        public void VerifyTheDataInTheModalMatchesTheInputData()
        {
            VerifyDataInModal("Student Name", "Inna Chykova");
            VerifyDataInModal("Student Email", "innac@example.com");
            VerifyDataInModal("Gender", "Female");
            VerifyDataInModal("Mobile", "1234567890");
            VerifyDataInModal("Date of Birth", "07 October,2000");
            VerifyDataInModal("Subjects", "Physics, Maths");
            VerifyDataInModal("Hobbies", "Reading, Music");
            VerifyDataInModal("Address", "123 Svobody Ave");
            VerifyDataInModal("State and City", "Uttar Pradesh Merrut");
        }
    }
}

/* var ModalStudentName = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Student Name')]/following-sibling::td[contains(text(), 'Inna Chykova')]"));
var ModalStudentEmail = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Student Email')]/following-sibling::td[contains(text(), 'innac@example.com')]"));
var ModalGender = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Gender')]/following-sibling::td[contains(text(), 'Female')]"));
var ModalMobile = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Mobile')]/following-sibling::td[contains(text(), '1234567890')]"));
var ModalDateOfBirth = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Date of Birth')]/following-sibling::td[contains(text(), '07 October,2000')]"));
var ModalSubjects = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Subjects')]/following-sibling::td[contains(text(), 'Physics, Maths')]"));
var ModalHobbies = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Hobbies')]/following-sibling::td[contains(text(), 'Reading, Music')]"));
var ModalAddress = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'Address')]/following-sibling::td[contains(text(), '123 Svobody Ave')]"));
var StateAndCity = driver.FindElement(By.XPath("//*[@class = 'table-responsive']//td[contains(text(), 'State and City')]/following-sibling::td[contains(text(), 'Uttar Pradesh Merrut')]"));
*/