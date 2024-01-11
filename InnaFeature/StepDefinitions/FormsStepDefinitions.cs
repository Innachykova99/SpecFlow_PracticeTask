using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.StepDefinitions
{
    [Binding]
    internal class FormsStepDefinitions
    {
        private readonly DriverHelper driverHelper = new DriverHelper();

        [Given(@"I navigate to the category named ""([^""]*)"" and ""([^""]*)"" section")]
        public void GivenINavigateToTheCategoryNamedFormsAndPracticeFormSection(string forms, string p1)
        {
            driverHelper.NavigateToTheCategoryNamedFormsAndPracticeFormSection(forms, p1);
        }

        [When(@"I fill out the text fields with data from the table Examples:")]
        public void WhenIFillOutTheTextFieldsWithDataFromTheTableExamples(Table table)
        {
            driverHelper.FillOutTheTextFieldsWithDataFromTheTableExamples(table);

        }

        [When(@"I select ""([^""]*)"" for ""([^""]*)""")]
        public void WhenISelectFemaleForGender(string female, string gender)
        {
            driverHelper.SelectFemaleForGender(female, gender);
        }

        [When(@"I fill out the ""([^""]*)"" form with ""([^""]*)""")]
        public void WhenIFillOutTheDateOfBirthFormWithNewDate(string p0, string p1)
        {
            driverHelper.FillOutTheDateOfBirthFormWithNewDate(p0, p1);
        }

        [When(@"I enter ""([^""]*)"" and ""([^""]*)"" in ""([^""]*)"" field")]
        public void WhenIEnterPhysicsAndMathInSubjectsField(string physics, string math, string subjects)
        {
            driverHelper.EnterPhysicsAndMathInSubjectsField(physics, math, subjects);
        }

        [When(@"I select ""([^""]*)"" and ""([^""]*)"" checkboxes for ""([^""]*)""")]
        public void WhenISelectReadingAndMusicCheckboxesForHobbies(string reading, string music, string hobbies)
        {
            driverHelper.SelectReadingAndMusicCheckboxesForHobbies(reading, music, hobbies);
        }

        [When(@"I select ""([^""]*)"" for ""([^""]*)"" dropdown and ""([^""]*)"" for ""([^""]*)"" dropdown")]
        public void WhenISelectForDropdownAndForDropdown(string p0, string state, string merrut, string city)
        {
            driverHelper.SelectForDropdownAndForDropdown(p0, state, merrut, city);
        }

        [When(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            driverHelper.WhenISubmitTheForm();
        }

        [Then(@"I verify the data in the modal matches the input data")]
        public void ThenIVerifyTheDataInTheModalMatchesTheInputData()
        {

            driverHelper.VerifyTheDataInTheModalMatchesTheInputData();

        }

        [AfterScenario]
        public void Teardown()
        {
            driverHelper.Teardown();
        }
    }
}
