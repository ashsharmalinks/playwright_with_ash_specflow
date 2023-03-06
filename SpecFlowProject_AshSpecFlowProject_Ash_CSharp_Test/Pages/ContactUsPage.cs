using Microsoft.Playwright;

namespace SpecFlowProject_AshSpecFlowProject_Ash_CSharp_Test.Pages;

public class ContactUsPage
{
    private IPage _page;
    public ContactUsPage(IPage page) => _page = page;

    // Page Locators
    private ILocator _lnklogin => _page.Locator(selector: "a#contact-us h1");
    private ILocator _lnkEmployeeDetails => _page.Locator(selector: "h2[name='contactme']");

    public async Task ClickContact()
    {
        await _lnklogin.ClickAsync();
    }

    public async Task<bool> IsEmployeeDetails() => await _lnkEmployeeDetails.IsVisibleAsync();
}