using SpecFlowProject_AshSpecFlowProject_Ash_CSharp_Test.Pages;
using Microsoft.Playwright;
using SpecFlowProject_AshSpecFlowProject_Ash_CSharp_Test.Drivers;

namespace SpecFlowProject_AshSpecFlowProject_Ash_CSharp_Test.Steps;

[Binding]
public sealed class ContactUsStepDefinitions
{
    private readonly Driver _driver;
    private readonly ContactUsPage _contactUsPage;

    public ContactUsStepDefinitions(Driver driver)
    {
        _driver = driver;
        _contactUsPage = new ContactUsPage(_driver.Page);
    }

    [Given(@"I navigate to the webdriver university")]
    public void GivenINaviagteToTheWebdriverUniversity()
    {
        _driver.Page.GotoAsync("http://www.webdriveruniversity.com/");
    }

    [When(@"I pressed the contact us link")]
    public void WhenIPressedTheContactUsLink()
    {
        _contactUsPage.ClickContact();
    }

    [Then(@"I should be able to see the contact us form")]
    public void ThenIShouldBeAbleToSeeTheContactUsForm()
    {
        _contactUsPage.IsEmployeeDetails();
    }
}