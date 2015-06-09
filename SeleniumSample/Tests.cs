namespace SeleniumSample
{
    using Xunit;

    public class When_I_navigate_to_Google_homepage
    {
        [Fact]
        public void It_should_complete_without_exception()
        {
            var chrome = WebDriverHelper.GetChromeDriver();
            chrome.Url = "http://google.com";
            chrome.Dispose();
        }
    }
}
