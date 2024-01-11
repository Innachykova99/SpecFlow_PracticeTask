using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlertsFramesAndWindows.StepDefinitions
{
    [Binding]
    internal class AlertsFramesAndWindowsStepDefinitions
    {
      private readonly DriverHelper driverHelper = new DriverHelper();

    
        [Given(@"I am on the Alerts, Frame & Windows section")]
        public void GivenIAmOnTheAlertsFrameWindowsSection()
        {
            driverHelper.IAmOnTheAlertsFrameWindowsSection();
        }

        [Given(@"I click ""([^""]*)"" section")]
        public void GivenIClickBrowserWindowSection(string p0)
        {
            driverHelper.IClickBrowserWindowSection(p0);
        }

        [Given(@"I click the ""([^""]*)"" button")]
        public void GivenIClickTheNewTabButton(string p0)
        {
            driverHelper.IClickTheNewTabButton(p0);
        }

        [When(@"I switch to the new tab")]
        public void WhenISwitchToTheNewTab()
        {
            driverHelper.ISwitchToTheNewTab();
        }

        [Then(@"I verify that the text ""([^""]*)"" is present")]
        public void ThenIVerifyThatTheTextIsPresent(string p0)
        {
            driverHelper.IVerifyThatTheTextIsPresent(p0);
        }



        [Given(@"I navigate to ""([^""]*)"" section")]
        public void GivenINavigateToSection(string p0)
        {
            driverHelper.INavigateToSection(p0);
        }

        [Given(@"I click the New Window button")]
        public void GivenIClickTheNewWindowButton()
        {
           driverHelper.IClickTheNewWindowButton();
        }

        [When(@"I switch to the new window")]
        public void WhenISwitchToTheNewWindow()
        {
            driverHelper.ISwitchToTheNewWindow();
        }

        [Then(@"I verify that the text ""([^""]*)"" is presented")]
        public void ThenIVerifyThatTheTextIsPresented(string p0)
        {
            driverHelper.IVerifyThatTheTextIsPresented(p0);
        }

        [AfterScenario]
        public void Teardown()
        {
            driverHelper.Teardown();
        }
    }
}
